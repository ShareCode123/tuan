using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSP_Covid21.Models.ShopEntity;

namespace TSP_Covid21.Areas.Test.Controllers
{
    public class TestController : Controller
    {
        private COVIDEntities db;

        public TestController()
        {
            db = new COVIDEntities();
        }
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sensors(string user)
        {
            var result = from a in db.ww_TEST_Detail
                         where a.User == user
                         select new InfSensor()
                         {
                             SensorName = a.ww_TEST_Sensor.SensorPara,
                             SensorDes = a.ww_TEST_Sensor.SensorDes,
                         };


            return PartialView(result);
        }

        public ActionResult UploadFile()
        {
            return View();
        }
    }

    public class InfSensor
    {
        public string SensorName { get; set; }
        public string SensorDes { get; set; }
    }
}