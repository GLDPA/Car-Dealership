using System;
using MVVMStarter.Models.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

namespace MVVMStarter.Models.Domain.Student
{
    public class Catalog : CatalogBase<Student>
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
        private Catalog() : base(new CollectionBase<Student>(), new FileSourceBase<Student>())
        {
            ZipFilter = new Filter<Student>("ZipFilter", ZipFilterCondition);
            AddFilter(ZipFilter);

            BornFilter = new Filter<Student>("BornFilter", BornFilterCondition);
            AddFilter(BornFilter);
        }
        #endregion

        public Filter<Student> ZipFilter;
        private bool ZipFilterCondition(Student obj) { return obj.ZipCode < 3000; }

        public Filter<Student> BornFilter;
        private bool BornFilterCondition(Student obj) { return obj.YearOfBirth > 1990; }
    }
}
