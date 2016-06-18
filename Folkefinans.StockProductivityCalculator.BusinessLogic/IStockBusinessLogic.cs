using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.Models;

namespace Folkefinans.StockProductivityCalculator.BusinessLogic
{
    /// <summary>
    /// Stock business logic interface
    /// </summary>
    public interface IStockBusinessLogic
    {
        /// <summary>
        /// Method used to calculate productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <returns>The productivity collection</returns>
        IEnumerable<Productivity> CalculateProductivity(Stock stock);

        /// <summary>
        /// Method used to save stock productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <param name="productivity">The productivity info</param>
        void SaveStockProductivity(Stock stock, IEnumerable<Productivity> productivity);

        /// <summary>
        /// Method used to get stocks
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