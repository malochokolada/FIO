using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFIO
{
    internal class User
    {
        public string Fio { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            Fio = lastName + " " + firstName[0] + "." + middleName[0] + ".";
        }
    }
}
