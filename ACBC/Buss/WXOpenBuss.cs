﻿using ACBC.Common;
using ACBC.Dao;
using Newtonsoft.Json;
using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.WxOpen.AdvancedAPIs.Sns;
using Senparc.Weixin.WxOpen.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ACBC.Buss
{
    public class TokenOpenBuss : IBuss
    {
        public ApiType GetApiType()
        {
            return ApiType.WXOpenApi;
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetToken(BaseApi baseApi)
        {
            LoginParam loginParam = JsonConvert.DeserializeObject<LoginParam>(baseApi.param.ToString());
            if (loginParam == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            
            if (loginParam.code == Global.XCSECRET)
            {
                SessionBag sessionBagX = SessionContainer.GetSession(Global.XCOPENID);
                if (sessionBagX != null)
                {
                    if (sessionBagX.Name!="")
                    {
                        SessionContainer.RemoveFromCache(sessionBagX.OpenId);
                    }
                }
                AccessTokenContainer.Register(Global.APPID, Global.APPSECRET);
                var sessionBag = SessionContainer.UpdateSession(null, Global.XCOPENID, Global.XCOPENID);

                OpenDao openDao = new OpenDao();
                SessionUser sessionUser = new SessionUser();

                Member member = openDao.GetMember(Utils.GetOpenID(sessionBag.Key));
                if (member == null)
                {
                    throw new ApiException(CodeMessage.SenparcCode, CodeMessage.SenparcCode.ToString());
                }
                else
                {
                    sessionUser.userType = "MEMBER";
                    sessionUser.openid = sessionBag.OpenId;
                    sessionUser.memberId = member.memberId;
                    sessionBag.Name = JsonConvert.SerializeObject(sessionUser);
                    SessionContainer.Update(sessionBag.Key, sessionBag);

                    SessionBag bag = new SessionBag();
                    bag.Name = sessionBag.Key;
                    SessionContainer.UpdateSession(Global.XCOPENID, sessionBag.Key, sessionBag.Key);

                    return new
                    {
                        token = sessionBag.Key
                    };
                }
            }
            else
            {
                throw new ApiException(CodeMessage.SenparcCode, CodeMessage.SenparcCode.ToString());
            }
        }

       

        /// <summary>
        /// 获取轮播图列表
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetBanner(BaseApi baseApi)
        {
            //PosParam posParam = JsonConvert.DeserializeObject<PosParam>(baseApi.param.ToString());
            //if (posParam == null)
            //{
            //    throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            //}
            //if (posParam.posCode == null || posParam.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            UserDao userDao = new UserDao();

            return userDao.getBanner(Global.POSCODE);
        }

        /// <summary>
        /// 获取近期动态
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetNews(BaseApi baseApi)
        {
            //PosParam posParam = JsonConvert.DeserializeObject<PosParam>(baseApi.param.ToString());
            //if (posParam == null)
            //{
            //    throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            //}
            //if (posParam.posCode == null || posParam.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            UserDao userDao = new UserDao();

            return userDao.getNews(Global.POSCODE);
        }

        /// <summary>
        /// 获取系统通知
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetNotify(BaseApi baseApi)
        {
            //PosParam posParam = JsonConvert.DeserializeObject<PosParam>(baseApi.param.ToString());
            //if (posParam == null)
            //{
            //    throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            //}
            //if (posParam.posCode == null || posParam.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            UserDao userDao = new UserDao();

            return userDao.getNotify(Global.POSCODE);
        }


        /// <summary>
        /// 获取咨询电话
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetTel(BaseApi baseApi)
        {
            //PosParam posParam = JsonConvert.DeserializeObject<PosParam>(baseApi.param.ToString());
            //if (posParam == null)
            //{
            //    throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            //}
            //if (posParam.posCode == null || posParam.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            UserDao userDao = new UserDao();

            return userDao.getTel(Global.POSCODE);
        }



       
        #region 注释掉
        ///// <summary>
        ///// 获取港口列表
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_GetPort(BaseApi baseApi)
        //{
        //    //Port obj = Utils.GetCache<Port>("PORT");

        //    //if (obj == null)
        //    //{
        //    //    obj = JsonConvert.DeserializeObject<Port>(GetPostListData(Global.POSCODE));

        //    //    Utils.SetCache("PORT",obj, 0, 1, 0);
        //    //}
        //    Port obj = JsonConvert.DeserializeObject<Port>(GetPostListData(Global.POSCODE));
        //    List<string> list = new List<string>();
        //    foreach (var item in obj.PORTLIST)
        //    {
        //        list.Add(item.PORT_CNAME);
        //    }
        //    return list;
        //}
        ///// <summary>
        ///// 获取船计划
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_GetPlan(BaseApi baseApi)
        //{
        //    PosDateParam posDateParam = JsonConvert.DeserializeObject<PosDateParam>(baseApi.param.ToString());
        //    if (posDateParam == null)
        //    {
        //        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        //    }
        //    if (posDateParam.dateFrom == null || posDateParam.dateFrom == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    if (posDateParam.dateFrom.Length!=8)
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }

        //    ShipWeb obj = JsonConvert.DeserializeObject<ShipWeb>(GetShipListData(posDateParam));
        //    Ship obj1 = new Ship();
        //    obj1.date = posDateParam.dateFrom.Insert(4, "-").Insert(7, "-");
        //    obj1.SHIPLIST = new List<SHIPLIST>();
        //    foreach (var ship in obj.SHIPLIST)
        //    {
        //        SHIPLIST shipList = new SHIPLIST();
        //        string[] ports = ship.SEAROUTE_NAME.Split("-");
        //        if (ports.Length > 1)
        //        {
        //            shipList.fromPort = ports[0];
        //            shipList.toPort = ports[1];
        //        }
        //        try
        //        {
        //            string[] times = ship.SAILING_TIME.Split(":");
        //            DateTime dtime = Convert.ToDateTime(ship.DEPARTURE_TIME);
        //            dtime = dtime.AddHours(Convert.ToInt16(times[0]));
        //            dtime = dtime.AddMinutes(Convert.ToInt16(times[1]));
        //            shipList.arriveDate = dtime.ToString("yyyy-MM-dd");
        //            shipList.arriveTime = dtime.ToString("HH:mm");
        //            shipList.berthName = ship.BERTH_NAME;
        //            shipList.departureDate = Convert.ToDateTime(ship.DEPARTURE_TIME).ToString("yyyy-MM-dd");
        //            shipList.departureTime = Convert.ToDateTime(ship.DEPARTURE_TIME).ToString("HH:mm");
        //            shipList.planId = ship.PLAN_ID;
        //            shipList.sailingTime = ship.SAILING_TIME;
        //            shipList.searouteAlise = ship.SEAROUTE_ALISE;
        //            shipList.searouteName = ship.SEAROUTE_NAME;
        //            shipList.shipName = ship.SHIP_NAME;
        //            shipList.stu = ship.STU;
        //            shipList.voyageNumber = ship.VOYAGE_NUMBER;
        //            shipList.gradeList = new List<Grade>();
        //            Grade grade = new Grade();
        //            grade.gradeId = ship.BUNK_GRADE_ID;
        //            grade.gradeName = ship.BUNK_GRADE_NAME;
        //            grade.ticketLeft = ship.TICKET_LEFT;
        //            grade.price = ship.PRICE;
        //            grade.halfPrice = ship.HALF_PRICE;
        //            shipList.gradeList.Add(grade);
        //            obj1.SHIPLIST.Add(shipList);
        //        }
        //        catch (Exception)
        //        {

        //        }

        //    }
        //    return obj1;
        //}
        ///// <summary>
        ///// 下订单
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_BookingTicket(BaseApi baseApi)
        //{
        //    OpenDao openDao = new OpenDao();
        //    BookingTicketParam param = JsonConvert.DeserializeObject<BookingTicketParam>(baseApi.param.ToString());
        //    if (param == null)
        //    {
        //        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        //    }
        //    //if (param.posCode == null || param.posCode == "")
        //    //{
        //    //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    //}
        //    if (param.planId == null || param.planId == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    if (param.gradeId == null || param.gradeId == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    if (param.mobile == null || param.mobile == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    if (param.passengerList == null || param.passengerList.Count == 0)
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    //try
        //    //{
        //    //先判断订票用户和账号是否匹配。
        //    string error = "";
        //        foreach (Passenger passenger in param.passengerList)
        //        {
        //            Passenger p = openDao.getPassenger(Global.POSCODE, openId, passenger.passengerId);
        //            if (p == null)
        //            {
        //                error += passenger.passengerName + "状态错误;";
        //            }
        //            else
        //            {
        //                passenger.passengerType = p.passengerType;
        //                passenger.passengerName = p.passengerName;
        //                passenger.passengerCard = p.passengerCard;
        //                passenger.passengerCardType = p.passengerCardType;
        //                passenger.passengerTel = p.passengerTel;
        //            }
        //        }
        //        //再判断是否都是一个等级
        //        string grade = param.passengerList[0].passengerType;
        //        foreach (Passenger passenger in param.passengerList)
        //        {
        //            if (grade != passenger.passengerType)
        //            {
        //                error += "不是同一个类型,一个订单只支持同一个类型的票;";
        //            }
        //        }
        //        if (error != "")
        //        {
        //            openDao.writeLog(Global.POSCODE, openId, "BookingTicket", error);
        //            throw new ApiException(CodeMessage.CheckPassengerError, error);
        //        }
        //        //用第一个人的信息生成一个新的订单号

        //        string bookBillId = "";
        //        string GetBookBillIdUserResult = GetBookBillIdUser(Global.POSCODE, param.passengerList[0].passengerName, param.mobile, param.passengerList[0].passengerCard, openId);
        //        WebBillIdResult web1 = JsonConvert.DeserializeObject<WebBillIdResult>(GetBookBillIdUserResult);
        //        if (web1.MESSAGE[0].IS_SUCCESS == "TRUE")
        //        {
        //            bookBillId = web1.BILLID[0].BILL_ID;
        //        }
        //        else
        //        {
        //            openDao.writeLog(Global.POSCODE, openId, "BookingTicket", web1.MESSAGE[0].MESSAGE);
        //            throw new ApiException(CodeMessage.GetBillIdError, "GetBillIdError");
        //        }
        //        //订票
        //        string allotType = "001", ticketType = param.passengerList[0].passengerType;
        //        int ticketNum = param.passengerList.Count;
        //        if (param.passengerList[0].passengerType == "004")
        //        {
        //            allotType = "999";
        //        }
        //        string BookTicketAutoByTicketResult = BookTicketAutoByTicketType(Global.POSCODE, param.planId, param.gradeId, allotType, ticketNum, bookBillId, ticketType);
        //        WebResult web2 = JsonConvert.DeserializeObject<WebResult>(BookTicketAutoByTicketResult);
        //        if (web2.MESSAGE[0].IS_SUCCESS == "TRUE")
        //        {

        //        }
        //        else
        //        {
        //            openDao.writeLog(Global.POSCODE, openId, "BookingTicket", web2.MESSAGE[0].MESSAGE);
        //            throw new ApiException(CodeMessage.BookTicketError, "BookTicketError");
        //        }
        //        //获取订票状态
        //        string GetBookBillStateResult = GetBookBillStateNew(Global.POSCODE, bookBillId);
        //        WebBookBillStateResult web3 = JsonConvert.DeserializeObject<WebBookBillStateResult>(GetBookBillStateResult);
        //        if (web3.MESSAGE[0].IS_SUCCESS == "TRUE")
        //        {
        //            List<WEBBILLSTATE> billState = web3.BILLSTATE;
        //            int billPrice = 0;//订单总金额
        //            //用订票用户信息补充票明细信息
        //            for (int i = 0; i < billState.Count; i++)
        //            {
        //                billPrice += billState[i].FACT_PRICE;
        //                string AddTicketInfoResult = AddTicketInfo(Global.POSCODE, bookBillId, billState[i].TICKET_ID, param.passengerList[i].passengerName, param.passengerList[i].passengerCard);
        //                //WebResult web4 = JsonConvert.DeserializeObject<WebResult>(AddTicketInfoResult);
        //                openDao.insertBillInfo(bookBillId, param.passengerList[i].passengerId, param.passengerList[i].passengerType,
        //                    param.passengerList[i].passengerName,param.passengerList[i].passengerCardType, 
        //                    param.passengerList[i].passengerCard, param.passengerList[i].passengerTel,
        //                    billState[i].BUNK_GRADE_NAME, billState[i].BUNK_CODE, billState[i].FACT_PRICE, billState[i].TICKET_ID);
        //            }
        //            //订票成功后添加一条记录在mysql里
        //            string[] ports = billState[0].SEAROUTE_NAME.Split("-");
        //            string[] times = billState[0].SAILING_TIME.Split(":");
        //            DateTime dtime = Convert.ToDateTime(billState[0].DEPARTURE_TIME);
        //            dtime = dtime.AddHours(Convert.ToInt16(times[0]));
        //            dtime = dtime.AddMinutes(Convert.ToInt16(times[1]));
        //            string ARRIVE_TIME = dtime.ToString("yyyy-MM-dd HH:mm:ss");

        //            if (!openDao.insertBillList(Global.POSCODE, openId, bookBillId, "1", param.passengerList[0].passengerName,
        //                                        param.passengerList[0].passengerTel, param.passengerList[0].passengerCard,
        //                                        billState[0].DEPARTURE_TIME, ARRIVE_TIME, billState[0].SHIP_NAME,
        //                                        ports[0], ports[1], billState.Count, billPrice))
        //            {
        //                openDao.writeLog(Global.POSCODE, openId, "InsertBillList", "InsertBillListError");
        //                throw new ApiException(CodeMessage.InsertBillListError, "InsertBillListError");
        //            }
        //        }
        //        else
        //        {
        //            openDao.writeLog(Global.POSCODE, openId, "GetBookBillState", web3.MESSAGE[0].MESSAGE);
        //            throw new ApiException(CodeMessage.GetBookBillStateError, "GetBookBillStateError");
        //        }

        //        //返回订单号

        //        return bookBillId;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    openDao.writeLog(Global.POSCODE, openId, "BookingTicket", ex.ToString());
        //    //    throw new ApiException(CodeMessage.BookingTicketError, "BookingTicketError");
        //    //}
        //}


        ///// <summary>
        ///// 获取订单列表
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_GetBookingListByState(BaseApi baseApi)
        //{
        //    BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
        //    if (param == null)
        //    {
        //        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        //    }
        //    //if (param.posCode == null || param.posCode == "")
        //    //{
        //    //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    //}
        //    if (param.bookingState == null || param.bookingState == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    OpenDao openDao = new OpenDao();

        //    return openDao.getBillListByState(param, openId);
        //}
        ///// <summary>
        ///// 获取订单列表
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_GetBookingListById(BaseApi baseApi)
        //{
        //    BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
        //    if (param == null)
        //    {
        //        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        //    }
        //    //if (param.posCode == null || param.posCode == "")
        //    //{
        //    //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    //}
        //    if (param.billId == null || param.billId == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    OpenDao openDao = new OpenDao();

        //    return openDao.getBillListById(param.billId, openId);
        //}
        ///// <summary>
        ///// 获取订单列表
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_GetBookingList(BaseApi baseApi)
        //{
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    OpenDao openDao = new OpenDao();

        //    return openDao.getBillList(Global.POSCODE, openId);
        //}
        ///// <summary>
        ///// 列表数量显示
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_TicketNum(BaseApi baseApi)
        //{
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    OpenDao openDao = new OpenDao();
        //    return openDao.getTicketNum(Global.POSCODE, openId);
        //}
        ///// <summary>
        ///// 申请退订单
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_ReturnTicket(BaseApi baseApi)
        //{
        //    ReturnTicketParam param = JsonConvert.DeserializeObject<ReturnTicketParam>(baseApi.param.ToString());
        //    if (param == null)
        //    {
        //        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        //    }
        //    if (param.billId == null || param.billId == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    if (param.id == null || param.id == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    OpenDao openDao = new OpenDao();

        //    BILLLIST billList = openDao.getBillListById(param.billId, openId);
        //    if (billList == null)
        //    {
        //        throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
        //    }
        //    if (billList.bookingState!="2")
        //    {
        //        throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
        //    }
        //    if (openDao.returnTicket(param.billId, openId, param.id))
        //    {
        //        if (!openDao.checkBillInfo(param.billId))
        //        {
        //            openDao.returnBooking(param.billId, openId);
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        throw new ApiException(CodeMessage.RetrunBillError, "RetrunBillError");
        //    }
        //}

        ///// <summary>
        ///// 取消订单
        ///// </summary>
        ///// <param name="baseApi"></param>
        ///// <returns></returns>
        //public object Do_ReturnBill(BaseApi baseApi)
        //{
        //    BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
        //    if (param == null)
        //    {
        //        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        //    }
        //    if (param.billId == null || param.billId == "")
        //    {
        //        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        //    }
        //    string openId = Utils.GetOpenID(baseApi.token);
        //    OpenDao openDao = new OpenDao();

        //    BILLLIST billList = openDao.getBillListById(param.billId, openId);
        //    if (billList == null)
        //    {
        //        throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
        //    }
        //    if (billList.bookingState != "0" && billList.bookingState != "1")
        //    {
        //        throw new ApiException(CodeMessage.RetrunBillStateError, "RetrunBillStateError");
        //    }
        //    if (openDao.returnBill(param.billId, openId))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        throw new ApiException(CodeMessage.RetrunBillError, "RetrunBillError");
        //    }
        //}

        /////// <summary>
        /////// 调用支付
        /////// </summary>
        /////// <param name="baseApi"></param>
        /////// <returns></returns>
        ////public object Do_Pay(BaseApi baseApi)
        ////{
        ////    BookingListParam param = JsonConvert.DeserializeObject<BookingListParam>(baseApi.param.ToString());
        ////    if (param == null)
        ////    {
        ////        throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
        ////    }
        ////    if (param.posCode == null || param.posCode == "")
        ////    {
        ////        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        ////    }
        ////    if (param.billId == null || param.billId == "")
        ////    {
        ////        throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
        ////    }
        ////    string openId = Utils.GetOpenID(baseApi.token);
        ////    OpenDao openDao = new OpenDao();
        ////    PAY pay = new PAY
        ////    {
        ////        appId = "1",
        ////        timeStamp = "2",
        ////        nonceStr = "3",
        ////        package = "4",
        ////        signType = "5",
        ////        paySign = "6",
        ////    };
        ////    return pay;
        ////}



        ///// <summary>
        ///// 获取码头
        ///// </summary>
        ///// <param name="posCode"></param>
        ///// <returns></returns>
        //public static String GetPostListData(string posCode)
        //{
        //    string result = "";
        //    // 创建 HTTP 绑定对象
        //    var binding = new BasicHttpBinding();
        //    // 根据 WebService 的 URL 构建终端点对象
        //    var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
        //    // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
        //    var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
        //    // 从工厂获取具体的调用实例
        //    var callClient = factory.CreateChannel();

        //    ////发送请求
        //    //var v = callClient.getPortAsync(posCode);

        //    ////异步等待
        //    //v.Wait();
        //    ////获取数据
        //    //result = v.Result;
        //    //return result;

        //    //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
        //    pts.getPortRequestBody body = new pts.getPortRequestBody();

        //    //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
        //    body._posCode = posCode;

        //    //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
        //    var request = new pts.getPortRequest(body);
        //    //发送请求
        //    var v = callClient.getPortAsync(request);

        //    //异步等待
        //    v.Wait();

        //    //获取数据
        //    result = v.Result.Body.getPortResult;


        //    return result;
        //}
        ///// <summary>
        ///// 获取航期
        ///// </summary>
        ///// <param name="posDateParam"></param>
        ///// <returns></returns>
        //public static String GetShipListData(PosDateParam posDateParam)
        //{
        //    string result = "";
        //    // 创建 HTTP 绑定对象
        //    var binding = new BasicHttpBinding();
        //    // 根据 WebService 的 URL 构建终端点对象
        //    var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
        //    // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
        //    var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
        //    // 从工厂获取具体的调用实例
        //    var callClient = factory.CreateChannel();



        //    //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
        //    pts.getShipListByPortRequestBody body = new pts.getShipListByPortRequestBody();

        //    //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
        //    body._posCode = Global.POSCODE;
        //    body._dateFrom = posDateParam.dateFrom;
        //    body._dateTo = posDateParam.dateTo;
        //    body._port = posDateParam.port;
        //    body._his = false;

        //    //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
        //    var request = new pts.getShipListByPortRequest(body);
        //    //发送请求
        //    var v = callClient.getShipListByPortAsync(request);

        //    //异步等待
        //    v.Wait();

        //    //获取数据
        //    result = v.Result.Body.getShipListByPortResult;


        //    return result;
        //}
        ///// <summary>
        ///// 申请生成一个新的订单号
        ///// </summary>
        ///// <param name="posDateParam"></param>
        ///// <returns></returns>
        //public static String GetBookBillIdUser(string posCode, string name, string phone, string card, string openId)
        //{
        //    string result = "";
        //    // 创建 HTTP 绑定对象
        //    var binding = new BasicHttpBinding();
        //    // 根据 WebService 的 URL 构建终端点对象
        //    var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
        //    // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
        //    var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
        //    // 从工厂获取具体的调用实例
        //    var callClient = factory.CreateChannel();



        //    //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
        //    pts.getBookBillIdUserRequestBody body = new pts.getBookBillIdUserRequestBody();

        //    //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
        //    body._posCode = posCode;
        //    body._getterName = name;
        //    body._getterPhone = phone;
        //    body._getterId = card;
        //    body._webUserId = openId;

        //    //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
        //    var request = new pts.getBookBillIdUserRequest(body);
        //    //发送请求
        //    var v = callClient.getBookBillIdUserAsync(request);

        //    //异步等待
        //    v.Wait();

        //    //获取数据
        //    result = v.Result.Body.getBookBillIdUserResult;


        //    return result;
        //}
        ///// <summary>
        ///// 订票
        ///// </summary>
        ///// <param name="posDateParam"></param>
        ///// <returns></returns>
        //public static String BookTicketAutoByTicketType(string posCode, string planId, string gradeId, string allotType, int ticketNum, string bookBillId, string ticketType)
        //{
        //    string result = "";
        //    // 创建 HTTP 绑定对象
        //    var binding = new BasicHttpBinding();
        //    // 根据 WebService 的 URL 构建终端点对象
        //    var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
        //    // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
        //    var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
        //    // 从工厂获取具体的调用实例
        //    var callClient = factory.CreateChannel();



        //    //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
        //    pts.bookTicketAutoByTicketTypeRequestBody body = new pts.bookTicketAutoByTicketTypeRequestBody();

        //    //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
        //    body._posCode = posCode;
        //    body._planId = planId;
        //    body._gradeId = gradeId;
        //    body._allotType = allotType;
        //    body._bz = 1;
        //    body._ticketNum = ticketNum;
        //    body._bookBillId = bookBillId;
        //    body._ticketType = ticketType;

        //    //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
        //    var request = new pts.bookTicketAutoByTicketTypeRequest(body);
        //    //发送请求
        //    var v = callClient.bookTicketAutoByTicketTypeAsync(request);

        //    //异步等待
        //    v.Wait();

        //    //获取数据
        //    result = v.Result.Body.bookTicketAutoByTicketTypeResult;


        //    return result;
        //}

        ///// <summary>
        ///// 获取订单状态
        ///// </summary>
        ///// <param name="posDateParam"></param>
        ///// <returns></returns>
        //public static String GetBookBillStateNew(string posCode, string bookBillId)
        //{
        //    string result = "";
        //    // 创建 HTTP 绑定对象
        //    var binding = new BasicHttpBinding();
        //    // 根据 WebService 的 URL 构建终端点对象
        //    var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
        //    // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
        //    var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
        //    // 从工厂获取具体的调用实例
        //    var callClient = factory.CreateChannel();



        //    //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
        //    pts.getBookBillStateNewRequestBody body = new pts.getBookBillStateNewRequestBody();

        //    //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
        //    body._posCode = posCode;
        //    body._bookBillId = bookBillId;

        //    //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
        //    var request = new pts.getBookBillStateNewRequest(body);
        //    //发送请求
        //    var v = callClient.getBookBillStateNewAsync(request);

        //    //异步等待
        //    v.Wait();

        //    //获取数据
        //    result = v.Result.Body.getBookBillStateNewResult;


        //    return result;
        //}
        ///// <summary>
        ///// 补充票明细信息
        ///// </summary>
        ///// <param name="posDateParam"></param>
        ///// <returns></returns>
        //public static String AddTicketInfo(string posCode, string bookBillId, string ticketId, string userName, string userCard)
        //{
        //    string result = "";
        //    // 创建 HTTP 绑定对象
        //    var binding = new BasicHttpBinding();
        //    // 根据 WebService 的 URL 构建终端点对象
        //    var endpoint = new EndpointAddress(System.Environment.GetEnvironmentVariable("PtsUrl"));
        //    // 创建调用接口的工厂，注意这里泛型只能传入接口 添加服务引用时生成的 webservice的接口 一般是 (XXXSoap)
        //    var factory = new ChannelFactory<pts.PtsServiceTJSoap>(binding, endpoint);
        //    // 从工厂获取具体的调用实例
        //    var callClient = factory.CreateChannel();



        //    //调用的对应webservice 服务类的函数生成对应的请求类Body (一般是webservice 中对应的方法+RequestBody  如GetInfoListRequestBody)
        //    pts.addTicketInfoRequestBody body = new pts.addTicketInfoRequestBody();

        //    //以下是为该请求body添加对应的参数（就是调用webService中对应的方法的参数）
        //    body._posCode = posCode;
        //    body._bookBillId = bookBillId;
        //    body._ticketId = ticketId;
        //    body._userName = userName;
        //    body._userId = userCard;

        //    //获取请求对象 （一般是webservice 中对应的方法+tRequest  如GetInfoListRequest）
        //    var request = new pts.addTicketInfoRequest(body);
        //    //发送请求
        //    var v = callClient.addTicketInfoAsync(request);

        //    //异步等待
        //    v.Wait();

        //    //获取数据
        //    result = v.Result.Body.addTicketInfoResult;


        //    return result;
        //}
        #endregion
    }
}
