using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using WPFAddressBook.Models;
using WPFAddressBook.Services;

namespace WPFAddressBook;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// HÄR MAN MAN SKRIVA BESKRIVNING AV MAINWINDOW
/// </summary>
public partial class MainWindow : Window
{
    private ObservableCollection<Contact> contacts = new();
    private readonly FileService file = new ();

    public MainWindow()
    {
        //KONSTRUCTORN (public MainWindow): VÄRDEM SÄTTS NÄR PROGRAMMET STARTAS
        InitializeComponent();
        file.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
        PopulateContactsList();
    }

    private void PopulateContactsList()
    {
        try
        {
            var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read());
            if (items != null)
                contacts = items;
        }
        catch { }

        lv_Contacts.ItemsSource = contacts;
    }

    private void Btn_Add_Click(object sender, RoutedEventArgs e)
    {
        var contact = new Contact
        {
            FirstName = tb_FirstName.Text,
            LastName = tb_LastName.Text,
            PhoneNumber = tb_PhoneNumber.Text,
            Email = tb_Email.Text,
            StreetName = tb_SteetName.Text,
            PostalCode = tb_PostalCode.Text,
            City = tb_City.Text
        };

        contacts.Add(contact);

        file.Save(JsonConvert.SerializeObject(contacts));
        ClearForm();
    }
    private void ClearForm()
    {
        tb_FirstName.Text = "";
        tb_LastName.Text = "";
        tb_PhoneNumber.Text = "";
        tb_Email.Text = "";
        tb_SteetName.Text = "";
        tb_PostalCode.Text = "";
        tb_City.Text = "";
    }
}
