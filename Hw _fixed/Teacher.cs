using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class Teacher:Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID, string ID) :
            base(name, address, citizenID, ID)
        {
            this.employeeID = employeeID;
        }
    }
}
