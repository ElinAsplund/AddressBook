using System.Collections.ObjectModel;
using WPFAddressBook_2.MVVM.Models;

namespace WPFAddressBook_2.Services;

public static class ContactService
{
    private static FileService fileService;
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

    public static ObservableCollection<ContactModel> Get()
    {
        return contacts;
    }
}
