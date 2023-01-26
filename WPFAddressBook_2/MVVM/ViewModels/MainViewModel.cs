using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private static ObservableObject currentViewModel = null!;

    [RelayCommand]
    public void GoToDetails()
    {
        CurrentViewModel = new DetailsViewModel();
    }
    
    [RelayCommand]
    public void GoToContacts()
    {
        CurrentViewModel= new ContactsViewModel();
    }

    [RelayCommand]
    public void GoToAddContact()
    {
        CurrentViewModel= new AddContactViewModel();
    }

    public MainViewModel()
    {
        CurrentViewModel = new ContactsViewModel();
    }
}
