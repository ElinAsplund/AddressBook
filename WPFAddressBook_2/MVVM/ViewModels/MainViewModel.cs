using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAddressBook_2.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private static ObservableObject currentViewModel;

        [RelayCommand]
        public void GoToDetails()
        {
            CurrentViewModel = new DetailsViewModel();
        }
        
        [RelayCommand]
        public void GoToContacts()
        {
            CurrentViewModel= new ContactsViewModel(this);
        }

        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel(this);
        }
    }
}
