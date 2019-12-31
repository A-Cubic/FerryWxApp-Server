using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACBC.Common
{
    /// <summary>
    /// 返回信息对照
    /// </summary>
    public enum CodeMessage
    {
        OK = 0,
        PostNull = -1,

        AppIDError = 201,
        SignError = 202,

        NotFound = 404,
        InnerError = 500,

        SenparcCode = 1000,

        PaymentError = 3000,
        PaymentTotalPriceZero=3001,
        PaymentMsgError = 3002,
        PaymentStateError = 3003,
        PaymentBillError = 3004,

        InvalidToken = 4000,
        InvalidMethod = 4001,
        InvalidParam = 4002,
        InterfaceRole = 4003,//接口权限不足
        InterfaceValueError = 4004,//接口的参数不对
        InterfaceDBError=4005,//接口数据库操作失败
        NeedLogin = 4006,

        MemberExist = 10001,
        MemberRegError = 10002,

        BookingTicketError = 20000, //订票失败
        CheckPassengerError = 20001,//检查乘车人失败
        GetBillIdError = 20002,//获取订单id失败
        BookTicketError = 20003,//订票失败
        GetBookBillStateError = 20004,//获取订单状态失败
        InsertBillListError = 20005,//写入订单失败
        RetrunBillStateError = 20006,//退票时退票状态校验失败
        RetrunBillError = 20007,//退票失败
        MemberStatusError = 20008,//用户被禁用
        PassengerNumError = 20009,//订票人超过5个
        OnePlanError = 20010,//已订同航次船票
        TimeError = 20011,//距离开航时间小于设定的禁买时间

        AddPassengerError = 30000,//新增乘客失败
        DelPassengerError = 30001,//删除乘客失败
        IdenticalPassengerError = 30002,//已有相同证件号的乘客
        IDCardError = 30003,//身份证号校验失败
    }
}
