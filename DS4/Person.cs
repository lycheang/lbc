using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS4
{
    public class Person
    {
        //attribute
        int id;
        string name;
        //string address;




        public int PersonID
        {
            get { return id; }
            set { id = value; }
        }
        public string PersonName
        {
            get { return name; }
            set { name = value; }
        }
        //public string PersonAddress
        //{
        //    get { return address; }
        //    set { address = value; }
        //}
        public Address address;
        //Method
        public void Displayinfo(int id, string name, Address ad)
        {
            Console.WriteLine("Personal Information: ");
            Console.Write("ID: " + id);
            Console.Write("  Name: " + name);
            Console.Write("  Address: " +"Home :"+ ad.Home+", Street: "+ad.Street + ", City: "+ad.City + ", Country: "+ad.Country);
        }
    }
}
