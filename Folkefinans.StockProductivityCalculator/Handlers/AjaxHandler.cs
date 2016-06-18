using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Folkefinans.StockProductivityCalculator.Controls;
using Ninject;
using Ninject.Web;

namespace Folkefinans.StockProductivityCalculator.Handlers
{
    public class AjaxHandler : HttpHandlerBase
    {
        [Inject]
        public IStockBusinessLogic stockBusinessLogic { get; set; }


        private const string ActionParameterName = "action";

        private static Dictionary<string, Action<IStockBusinessLogic>> actionDictionary = new Dictionary<string, Action<IStockBusinessLogic>>()
        {
            { "getproductivity", GetProductivityInfo }
        };

        protected override void DoProcessRequest(HttpContext context)
        {
            var action = context.Request.QueryString[ActionParameterName];

            if (actionDictionary.ContainsKey(action))
            {
                actionDictionary[action](stockBusinessLogic);
            }

        }

        public override bool IsReusable => false;

        private static void GetProductivityInfo(IStockBusinessLogic stockBL)
        {
            var stock = HttpContext.Current.Request.QueryString["stock"];

            using (var page = new Page())
            {
                var ctrl = (ProductivityControl)page.LoadControl("~/Controls/ProductivityControl.ascx");
                var stockInfo = stockBL.GetStocks().FirstOrDefault(s => string.Equals(s.Name, stock));

                ctrl.Productivity = stockBL.GetStockProductivity(stockInfo);
                page.Controls.Add(ctrl);
                using (var writer = new StringWriter())
                {
                    page.Controls.Add(ctrl);
                    HttpContext.Current.Server.Execute(page, writer, false);
                    HttpContext.Current.Response.Write(writer.ToString());
                    HttpContext.Current.Response.Flush();
                }
            }
        }
    }
}
