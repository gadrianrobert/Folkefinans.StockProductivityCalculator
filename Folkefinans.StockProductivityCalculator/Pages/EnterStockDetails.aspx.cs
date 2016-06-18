using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Folkefinans.StockProductivityCalculator.Models;
using Ninject;
using Ninject.Web;

namespace Folkefinans.StockProductivityCalculator.Pages
{
    public partial class EnterStockDetails : PageBase
    {
        [Inject]
        public IStockBusinessLogic stockBusinessLogic { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var stock = new Stock();


            if (Page.IsValid && TryUpdateModel(stock))
            {
                var productivity = new List<Productivity>(stockBusinessLogic.CalculateProductivity(stock));
                stockBusinessLogic.SaveStockProductivity(stock, productivity);

                ProductivityControl.Productivity = productivity;
                lblMessage.Text = "Stock productivity has been calculated.";
            }
        }

        private bool TryUpdateModel(Stock stock)
        {
            try
            {
                stock.Name = tbName.Text;
                stock.Price = decimal.Parse(tbPrice.Text);
                stock.Quantity = int.Parse(tbQuantity.Text);
                stock.Percentage = decimal.Parse(tbPercentage.Text);
                stock.Years = int.Parse(tbYears.Text);
                return true;
            }
            catch
            {
            }
            return false;
        }
    }
}