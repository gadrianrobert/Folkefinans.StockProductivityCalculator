using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Repositories
{
    public interface IStockRepository
    {
        void Add(Stock stock, IEnumerable<Productivity> productivity);
        IEnumerable<Stock> GetStocks();
        IEnumerable<Productivity> GetStockProductivity(Stock stock);
    }
}