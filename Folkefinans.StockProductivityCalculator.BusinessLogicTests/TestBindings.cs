using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Folkefinans.StockProductivityCalculator.Repositories;
using Ninject.Modules;

namespace Folkefinans.StockProductivityCalculator.BusinessLogicTests
{
    public class TestBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IStockRepository>().To<StockRepository>();
            Bind<IStockBusinessLogic>().To<StockBusinessLogic>();
        }
    }
}
