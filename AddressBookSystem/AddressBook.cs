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
        public void EditContact()
        {
            DisplayContact();
            Console.WriteLine("\nTo Edit Contact Enter First Name\n");
            string name = Console.ReadLine();
            foreach (Contact data in contactList)
            {
                if (data.fName == name)
                {
                    Console.WriteLine("Contact Found...Enter the option to Edit the Contact: ");
                    Console.WriteLine("\n1:to Change First name \n2:to Change Last name \n3:to Change Address  \n4:to Change City  \n5:to Change State  \n6:to Change Zip  \n7:to Change Phonenumber  \n8:to Change Email \n9:Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the New First Name: ");
                            data.fName = Console.ReadLine();
                            DisplayContact();
                            break;
                        case 2:
                            Console.WriteLine("Enter the New Last Name: ");
                            data.lName = Console.ReadLine();
                            DisplayContact();
                            break;
                        case 3:
                            Console.WriteLine("Enter the New Address: ");
                            data.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the New City: ");
                            data.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the New State: ");
                            data.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the New Pin Code: ");
                            data.zipCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter the New Phone Number: ");
                            data.phoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter the New Email: ");
                            data.email = Console.ReadLine();
                            break;
                        case 9:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Contact Not Found. Enter the valid name!");
                }
            }
        }
            
            public void DeleteContact()
            {
                DisplayContact();           
                Console.WriteLine("\nEnter the First name to delete the contact ");
                string name = Console.ReadLine();
            foreach (Contact data in contactList)
            {
                    if (data.fName == name)
                    {
                        contactList.Remove(data);
                        Console.WriteLine("Contact deleted successfully...!");
                    }
                    else
                    {
                        Console.WriteLine("Contact is not present");
                    }
            }
            }

        



        public void DisplayContact()
            {
                AddContact();
                foreach (Contact data in contactList)
                {
                    Console.WriteLine("Contact Details");
                    Console.WriteLine("1.Name: " + data.fName + " " + data.lName + "\n2.Address: " + data.address + "\n3.City: " + data.city + "\n4.State: " + data.state + "\n5.Zipcode: " + data.zipCode + " \n6.EMAIL:  " + data.email + "\n7.PhoneNumber: " + data.phoneNumber);
                }
            }
        
    }
}
