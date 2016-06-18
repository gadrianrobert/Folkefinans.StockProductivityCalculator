using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Repositories
{
    /// <summary>
    /// Stock repository class
    /// </summary>
    public class StockRepository : IStockRepository
    {
        private static readonly ConcurrentDictionary<Stock,IEnumerable<Productivity>> Store = new ConcurrentDictionary<Stock, IEnumerable<Productivity>>();

        /// <summary>
        /// Method used to add a stock and ita productivity details to repo
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <param name="productivity">The productivity info</param>
        public void Add(Stock stock, IEnumerable<Productivity> productivity)
        {
            var addValue = productivity as IList<Productivity> ?? productivity.ToList();

            IEnumerable<Productivity> removed;
            if (Store.ContainsKey(stock)) Store.TryRemove(stock, out removed);

            Store.TryAdd(stock, addValue);
        }

        /// <summary>
        /// Method used to get stocks collection
        /// </summary>
        /// <returns>The stocks collection</returns>
        public IEnumerable<Stock> GetStocks()
        {
            return Store.Keys;
        }

        /// <summary>
        /// Method used to get stock productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <returns>The productivity collection</returns>
        public IEnumerable<Productivity> GetStockProductivity(Stock stock)
        {
            return !Store.ContainsKey(stock) ? Enumerable.Empty<Productivity>() : Store[stock];
        }
    }
}
