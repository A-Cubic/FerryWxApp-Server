using ACBC.Buss;
using Com.ACBC.Framework.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACBC.Dao
{
    public class PaymentDao
    {
        /// <summary>
        /// 写入prepayid
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="prePayId"></param>
        /// <returns></returns>
        public bool writePrePayId(string billId, string prePayId)
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.AppendFormat(PaymentSqls.UPDATE_BILLLIST_FOR_PAYID, prePayId, billId);
            string sql1 = builder1.ToString();

            return DatabaseOperationWeb.ExecuteDML(sql1);
        }
        /// <summary>
        /// 获取prepayid
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="prePayId"></param>
        /// <returns></returns>
        public PaymentDataResults getPayData(string billId)
        {
            PaymentDataResults paymentDataResults = null;
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(PaymentSqls.SELECT_PREPAYID_BY_BILLID, billId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt.Rows.Count > 0)
            {
                string state = "待支付";
                if (dt.Rows[0]["bookingState"].ToString() == "2" || dt.Rows[0]["bookingState"].ToString() == "4")
                {
                    state = "已支付";
                }
                else if (dt.Rows[0]["bookingState"].ToString() == "3" || dt.Rows[0]["bookingState"].ToString() == "5")
                {
                    state = "已退票";
                }
                paymentDataResults = new PaymentDataResults
                {
                    openId = dt.Rows[0]["openId"].ToString(),
                    billid = dt.Rows[0]["billId"].ToString(),
                    billPrice = dt.Rows[0]["billPrice"].ToString(),
                    billValue = dt.Rows[0]["beginTime"].ToString()+" "+ dt.Rows[0]["beginPort"].ToString()+"-"+dt.Rows[0]["endPort"].ToString()+" "+ dt.Rows[0]["shipName"].ToString(),
                    bookingTime = dt.Rows[0]["bookingTime"].ToString(),
                    bookingState = state,
                    prePayId = dt.Rows[0]["prePayId"].ToString(),
                    payNo = dt.Rows[0]["payNo"].ToString(),
                    refundFee = dt.Rows[0]["refundFee"].ToString(),
                    refundTime = dt.Rows[0]["refundTime"].ToString(),
                    formId = dt.Rows[0]["formId"].ToString(),
                };
            }
            return paymentDataResults;
        }



        /// <summary>
        /// 修改支付状态
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payNo"></param>
        public bool updateOrderForPay(string billId, string payNo)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(PaymentSqls.SELECT_PREPAYID_BY_BILLID, billId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt.Rows.Count > 0)
            {
                StringBuilder builder1 = new StringBuilder();
                builder1.AppendFormat(PaymentSqls.UPDATE_PAYINFO_BY_BILLLIST, payNo, billId);
                string sql1 = builder1.ToString();

                if (DatabaseOperationWeb.ExecuteDML(sql1))
                {
                    StringBuilder builder2 = new StringBuilder();
                    builder2.AppendFormat(PaymentSqls.UPDATE_PAYINFO_BY_BILLINFO, billId);
                    string sql2 = builder2.ToString();
                    return DatabaseOperationWeb.ExecuteDML(sql2);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 保存支付日志
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payNo"></param>
        /// <param name="totalPrice"></param>
        /// <param name="openid"></param>
        /// <param name="status"></param>
        public void insertPayLog(string orderId, string payNo, string totalPrice, string openid, string status)
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.AppendFormat(PaymentSqls.INSERT_PAYLOG, orderId, payNo, totalPrice, openid, status);
            string sql1 = builder1.ToString();

            DatabaseOperationWeb.ExecuteDML(sql1);
        }




        public class PaymentSqls
        {
            public const string UPDATE_BILLLIST_FOR_PAYID = "UPDATE T_BILL_LIST SET PREPAYID='{0}',prePayTime = now() WHERE BILLID = '{1}' ";
            public const string SELECT_PREPAYID_BY_BILLID = "SELECT * FROM T_BILL_LIST  WHERE BILLID = '{0}'   ";
            public const string UPDATE_PAYINFO_BY_BILLLIST = "UPDATE T_BILL_LIST SET PAYNO='{0}',PAYTYPE='微信支付'," +
                                                 "PAYTIME=NOW(),BOOKINGSTATE ='2' " +
                                                 "WHERE BILLID = '{1}' ";
            public const string UPDATE_PAYINFO_BY_BILLINFO = "UPDATE T_BILL_INFO SET TICKETSTATE ='2' " +
                                                 "WHERE BILLID = '{0}' ";
            public const string INSERT_PAYLOG = "INSERT INTO T_LOG_PAY(ORDERID,PAYTYPE,PAYNO,TOTALPRICE,OPENID,CREATETIME,STATUS) " +
                "VALUES('{0}','微信支付','{1}',{2},'{3}',NOW(),'{4}')";

        }
    }
}
