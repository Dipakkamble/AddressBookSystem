using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Contact
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public long zipCode { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }

    }
}
