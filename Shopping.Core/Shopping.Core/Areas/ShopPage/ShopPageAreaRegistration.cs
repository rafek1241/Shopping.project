using System.Web.Http;
using System.Web.Mvc;

namespace Shopping.Core.Areas.ShopPage
{
    public class ShopPageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ShopPage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ShopPage_default",
                "ShopPage/{controller}/{action}/{id}",
                new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );
        }

        public static void Register(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                 name: "Categories",
                 routeTemplate: "api/categories/{action}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );
        }

    }
}