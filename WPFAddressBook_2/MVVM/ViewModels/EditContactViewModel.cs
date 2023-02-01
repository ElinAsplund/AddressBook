using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.ViewModels;

public partial class EditContactViewModel : ObservableObject
{
    private ContactModel oldContact = null!;

    [ObservableProperty]
    private string firstName = string.Empty;

    [ObservableProperty]
    private string lastName = string.Empty;

    [ObservableProperty]
    private string phoneNumber = string.Empty;

    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    private string streetName = string.Empty;

    [ObservableProperty]
    private string postalCode = string.Empty;

    [ObservableProperty]
    private string city = string.Empty;

    public EditContactViewModel()
    {

    }

    public EditContactViewModel(ContactModel contact)
    {
        firstName = contact.FirstName;
        lastName = contact.LastName;
        phoneNumber = contact.PhoneNumber;
        email = contact.Email;
        streetName = contact.StreetName;
        postalCode = contact.PostalCode;
        city = contact.City;

        oldContact = new ContactModel
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            PhoneNumber = contact.PhoneNumber,
            Email = contact.Email,
            StreetName = contact.StreetName,
            PostalCode = contact.PostalCode,
            City = contact.City
        };
    }

    [RelayCommand]
    private void SaveEdits()
    {
        ContactModel updatedContact = new ContactModel
        {
            Id = oldContact.Id,
            FirstName = FirstName,
            LastName = LastName,
            PhoneNumber = PhoneNumber,
            Email = Email,
            StreetName = StreetName,
            PostalCode = PostalCode,
            City = City
        };

        ContactService.Edit(updatedContact);
    }
}
