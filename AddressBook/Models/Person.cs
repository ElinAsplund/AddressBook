using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Interfaces;

namespace AddressBook.Models
{
    internal class Person : IPerson
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
