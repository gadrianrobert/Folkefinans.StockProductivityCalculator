using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.Repositories
{
    /// <summary>
    /// Stock repository interface
    /// </summary>
    public interface IStockRepository
    {
        /// <summary>
        /// Method used to add a stock and ita productivity details to repo
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <param name="productivity">The productivity info</param>
        void Add(Stock stock, IEnumerable<Productivity> productivity);

        /// <summary>
        /// Method used to get stocks collection
        /// </summary>
        /// <returns>The stocks collection</returns>
        IEnumerable<Stock> GetStocks();

        /// <summary>
        /// Method used to get stock productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <returns>The productivity collection</returns>
        IEnumerable<Productivity> GetStockProductivity(Stock stock);
    }
}