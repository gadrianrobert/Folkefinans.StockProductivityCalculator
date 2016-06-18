using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Repositories
{
    public class StockRepository : IStockRepository
    {
        private static readonly ConcurrentDictionary<Stock,IEnumerable<Productivity>> Store = new ConcurrentDictionary<Stock, IEnumerable<Productivity>>();

        public void Add(Stock stock, IEnumerable<Productivity> productivity)
        {
            var addValue = productivity as IList<Productivity> ?? productivity.ToList();
            Store.AddOrUpdate(stock, addValue, (s, p) => addValue);
        }

        public IEnumerable<Stock> GetStocks()
        {
            return Store.Keys;
        }

        public IEnumerable<Productivity> GetStockProductivity(Stock stock)
        {
            if (!Store.ContainsKey(stock)) return Enumerable.Empty<Productivity>();

            return Store[stock];
        }
    }
}
