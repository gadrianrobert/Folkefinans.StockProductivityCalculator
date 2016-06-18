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
    /// <summary>
    /// Ajax handler class
    /// </summary>
    public class AjaxHandler : HttpHandlerBase
    {
        [Inject]
        public IStockBusinessLogic StockBusinessLogic { get; set; }

        /// <summary>
        /// Action parameter name
        /// </summary>
        private const string ActionParameterName = "action";

        /// <summary>
        /// Action dictionary
        /// </summary>
        private static readonly Dictionary<string, Action<IStockBusinessLogic>> ActionDictionary = new Dictionary<string, Action<IStockBusinessLogic>>()
        {
            { "getproductivity", GetProductivityInfo }
        };

        /// <summary>
        /// Method used to process request
        /// </summary>
        /// <param name="context">The context info</param>
        protected override void DoProcessRequest(HttpContext context)
        {
            var action = context.Request.QueryString[ActionParameterName];

            if (ActionDictionary.ContainsKey(action))
            {
                ActionDictionary[action](StockBusinessLogic);
            }
        }

        /// <summary>
        /// True if handler should be reused
        /// </summary>
        public override bool IsReusable => false;

        /// <summary>
        /// Method used to get productivity info
        /// </summary>
        /// <param name="stockBusinessLogic">The stock business logic info</param>
        private static void GetProductivityInfo(IStockBusinessLogic stockBusinessLogic)
        {
            var stock = HttpContext.Current.Request.QueryString["stock"];

            using (var page = new Page())
            {
                var stockInfo = stockBusinessLogic.GetStocks().FirstOrDefault(s => string.Equals(s.Name, stock));
                if(stockInfo==null) return;

                var ctrl = (ProductivityControl)page.LoadControl("~/Controls/ProductivityControl.ascx");
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
