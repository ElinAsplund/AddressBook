using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.ViewModels;
public partial class AddContactViewModel : ObservableObject
{
    public AddContactViewModel()
    {
        Contacts = ContactService.Get();
    }

    [ObservableProperty]
    private string firstName = "Hej";

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

    [RelayCommand]
    private void AddContact()
    {
        var contact = new ContactModel
        {
            FirstName = FirstName,
            LastName = LastName,
            PhoneNumber = PhoneNumber,
            Email = Email,
            StreetName = StreetName,
            PostalCode = PostalCode,
            City = City
        };

        ContactService.Add(contact);
        ClearForm();
    }

    private void ClearForm()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        PhoneNumber = string.Empty;
        Email = string.Empty;
        StreetName = string.Empty;
        PostalCode = string.Empty;    
        City = string.Empty;
    }
}