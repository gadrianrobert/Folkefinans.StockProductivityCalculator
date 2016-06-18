using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Elmah;

namespace Folkefinans.StockProductivityCalculator
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();

           Server.Transfer("~/pages/Error.aspx");

            ErrorSignal.FromCurrentContext().Raise(exception);

            // Clear the error from the server
            Server.ClearError();
        }
    }
}