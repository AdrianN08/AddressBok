using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Adressbok
{
   public class Contact
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public Contact(string name, string adress, string zipCode, string city, string phoneNr, string emailAdress)
        {
            Name = name;
            Adress = adress;
            ZipCode = zipCode;
            City = city;
            PhoneNr = phoneNr;
            Email = emailAdress;
        }
        public Contact()
        {

        }
        public override string ToString()
        {
            return Name + "," + Adress + "," + ZipCode + "," + City + "," + PhoneNr + "," + Email;
        }
    }
}

