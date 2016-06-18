using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Folkefinans.StockProductivityCalculator
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            routes.EnableFriendlyUrls(settings);
        }
    }
}
