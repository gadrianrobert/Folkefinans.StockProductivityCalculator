using System;
using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Ninject;
using Ninject.Web;

namespace Folkefinans.StockProductivityCalculator.Pages
{
    /// <summary>
    /// View calculated result page
    /// </summary>
    public partial class ViewCalculatedResult : PageBase
    {
        [Inject]
        public IStockBusinessLogic StockBusinessLogic { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            StocksControl.Stocks = StockBusinessLogic.GetStocks();
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