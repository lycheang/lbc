using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS4
{
    public class Address
    {
        public int Home { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Address(int ho, string st, string ci, string co)
        {
            this.Home = ho;
            this.Street = st;
            this.City = ci;
            this.Country = co;
        }
    }
    internal class address
    {
    }
}
