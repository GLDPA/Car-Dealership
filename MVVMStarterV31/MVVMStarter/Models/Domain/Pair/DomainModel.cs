using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Pair
{
    public class DomainModel : DomainModelBase<Pair>
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
        private DomainModel() : base(new CollectionBase<Pair>(), new FileSourceBase<Pair>())
        {
        }
        #endregion
    }
}