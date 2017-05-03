using System;
using MVVMStarter.Models.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Student
{
    public class Catalog : CatalogBase<Person>
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
        private Catalog() : base(new CollectionBase<Person>(), new FileSourceBase<Person>())
        {
            ZipFilter = new Filter<Person>("ZipFilter", ZipFilterCondition);
            AddFilter(ZipFilter);

            BornFilter = new Filter<Person>("BornFilter", BornFilterCondition);
            AddFilter(BornFilter);
        }
        #endregion

        public Filter<Person> ZipFilter;
        private bool ZipFilterCondition(Person obj) { return obj.ZipCode < 3000; }

        public Filter<Person> BornFilter;
        private bool BornFilterCondition(Person obj) { return obj.YearOfBirth > 1990; }
    }
}
