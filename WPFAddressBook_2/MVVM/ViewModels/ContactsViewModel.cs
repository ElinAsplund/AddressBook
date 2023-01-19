using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        public ContactsViewModel()
        {
            Contacts = ContactService.Get();
        }

        [ObservableProperty]
        private string pageTitle = "Contacts";

        [ObservableProperty]
        private string firstName = string.Empty;

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts;

        //[ObservableProperty]
        //private ContactModel contact = new ContactModel
        //{
        //    FirstName = "",
        //    LastName = "",
        //    PhoneNumber = "",
        //    Email = "",
        //    StreetName = "",
        //    PostalCode = "",
        //    City = ""
        //};

        [RelayCommand]
        private void AddContact()
        {
            var contact = new ContactModel
            {
                FirstName = FirstName,
                LastName = "",
                PhoneNumber = "",
                Email = "",
                StreetName = "",
                PostalCode = "",
                City = ""
            };

            ContactService.Add(contact);
            ClearForm();
        }

        private void ClearForm()
        {
            FirstName = "";
        }
    }
}
