using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMStarter.Models.Domain.Student;

namespace MVVMStarter.Models.Domain.SP
{
    class SPClass : Person
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username;}
            set { value = _username;}
        }

        public string Password
        {
            get { return _password;}
            set { value = _password;}
        }
    }
}
