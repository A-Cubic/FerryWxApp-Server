using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ACBC.Buss
{
    #region Sys
    public class BussCache
    {
        private string unique = "";
        public string Unique
        {
            get
            {
                return unique;
            }
            set
            {
                unique = value;
            }
        }
    }

    public class BussParam
    {
        public string GetUnique()
        {
            string needMd5 = "";
            string md5S = "";
            foreach (FieldInfo f in this.GetType().GetFields())
            {
                needMd5 += f.Name;
                needMd5 += f.GetValue(this).ToString();
            }
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(needMd5));
                var strResult = BitConverter.ToString(result);
                md5S = strResult.Replace("-", "");
            }
            return md5S;
        }
    }

    public class SessionUser
    {
        public string openid;
        public string checkPhone;
        public string checkCode;
        public string userType;
        public string memberId;
    } 
    public class SmsCodeRes
    {
        public int error_code;
        public string reason;
    }

    public class WsPayState
    {
        public string userId;
        public string scanCode;
    }

    public class ExchangeRes
    {
        public string reason;
        public ExchangeResult result;
        public int error_code;
    }
    public class ExchangeResult
    {
        public string update;
        public List<string[]> list;
    }

    public enum ScanCodeType
    {
        Shop,
        User,
        Null,
    }

    #endregion

    #region Params

    public class LoginParam
    {
        public string code;
    }
    public class MemberRegParam
    {
        public string avatarUrl;
        public string city;
        public string country;
        public string gender;
        public string language;
        public string nickName;
        public string province;
    }
    //public class PosParam
    //{
    //    public string posCode;
    //}

    public class PosDateParam
    {
        //public string posCode;
        public string dateFrom;
        public string dateTo;
        public string port;
    }
    //public class PassengerParam
    //{
    //    public string posCode;
    //}

    public class AddPassengerParam
    {
        //public string posCode;
        public string passengerType;//乘客类型
        public string passengerName;//乘客名
        public string passengerCard;//乘客证件号
        public string passengerCardType;//证件类型
        public string passengerTel;//电话
    }
    public class DelPassengerParam
    {
        public string passengerId;//乘客id
    }
    public class GetOnlineShopDataParam  
    {
        public string shopId;
    }

    public class GetOfflineShopDataParam  
    {
        public string shopId;
    }

    public class BookingTicketParam
    {
        //public string posCode;
        public string planId;
        public string gradeId;
        public string name;
        public string card;
        public string mobile;
        public List<Passenger> passengerList;
    }
    public class BookingListParam
    {
        //public string posCode;
        public string billId;
        public string bookingState;
    }
    public class ReturnTicketParam
    {
        public string billId;
        public string id;
    }
    public class PaymentParam
    {
        public string billId; //
    }
    #endregion

    #region DaoObjs

    public class Member
    {
        public string memberName;
        public string memberId;
        public string openid;
        public string memberImg;
        public string memberPhone;
        public string memberSex;
        public string scanCode;
        public string status;
    }
    public class User
    {
        public string userName;
        public string userId;
        public string openid;
        public string userImg;
        public string phone;
        public string userType;
        public string scanCode;
        public string sex;
    }
    public class Port
    {
        public List<PORTLIST> PORTLIST;
    }
    public class PORTLIST
    {
        public string PORT_CNAME;
    }
    public class ShipWeb
    {
        public List<SHIPLISTWEB> SHIPLIST;
    }
    public class Ship
    {
        public string date;
        public List<SHIPLIST> SHIPLIST;
    }

    public class WebResult
    {
        public List<MessageTxt> MESSAGE;
    }
    public class WebBillIdResult
    {
        public List<MessageTxt> MESSAGE;
        public List<BILLID> BILLID;
    }
    public class MessageTxt
    {
        public string IS_SUCCESS;
        public string MESSAGE;
    }
    public class BILLID
    {
        public string BILL_ID;
    }
    public class SHIPLISTWEB : BaseBuss
    {
        public string FROM_PORT;//起始港
        public string TO_PORT;//到达港
        public string ARRIVE_TIME;//预计到达时间
        public string SAILING_TIME;//航行时间
        public string SEAROUTE_NAME;//航线
        public string DEPARTURE_TIME;//开行时间
        public string SEAROUTE_ALISE;//航线简称
        public string BERTH_NAME;//停靠泊位
        public string SHIP_NAME;//船舶名称
        public string PLAN_ID;//计划号
        public string VOYAGE_NUMBER;//航次号
        public string BUNK_GRADE_NAME;//铺位等级
        public string PRICE;//票价
        public string HALF_PRICE;//半价票价
        public string BUNK_GRADE_ID;//铺位等级序号
        public string TICKET_LEFT;//余票量
        public string STU;//是否可售学生票  
    }
    public class SHIPLIST : BaseBuss
    {
        public string fromPort;//起始港
        public string toPort;//到达港
        public string arriveDate;//预计到达日期
        public string arriveTime;//预计到达时间
        public string sailingTime;//航行时间
        public string searouteName;//航线
        public string departureDate;//开行日期
        public string departureTime;//开行时间
        public string searouteAlise;//航线简称
        public string berthName;//停靠泊位
        public string shipName;//船舶名称
        public string planId;//计划号
        public string voyageNumber;//航次号
        public string stu;//是否可售学生票 
        public List<Grade> gradeList;
    }
    public class Grade
    {
        public string gradeId;//铺位等级序号
        public string gradeName;//铺位等级
        public string ticketLeft;//余票量
        public string price;//票价
        public string halfPrice;//半价票价
    }

    public class Banner
    {
        public string sort;//序号
        public string advname;//名称
        public string advtime;//时间
        public string advurl;//跳转链接
        public string imgurl;//图片链接
        public string remark;//选中图片时显示的文字
    }
    public class Passenger
    {
        public string passengerId;//乘客ID
        public string passengerType;//乘客类型
        public string passengerTypeName;//乘客类型
        public string passengerName;//乘客名
        public string passengerCard;//乘客证件号
        public string passengerCardType;//证件类型
        public string passengerTel;//电话
    }
    public class WebBookBillStateResult
    {
        public List<MessageTxt> MESSAGE;
        public List<WEBBILLLIST> BILLLIST;
        public List<WEBBILLSTATE> BILLSTATE;
    }
    public class WEBBILLLIST
    {
        public string BOOK_TIME;
        public string BOOKING_NAME;
        public string BOOKING_PHONE;
        public string BOOKING_ID;
        public string BOOK_STATE;
        public string FOR_WEB_TAG2;
    }
    public class WEBBILLSTATE
    {
        public string SEAROUTE_ALISE;
        public string SEAROUTE_NAME;
        public string SAILING_TIME;
        public string BERTH_NAME;
        public string SHIP_NAME;
        public string DEPARTURE_TIME;
        public string BUNK_GRADE_NAME;
        public string BUNK_CODE;
        public string BUNK_IFWINDOW;
        public string BUNK_POS;
        public int FACT_PRICE;
        public string PASSENGER_NAME;
        public string PERSON_CARD_ID;
        public string PLAN_ID;
        public string BUNK_GRADE_ID;
        public string MARK_CODE;
        public string TICKET_BARCODE;
        public string TICKET_ID;
        public string PAY_BOOK_STATE;
    }


    public class BookingBillList
    {
        public List<BILLLIST> unpaid;
        public List<BILLLIST> paid;
        public List<BILLLIST> refund;
    }
    public class BILLLIST
    {
        public string id;
        //public string posCode;
        public string openId;
        public string billId;
        public string beginDate;
        public string endDate;
        public string beginTime;
        public string endTime;
        public string shipName;
        public string sailing;
        public string beginPort;
        public string endPort;
        public int ticketNum;
        public double billPrice;
        public string bookingState;
        public string state;
        public string bookingTime;
        public string bookingName;
        public string bookingPhone;
        public string bookingCard;
        public string prePayId;
        public string prePayTime;
        public List<BILLINFO> billInfoList;
    }
    public class BILLINFO
    {
        public string id;
        public string billId;
        public string bunkGradeName;
        public string bunkCode;
        public int factPrice;
        public string passengerId;
        public string passengerType;
        public string passengerTypeName;
        public string passengerName;
        public string passengerCardType;
        public string passengerCard;
        public string passengerTel;
        public string ticketId;
        public string ticketState;
    }
    public class PAY
    {
        public string appId;
        public string timeStamp;
        public string nonceStr;
        public string package;
        public string signType;
        public string paySign;
    }
    public class TelResult
    {
        public List<TEL> tellist;
    }
    public class TEL
    {
        public string addr;
        public string phone;
    }
    public class TicketNum
    {
        public string unpaid;
        public string paid;
        public string refund;
    }
    public class PaymentResults
    {
        public string product;
        public string appId;
        public string timeStamp;
        public string nonceStr;
        public string package;
        public string paySign;
        public string billId;
    }

    public class SendPaymentMsg
    {
        public string orderId;
    }


    public class PaymentDataResults
    {
        public string openId;
        public string billid;
        public string billPrice;
        public string billValue;
        public string bookingTime;
        public string bookingState;
        public string prePayId;
        public string payNo;
        public string refundFee;
        public string refundTime;
    }
    #endregion
}
