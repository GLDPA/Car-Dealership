using System.Collections.Generic;
using System.Windows.Input;
using MVVMStarter.Controllers.Domain.Pair;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using PairClass = MVVMStarter.Models.Domain.Pair.Pair;

namespace MVVMStarter.ViewModels.Domain.Pair
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<PairClass>
    {
        public MasterDetailsViewModel() 
            : base(new ViewModelFactory(), Models.Domain.Pair.Catalog.Instance)
        {
            List<string> fixedProperties = new List<string>();

            List<string> nonFixedProperties = new List<string>();
            fixedProperties.Add(nameof(PairClass.LeftPhoto));
            fixedProperties.Add(nameof(PairClass.RightPhoto));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedProperties);

            StateManager.AddButtonDefaultStates();
            StateManager.AddViewControlState(new ViewControlState("Swap"));
        }

        public ICommand SwapCommand
        {
            get { return new SwapController(this, Models.Domain.Pair.Catalog.Instance, ItemViewModelSelected?.DomainObject); }
        }

        public override ItemViewModelBase<PairClass> ItemViewModelSelected
        {
            get { return base.ItemViewModelSelected; }
            set
            {
                base.ItemViewModelSelected = value;
                OnPropertyChanged(nameof(SwapCommand));
            }
        }
    }
}