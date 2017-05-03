using MVVMStarter.Controllers.Base;
using MVVMStarter.Models.Base;
using MVVMStarter.ViewModels.Base;
using PairClass = MVVMStarter.Models.Domain.Pair.Pair;

namespace MVVMStarter.Controllers.Domain.Pair
{
    public class SwapController : ControllerBase<PairClass>
    {
        private PairClass _obj;

        public SwapController(
            MasterDetailsViewModelBase<PairClass> masterDetailsViewModel, 
            DomainModelBase<PairClass> domainModel,
            PairClass obj) 
            : base(masterDetailsViewModel, domainModel)
        {
            _obj = obj;
        }

        public override void Execute()
        {
            if (_obj != null)
            {
                var left = _obj.LeftPhoto;
                _obj.LeftPhoto = _obj.RightPhoto;
                _obj.RightPhoto = left;

                MasterDetailsViewModel.AfterModelUpdate(_obj);
            }
        }

        public override bool CanExecute()
        {
            return MasterDetailsViewModel.ItemViewModelSelected != null;
        }
    }
}