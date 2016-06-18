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
        public IStockBusinessLogic StockBusinessLogic { get; set; }


        private const string ActionParameterName = "action";

        private static readonly Dictionary<string, Action<IStockBusinessLogic>> ActionDictionary = new Dictionary<string, Action<IStockBusinessLogic>>()
        {
            { "getproductivity", GetProductivityInfo }
        };

        protected override void DoProcessRequest(HttpContext context)
        {
            var action = context.Request.QueryString[ActionParameterName];

            if (ActionDictionary.ContainsKey(action))
            {
                ActionDictionary[action](StockBusinessLogic);
            }

        }

        public override bool IsReusable => false;

        private static void GetProductivityInfo(IStockBusinessLogic stockBusinessLogic)
        {
            var stock = HttpContext.Current.Request.QueryString["stock"];

            using (var page = new Page())
            {
                var ctrl = (ProductivityControl)page.LoadControl("~/Controls/ProductivityControl.ascx");
                var stockInfo = stockBusinessLogic.GetStocks().FirstOrDefault(s => string.Equals(s.Name, stock));

                ctrl.Productivity = stockBusinessLogic.GetStockProductivity(stockInfo);
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
