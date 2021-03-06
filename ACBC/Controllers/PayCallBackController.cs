﻿using ACBC.Buss;
using ACBC.Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senparc.Weixin.MP.TenPayLibV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACBC.Controllers
{
    [Produces("text/xml")]
    [Consumes("multipart/form-data", "text/xml")]
    [Route(Global.ROUTE_PX + "/[controller]/[action]")]
    [EnableCors("AllowSameDomain")]
    public class PayCallBackController : Controller
    {

        /// <summary>
        /// 支付操作类API回调地址
        /// </summary>
        /// <param name="paymentApi"></param>
        /// <returns></returns>
        [HttpPost]
        public XmlResult PaymentCallBack()
        {
            ResponseHandler resHandler = new ResponseHandler(HttpContext);

            PaymentCallBackBuss paymentCallBackBuss = new PaymentCallBackBuss();
            string result = paymentCallBackBuss.GetPaymentResult(resHandler);
            return this.Xml(result);

        }
    }
}
