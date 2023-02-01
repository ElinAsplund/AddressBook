using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.ViewModels;

public partial class ContactsViewModel : ObservableObject
{
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

    [ObservableProperty]
    private ObservableCollection<ContactModel> contacts = null!;

    public ContactsViewModel()
    {

    }

    public ContactsViewModel(ContactModel selectedContact)
    {
        firstName = selectedContact.FirstName;
        lastName = selectedContact.LastName;
        phoneNumber = selectedContact.PhoneNumber;
        email = selectedContact.Email;
        streetName = selectedContact.StreetName;
        postalCode = selectedContact.PostalCode;
        city = selectedContact.City;
    }
}
