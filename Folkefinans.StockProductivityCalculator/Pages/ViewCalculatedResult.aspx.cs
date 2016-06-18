using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Folkefinans.StockProductivityCalculator.App_Start;
using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Folkefinans.StockProductivityCalculator.Controls;
using Ninject;
using Ninject.Web;

namespace Folkefinans.StockProductivityCalculator.Pages
{
    public partial class ViewCalculatedResult : PageBase
    {
        [Inject]
        public IStockBusinessLogic stockBusinessLogic { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            StocksControl.Stocks = stockBusinessLogic.GetStocks();
        }

        //[Inject]
        //[WebMethod]
        //public static string LoadUserControl(string stock, IStockBusinessLogic st)
        //{
        //    using (var page = new Page())
        //    {
        //        var ctrl = (ProductivityControl)page.LoadControl("~/Controls/ProductivityControl.ascx");
        //        var stockInfo = st.GetStocks().FirstOrDefault(s => string.Equals(s.Name, stock));

        //        ctrl.Productivity = st.GetStockProductivity(stockInfo);
        //        page.Controls.Add(ctrl);
        //        using (var writer = new StringWriter())
        //        {
        //            page.Controls.Add(ctrl);
        //            HttpContext.Current.Server.Execute(page, writer, false);
        //            return writer.ToString();
        //        }
        //    }
        //}
    }
}