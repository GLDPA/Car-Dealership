using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;
using MVVMStarter.Validators.Domain.Photo;

namespace MVVMStarter.Models.Domain.Photo
{
    /// <summary>
    /// Domain class for the example Photo class.
    /// A domain class MUST inherit from DomainClassBase, and
    /// implement its abstract methods.
    /// </summary>
    public class Photo : DomainClassBase
    {
        public string Description { get; set; }
        public string Location { get; set; }

        private string _photoSource;
        public string PhotoSource
        {
            get { return _photoSource; }
            set
            {
                _photoSource = value;
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                ValidationHandler.ThrowOnInvalid<string>(Validator.ValidateTitle, value);
                 _title = value;
            }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                ValidationHandler.ThrowOnInvalid<int>(Validator.ValidateYear, value);
                _year = value;
            }
        }

        public override void SetDefaultValues()
        {
            Title = "(none)";
            Description = "(none)";
            Location = "(none)";
            Year = 2000;
            PhotoSource = AppConfig.ImageFilePrefix + "Photo\\01.jpg";
        }
    }
}
