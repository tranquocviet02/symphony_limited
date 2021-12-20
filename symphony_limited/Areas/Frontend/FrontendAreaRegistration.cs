using System.Web.Mvc;

namespace symphony_limited.Areas.Frontend
{
    public class FrontendAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Frontend";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Frontend_default",
                "Frontend/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}