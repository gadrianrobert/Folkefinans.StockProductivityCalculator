using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.BusinessLogic
{
    public interface IStockBusinessLogic
    {
        IEnumerable<Productivity> CalculateProductivity(Stock stock);
        void SaveStockProductivity(Stock stock);
        IEnumerable<Stock> GetStocks();
        IEnumerable<Productivity> GetStockProductivity(Stock stock);
    }
}