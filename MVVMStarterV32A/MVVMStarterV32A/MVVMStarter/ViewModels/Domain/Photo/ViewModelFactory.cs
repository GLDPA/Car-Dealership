using MVVMStarter.ViewModels.Base;
using PhotoClass = MVVMStarter.Models.Domain.Photo.Photo;

namespace MVVMStarter.ViewModels.Domain.Photo
{
    public class ViewModelFactory : ViewModelFactoryBase<PhotoClass>
    {
        public override DetailsViewModelBase<PhotoClass> CreateDetailsViewModel(PhotoClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<PhotoClass> CreateItemViewModel(PhotoClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<PhotoClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
