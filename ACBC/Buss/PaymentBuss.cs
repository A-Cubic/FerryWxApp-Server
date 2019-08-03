using ACBC.Common;
using ACBC.Dao;
using Newtonsoft.Json;
using Senparc.Weixin.Entities;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.TenPayLibV3;
using Senparc.Weixin.WxOpen.AdvancedAPIs.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACBC.Buss
{
    public class PaymentBuss : IBuss
    {
        private TenPayV3Info tenPayV3Info;
        private PaymentDao pDao = new PaymentDao();

        public PaymentBuss()
        {
            tenPayV3Info = new TenPayV3Info(
                Global.APPID,
                Global.APPSECRET,
                Global.MCHID,
                Global.PaymentKey,
                Global.CallBackUrl);
        }

        public ApiType GetApiType()
        {
            return ApiType.PaymentApi;
        }

        public object Do_Payment(BaseApi baseApi)
        {
            PaymentParam paymentParam = JsonConvert.DeserializeObject<PaymentParam>(baseApi.param.ToString());
            if (paymentParam == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            if (paymentParam.billId == null || paymentParam.billId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }

            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();
            //处理10分取消未支付订单
            openDao.UpdateBookingStatusBy10Minute(openId);
            BILLLIST billList = openDao.getBillListById(paymentParam.billId, openId);
            if (billList == null)
            {
                throw new ApiException(CodeMessage.PaymentBillError, "PaymentBillError");
            }
            if (billList.bookingState != "1")
            {
                throw new ApiException(CodeMessage.PaymentStateError, "PaymentStateError");
            }
            var billId = paymentParam.billId;
            int totalPrice = Convert.ToInt32(billList.billPrice * 100);
            if (totalPrice <= 0)
            {
                throw new ApiException(CodeMessage.PaymentTotalPriceZero, "PaymentTotalPriceZero");
            }

            //if (billList.prePayId!=null && billList.prePayId!="" && billList.prePayTime != null && billList.prePayTime != "")
            //{
            //    try
            //    {
            //        DateTime preDateTime = Convert.ToDateTime(billList.prePayTime);
            //        if (DateTime.Now.AddHours(-2)< preDateTime)
            //        {
            //            var timeStamp = TenPayV3Util.GetTimestamp();
            //            var nonceStr = TenPayV3Util.GetNoncestr();
            //            var product = "船票";
            //            var package = string.Format("prepay_id={0}", billList.prePayId);
            //            var paySign = TenPayV3.GetJsPaySign(tenPayV3Info.AppId, timeStamp, nonceStr, package, tenPayV3Info.Key);

            //            PaymentResults paymentResults = new PaymentResults();
            //            paymentResults.appId = tenPayV3Info.AppId;
            //            paymentResults.nonceStr = nonceStr;
            //            paymentResults.package = package;
            //            paymentResults.paySign = paySign;
            //            paymentResults.timeStamp = timeStamp;
            //            paymentResults.product = product;
            //            paymentResults.billId = billId;

            //            return paymentResults;
            //        }
            //    }
            //    catch (Exception)
            //    {
                    
            //    }
                
            //}

            try
            {
                var timeStamp = TenPayV3Util.GetTimestamp();
                var nonceStr = TenPayV3Util.GetNoncestr();
                var product = "船票";
                var xmlDataInfo =
                    new TenPayV3UnifiedorderRequestData(
                        tenPayV3Info.AppId,
                        tenPayV3Info.MchId,
                        product,
                        billId,
                        totalPrice,
                        "127.0.0.1",
                        tenPayV3Info.TenPayV3Notify,
                        TenPayV3Type.JSAPI,
                        openId,
                        tenPayV3Info.Key,
                        nonceStr);

                var result = TenPayV3.Html5Order(xmlDataInfo);
                if (result.return_msg!="")
                {
                    openDao.writeLog(Global.POSCODE, "", "pay", result.return_msg);
                }
                
                pDao.writePrePayId(billId, result.prepay_id);
                var package = string.Format("prepay_id={0}", result.prepay_id);
                var paySign = TenPayV3.GetJsPaySign(tenPayV3Info.AppId, timeStamp, nonceStr, package, tenPayV3Info.Key);

                PaymentResults paymentResults = new PaymentResults();
                paymentResults.appId = tenPayV3Info.AppId;
                paymentResults.nonceStr = nonceStr;
                paymentResults.package = package;
                paymentResults.paySign = paySign;
                paymentResults.timeStamp = timeStamp;
                paymentResults.product = product;
                paymentResults.billId = billId;

                return paymentResults;
            }
            catch (Exception ex)
            {
                throw new ApiException(CodeMessage.PaymentError, "PaymentError");
            }
        }

        public object Do_SendPaymentMsg(BaseApi baseApi)
        {
            try
            {
                SendPaymentMsg sendPaymentMsg = JsonConvert.DeserializeObject<SendPaymentMsg>(baseApi.param.ToString());
                if (sendPaymentMsg == null)
                {
                    throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
                }
                if (this.sendTemplateMessage(sendPaymentMsg.orderId))
                {
                    return new { };
                }
                else
                {
                    throw new ApiException(CodeMessage.PaymentMsgError, "PaymentMsgError");
                }
            }
            catch (Exception ex)
            {
                throw new ApiException(CodeMessage.PaymentMsgError, "PaymentMsgError");
            }


        }
        /// <summary>
        /// 支付成功
        /// </summary>
        /// <param name="out_trade_no"></param>
        /// <returns></returns>
        private bool sendTemplateMessage(string out_trade_no)
        {
            try
            {
                PaymentDataResults paymentDataResults = pDao.getPayData(out_trade_no);
                WxJsonResult wxJsonResult = TemplateApi.SendTemplateMessage(Global.APPID,
                    paymentDataResults.openId,
                    Global.PaySuccessTemplate,
                    new
                    {
                        keyword1 = new { value = paymentDataResults.billid },
                        keyword2 = new { value = paymentDataResults.billPrice },
                        keyword3 = new { value = paymentDataResults.billValue },
                        keyword4 = new { value = paymentDataResults.bookingTime },
                        keyword5 = new { value = paymentDataResults.bookingState }
                    },
                    paymentDataResults.prePayId, "/pages/orderList/orderList?num=1", "keyword4.DATA");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
    }
}
