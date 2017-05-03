using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Photo
{
    /// <summary>
    /// Model class for the example Photo class.
    /// The implementation is generic, and is made 
    /// domain-specific by the namespace only.
    /// </summary>
    public class DomainModel : DomainModelBase<Photo>
    {
        #region Model Singleton implementation
        private static DomainModel _instance = null;

        public static DomainModel Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new DomainModel();
                return _instance;
            }
        }

        /// <summary>
        /// Use a file-based persistent source
        /// </summary>
        private DomainModel() : base(new CollectionBase<Photo>(), new FileSourceBase<Photo>())
        {
        }
        #endregion
    }
}

