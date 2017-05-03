using MVVMStarter.Models.Base;

namespace MVVMStarter.Models.Domain.Pair
{
    public class Pair : DomainClassBase
    {
        private Photo.Photo _photoLeft;
        private Photo.Photo _photoRight;

        public Pair()
        {
            _photoLeft = null;
            _photoRight = null;
        }

        public Photo.Photo LeftPhoto
        {
            get { return _photoLeft; }
            set { _photoLeft = value; }
        }

        public Photo.Photo RightPhoto
        {
            get { return _photoRight; }
            set { _photoRight = value; }
        }

        public override void SetDefaultValues()
        {
            _photoLeft = null;
            _photoRight = null;
        }
    }
}