using System.Web.Mvc;

namespace TSP_Covid21.Areas.Test
{
    public class TestAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Test";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Test_Sensor",
                "Sensor",
                new { controller = "Test", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Test_default",
                "Test/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}