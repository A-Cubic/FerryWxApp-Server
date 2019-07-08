using ACBC.Common;
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
    public class UserBuss : IBuss
    {
        public ApiType GetApiType()
        {
            return ApiType.UserApi;
        }

        /// <summary>
        /// 获取乘客列表
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_GetPassenger(BaseApi baseApi)
        {
            //PassengerParam passengerParam = JsonConvert.DeserializeObject<PassengerParam>(baseApi.param.ToString());
            //if (passengerParam == null)
            //{
            //    throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            //}
            //if (passengerParam.posCode == null || passengerParam.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            UserDao userDao = new UserDao();
            string openId = Utils.GetOpenID(baseApi.token);

            return userDao.getPassenger(Global.POSCODE,openId);
        }

        /// <summary>
        /// 新增乘客
        /// </summary>
        /// <param name="baseApi"></param>
        /// <returns></returns>
        public object Do_AddPassenger(BaseApi baseApi)
        {
            AddPassengerParam addPassengerParam = JsonConvert.DeserializeObject<AddPassengerParam>(baseApi.param.ToString());
            if (addPassengerParam == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            //if (addPassengerParam.posCode == null || addPassengerParam.posCode == "")
            //{
            //    throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            //}
            string openId = Utils.GetOpenID(baseApi.token);
            UserDao userDao = new UserDao();
            if (addPassengerParam.passengerCardType == "1")
            {
                if (!userDao.CheckIDCard(addPassengerParam.passengerCard))
                {
                    throw new ApiException(CodeMessage.IDCardError, "IDCardError");
                }
            }
            if (userDao.seletePassenger(Global.POSCODE, openId, addPassengerParam.passengerCard)!=null)
            {
                throw new ApiException(CodeMessage.IdenticalPassengerError, "IdenticalPassengerError");
            }
            if(userDao.addPassenger(addPassengerParam, Global.POSCODE,openId))
            {
                return userDao.getPassenger(Global.POSCODE,openId);
            }
            else
            {
                throw new ApiException(CodeMessage.AddPassengerError, "AddPassengerError");
            }
        }
        /// <summary>
         /// 删除乘客
         /// </summary>
         /// <param name="baseApi"></param>
         /// <returns></returns>
        public object Do_DelPassenger(BaseApi baseApi)
        {
            DelPassengerParam delPassengerParam = JsonConvert.DeserializeObject<DelPassengerParam>(baseApi.param.ToString());
            if (delPassengerParam == null)
            {
                throw new ApiException(CodeMessage.InvalidParam, "InvalidParam");
            }
            if (delPassengerParam.passengerId == null || delPassengerParam.passengerId == "")
            {
                throw new ApiException(CodeMessage.InterfaceValueError, "InterfaceValueError");
            }
            string openId = Utils.GetOpenID(baseApi.token);
            UserDao userDao = new UserDao();
            if (userDao.delPassenger(delPassengerParam.passengerId, openId))
            {
                return userDao.getPassenger(Global.POSCODE, openId);
            }
            else
            {
                throw new ApiException(CodeMessage.DelPassengerError, "DelPassengerError");
            }
        }
    }
}
