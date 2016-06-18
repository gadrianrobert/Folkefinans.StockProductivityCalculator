using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Folkefinans.StockProductivityCalculator.Repositories;
using Ninject.Modules;

namespace Folkefinans.StockProductivityCalculator.BusinessLogicTests
{
    /// <summary>
    /// Test bindings class
    /// </summary>
    public class TestBindings : NinjectModule
    {
        /// <summary>
        /// Method used to setup bindings
        /// </summary>
        public override void Load()
        {
            Bind<IStockRepository>().To<StockRepository>();
            Bind<IStockBusinessLogic>().To<StockBusinessLogic>();
        }
    }
}
