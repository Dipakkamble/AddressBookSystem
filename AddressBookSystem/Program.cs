using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system");
            Console.WriteLine("Enter the number from below option");
            Console.WriteLine("1:Create conatct\n2:Add contact\n3:Display contact");
            int option =Convert.ToInt32(Console.ReadLine());
            AddressBook addressBook = new AddressBook();
            switch (option) 
            {
                case 1:                    
                    addressBook.CreateContact();
                    break;
                case 2:
                    addressBook.AddContact();
                    break;
                case 3:
                    addressBook.DisplayContact();
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
