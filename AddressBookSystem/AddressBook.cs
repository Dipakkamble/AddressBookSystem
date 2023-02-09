using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> contactList = new List<Contact>();
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
        public void AddContact()
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
            contactList.Add(contact);
            Console.WriteLine("\nContact Added Succesfully....!\n");

        }
            public void DisplayContact()
            {
                AddContact();
                foreach (Contact data in contactList)
                {
                    Console.WriteLine("Contact Details");
                    Console.WriteLine("1.Name: " + data.fName + " " + data.lName + "\n 2.Address: " + data.address + "\n 3.City: " + data.city + "\n 4.State: " + data.state + "\n 5.Zipcode: " + data.zipCode + " 6.EMAIL:  " + data.email + "\n 7.PhoneNumber: " + data.phoneNumber);
                }
            }
        
    }
}
