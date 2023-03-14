using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class ContactData
    {
        public ContactData(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }


       public string Name { get; set; }
       public string PhoneNumber { get; set; }   

    }
}
