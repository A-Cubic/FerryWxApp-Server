using ACBC.Common;
using ACBC.Dao;
using Newtonsoft.Json;
using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.WxOpen.AdvancedAPIs.Sns;
using Senparc.Weixin.WxOpen.Containers;
using Senparc.Weixin.Entities;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.TenPayLibV3;
using Senparc.Weixin.WxOpen.AdvancedAPIs.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ACBC.Buss
{
    public class TicketBuss : IBuss
    {
        public ApiType GetApiType()
        {
            return ApiType.TicketApi;
        }
        /// <summary>
        /// 获取港口列表
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetPort(BaseApi baseApi)
        {
            Port obj = JsonConvert.DeserializeObject<Port>(GetPostListData(Global.XCPOSCODE));
            List<string> list = new List<string>();
            foreach (var item in obj.PORTLIST)
            {
                list.Add(item.PORT_CNAME);
            }
            return list;
        }

        /// <summary>
        /// 获取船计划
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetPlan(BaseApi baseApi)
        {
            PosDateParam posDateParam = JsonConvert.DeserializeObject<PosDateParam>(baseApi.param.ToString());
            if (posDateParam == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            if (posDateParam.dateFrom == null || posDateParam.dateFrom == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            if (posDateParam.dateFrom.Length != 8)
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }

            ShipWeb obj = JsonConvert.DeserializeObject<ShipWeb>(GetShipListData(posDateParam, Global.XCALLOTTYPE));
            Ship obj1 = new Ship();
            obj1.date = posDateParam.dateFrom.Insert(4, "-").Insert(7, "-");
            obj1.SHIPLIST = new List<SHIPLIST>();
            if (obj.SHIPLIST != null)
            {
                foreach (var ship in obj.SHIPLIST)
                {
                    bool ifNotPlan = true;
                    for (int i = 0; i < obj1.SHIPLIST.Count; i++)
                    {
                        if (obj1.SHIPLIST[i].planId == ship.PLAN_ID)
                        {
                            try
                            {
                                Grade grade = new Grade();
                                grade.gradeId = ship.BUNK_GRADE_ID;
                                grade.gradeName = ship.BUNK_GRADE_NAME;
                                grade.ticketLeft = ship.TICKET_LEFT;
                                grade.price = ship.PRICE;
                                grade.halfPrice = ship.HALF_PRICE;

                                obj1.SHIPLIST[i].gradeList.Add(grade);
                                ifNotPlan = false;
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    if (ifNotPlan)
                    {
                        SHIPLIST shipList = new SHIPLIST();
                        string[] ports = ship.SEAROUTE_NAME.Split("-");
                        if (ports.Length > 1)
                        {
                            shipList.fromPort = ports[0];
                            shipList.toPort = ports[1];
                        }
                        try
                        {
                            string[] times = ship.SAILING_TIME.Split(":");
                            DateTime dtime = Convert.ToDateTime(ship.DEPARTURE_TIME);
                            dtime = dtime.AddHours(Convert.ToInt16(times[0]));
                            dtime = dtime.AddMinutes(Convert.ToInt16(times[1]));
                            string sailing = "";
                            if (Convert.ToInt16(times[0]) != 0)
                            {
                                sailing = Convert.ToInt16(times[0]) + "小时";
                            }
                            if (Convert.ToInt16(times[1]) != 0)
                            {
                                sailing += Convert.ToInt16(times[1]) + "分钟";
                            }

                            shipList.arriveDate = dtime.ToString("yyyy-MM-dd");
                            shipList.arriveTime = dtime.ToString("HH:mm");
                            shipList.berthName = ship.BERTH_NAME;
                            shipList.departureDate = Convert.ToDateTime(ship.DEPARTURE_TIME).ToString("yyyy-MM-dd");
                            shipList.departureTime = Convert.ToDateTime(ship.DEPARTURE_TIME).ToString("HH:mm");
                            shipList.planId = ship.PLAN_ID;
                            shipList.sailingTime = sailing;
                            shipList.searouteAlise = ship.SEAROUTE_ALISE;
                            shipList.searouteName = ship.SEAROUTE_NAME;
                            shipList.shipName = ship.SHIP_NAME;
                            shipList.stu = ship.STU;
                            shipList.voyageNumber = ship.VOYAGE_NUMBER;
                            shipList.gradeList = new List<Grade>();
                            Grade grade = new Grade();
                            grade.gradeId = ship.BUNK_GRADE_ID;
                            grade.gradeName = ship.BUNK_GRADE_NAME;
                            grade.ticketLeft = ship.TICKET_LEFT;
                            grade.price = ship.PRICE;
                            grade.halfPrice = ship.HALF_PRICE;
                            shipList.gradeList.Add(grade);
                            obj1.SHIPLIST.Add(shipList);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }

            return obj1;
        }
        /// <summary>
        /// 下订单
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_WebBookingTicket(BaseApi baseApi)
        {
            OpenDao openDao = new OpenDao();
            BookingTicketParam param = JsonConvert.DeserializeObject<BookingTicketParam>(baseApi.param.ToString());
            if (param == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            //if (param.posCode == null || param.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            if (param.planId == null || param.planId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            if (param.gradeId == null || param.gradeId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            if (param.mobile == null || param.mobile == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            if (param.passengerList == null || param.passengerList.Count == 0)
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            //处理10分取消未支付订单
            openDao.UpdateBookingStatusBy10Minute(openId);


            //判断用户是否被禁用
            Member member = openDao.GetMember(openId);
            if (member.status =="0")
            {
                throw new ApiException(CodeMessage.MemberStatusError, "MemberStatusError");
            }

            if (!openDao.ifBooking(param.planId, Global.XCIfBookingTime))
            {
                throw new ApiException(CodeMessage.BookingTicketError, "BookingTicketError");
            }
            //先判断订票用户和账号是否匹配。
            string error = "";
            if (param.passengerList.Count>5)
            {
                openDao.writeLog(Global.XCPOSCODE, openId, "PassengerNumError", "订票人超过5个");
                throw new ApiException(CodeMessage.PassengerNumError, "订票人超过5个");
            }
            

            foreach (Passenger passenger in param.passengerList)
            {
                //判断用户是否订过同一航次
                if (openDao.checkOnePlan(param.planId, passenger.passengerCard))
                {
                    throw new ApiException(CodeMessage.OnePlanError, "OnePlanError");
                }
            }
            //再判断是否都是一个等级
            string grade = param.passengerList[0].passengerType;
            foreach (Passenger passenger in param.passengerList)
            {
                if (grade != passenger.passengerType)
                {
                    error += "不是同一个类型,一个订单只支持同一个类型的票;";
                }
            }
            if (error != "")
            {
                openDao.writeLog(Global.XCPOSCODE, openId, "BookingTicket", error);
                throw new ApiException(CodeMessage.CheckPassengerError, error);
            }
            //用第一个人的信息生成一个新的订单号

            string bookBillId = "";
            string GetBookBillIdUserResult = GetBookBillIdUser(Global.XCPOSCODE, param.name, param.mobile, param.card, openId);
            WebBillIdResult web1 = JsonConvert.DeserializeObject<WebBillIdResult>(GetBookBillIdUserResult);
            if (web1.MESSAGE[0].IS_SUCCESS == "TRUE")
            {
                bookBillId = web1.BILLID[0].BILL_ID;
            }
            else
            {
                openDao.writeLog(Global.XCPOSCODE, openId, "BookingTicket", web1.MESSAGE[0].MESSAGE);
                throw new ApiException(CodeMessage.GetBillIdError, "GetBillIdError");
            }
            //订票
            string allotType = Global.XCALLOTTYPE, ticketType = param.passengerList[0].passengerType;
            int ticketNum = param.passengerList.Count;
            if (param.passengerList[0].passengerType == "004")
            {
                allotType = "999";
            }
            string BookTicketAutoByTicketResult = BookTicketAutoByTicketType(Global.XCPOSCODE, param.planId, param.gradeId, allotType, ticketNum, bookBillId, ticketType);
            WebResult web2 = JsonConvert.DeserializeObject<WebResult>(BookTicketAutoByTicketResult);
            if (web2.MESSAGE[0].IS_SUCCESS == "TRUE")
            {

            }
            else
            {
                openDao.writeLog(Global.XCPOSCODE, openId, "BookingTicket", web2.MESSAGE[0].MESSAGE);
                throw new ApiException(CodeMessage.BookTicketError, "BookTicketError");
            }
            //获取订票状态
            string GetBookBillStateResult = GetBookBillStateNew(Global.XCPOSCODE, bookBillId);
            WebBookBillStateResult web3 = JsonConvert.DeserializeObject<WebBookBillStateResult>(GetBookBillStateResult);
            if (web3.MESSAGE[0].IS_SUCCESS == "TRUE")
            {
                List<WEBBILLSTATE> billState = web3.BILLSTATE;
                int billPrice = 0;//订单总金额
                                  //用订票用户信息补充票明细信息
                for (int i = 0; i < billState.Count; i++)
                {
                    billPrice += billState[i].FACT_PRICE;
                    string AddTicketInfoResult = AddTicketInfo(Global.XCPOSCODE, bookBillId, billState[i].TICKET_ID, param.passengerList[i].passengerName, param.passengerList[i].passengerCard);
                    //WebResult web4 = JsonConvert.DeserializeObject<WebResult>(AddTicketInfoResult);
                    openDao.insertBillInfo(bookBillId, param.passengerList[i].passengerId, param.passengerList[i].passengerType,
                        param.passengerList[i].passengerName, param.passengerList[i].passengerCardType,
                        param.passengerList[i].passengerCard, param.passengerList[i].passengerTel,
                        billState[i].BUNK_GRADE_NAME, billState[i].BUNK_CODE, billState[i].FACT_PRICE,
                        billState[i].TICKET_ID, billState[i].MARK_CODE);
                }
                //订票成功后添加一条记录在mysql里
                string[] ports = billState[0].SEAROUTE_NAME.Split("-");
                string[] times = billState[0].SAILING_TIME.Split(":");
                DateTime dtime = Convert.ToDateTime(billState[0].DEPARTURE_TIME);
                dtime = dtime.AddHours(Convert.ToInt16(times[0]));
                dtime = dtime.AddMinutes(Convert.ToInt16(times[1]));
                string ARRIVE_TIME = dtime.ToString("yyyy-MM-dd HH:mm:ss");

                if (!openDao.insertBillList(Global.XCPOSCODE, openId, bookBillId, "1", param.passengerList[0].passengerName,
                                            param.passengerList[0].passengerTel, param.passengerList[0].passengerCard,
                                            billState[0].DEPARTURE_TIME, ARRIVE_TIME, billState[0].SHIP_NAME,
                                            ports[0], ports[1], billState.Count, billPrice, billState[0].PLAN_ID,""))
                {
                    openDao.writeLog(Global.XCPOSCODE, openId, "InsertBillList", "InsertBillListError");
                    throw new ApiException(CodeMessage.InsertBillListError, "InsertBillListError");
                }
            }
            else
            {
                openDao.writeLog(Global.XCPOSCODE, openId, "GetBookBillState", web3.MESSAGE[0].MESSAGE);
                throw new ApiException(CodeMessage.GetBookBillStateError, "GetBookBillStateError");
            }
            //返回订单号

            return bookBillId;
        }


        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetBookingListByState(BaseApi baseApi)
        {
            BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
            if (param == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            //if (param.posCode == null || param.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            if (param.bookingState == null || param.bookingState == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();

            //处理10分取消未支付订单
            openDao.UpdateBookingStatusBy10Minute(openId);

            return openDao.getBillListByState(param, openId);
        }
        /// <summary>
        /// 获取订单信息
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetBookingListById(BaseApi baseApi)
        {
            BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
            if (param == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            //if (param.posCode == null || param.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            if (param.billId == null || param.billId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();

            //处理10分取消未支付订单
            openDao.UpdateBookingStatusBy10Minute(openId);

            return openDao.getBillListById(param.billId, openId);
        }
        /// <summary>
        /// 获取订单列表
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetBookingList(BaseApi baseApi)
        {
            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();

            //处理10分取消未支付订单
            openDao.UpdateBookingStatusBy10Minute(openId);

            return openDao.getBillList(Global.XCPOSCODE, openId);
        }
        /// <summary>
        /// 列表数量显示
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_TicketNum(BaseApi baseApi)
        {
            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();
            //处理10分取消未支付订单
            openDao.UpdateBookingStatusBy10Minute(openId);

            return openDao.getTicketNum(Global.XCPOSCODE, openId);
        }
        /// <summary>
        /// 申请退订单
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_ReturnTicket(BaseApi baseApi)
        {
            ReturnTicketParam param = JsonConvert.DeserializeObject<ReturnTicketParam>(baseApi.param.ToString());
            if (param == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            if (param.billId == null || param.billId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            if (param.id == null || param.id == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();

            BILLLIST billList = openDao.getBillListById(param.billId, openId);
            if (billList == null)
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "未查到订票信息");
            }
            if (billList.bookingState != "2")
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "订票状态错误");
            }
            DateTime dtime = Convert.ToDateTime(billList.beginDate+" "+billList.beginTime);
            //判断开船30分内不许退票
            if (dtime<DateTime.Now.AddMinutes(30))
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "开船30分内不许退票");
            }
            //判断是否已经打票
            BILLINFO billInfo = openDao.getBillInfoById(param.billId, param.id);
            if (billInfo==null)
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "退票信息不正确");
            }
            if (billInfo.ticketState != "2")
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
            }
            bool checkTicketIdError = true;
            string GetBookBillStateResult = GetBookBillStateNew(Global.XCPOSCODE, param.billId);
            WebBookBillStateResult web3 = JsonConvert.DeserializeObject<WebBookBillStateResult>(GetBookBillStateResult);
            if (web3.MESSAGE[0].IS_SUCCESS == "TRUE")
            {
                List<WEBBILLSTATE> billState = web3.BILLSTATE;
                for (int i = 0; i < billState.Count; i++)
                {
                    if (billInfo.ticketId == billState[i].TICKET_ID)
                    {
                        checkTicketIdError = false;
                        if (billState[i].MARK_CODE==null|| billState[i].MARK_CODE==""|| billState[i].MARK_CODE.Length==0)
                        {
                            throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
                        }else if (billState[i].MARK_CODE.Substring(0,1).ToUpper()!="W"|| billState[i].PAY_BOOK_STATE=="3")
                        {
                            throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
                        }
                    }
                }
                if (checkTicketIdError)
                {
                    throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
                }
            }
            else
            {
                throw new ApiException(CodeMessage.GetBookBillStateError, "GetBookBillStateError");
            }



            if (openDao.returnTicket(param.billId, openId, param.id,"4"))
            {
                if (!openDao.checkBillInfo(param.billId))
                {
                    openDao.returnBooking(param.billId, openId, "4");
                }
            }
            else
            {
                throw new ApiException(CodeMessage.RetrunBillError, "RetrunBillError");
            }
            string ReturnBookTicketResult = ReturnBookTicket(Global.POSCODE, billInfo.ticketId, param.billId, "0001");
            WebBillIdResult web1 = JsonConvert.DeserializeObject<WebBillIdResult>(ReturnBookTicketResult);
            if (web1.MESSAGE[0].IS_SUCCESS == "TRUE")
            {
                double price = billList.billPrice * 100;
                double refundFee = Math.Round(billInfo.factPrice * 0.2, 1);
                double amount = Math.Round(billInfo.factPrice * 0.8 * 100, 1);
                if (openDao.UpdateBillInfoByRetrun(param.billId, param.id, "5", refundFee.ToString()))
                {
                    if (!openDao.checkBillInfo(param.billId))
                    {
                        openDao.UpdateBillListByRetrun(param.billId, openId, "5", "", refundFee.ToString());
                    }
                    return true;
                }
                else
                {
                    throw new ApiException(CodeMessage.RetrunBillError, "RetrunBillError");
                }
            }
            else
            {
                openDao.writeLog(Global.POSCODE, openId, "BookingTicket", web1.MESSAGE[0].MESSAGE);
                throw new ApiException(CodeMessage.GetBillIdError, "GetBillIdError");
            }


        }

        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_ReturnBill(BaseApi baseApi)
        {
            BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
            if (param == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            if (param.billId == null || param.billId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            OpenDao openDao = new OpenDao();

            BILLLIST billList = openDao.getBillListById(param.billId, openId);
            if (billList == null)
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
            }
            if (billList.bookingState != "0" && billList.bookingState != "1")
            {
                throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
            }
            if (openDao.returnBill(param.billId, openId))
            {
                return true;
            }
            else
            {
                throw new ApiException(CodeMessage.RetrunBillError, "RetrunBillError");
            }
        }

        /// <summary>
        /// 调用支付
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_PaymentDone(BaseApi baseApi)
        {
            PaymentDoneParam param = JsonConvert.DeserializeObject<PaymentDoneParam>(baseApi.param.ToString());
            if (param == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            if (param.payId == null || param.payId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            if (param.billId == null || param.billId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            PaymentDao pDao = new PaymentDao();
            if (pDao.updateOrderForPay(param.billId, param.payId))
            {
                string SetPayIdResult = SetPayId(Global.XCPOSCODE, param.billId, param.payId);
                WebBillIdResult web1 = JsonConvert.DeserializeObject<WebBillIdResult>(SetPayIdResult);
                if (web1.MESSAGE[0].IS_SUCCESS == "TRUE")
                {
                    string PayTicketDoneResult = PayTicketDone(Global.XCPOSCODE, param.billId, param.payId).Replace("\"Msg\":]", "\"Msg\":[]");
                    WebBillIdResult web2 = JsonConvert.DeserializeObject<WebBillIdResult>(PayTicketDoneResult);
                    if (web2.MESSAGE[0].IS_SUCCESS == "TRUE")
                    {
                        pDao.insertPayLog(param.billId, param.payId, "0", openId, "携程支付完成-成功");
                    }
                    else
                    {
                        pDao.insertPayLog(param.billId, param.payId, "0", openId, "携程支付失败-确认付款失败");
                    }
                }
                else
                {
                    pDao.insertPayLog(param.billId, param.payId, "0", openId, "携程支付失败-同步设置支付单号失败");
                }

            }
            else
            {
                pDao.insertPayLog(param.billId, param.payId, "0", openId, "携程支付失败-修改订单状态失败");
            }
            return "";
        }

        /// <summary>
        /// 获取码头
        /// </summary>
        /// <param name="posCode"></param>
        /// <returns></returns>
        public static String GetPostListData(string posCode)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();

            ////发送请求
            //var v = callClient.getPortAsync(posCode);

            ////异步等待
            //v.Wait();
            ////获取数据
            //result = v.Result;
            //return result;

            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts.getPortRequestBody body = new pts.getPortRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts.getPortRequest(body);
            //发送请求
            var v = callClient.getPortAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.getPortResult;


            return result;
        }
        /// <summary>
        /// 获取航期
        /// </summary>
        /// <param name="posDateParam"></param>
        /// <returns></returns>
        public static String GetShipListData(PosDateParam posDateParam,string allotType)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts.getShipListByPortRequestBody body = new pts.getShipListByPortRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = Global.XCPOSCODE;
            body._dateFrom = posDateParam.dateFrom;
            body._dateTo = posDateParam.dateTo;
            body._port = posDateParam.port;
            body._allotType = allotType;
            body._his = false;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts.getShipListByPortRequest(body);
            //发送请求
            var v = callClient.getShipListByPortAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.getShipListByPortResult;


            return result;
        }
        /// <summary>
        /// 申请生成一个新的订单号
        /// </summary>
        /// <param name="posDateParam"></param>
        /// <returns></returns>
        public static String GetBookBillIdUser(string posCode, string name, string phone, string card, string openId)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts.getBookBillIdUserRequestBody body = new pts.getBookBillIdUserRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._getterName = name;
            body._getterPhone = phone;
            body._getterId = card;
            body._webUserId = openId;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts.getBookBillIdUserRequest(body);
            //发送请求
            var v = callClient.getBookBillIdUserAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.getBookBillIdUserResult;


            return result;
        }
        /// <summary>
        /// 订票
        /// </summary>
        /// <param name="posDateParam"></param>
        /// <returns></returns>
        public static String BookTicketAutoByTicketType(string posCode, string planId, string gradeId, string allotType, int ticketNum, string bookBillId, string ticketType)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts.bookTicketAutoByTicketTypeRequestBody body = new pts.bookTicketAutoByTicketTypeRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._planId = planId;
            body._gradeId = gradeId;
            body._allotType = allotType;
            body._bz = 1;
            body._ticketNum = ticketNum;
            body._bookBillId = bookBillId;
            body._ticketType = ticketType;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts.bookTicketAutoByTicketTypeRequest(body);
            //发送请求
            var v = callClient.bookTicketAutoByTicketTypeAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.bookTicketAutoByTicketTypeResult;


            return result;
        }

        /// <summary>
        /// 获取订单状态
        /// </summary>
        /// <param name="posDateParam"></param>
        /// <returns></returns>
        public static String GetBookBillStateNew(string posCode, string bookBillId)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts.getBookBillStateNewRequestBody body = new pts.getBookBillStateNewRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._bookBillId = bookBillId;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts.getBookBillStateNewRequest(body);
            //发送请求
            var v = callClient.getBookBillStateNewAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.getBookBillStateNewResult;


            return result;
        }
        /// <summary>
        /// 补充票明细信息
        /// </summary>
        /// <param name="posDateParam"></param>
        /// <returns></returns>
        public static String AddTicketInfo(string posCode, string bookBillId, string ticketId, string userName, string userCard)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts.addTicketInfoRequestBody body = new pts.addTicketInfoRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._bookBillId = bookBillId;
            body._ticketId = ticketId;
            body._userName = userName;
            body._userId = userCard;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts.addTicketInfoRequest(body);
            //发送请求
            var v = callClient.addTicketInfoAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.addTicketInfoResult;


            return result;
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
        /// <summary>
        /// 按票号退票
        /// </summary>
        /// <param name="posDateParam"></param>
        /// <returns></returns>
        public static String ReturnBookTicket(string posCode, string ticketId, string bookBillId, string returnType)
        {
            string result = "";
            // 创建 HTTP 绑定对象
            var binding = new BasicHttpBinding();
            // 根据 WebService 的 URL 构建终端点对象
            var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
            // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
            var factory = new ChannelFactory<pts1.PtsServiceTJSoap>(binding, endpoint);
            // 从工厂获取具体的调用实例
            var callClient = factory.CreateChannel();



            //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
            pts1.returnBookTicketRequestBody body = new pts1.returnBookTicketRequestBody();

            //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
            body._posCode = posCode;
            body._bookBillId = bookBillId;
            body._ticketId = ticketId;
            body._returnType = returnType;

            //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
            var request = new pts1.returnBookTicketRequest(body);
            //发送请求
            var v = callClient.returnBookTicketAsync(request);

            //异步等待
            v.Wait();

            //获取数据
            result = v.Result.Body.returnBookTicketResult;


            return result;
        }


    }
}
