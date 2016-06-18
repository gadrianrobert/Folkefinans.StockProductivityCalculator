using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Controls
{
    public partial class StocksControl : System.Web.UI.UserControl
    {
        public IEnumerable<Stock> Stocks { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}