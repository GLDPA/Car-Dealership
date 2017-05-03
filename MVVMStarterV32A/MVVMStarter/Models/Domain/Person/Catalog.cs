using System;
using MVVMStarter.Models.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Student
{
    public class Catalog : CatalogBase<Car>
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
        private Catalog() : base(new CollectionBase<Car>(), new FileSourceBase<Car>())
        {
            ZipFilter = new Filter<Car>("ZipFilter", ZipFilterCondition);
            AddFilter(ZipFilter);

            BornFilter = new Filter<Car>("BornFilter", BornFilterCondition);
            AddFilter(BornFilter);
        }
        #endregion

        public Filter<Car> ZipFilter;
        private bool ZipFilterCondition(Car obj) { return obj.ZipCode < 3000; }

        public Filter<Car> BornFilter;
        private bool BornFilterCondition(Car obj) { return obj.YearOfBirth > 1990; }
    }
}
