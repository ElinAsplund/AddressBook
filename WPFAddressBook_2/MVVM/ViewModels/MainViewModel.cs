using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{

    [ObservableProperty]
    private ObservableCollection<ContactModel> contacts = null!;

    [ObservableProperty]
    private static ObservableObject currentViewModel = null!;

    [ObservableProperty]
    public ContactModel selectedContact;

    [RelayCommand]
    public void GoToDetails(object sender)
    {
        var contact = sender as ContactModel;

        if (contact != null)
            CurrentViewModel = new DetailsViewModel(contact);
        else
            CurrentViewModel = new DetailsViewModel();
    }

    [RelayCommand]
    public void GoToContacts()
    {
        if (selectedContact != null)
            CurrentViewModel= new ContactsViewModel(selectedContact);
        else
            CurrentViewModel = new ContactsViewModel();
    }

    [RelayCommand]
    public void GoToAddContact()
    {
        CurrentViewModel= new AddContactViewModel();
    }

    public MainViewModel()
    {
        CurrentViewModel = new ContactsViewModel();
        Contacts = ContactService.Get();
    }
}
