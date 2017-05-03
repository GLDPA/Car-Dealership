using MVVMStarter.Configuration.App;
using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using PhotoClass = MVVMStarter.Models.Domain.Photo.Photo;

namespace MVVMStarter.ViewModels.Domain.Photo
{
    public class DetailsViewModel : DetailsViewModelBase<PhotoClass>
    {
        public string PhotoSource
        {
            get
            {
                string source = DomainObject.PhotoSource.Substring(DomainObject.PhotoSource.Length - 6, 2);
                return source;
            }
            set
            {
                string source = AppConfig.ImageFilePrefix + "Photo\\" + value + ".jpg";
                DomainObject.PhotoSource = source;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return DomainObject.Title; }
            set
            {
                try
                {
                    DomainObject.Title = value;
                }
                catch (ValidationException e)
                {
                    PresentValidationError(e.Message, () => { OnPropertyChanged(); });
                }
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return DomainObject.Description; }
            set
            {
                DomainObject.Description = value;
                OnPropertyChanged();
                PropertyDependencies.Dependencies().ForEach(OnPropertyChanged);
            }
        }

        public string Location
        {
            get { return DomainObject.Location; }
            set
            {
                DomainObject.Location = value;
                OnPropertyChanged();
            }
        }

        public int Year
        {
            get { return DomainObject.Year; }
            set
            {
                var orgValue = DomainObject.Year;
                try
                {
                    DomainObject.Year = value;
                }
                catch (ValidationException e)
                {
                    PresentValidationError(e.Message, () => { Year = orgValue; });
                }
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(PhotoClass obj) 
            : base(obj)
        {
        }
    }
}
