using ACBC.Common;
using ACBC.Dao;
using Newtonsoft.Json;
using Senparc.Weixin.MP.TenPayLibV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ACBC.Buss
{
    public class PaymentCallBackBuss
    {
        private TenPayV3Info tenPayV3Info;
        private PaymentDao pDao = new PaymentDao();

        public PaymentCallBackBuss()
        {
            tenPayV3Info = new TenPayV3Info(
                Global.APPID,
                Global.APPSECRET,
                Global.MCHID,
                Global.PaymentKey,
                Global.CallBackUrl);
        }

        public string GetPaymentResult(ResponseHandler resHandler)
        {
            OpenDao openDao = new OpenDao();
            string return_code = "";
            string return_msg = "";
            try
            {
                return_code = resHandler.GetParameter("return_code");
                return_msg = resHandler.GetParameter("return_msg");
                string openid = resHandler.GetParameter("openid");
                string total_fee = resHandler.GetParameter("total_fee");
                string time_end = resHandler.GetParameter("time_end");
                string out_trade_no = resHandler.GetParameter("out_trade_no");
                string transaction_id = resHandler.GetParameter("transaction_id");
                openDao.writeLog(Global.POSCODE, openid, "payCallBack", return_msg + "#" + out_trade_no + "#" + transaction_id + "#" + total_fee + "#" + time_end);

                resHandler.SetKey(tenPayV3Info.Key);
                //验证请求是否从微信发过来（安全）
                if (resHandler.IsTenpaySign() && return_code.ToUpper() == "SUCCESS")
                {
                    /* 这里可以进行订单处理的逻辑 */
                    // transaction_id:微信支付单号
                    // out_trade_no:商城实际订单号
                    // openId:用户信息
                    // total_fee:实际支付价格

                    if (checkOrderTotalPrice(out_trade_no, Convert.ToDouble(total_fee)))
                    {
                        if (pDao.updateOrderForPay(out_trade_no, transaction_id))
                        {
                            string SetPayIdResult = SetPayId(Global.POSCODE, out_trade_no, transaction_id);
                            WebBillIdResult web1 = JsonConvert.DeserializeObject<WebBillIdResult>(SetPayIdResult);
                            if (web1.MESSAGE[0].IS_SUCCESS == "TRUE")
                            {
                                string PayTicketDoneResult = PayTicketDone(Global.POSCODE, out_trade_no, transaction_id);
                                WebBillIdResult web2 = JsonConvert.DeserializeObject<WebBillIdResult>(PayTicketDoneResult);
                                if (web2.MESSAGE[0].IS_SUCCESS == "TRUE")
                                {
                                    pDao.insertPayLog(out_trade_no, transaction_id, total_fee, openid, "支付完成-成功");
                                }
                                else
                                {
                                    pDao.insertPayLog(out_trade_no, transaction_id, total_fee, openid, "支付完成-确认付款失败");
                                }
                            }
                            else
                            {
                                pDao.insertPayLog(out_trade_no, transaction_id, total_fee, openid, "支付完成-同步设置支付单号失败");
                            }

                        }
                        else
                        {
                            pDao.insertPayLog(out_trade_no, transaction_id, total_fee, openid, "支付完成-修改订单状态失败");
                        }
                    }
                    else
                    {
                        pDao.insertPayLog(out_trade_no, transaction_id, total_fee, openid, "支付完成-支付金额与订单总金额不符");
                    }
                }
                else
                {
                    return_code = "FAIL";
                    return_msg = "不是从微信发过来";

                    openDao.writeLog(Global.POSCODE, openid, "payCallBack", return_msg + "#" + out_trade_no + "#" + transaction_id + "#" + total_fee + "#" + time_end);
                }
                return string.Format(@"<xml><return_code><![CDATA[{0}]]></return_code><return_msg><![CDATA[{1}]]></return_msg></xml>", return_code, return_msg);

            }
            catch (Exception ex)
            {
                return_code = "FAIL";
                return_msg = ex.ToString();
                openDao.writeLog(Global.POSCODE, "", "payCallBack", return_msg);
                return string.Format(@"<xml><return_code><![CDATA[{0}]]></return_code><return_msg><![CDATA[{1}]]></return_msg></xml>", return_code, return_msg);
            }
        }
        /// <summary>
        /// 核对订单总金额和支付金额
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="totalPrice"></param>
        /// <returns></returns>
        public bool checkOrderTotalPrice(string billId, double totalPrice)
        {
#if DEBUG
            return true;
#endif

            OpenDao openDao = new OpenDao();
            BILLLIST billList = openDao.getBillListByBillId(billId);
            if (billList == null)
            {
                throw new ApiException(CodeMessage.PaymentBillError, "PaymentBillError");
            }

            if (billList.billPrice * 100 == totalPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 设置付款单号
        /// </summary>
        /// <param name="posCode"></param>
        /// <returns></returns>
        public static String SetPayId(string posCode, string billId, string payId)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PayUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pay.PayTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pay.setPayIdRequestBody body = new pay.setPayIdRequestBody();
            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._billId = billId;
            body._payId = payId;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pay.setPayIdRequest(body);
            //发送请求
            var v = callClient.setPayIdAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.setPayIdResult;


            return result;
        }
        /// <summary>
        /// 确认付款
        /// </summary>
        /// <param name="posCode"></param>
        /// <returns></returns>
        public static String PayTicketDone(string posCode, string billId, string payId)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PayUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pay.PayTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pay.payTicketDoneRequestBody body = new pay.payTicketDoneRequestBody();
            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._billId = billId;
            body._payId = payId;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pay.payTicketDoneRequest(body);
            //发送请求
            var v = callClient.payTicketDoneAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.payTicketDoneResult;


            return result;
        }

    }
}
