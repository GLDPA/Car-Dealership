using System.Collections.ObjectModel;
using MVVMStarter.ViewModels.Base;
using PairClass = MVVMStarter.Models.Domain.Pair.Pair;
using PhotoClass = MVVMStarter.Models.Domain.Photo.Photo;

namespace MVVMStarter.ViewModels.Domain.Pair
{
    public class DetailsViewModel : DetailsViewModelBase<PairClass>
    {
        private ObservableCollection<string> _photoTitles;
        private string _leftSelection;
        private string _rightSelection;

        public DetailsViewModel(PairClass obj) : base(obj)
        {
            _photoTitles = new ObservableCollection<string>();

            foreach (var photo in MVVMStarter.Models.Domain.Photo.DomainModel.Instance.All)
            {
                _photoTitles.Add(photo.Title);
            }

            LeftSelection = obj.LeftPhoto == null ? string.Empty : obj.LeftPhoto.Title;
            RightSelection = obj.RightPhoto == null ? string.Empty : obj.RightPhoto.Title;
        }

        public ObservableCollection<string> PhotoTitles
        {
            get { return _photoTitles; }
        }

        public string LeftSelection
        {
            get { return _leftSelection; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _leftSelection = value;
                    DomainObject.LeftPhoto = TitleToKey(_leftSelection);
                    OnPropertyChanged();
                }
            }
        }

        public string RightSelection
        {
            get { return _rightSelection; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _rightSelection = value;
                    DomainObject.RightPhoto = TitleToKey(_rightSelection);
                    OnPropertyChanged();
                }
            }
        }

        public PhotoClass TitleToKey(string title)
        {
            foreach (var photo in MVVMStarter.Models.Domain.Photo.DomainModel.Instance.All)
            {
                if (photo.Title == title)
                {
                    return photo;
                }
            }

            return null;
        }
    }
}