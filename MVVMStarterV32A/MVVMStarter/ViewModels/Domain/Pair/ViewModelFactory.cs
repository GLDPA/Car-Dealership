using MVVMStarter.ViewModels.Base;
using PairClass = MVVMStarter.Models.Domain.Pair.Pair;

namespace MVVMStarter.ViewModels.Domain.Pair
{
    public class ViewModelFactory : ViewModelFactoryBase<PairClass>
    {
        public override DetailsViewModelBase<PairClass> CreateDetailsViewModel(PairClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<PairClass> CreateItemViewModel(PairClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<PairClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}