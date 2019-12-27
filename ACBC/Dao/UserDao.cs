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
    public class UserDao
    {
        public string getLastPhone(string posCode,string openId)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_LASTPHONE_BY_POSCODE_AND_OPENID, posCode, openId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                if (dt.Rows.Count>0)
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            return "";
        }

        public BannerList getBanner(string posCode)
        {
            BannerList bannerList = new BannerList();
            List<Banner> list = new List<Banner>();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_BANNER_BY_POSCODE, posCode, "BANNER");
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Banner banner = new Banner
                    {
                        sort = dr["sort"].ToString(),
                        advname = dr["advname"].ToString(),
                        advtime = dr["advtime"].ToString(),
                        advurl = dr["advurl"].ToString(),
                        imgurl = dr["imgurl"].ToString(),
                        remark = dr["remark"].ToString()
                    };
                    list.Add(banner);
                }
            }
            bannerList.lb = list;
            return bannerList;
        }
        public List<Banner> getNews(string posCode)
        {
            List<Banner> list = new List<Banner>();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_BANNER_BY_POSCODE, posCode, "NEWS");
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Banner banner = new Banner
                    {
                        sort = dr["sort"].ToString(),
                        advname = dr["advname"].ToString(),
                        advtime = dr["advtime"].ToString(),
                        advurl = dr["advurl"].ToString(),
                        imgurl = dr["imgurl"].ToString(),
                        remark = dr["remark"].ToString()
                    };
                    list.Add(banner);
                }
            }
            return list;
        }
        public List<Banner> getNotify(string posCode)
        {
            List<Banner> list = new List<Banner>();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_BANNER_BY_POSCODE, posCode, "NOTIFY");
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Banner banner = new Banner
                    {
                        sort = dr["sort"].ToString(),
                        advname = dr["advname"].ToString(),
                        advtime = dr["advtime"].ToString(),
                        advurl = dr["advurl"].ToString(),
                        imgurl = dr["imgurl"].ToString(),
                        remark = dr["remark"].ToString()
                    };
                    list.Add(banner);
                }
            }
            return list;
        }

        public List<Passenger> getPassenger(string posCode,string openId)
        {
            List<Passenger> list = new List<Passenger>();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_PASSENGER_BY_POSCODE_AND_OPENID, posCode, openId);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string ptn = "普通票";
                    if (dr["passengerType"].ToString()=="002")
                    {
                        ptn = "学生票";
                    }
                    else if (dr["passengerType"].ToString() == "004")
                    {
                        ptn = "儿童票";
                    }
                    else if (dr["passengerType"].ToString() == "005")
                    {
                        ptn = "军人票";
                    }
                    Passenger passenger = new Passenger
                    {
                        passengerId = dr["passengerId"].ToString(),
                        passengerType = dr["passengerType"].ToString(),
                        passengerTypeName = ptn,
                        passengerName = dr["passengerName"].ToString(),
                        passengerCard = dr["passengerCard"].ToString(),
                        passengerCardType = dr["passengerCardType"].ToString(),
                        passengerTel = dr["passengerTel"].ToString()
                    };
                    list.Add(passenger);
                }
            }
            return list;
        }
        public Passenger seletePassenger(string posCode, string openId, string passengerCard)
        {
            Passenger passenger = null;
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_PASSENGER_BY_POSCODE_AND_OPENID_AND_CARD, posCode, openId, passengerCard);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt.Rows.Count > 0)
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
        public bool addPassenger(AddPassengerParam addPassengerParam,string posCode,string openId)
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.AppendFormat(ShipSqls.INSERT_PASSENGER, posCode, openId,
                                 addPassengerParam.passengerType, addPassengerParam.passengerName,
                                 addPassengerParam.passengerCardType, addPassengerParam.passengerCard,
                                 addPassengerParam.passengerTel);
            string sql1 = builder1.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql1);
        }
        public bool delPassenger( string passengerId, string openId)
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.AppendFormat(ShipSqls.DELETE_PASSENGER, openId, passengerId);
            string sql1 = builder1.ToString();
            return DatabaseOperationWeb.ExecuteDML(sql1);
        }
        public TelResult getTel(string posCode)
        {
            TelResult telResult = new TelResult();
            List<TEL> list = new List<TEL>();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(ShipSqls.SELECT_TEL_BY_POSCODE, posCode);
            string sql = builder.ToString();
            DataTable dt = DatabaseOperationWeb.ExecuteSelectDS(sql, "T").Tables[0];
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TEL tel = new TEL
                    {
                        addr = dr["addr"].ToString(),
                        phone = dr["phone"].ToString(),
                    };
                    list.Add(tel);
                }
            }
            telResult.tellist = list;
            return telResult;
        }

        public class ShipSqls
        {
            public const string SELECT_LASTPHONE_BY_POSCODE_AND_OPENID = "" +
                "SELECT BOOKINGPHONE " +
                "FROM T_BILL_LIST " +
                "WHERE POSCODE = '{0}' " +
                "AND OPENID = '{1}' " +
                "AND BOOKINGPHONE<>'' " +
                "ORDER BY ID DESC LIMIT 1";
            public const string INSERT_TEST = "insert into test(val) values('{0}') ";
            public const string SELECT_BANNER_BY_POSCODE = "SELECT * FROM T_ADV_LIST WHERE FLAG='1' AND POSCODE = '{0}' AND ADVTYPE ='{1}' ORDER BY ID DESC ";
            public const string SELECT_PASSENGER_BY_POSCODE_AND_OPENID = "SELECT * FROM T_PASSENGER_LIST " +
                                        "WHERE FLAG='1' AND POSCODE = '{0}' AND OPENID = '{1}'";
            public const string INSERT_PASSENGER = "INSERT INTO T_PASSENGER_LIST(POSCODE,OPENID,PASSENGERTYPE,PASSENGERNAME," +
                                        "PASSENGERCARDTYPE,PASSENGERCARD,PASSENGERTEL) " +
                                        "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            public const string DELETE_PASSENGER = "DELETE FROM T_PASSENGER_LIST " +
                                        "WHERE  OPENID = '{0}' AND PASSENGERID = '{1}'";
            public const string SELECT_PASSENGER_BY_POSCODE_AND_OPENID_AND_CARD = "SELECT * FROM T_PASSENGER_LIST " +
                                        "WHERE FLAG='1' AND POSCODE = '{0}' AND OPENID = '{1}' AND PASSENGERCARD = '{2}'";
            public const string SELECT_TEL_BY_POSCODE = "SELECT * FROM T_BASE_TEL " +
                                        "WHERE POSCODE = '{0}'";
        }



        #region 验证身份证
        public bool CheckIDCard(string Id)
        {
            if (Id.Length == 18)
            {
                bool check = CheckIDCard18(Id);
                return check;
            }
            else if (Id.Length == 15)
            {
                bool check = CheckIDCard15(Id);
                return check;
            }
            else
            {
                return false;
            }
        }

        public  bool CheckIDCard18(string Id)
        {
            long n = 0;
            if (long.TryParse(Id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }

            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }

            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = Id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }
            return true;//符合GB11643-1999标准
        }

        public  int DivRem(int a, int b, out int result)
        {
            result = a % b;
            return (a / b);
        }

        public  bool CheckIDCard15(string Id)
        {
            long n = 0;
            if (long.TryParse(Id, out n) == false || n < Math.Pow(10, 14))
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            return true;//符合15位身份证标准
        }

        #endregion
    }
}
