using System;
using System.Collections.Generic;
using System.Web.UI;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Controls
{
    public partial class ProductivityControl : UserControl
    {
        public IEnumerable<Productivity> Productivity { get; set; }
    }
}