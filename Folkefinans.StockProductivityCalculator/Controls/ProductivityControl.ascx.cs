using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Controls
{
    public partial class ProductivityControl : System.Web.UI.UserControl
    {
        public IEnumerable<Productivity> Productivity { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}