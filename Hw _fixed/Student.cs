using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw__fixed
{
    class Student : Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID, string ID)
            : base(name, address, citizenID, ID)
        {
            this.studentID = studentID;
        }
    }
}
