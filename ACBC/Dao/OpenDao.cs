using ACBC.Buss;
using ACBC.Common;
using Com.ACBC.Framework.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ACBC.Dao
{
    public class OpenDao
    {
        public void writeLog(string posCode, string openId, string logType, string logTxt)
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.AppendFormat(OpenSqls.INSERT_LOG, posCode, openId, logType, logTxt);
            string sql1 = builder1.ToString();
            DatabaseOperationWeb.ExecuteDML(sql1);
        }
        public Member GetMember(string openID)
        {
            Member member = null;

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_MEMBER_BY_OPENID, openID);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count == 1)
            {
                member = new Member
                {
                    memberId = dt.Rows[0]["MEMBER_ID"].ToString(),
                    memberImg = dt.Rows[0]["MEMBER_IMG"].ToString(),
                    memberName = dt.Rows[0]["MEMBER_NAME"].ToString(),
                    memberPhone = dt.Rows[0]["MEMBER_PHONE"].ToString(),
                    memberSex = dt.Rows[0]["MEMBER_SEX"].ToString(),
                    openid = dt.Rows[0]["OPENID"].ToString(),
                    scanCode = "CHECK_" + dt.Rows[0]["SCAN_CODE"].ToString(),
                    status = dt.Rows[0]["STATUS"].ToString(),
                };
            }

            return member;
        }

        public bool MemberReg(MemberRegParam memberRegParam, string openID)
        {
            string scanCode = "";
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(openID));
                var strResult = BitConverter.ToString(result);
                scanCode = strResult.Replace("-", "");
            }

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.INSERT_MEMBER,
                memberRegParam.nickName,
                memberRegParam.avatarUrl,
                memberRegParam.gender,
                openID,
                scanCode);
            string sqlInsert = builder.ToString();

            return DatabaseOperationWeb.ExecuteDML(sqlInsert);
        }
        public Passenger getPassenger(string posCode, string openId, string passengerId)
        {
            Passenger passenger = null;

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_MEMBER_BY_POSCODE_OPENID_ID, posCode, openId, passengerId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count == 1)
            {
                passenger = new Passenger
                {
                    passengerId = dt.Rows[0]["passengerId"].ToString(),
                    passengerType = dt.Rows[0]["passengerType"].ToString(),
                    passengerName = dt.Rows[0]["passengerName"].ToString(),
                    passengerCard = dt.Rows[0]["passengerCard"].ToString(),
                    passengerCardType = dt.Rows[0]["passengerCardType"].ToString(),
                    passengerTel = dt.Rows[0]["passengerTel"].ToString(),
                };
            }

            return passenger;
        }

        public bool insertBillList(string posCode, string openId, string billId, string bookingState,
                                            string bookingName, string bookingPhone, string bookingCard,
                                            string beginTime, string endTime, string shipName, string beginPort,
                                            string endPort, int ticketNum, int billPrice,string planId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.INSERT_BILLLIST, posCode, openId, billId, bookingState, bookingName, bookingPhone,
                                    bookingCard, beginTime, endTime, shipName, beginPort, endPort, ticketNum, billPrice,planId);
            string sql = builder.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql);
        }

        public bool insertBillInfo(string billId, string passengerId, string passengerType, string passengerName,
                                           string passengerCardType, string passengerCard, string passengerTel,
                                           string bunkGradeName, string bunkCode, int factPrice, string ticketId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.INSERT_BILLINFO, billId, passengerId, passengerType, passengerName,
                                    passengerCardType, passengerCard, passengerTel, bunkGradeName, bunkCode, factPrice,ticketId);
            string sql = builder.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql);
        }

        public List<BILLLIST> getBillListByState(BookingListParam param, string openId)
        {
            List<BILLLIST> list = new List<BILLLIST>();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_POSCODE_STATE, Global.POSCODE, openId, param.bookingState);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    List<BILLINFO> billInfoList = new List<BILLINFO>();
                    StringBuilder builder1 = new StringBuilder();
                    builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID, dr["BILLID"].ToString());
                    string sql1 = builder1.ToString();
                    DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        BILLINFO billInfo = new BILLINFO
                        {
                            id = dr1["id"].ToString(),
                            billId = dr1["billId"].ToString(),
                            bunkGradeName = dr1["bunkGradeName"].ToString(),
                            bunkCode = dr1["bunkCode"].ToString(),
                            factPrice = Convert.ToInt16(dr1["factPrice"]),
                            passengerId = dr1["passengerId"].ToString(),
                            passengerType = dr1["passengerType"].ToString(),
                            passengerName = dr1["passengerName"].ToString(),
                            passengerCardType = dr1["passengerCardType"].ToString(),
                            passengerCard = dr1["passengerCard"].ToString(),
                            passengerTel = dr1["passengerTel"].ToString(),
                        };
                        billInfoList.Add(billInfo);
                    }

                    BILLLIST billList = new BILLLIST
                    {
                        id = dr["id"].ToString(),
                        openId = dr["openId"].ToString(),
                        billId = dr["billId"].ToString(),
                        beginTime = dr["beginTime"].ToString(),
                        endTime = dr["endTime"].ToString(),
                        shipName = dr["shipName"].ToString(),
                        beginPort = dr["beginPort"].ToString(),
                        endPort = dr["endPort"].ToString(),
                        ticketNum = Convert.ToInt16(dr["ticketNum"]),
                        billPrice = Convert.ToInt16(dr["billPrice"]),
                        bookingState = dr["bookingState"].ToString(),
                        bookingTime = dr["bookingTime"].ToString(),
                        bookingName = dr["bookingName"].ToString(),
                        bookingPhone = dr["bookingPhone"].ToString(),
                        bookingCard = dr["bookingCard"].ToString(),
                        prePayId = dr["prePayId"].ToString(),
                        prePayTime = dr["prePayTime"].ToString(),
                        billInfoList = billInfoList,
                    };
                    list.Add(billList);
                }
            }
            return list;
        }

        public BILLLIST getBillListById(string billId, string openId)
        {
            BILLLIST billList = new BILLLIST();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_BILLID, Global.POSCODE, openId, billId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                List<BILLINFO> billInfoList = new List<BILLINFO>();
                StringBuilder builder1 = new StringBuilder();
                builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID, dr["BILLID"].ToString());
                string sql1 = builder1.ToString();
                DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
                foreach (DataRow dr1 in dt1.Rows)
                {
                    string ptn = "普通票";
                    if (dr1["passengerType"].ToString() == "002")
                    {
                        ptn = "学生票";
                    }
                    else if (dr1["passengerType"].ToString() == "004")
                    {
                        ptn = "儿童票";
                    }
                    else if (dr1["passengerType"].ToString() == "005")
                    {
                        ptn = "军人票";
                    }
                    BILLINFO billInfo = new BILLINFO
                    {
                        id = dr1["id"].ToString(),
                        billId = dr1["billId"].ToString(),
                        bunkGradeName = dr1["bunkGradeName"].ToString(),
                        bunkCode = dr1["bunkCode"].ToString(),
                        factPrice = Convert.ToInt16(dr1["factPrice"]),
                        passengerId = dr1["passengerId"].ToString(),
                        passengerType = dr1["passengerType"].ToString(),
                        passengerName = dr1["passengerName"].ToString(),
                        passengerCardType = dr1["passengerCardType"].ToString(),
                        passengerCard = dr1["passengerCard"].ToString(),
                        passengerTel = dr1["passengerTel"].ToString(),
                        passengerTypeName = ptn,
                        ticketId = dr1["ticketId"].ToString(),
                        ticketState = dr1["ticketState"].ToString(),
                    };
                    billInfoList.Add(billInfo);
                }
                DateTime btime = Convert.ToDateTime(dr["beginTime"]);
                DateTime etime = Convert.ToDateTime(dr["endTime"]);
                TimeSpan ts = etime.Subtract(btime);
                int hours = ts.Hours;    //时
                int minutes = ts.Minutes;    //分
                string sailing = "";
                if (ts.Hours != 0)
                {
                    sailing = ts.Hours + "小时";
                }
                if (ts.Minutes != 0)
                {
                    sailing +=ts.Minutes + "分钟";
                }
                string state = "待支付";
                if (dr["bookingState"].ToString()=="2" || dr["bookingState"].ToString()=="4")
                {
                    state = "已支付";
                }else if (dr["bookingState"].ToString() == "3" || dr["bookingState"].ToString() == "5")
                {
                    state = "已退票";
                }
                billList = new BILLLIST
                {
                    id = dr["id"].ToString(),
                    openId = dr["openId"].ToString(),
                    billId = dr["billId"].ToString(),
                    beginDate = btime.ToString("yyyy-MM-dd"),
                    beginTime = btime.ToString("HH:mm"),
                    endDate = etime.ToString("yyyy-MM-dd"),
                    endTime = etime.ToString("HH:mm"),
                    sailing= sailing,
                    state = state,
                    shipName = dr["shipName"].ToString(),
                    beginPort = dr["beginPort"].ToString(),
                    endPort = dr["endPort"].ToString(),
                    ticketNum = Convert.ToInt16(dr["ticketNum"]),
                    billPrice = Convert.ToInt16(dr["billPrice"]),
                    bookingState = dr["bookingState"].ToString(),
                    bookingTime = dr["bookingTime"].ToString(),
                    bookingName = dr["bookingName"].ToString(),
                    bookingPhone = dr["bookingPhone"].ToString(),
                    bookingCard = dr["bookingCard"].ToString(),
                    prePayId = dr["prePayId"].ToString(),
                    prePayTime = dr["prePayTime"].ToString(),
                    billInfoList = billInfoList,
                };
            }
            return billList;
        }


        public BILLLIST getBillListByBillId(string billId )
        {
            BILLLIST billList = new BILLLIST();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_BILLID_NOOPENID,  billId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                List<BILLINFO> billInfoList = new List<BILLINFO>();
                StringBuilder builder1 = new StringBuilder();
                builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID, dr["BILLID"].ToString());
                string sql1 = builder1.ToString();
                DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
                foreach (DataRow dr1 in dt1.Rows)
                {
                    string ptn = "普通票";
                    if (dr1["passengerType"].ToString() == "002")
                    {
                        ptn = "学生票";
                    }
                    else if (dr1["passengerType"].ToString() == "004")
                    {
                        ptn = "儿童票";
                    }
                    else if (dr1["passengerType"].ToString() == "005")
                    {
                        ptn = "军人票";
                    }
                    BILLINFO billInfo = new BILLINFO
                    {
                        id = dr1["id"].ToString(),
                        billId = dr1["billId"].ToString(),
                        bunkGradeName = dr1["bunkGradeName"].ToString(),
                        bunkCode = dr1["bunkCode"].ToString(),
                        factPrice = Convert.ToInt16(dr1["factPrice"]),
                        passengerId = dr1["passengerId"].ToString(),
                        passengerType = dr1["passengerType"].ToString(),
                        passengerName = dr1["passengerName"].ToString(),
                        passengerCardType = dr1["passengerCardType"].ToString(),
                        passengerCard = dr1["passengerCard"].ToString(),
                        passengerTel = dr1["passengerTel"].ToString(),
                        passengerTypeName = ptn,
                        ticketId = dr1["ticketId"].ToString(),
                        ticketState = dr1["ticketState"].ToString(),
                    };
                    billInfoList.Add(billInfo);
                }
                DateTime btime = Convert.ToDateTime(dr["beginTime"]);
                DateTime etime = Convert.ToDateTime(dr["endTime"]);
                string state = "待支付";
                if (dr["bookingState"].ToString() == "2" || dr["bookingState"].ToString() == "4")
                {
                    state = "已支付";
                }
                else if (dr["bookingState"].ToString() == "3" || dr["bookingState"].ToString() == "5")
                {
                    state = "已退票";
                }
                billList = new BILLLIST
                {
                    id = dr["id"].ToString(),
                    openId = dr["openId"].ToString(),
                    billId = dr["billId"].ToString(),
                    beginDate = btime.ToString("yyyy-MM-dd"),
                    beginTime = btime.ToString("HH:mm"),
                    endDate = etime.ToString("yyyy-MM-dd"),
                    endTime = etime.ToString("HH:mm"),
                    state = state,
                    shipName = dr["shipName"].ToString(),
                    beginPort = dr["beginPort"].ToString(),
                    endPort = dr["endPort"].ToString(),
                    ticketNum = Convert.ToInt16(dr["ticketNum"]),
                    billPrice = Convert.ToInt16(dr["billPrice"]),
                    bookingState = dr["bookingState"].ToString(),
                    bookingTime = dr["bookingTime"].ToString(),
                    bookingName = dr["bookingName"].ToString(),
                    bookingPhone = dr["bookingPhone"].ToString(),
                    bookingCard = dr["bookingCard"].ToString(),
                    prePayId = dr["prePayId"].ToString(),
                    prePayTime = dr["prePayTime"].ToString(),
                    billInfoList = billInfoList,
                };
            }
            return billList;
        }
        public BookingBillList getBillList(string posCode, string openId)
        {
            BookingBillList bookingBillList = new BookingBillList();
            List<BILLLIST> unpaid = new List<BILLLIST>();
            StringBuilder builderU = new StringBuilder();
            builderU.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_POSCODE_STATE_NOPAID, posCode, openId);
            string sqlU = builderU.ToString();
            DataTable dtU = DatabaseOperationWeb.ExecuteSelectDS(sqlU, "T").Tables[0];
            if (dtU != null)
            {
                foreach (DataRow dr in dtU.Rows)
                {
                    List<BILLINFO> billInfoList = new List<BILLINFO>();
                    StringBuilder builder1 = new StringBuilder();
                    builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID, dr["BILLID"].ToString());
                    string sql1 = builder1.ToString();
                    DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        string ptn = "普通票";
                        if (dr1["passengerType"].ToString() == "002")
                        {
                            ptn = "学生票";
                        }
                        else if (dr1["passengerType"].ToString() == "004")
                        {
                            ptn = "儿童票";
                        }
                        else if (dr1["passengerType"].ToString() == "005")
                        {
                            ptn = "军人票";
                        }
                        BILLINFO billInfo = new BILLINFO
                        {
                            id = dr1["id"].ToString(),
                            billId = dr1["billId"].ToString(),
                            bunkGradeName = dr1["bunkGradeName"].ToString(),
                            bunkCode = dr1["bunkCode"].ToString(),
                            factPrice = Convert.ToInt16(dr1["factPrice"]),
                            passengerId = dr1["passengerId"].ToString(),
                            passengerType = dr1["passengerType"].ToString(),
                            passengerName = dr1["passengerName"].ToString(),
                            passengerCardType = dr1["passengerCardType"].ToString(),
                            passengerCard = dr1["passengerCard"].ToString(),
                            passengerTel = dr1["passengerTel"].ToString(),
                            passengerTypeName = ptn,
                            ticketId = dr1["ticketId"].ToString(),
                            ticketState = dr1["ticketState"].ToString(),
                        };
                        billInfoList.Add(billInfo);
                    }
                    DateTime btime = Convert.ToDateTime(dr["beginTime"]);
                    DateTime etime = Convert.ToDateTime(dr["endTime"]);
                    BILLLIST billList = new BILLLIST
                    {
                        id = dr["id"].ToString(),
                        openId = dr["openId"].ToString(),
                        billId = dr["billId"].ToString(),
                        beginDate = btime.ToString("yyyy-MM-dd"),
                        beginTime = btime.ToString("HH:mm"),
                        endDate = etime.ToString("yyyy-MM-dd"),
                        endTime = etime.ToString("HH:mm"),
                        state = "待支付",
                        shipName = dr["shipName"].ToString(),
                        beginPort = dr["beginPort"].ToString(),
                        endPort = dr["endPort"].ToString(),
                        ticketNum = Convert.ToInt16(dr["ticketNum"]),
                        billPrice = Convert.ToInt16(dr["billPrice"]),
                        bookingState = dr["bookingState"].ToString(),
                        bookingTime = dr["bookingTime"].ToString(),
                        bookingName = dr["bookingName"].ToString(),
                        bookingPhone = dr["bookingPhone"].ToString(),
                        bookingCard = dr["bookingCard"].ToString(),
                        billInfoList = billInfoList,
                    };
                    unpaid.Add(billList);
                }
            }
            bookingBillList.unpaid = unpaid;


            List<BILLLIST> paid = new List<BILLLIST>();
            StringBuilder builderP = new StringBuilder();
            builderP.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_POSCODE_STATE_PAID, posCode, openId);
            string sqlP = builderP.ToString();
            DataTable dtP = DatabaseOperationWeb.ExecuteSelectDS(sqlP, "T").Tables[0];
            if (dtP != null)
            {
                foreach (DataRow dr in dtP.Rows)
                {
                    List<BILLINFO> billInfoList = new List<BILLINFO>();
                    StringBuilder builder1 = new StringBuilder();
                    builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID, dr["BILLID"].ToString());
                    string sql1 = builder1.ToString();
                    DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        string ptn = "普通票";
                        if (dr1["passengerType"].ToString() == "002")
                        {
                            ptn = "学生票";
                        }
                        else if (dr1["passengerType"].ToString() == "004")
                        {
                            ptn = "儿童票";
                        }
                        else if (dr1["passengerType"].ToString() == "005")
                        {
                            ptn = "军人票";
                        }
                        BILLINFO billInfo = new BILLINFO
                        {
                            id = dr1["id"].ToString(),
                            billId = dr1["billId"].ToString(),
                            bunkGradeName = dr1["bunkGradeName"].ToString(),
                            bunkCode = dr1["bunkCode"].ToString(),
                            factPrice = Convert.ToInt16(dr1["factPrice"]),
                            passengerId = dr1["passengerId"].ToString(),
                            passengerType = dr1["passengerType"].ToString(),
                            passengerName = dr1["passengerName"].ToString(),
                            passengerCardType = dr1["passengerCardType"].ToString(),
                            passengerCard = dr1["passengerCard"].ToString(),
                            passengerTel = dr1["passengerTel"].ToString(),
                            passengerTypeName = ptn,
                            ticketId = dr1["ticketId"].ToString(),
                            ticketState = dr1["ticketState"].ToString(),
                        };
                        billInfoList.Add(billInfo);
                    }

                    DateTime btime = Convert.ToDateTime(dr["beginTime"]);
                    DateTime etime = Convert.ToDateTime(dr["endTime"]);
                    BILLLIST billList = new BILLLIST
                    {
                        id = dr["id"].ToString(),
                        openId = dr["openId"].ToString(),
                        billId = dr["billId"].ToString(),
                        beginDate = btime.ToString("yyyy-MM-dd"),
                        beginTime = btime.ToString("HH:mm"),
                        endDate = etime.ToString("yyyy-MM-dd"),
                        endTime = etime.ToString("HH:mm"),
                        state = "已支付",
                        shipName = dr["shipName"].ToString(),
                        beginPort = dr["beginPort"].ToString(),
                        endPort = dr["endPort"].ToString(),
                        ticketNum = Convert.ToInt16(dr["ticketNum"]),
                        billPrice = Convert.ToInt16(dr["billPrice"]),
                        bookingState = dr["bookingState"].ToString(),
                        bookingTime = dr["bookingTime"].ToString(),
                        bookingName = dr["bookingName"].ToString(),
                        bookingPhone = dr["bookingPhone"].ToString(),
                        bookingCard = dr["bookingCard"].ToString(),
                        billInfoList = billInfoList,
                    };
                    paid.Add(billList);
                }
            }
            bookingBillList.paid = paid;


            List<BILLLIST> refund = new List<BILLLIST>();
            StringBuilder builderR = new StringBuilder();
            builderR.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_POSCODE_STATE_REFUND, posCode, openId);
            string sqlR = builderR.ToString();
            DataTable dtR = DatabaseOperationWeb.ExecuteSelectDS(sqlR, "T").Tables[0];
            if (dtR != null)
            {
                foreach (DataRow dr in dtR.Rows)
                {
                    List<BILLINFO> billInfoList = new List<BILLINFO>();
                    StringBuilder builder1 = new StringBuilder();
                    builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID, dr["BILLID"].ToString());
                    string sql1 = builder1.ToString();
                    DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        string ptn = "普通票";
                        if (dr1["passengerType"].ToString() == "002")
                        {
                            ptn = "学生票";
                        }
                        else if (dr1["passengerType"].ToString() == "004")
                        {
                            ptn = "儿童票";
                        }
                        else if (dr1["passengerType"].ToString() == "005")
                        {
                            ptn = "军人票";
                        }
                        BILLINFO billInfo = new BILLINFO
                        {
                            id = dr1["id"].ToString(),
                            billId = dr1["billId"].ToString(),
                            bunkGradeName = dr1["bunkGradeName"].ToString(),
                            bunkCode = dr1["bunkCode"].ToString(),
                            factPrice = Convert.ToInt16(dr1["factPrice"]),
                            passengerId = dr1["passengerId"].ToString(),
                            passengerType = dr1["passengerType"].ToString(),
                            passengerName = dr1["passengerName"].ToString(),
                            passengerCardType = dr1["passengerCardType"].ToString(),
                            passengerCard = dr1["passengerCard"].ToString(),
                            passengerTel = dr1["passengerTel"].ToString(),
                            passengerTypeName = ptn,
                            ticketId = dr1["ticketId"].ToString(),
                            ticketState = dr1["ticketState"].ToString(),
                        };
                        billInfoList.Add(billInfo);
                    }

                    DateTime btime = Convert.ToDateTime(dr["beginTime"]);
                    DateTime etime = Convert.ToDateTime(dr["endTime"]);
                    BILLLIST billList = new BILLLIST
                    {
                        id = dr["id"].ToString(),
                        openId = dr["openId"].ToString(),
                        billId = dr["billId"].ToString(),
                        beginDate = btime.ToString("yyyy-MM-dd"),
                        beginTime = btime.ToString("HH:mm"),
                        endDate = etime.ToString("yyyy-MM-dd"),
                        endTime = etime.ToString("HH:mm"),
                        state = "已退票",
                        shipName = dr["shipName"].ToString(),
                        beginPort = dr["beginPort"].ToString(),
                        endPort = dr["endPort"].ToString(),
                        ticketNum = Convert.ToInt16(dr["ticketNum"]),
                        billPrice = Convert.ToInt16(dr["billPrice"]),
                        bookingState = dr["bookingState"].ToString(),
                        bookingTime = dr["bookingTime"].ToString(),
                        bookingName = dr["bookingName"].ToString(),
                        bookingPhone = dr["bookingPhone"].ToString(),
                        bookingCard = dr["bookingCard"].ToString(),
                        billInfoList = billInfoList,
                    };
                    refund.Add(billList);
                }
            }
            bookingBillList.refund = refund;


            return bookingBillList;
        }

        public TicketNum getTicketNum(string posCode, string openId)
        {
            TicketNum ticketNum = null;

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_TICKETNUM_BY_POSCODE_AND_OPENID, posCode, openId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count == 1)
            {
                ticketNum = new TicketNum
                {
                    unpaid = dt.Rows[0]["unpaid"].ToString(),
                    paid = dt.Rows[0]["paid"].ToString(),
                    refund = dt.Rows[0]["refund"].ToString(),
                };
            }

            return ticketNum;
        }

        public BILLINFO getBillInfoById(string billId,string id)
        {
            BILLINFO billInfo = null;
            StringBuilder builder1 = new StringBuilder();
            builder1.AppendFormat(OpenSqls.SELECT_BILLINFO_BY_BILLID_AND_ID, billId,id);
            string sql1 = builder1.ToString();
            DataTable dt1 = DatabaseOperationWeb.ExecuteSelectDS(sql1, "T").Tables[0];
            if (dt1.Rows.Count>0)
            {
                DataRow dr1 = dt1.Rows[0];
                string ptn = "普通票";
                if (dr1["passengerType"].ToString() == "002")
                {
                    ptn = "学生票";
                }
                else if (dr1["passengerType"].ToString() == "004")
                {
                    ptn = "儿童票";
                }
                else if (dr1["passengerType"].ToString() == "005")
                {
                    ptn = "军人票";
                }
                billInfo = new BILLINFO
                {
                    id = dr1["id"].ToString(),
                    billId = dr1["billId"].ToString(),
                    bunkGradeName = dr1["bunkGradeName"].ToString(),
                    bunkCode = dr1["bunkCode"].ToString(),
                    factPrice = Convert.ToInt16(dr1["factPrice"]),
                    passengerId = dr1["passengerId"].ToString(),
                    passengerType = dr1["passengerType"].ToString(),
                    passengerName = dr1["passengerName"].ToString(),
                    passengerCardType = dr1["passengerCardType"].ToString(),
                    passengerCard = dr1["passengerCard"].ToString(),
                    passengerTel = dr1["passengerTel"].ToString(),
                    passengerTypeName = ptn,
                    ticketId = dr1["ticketId"].ToString(),
                    ticketState = dr1["ticketState"].ToString(),
                };
            }

            return billInfo;
        }

        public bool returnBooking(string billId, string openId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.RETURN_BILLLIST, billId, openId, "4");
            string sql = builder.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql);
        }
        public bool returnTicket(string billId, string openId, string id)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.RETURN_BILLINFO, billId, id, "4");
            string sql = builder.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql);
        }

        public bool returnBill(string billId, string openId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.RETURN_BILLLIST, billId, openId, "3");
            string sql = builder.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql);
        }

        public bool checkBillInfo(string billId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.CHECK_BILLINFO_BY_BILLID_AND_STATE, billId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkOnePlan(string openId,string planId,string passengerId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.SELECT_BILLLIST_BY_OPENID_AND_PLANID, openId,planId, passengerId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateBookingStatusBy10Minute(string openId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(OpenSqls.UPDATE_BOOKINGSTATUS_TO_THREE_BY_10MINUTE, openId);
            string sql = builder.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql);
        }


        public class OpenSqls
        {
            public const string INSERT_LOG = ""
                + "INSERT INTO T_BASE_LOG "
                + "(LOGTIME,POSCODE,OPENID,LOGTYPE,LOGTXT)"
                + "VALUES( "
                + "NOW(),'{0}','{1}','{2}','{3}')";
            public const string SELECT_MEMBER_BY_OPENID = ""
               + "SELECT * "
               + "FROM T_BASE_MEMBER "
               + "WHERE OPENID = '{0}'";
            public const string INSERT_MEMBER = ""
                + "INSERT INTO T_BASE_MEMBER "
                + "(MEMBER_NAME,MEMBER_IMG,MEMBER_SEX,OPENID,SCAN_CODE)"
                + "VALUES( "
                + "'{0}','{1}','{2}','{3}','{4}')";
            public const string SELECT_MEMBER_BY_POSCODE_OPENID_ID = ""
               + "SELECT * "
               + "FROM T_PASSENGER_LIST "
               + "WHERE POSCODE='{0}' AND OPENID = '{1}'  AND PASSENGERID = '{2}' ";
            public const string INSERT_BILLLIST = ""
                + "INSERT INTO T_BILL_LIST "
                + "(POSCODE,OPENID,BILLID,BOOKINGSTATE,BOOKINGTIME,BOOKINGNAME,BOOKINGPHONE,BOOKINGCARD," +
                "BEGINTIME,ENDTIME,SHIPNAME,BEGINPORT,ENDPORT,TICKETNUM,BILLPRICE,PLANID)"
                + "VALUES( "
                + "'{0}','{1}','{2}','{3}',now(),'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')";
            public const string INSERT_BILLINFO = ""
                + "INSERT INTO T_BILL_INFO "
                + "(BILLID,PASSENGERID,PASSENGERTYPE,PASSENGERNAME,PASSENGERCARDTYPE,PASSENGERCARD,PASSENGERTEL,BUNKGRADENAME,BUNKCODE,FACTPRICE,TICKETID,TICKETSTATE)"
                + "VALUES( "
                + "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},'{10}','1')";

            public const string SELECT_BILLLIST_BY_POSCODE_STATE = ""
               + "SELECT * "
               + "FROM T_BILL_LIST "
               + "WHERE POSCODE='{0}' AND OPENID = '{1}'  AND BOOKINGSTATE = '{2}'  "
               + "ORDER BY ID DESC ";
            public const string SELECT_BILLLIST_BY_BILLID = ""
               + "SELECT * "
               + "FROM T_BILL_LIST "
               + "WHERE POSCODE='{0}' AND OPENID = '{1}'  AND BILLID = '{2}' ";
            public const string SELECT_BILLLIST_BY_BILLID_NOOPENID = ""
               + "SELECT * "
               + "FROM T_BILL_LIST "
               + "WHERE  BILLID = '{0}' "
               + "ORDER BY ID DESC ";
            public const string SELECT_BILLINFO_BY_BILLID = ""
               + "SELECT * "
               + "FROM T_BILL_INFO "
               + "WHERE  BILLID='{0}'   ";
            public const string SELECT_BILLINFO_BY_BILLID_AND_ID = ""
               + "SELECT * "
               + "FROM T_BILL_INFO "
               + "WHERE  BILLID='{0}' AND ID='{1}'   ";

            public const string SELECT_BILLLIST_BY_POSCODE_STATE_NOPAID = ""
               + "SELECT * "
               + "FROM T_BILL_LIST "
               + "WHERE POSCODE='{0}' AND OPENID = '{1}' AND  (BOOKINGSTATE='1' OR BOOKINGSTATE='0')   "
               + "ORDER BY ID DESC ";

            public const string SELECT_BILLLIST_BY_POSCODE_STATE_PAID = ""
               + "SELECT * "
               + "FROM T_BILL_LIST "
               + "WHERE POSCODE='{0}' AND OPENID = '{1}'  AND (BOOKINGSTATE='2' OR BOOKINGSTATE='4')  "
               + "ORDER BY ID DESC ";

            public const string SELECT_BILLLIST_BY_POSCODE_STATE_REFUND = ""
               + "SELECT * "
               + "FROM T_BILL_LIST "
               + "WHERE POSCODE='{0}' AND OPENID = '{1}'  AND (BOOKINGSTATE = '3'  OR BOOKINGSTATE = '5')  "
               + "ORDER BY ID DESC ";


            public const string SELECT_TICKETNUM_BY_POSCODE_AND_OPENID = "SELECT" +
                " (SELECT COUNT(*) FROM T_BILL_LIST WHERE POSCODE = '{0}' AND  OPENID = '{1}' AND (BOOKINGSTATE='1' OR BOOKINGSTATE='0') ) AS UNPAID," +
                "(SELECT COUNT(*) FROM T_BILL_LIST WHERE POSCODE = '{0}' AND  OPENID = '{1}' AND (BOOKINGSTATE='2' OR BOOKINGSTATE='4')) AS PAID," +
                "(SELECT COUNT(*) FROM T_BILL_LIST WHERE POSCODE = '{0}' AND  OPENID = '{1}' AND (BOOKINGSTATE = '3'  OR BOOKINGSTATE = '5') ) AS REFUND";

            public const string RETURN_BILLLIST = ""
                + " UPDATE T_BILL_LIST SET BOOKINGSTATE='{2}' WHERE BILLID= '{0}' AND  OPENID = '{1}' ";
            public const string RETURN_BILLINFO = ""
                + " UPDATE T_BILL_INFO SET TICKETSTATE='{2}' WHERE BILLID= '{0}'  AND ID={1} ";

            public const string CHECK_BILLINFO_BY_BILLID_AND_STATE = ""
               + "SELECT * "
               + "FROM T_BILL_INFO "
               + "WHERE  BILLID='{0}' AND TICKETSTATE='2'  ";
            public const string SELECT_BILLLIST_BY_OPENID_AND_PLANID =
                "SELECT * " +
                "FROM T_BILL_LIST L,T_BILL_INFO I " +
                "WHERE L.BILLID = I.BILLID " +
                    "AND L.OPENID = '{0}' " +
                    "AND L.PLANID = '{1}' " +
                    "AND L.BOOKINGSTATE IN ('1','2','4') " +
                    "AND I.PASSENGERID = '{2}'";
            public const string UPDATE_BOOKINGSTATUS_TO_THREE_BY_10MINUTE = "" +
                "UPDATE T_BILL_LIST " +
                   "SET BOOKINGSTATE ='3' " +
                 "WHERE OPENID = '{0}' " +
                   "AND BOOKINGSTATE = '1' " +
                   "AND BOOKINGTIME< DATE_ADD(NOW(), INTERVAL - 10 MINUTE)";
        }
    }
}
