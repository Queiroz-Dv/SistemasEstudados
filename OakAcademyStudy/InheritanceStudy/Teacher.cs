using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudy
{
    class Teacher : Employee
    {
        public string Branch { get; set; }

        public void FindSalary()
        {
            //this method invoke the Salary other class
            Salary = 2000;
        }

        public void SetValue2()
        {
            Position = "Teacher";
            Branch = "Math";
        }
    }
}
