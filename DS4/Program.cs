using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DS4
{
    


        internal class Program
        {

        
        static void Main(string[] args)
        {
            //declare
            Person person = new Person();
            Employees emp = new Employees();
            Address add1 = new Address(1002, "St371", "Phnom Penh", "Cambodia");
            float tax;
            ////input
            emp.PersonID = 302;
            emp.PersonName = " Ly Bunchheang";
            //emp.PersonAddress = "Phnom Penh";
            emp.Department = "Science and Technology";
            emp.Position = "Manager";
            emp.Salary = 1200.0f;   
            ////process
            emp.Displayinfo(emp.PersonID, emp.PersonName, add1);
            //emp.salaryafter 0.1f 10% of salary 
            tax = emp.Salary - emp.Salaryaftertax(emp.Salary, 0.1f);
            //output
            Console.WriteLine();
            Console.WriteLine("Employee info: " + "Deparment: " + emp.Department + ",");
            Console.WriteLine("Poition: " + emp.Position + " Salary: " + "$" + emp.Salary + ",tax: $" + tax);
            Console.ReadKey();



            //declare
            // Students student = new Students();
            //Address address = new Address(1001,"St371","Phnom Penh","Cambodia");
            //Enrollment enrollment = new Enrollment(002, "20/01/2025", 003);
            //float avg;
            //student.PersonID = 1;
            //student.PersonName = "Ly Bunchheang";
            ////student.PersonAddress = "Phnom penh";
            //student.falculty = "Acleda University";
            //student.major = "Fintech";
            //student.batch = 8;
            //student.total = 95;
            ////student.IsCoursePaid(true);
            ////process
            //student.Displayinfo(student.PersonID, student.PersonName, address);
            //avg = student.total / 3;
            ////output
            //Console.WriteLine();
            //Console.WriteLine("Student info: " +" Falculty: "+ student.falculty + ",");
            //Console.WriteLine("Major: " + student.major + "," + "Batch: " + student.batch + "\n" + "Total Score: " + student.total);
            //Console.WriteLine("Enrollments Information: ");
            //student.IsCoursePaid(true);
            //student.EnrollClass(true);
            //enrollment.Enrollinfo(student.PersonID, student.PersonName, enrollment);

            Console.ReadLine();
        }
    }
}

