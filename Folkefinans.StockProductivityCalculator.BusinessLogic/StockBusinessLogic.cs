using System;
using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.Models;
using Folkefinans.StockProductivityCalculator.Repositories;

namespace Folkefinans.StockProductivityCalculator.BusinessLogic
{
    /// <summary>
    /// Stock business logic class
    /// </summary>
    public class StockBusinessLogic : IStockBusinessLogic
    {
        private readonly IStockRepository _stockRepository;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="stockRepository">The stock repository</param>
        public StockBusinessLogic(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        /// <summary>
        /// Method used to calculate productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <returns>The productivity collection</returns>
        public IEnumerable<Productivity> CalculateProductivity(Stock stock)
        {
            if (stock == null) yield break;

            decimal growth = 0;
            for (var i = 0; i <= stock.Years; i++)
            {
                var result = (stock.Price + i * stock.Price * stock.Percentage / 100) * stock.Quantity;
                result += (i > 1 ? growth * stock.Percentage / 100 : 0);
                growth += result - stock.Price * stock.Quantity;

                yield return new Productivity { Year = i, Value = decimal.Round(result, 2) };
            }
        }

        /// <summary>
        /// Method used to save stock productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <param name="productivity">The productivity info</param>
        public void SaveStockProductivity(Stock stock, IEnumerable<Productivity> productivity)
        {
            if (stock == null) return;

            _stockRepository.Add(stock, productivity);
        }

        /// <summary>
        /// Method used to get stocks
        /// </summary>
        /// <returns>The stocks collection</returns>
        public IEnumerable<Stock> GetStocks()
        {
            return _stockRepository.GetStocks();
        }

        /// <summary>
        /// Method used to get stock productivity
        /// </summary>
        /// <param name="stock">The stock info</param>
        /// <returns>The productivity collection</returns>
        public IEnumerable<Productivity> GetStockProductivity(Stock stock)
        {
            return _stockRepository.GetStockProductivity(stock);
        }
    }
}
