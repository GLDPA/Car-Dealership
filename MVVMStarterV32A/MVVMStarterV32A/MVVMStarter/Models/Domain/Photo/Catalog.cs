using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Photo
{
    /// <summary>
    /// Catalog for the example Photo class.
    /// The implementation is generic, and is made 
    /// domain-specific by the namespace only.
    /// </summary>
    public class Catalog : CatalogBase<Photo>
    {
        #region Model Singleton implementation
        private static Catalog _instance = null;

        public static Catalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new Catalog();
                return _instance;
            }
        }

        /// <summary>
        /// Use a file-based persistent source
        /// </summary>
        private Catalog() : base(new CollectionBase<Photo>(), new FileSourceBase<Photo>())
        {
        }
        #endregion
    }
}

