using Folkefinans.StockProductivityCalculator.BusinessLogic;
using Ninject.Modules;

namespace Folkefinans.StockProductivityCalculator
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IStockBusinessLogic>().To<StockBusinessLogic>();
        }
    }
}
