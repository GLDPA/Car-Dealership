using System.Collections.Generic;
using MVVMStarter.ViewModels.Base;
using PhotoClass = MVVMStarter.Models.Domain.Photo.Photo;

namespace MVVMStarter.ViewModels.Domain.Photo
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<PhotoClass>
    {
        public MasterDetailsViewModel() 
            : base(new ViewModelFactory(), Models.Domain.Photo.DomainModel.Instance)
        {
            List<string> fixedProperties = new List<string>();
            fixedProperties.Add(nameof(PhotoClass.Title));

            List<string> nonFixedProperties = new List<string>();
            nonFixedProperties.Add(nameof(PhotoClass.Description));
            nonFixedProperties.Add(nameof(PhotoClass.Location));
            nonFixedProperties.Add(nameof(PhotoClass.Year));
            nonFixedProperties.Add(nameof(PhotoClass.PhotoSource));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedProperties);

            StateManager.AddButtonDefaultStates();
        }
    }
}
