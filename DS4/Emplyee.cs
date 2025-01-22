using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS4
{
    public class Employees : Person
    {
        //Attribute
        string dept;
        string pos;
        float sal;
        public String Department
        {
            get { return dept; }
            set { dept = value; }
        }
        public String Position
        {
            get { return pos; }
            set { pos = value; }
        }
        public float Salary
        {
            get { return sal; }
            set { sal = value; }
        }
        //method
        public float Salaryaftertax(float salary, float tax)
        {
            return salary - (salary * tax);

        }
        internal class Emplyee
        {
        }
    }
}
