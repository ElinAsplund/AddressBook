using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAddressBook_2.MVVM.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        [RelayCommand]
        private void GoToDetails()
        {
            CurrentViewModel = new DetailsViewModel();
        }
        
        [RelayCommand]
        private void GoToContacts()
        {
            CurrentViewModel= new ContactsViewModel();
        }

        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel();
        }
    }
}
