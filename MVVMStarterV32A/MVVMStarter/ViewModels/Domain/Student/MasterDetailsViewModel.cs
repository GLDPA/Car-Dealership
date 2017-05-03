using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using StudentClass = MVVMStarter.Models.Domain.Student.Person;
using StudentCatalog = MVVMStarter.Models.Domain.Student.Catalog;

namespace MVVMStarter.ViewModels.Domain.Student
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<StudentClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Student.Catalog.Instance)
        {
            #region Control state setup
            // Use the below code as a template for setting up default
            // behavior for your GUI controls

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(StudentClass.Name));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(StudentClass.Country));
            nonFixedKeyProperties.Add(nameof(StudentClass.YearOfBirth));
            nonFixedKeyProperties.Add(nameof(StudentClass.City));
            nonFixedKeyProperties.Add(nameof(StudentClass.ZipCode));
            nonFixedKeyProperties.Add(nameof(StudentClass.PhotoID));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();

            StateManager.AddViewControlState(new ViewControlState("ZipCodeFilter", "ZipCode below 3000"));
            StateManager.AddViewControlState(new ViewControlState("BornFilter", "Born after 1990"));
            #endregion
        }

        public bool ZipFilterOn
        {
            get { return StudentCatalog.Instance.ZipFilter.On; }
            set
            {
                StudentCatalog.Instance.ZipFilter.On = value;
                OnPropertyChanged(nameof(ItemViewModelCollection));
            }
        }

        public bool BornFilterOn
        {
            get { return StudentCatalog.Instance.BornFilter.On; }
            set
            {
                StudentCatalog.Instance.BornFilter.On = value;
                OnPropertyChanged(nameof(ItemViewModelCollection));
            }
        }
    }
}
