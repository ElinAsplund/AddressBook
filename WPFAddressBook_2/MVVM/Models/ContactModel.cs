﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAddressBook_2.MVVM.Models;

internal interface IContact
{
    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string PhoneNumber { get; set; }
    string Email { get; set; }

    //Address-info
    string StreetName { get; set; }
    string PostalCode { get; set; }
    string City { get; set; }
}

internal class ContactModel : IContact
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public string DisplayName => $"{FirstName} {LastName}";
}
