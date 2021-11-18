using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class StartContact // This Model Class is Only Responisible for Changing Purpose
    {
        internal class Contact
        {
            public string FirstName { get; internal set; }
            public string LastName { get; internal set; }
            public string Address { get; internal set; }
            public string City { get; internal set; }
            public string State { get; internal set; }
            public string Zip { get; internal set; }
            public string PhoneNumber { get; internal set; }
            public string Email { get; internal set; }
        }
    }
}