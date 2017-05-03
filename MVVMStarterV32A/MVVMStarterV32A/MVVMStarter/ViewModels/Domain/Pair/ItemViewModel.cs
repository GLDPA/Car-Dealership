using MVVMStarter.ViewModels.Base;
using PairClass = MVVMStarter.Models.Domain.Pair.Pair;

namespace MVVMStarter.ViewModels.Domain.Pair
{
    public class ItemViewModel : ItemViewModelBase<PairClass>
    {
        public ItemViewModel(PairClass obj) : base(obj)
        {
        }

        public string ImageSourceLeft
        {
            get { return DomainObject.LeftPhoto == null ? string.Empty : DomainObject.LeftPhoto.PhotoSource; }
        }

        public string ImageSourceRight
        {
            get { return DomainObject.RightPhoto == null ? string.Empty : DomainObject.RightPhoto.PhotoSource; }
        }
    }
}