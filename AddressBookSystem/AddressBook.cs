using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.Write("Enter First Name : ");
            contact.fName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            contact.lName = Console.ReadLine();

            Console.Write("Enter Address : ");
            contact.address = Console.ReadLine();

            Console.Write("Enter City Name : ");
            contact.city = Console.ReadLine();

            Console.Write("Enter state Name : ");
            contact.state = Console.ReadLine();

            Console.Write("Enter ZIP Code : ");
            contact.zipCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Phone Number : ");
            contact.phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Email Id : ");
            contact.email = Console.ReadLine();
            Console.WriteLine("\nContact Added Succesfully....!\n");
        }
    }
}
