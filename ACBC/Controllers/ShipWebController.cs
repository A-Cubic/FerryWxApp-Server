using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACBC.Buss;
using ACBC.Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senparc.Weixin.MP.TenPayLibV3;

namespace ACBC.Controllers
{
    [Produces("application/json")]
    [Consumes("multipart/form-data", "application/json")]
    [Route(Global.ROUTE_PX + "/[controller]/[action]")]
    [EnableCors("AllowSameDomain")]
    public class ShipWebController : Controller
    {
        [HttpPost]
        public ActionResult TokenOpen([FromBody]WXOpenApi openApi)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\r");
            if (openApi == null)
                return Json(new ResultsJson(new Message(CodeMessage.PostNull, "PostNull"), null));
            return Json(Global.BUSS.BussResults(this, openApi));
        }
        [HttpPost]
        public ActionResult Ticket([FromBody]TicketApi TicketApi)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\r");
            if (TicketApi == null)
                return Json(new ResultsJson(new Message(CodeMessage.PostNull, "PostNull"), null));
            return Json(Global.BUSS.BussResults(this, TicketApi));
        }
    }
}