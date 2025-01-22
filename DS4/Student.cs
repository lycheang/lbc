using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS4
{
    public class Students : Person
    {
        //attribute
        string fal;
        string maj;
        int bat;
        float tal;
        public string falculty
        {
            get { return fal; }
            set { fal = value; }
        }
        public string major
        {
            get { return maj; }
            set { maj = value; }
        }
        public int batch
        {
            get { return bat; }
            set { bat = value; }
        }
        //public void Studentinfo()
        //{
        //    Console.WriteLine("Student Info: "+this.falculty+","+this.major+","+this.batch);
        //}
        public float total
        {
            get { return tal; }
            set { tal = value; }
        }
        //method
        public bool IsCoursePaid(bool isCoursePaid)
        {
            if (isCoursePaid == true)
            {
                Console.WriteLine(this.PersonName + " :Already Paid");
                return true;
            }
            else
            {

            }
            return false;
        }
        public bool EnrollClass(bool IsEnrollClass)
        {
            if (IsEnrollClass == true)
            {
                Console.WriteLine("This Student is Already Enroll Classs");
                return true;
            }
            else
            {
                Console.WriteLine("This Student is not Enroll Yet!!!");
            }
            return false;
        }
        public Enrollment enrollment;
        
        //public float totalscore
        //{
            
        //    float html = 70;
        //     float javascript = 90;
        //     float ux = 95;
        //    total = html + javascript + ux;

        //    return total;
        //}
        
        internal class Student
        {
        }
    }
}
