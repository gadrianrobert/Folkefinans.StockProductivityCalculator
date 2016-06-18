using System;
using System.Collections.Generic;
using Folkefinans.StockProductivityCalculator.Models;
using Folkefinans.StockProductivityCalculator.Repositories;

namespace Folkefinans.StockProductivityCalculator.BusinessLogic
{
    public class StockBusinessLogic : IStockBusinessLogic
    {
        private readonly IStockRepository _stockRepository;

        public StockBusinessLogic(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }
        public IEnumerable<Productivity> CalculateProductivity(Stock stock)
        {
            if (stock == null) yield break;

            decimal growth = 0;
            for (var i = 0; i <= stock.Years; i++)
            {
                var result = (stock.Price + i * stock.Price * stock.Percentage / 100) * stock.Quantity;
                result += (i > 1 ? growth * stock.Percentage / 100 : 0);
                growth += result - stock.Price * stock.Quantity;

                yield return new Productivity() { Year = i, Value = Decimal.Round(result, 2) };
            }
        }

        public void SaveStockProductivity(Stock stock, IEnumerable<Productivity> productivity)
        {
            if(stock==null) return;

            _stockRepository.Add(stock, productivity);
        }

        public IEnumerable<Stock> GetStocks()
        {
            return _stockRepository.GetStocks();
        }

        public IEnumerable<Productivity> GetStockProductivity(Stock stock)
        {
            return _stockRepository.GetStockProductivity(stock);
        }
    }
}
