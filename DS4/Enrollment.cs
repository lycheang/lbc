using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DS4
{
    public class Enrollment
    {
        public int EnrollNo { get; set; }
        public String Date { get; set; }
        public int EmpNo {  get; set; }
        

        public  Enrollment(int enrollno,string date,int empno)
        {
            this.EnrollNo = enrollno;
            this.Date = date;
            this.EmpNo = empno;
        }
        public void Enrollinfo(int eno,string d,Enrollment en)
        {

            
            Console.Write("EnrollID :"+en.EnrollNo);
            Console.Write(" Enroll Date : " + en.Date);
            Console.Write(" Employee No: "+en.EmpNo);

        }
    }

    internal class Enrollments
    {
    }
}
