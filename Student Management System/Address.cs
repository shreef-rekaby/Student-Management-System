using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public Address(string street, string city, string postalCode)
        {
            this.Street = street;
            this.City = city;
            this.PostalCode = postalCode;
        }

       
        public Address() : this("no street", "no government", "no building number")
        {
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {PostalCode}";
        }
    }
}
