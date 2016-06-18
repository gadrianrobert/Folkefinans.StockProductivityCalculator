using System;
using System.Collections.Generic;
using System.Web.UI;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Controls
{
    public partial class StocksControl : UserControl
    {
        public IEnumerable<Stock> Stocks { get; set; }
    }
}