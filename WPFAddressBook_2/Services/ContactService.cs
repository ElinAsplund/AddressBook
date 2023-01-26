using System.Collections.ObjectModel;
using System.Linq;
using WPFAddressBook_2.MVVM.Models;

namespace WPFAddressBook_2.Services;

public static class ContactService
{
    private static FileService fileService;

    //ÄR DESSA SAMMA LISTA? -> CONTACTSVIEWMODEL
    private static ObservableCollection<ContactModel> contacts;

    static ContactService()
    {
        fileService = new FileService();
        contacts = fileService.ReadFromFile();
    }

    public static void Add(ContactModel contact)
    {
        contacts.Add(contact);
        fileService.SaveToFile(contacts);
    }

    public static void Remove(ContactModel contact)
    {
        contacts.Remove(contact);
        fileService.SaveToFile(contacts);
    }
    
    public static void Edit(ContactModel selectedContact)
    {
        if (selectedContact != null)
        {
            //sök efter kontankt som matchar selectedContact
            ContactModel foundContact = contacts.FirstOrDefault(x => x.Id == selectedContact.Id)!;

            //ta bort gamla kontakten som hittas
            if(foundContact != null)
                Remove(foundContact);

            //spara ny kontakt (selectedContact) i contacts
            Add(selectedContact);

            fileService.SaveToFile(contacts);
        }
    }

    public static ObservableCollection<ContactModel> Get()
    {
        return contacts;
    }
}
