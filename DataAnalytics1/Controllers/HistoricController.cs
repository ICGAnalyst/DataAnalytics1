using DataAnalytics1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace DataAnalytics1.Controllers
{
    public class HistoricController : Controller
    {
        // GET: Historic
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetHisToricData(string symbolKey, int fromDate, int toDate)
        {
            HistoricBusiness historicBusiness = new HistoricBusiness();
            List<Historic> historics = historicBusiness.GetHisToricData(symbolKey, fromDate, toDate);
            return Json(historics, JsonRequestBehavior.AllowGet);
        }
    }
}