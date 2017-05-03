using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;

namespace MVVMStarter.Models.Domain.Student
{
    public class Person : DomainClassBase
    {
        private string _navn;
        private string _email;
        private int _tlfnummer;
        

        public string Name
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Tlfnummer
        {
            get { return _tlfnummer; }
            set { _tlfnummer = value; }
        }

        public override void SetDefaultValues()
        {
            _navn = "(Anders)";
            _email = "(anders123@mail.com)";
            _tlfnummer = (12345678);
        }
    }
}

