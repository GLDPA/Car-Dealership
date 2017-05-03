using MVVMStarter.ViewModels.Base;
using PhotoClass = MVVMStarter.Models.Domain.Photo.Photo;

namespace MVVMStarter.ViewModels.Domain.Photo
{
    public class ItemViewModel : ItemViewModelBase<PhotoClass>
    {
        public override string Description
        {
            get { return DomainObject.Title + " (" + DomainObject.Year + ")"; }
        }

        public override int FontSize
        {
            get { return 18; }
        }

        public override string ImageSource
        {
            get { return DomainObject.PhotoSource; }
        }

        public override int ImageSize
        {
            get { return 60; }
        }

        public override bool ImageIsVisible
        {
            get { return true; }
        }

        public ItemViewModel(PhotoClass obj) 
            : base(obj)
        {
        }
    }
}
