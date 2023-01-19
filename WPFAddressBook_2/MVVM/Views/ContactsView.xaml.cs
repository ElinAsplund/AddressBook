using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {

       

        public ContactsView()
        {
            InitializeComponent();
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var item = (ContactModel)button!.DataContext;
            ContactService.Remove(item);
           
        }

        //private ObservableCollection<ContactModel> contacts = new();
        //private readonly FileService file = new();
        //public ContactsView()
        //{
        //    InitializeComponent();
        //    file.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
        //    PopulateContactsList();
        //}

        //private void PopulateContactsList()
        //{
        //    try
        //    {
        //        var items = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(file.Read());
        //        if (items != null)
        //            contacts = items;
        //    }
        //    catch { }

        //    lv_Contacts.ItemsSource = contacts;
        //}

        //private void Btn_Add_Click(object sender, RoutedEventArgs e)
        //{
        //    var contact = new ContactModel
        //    {
        //        FirstName = tb_FirstName.Text,
        //        LastName = tb_LastName.Text,
        //        PhoneNumber = tb_PhoneNumber.Text,
        //        Email = tb_Email.Text,
        //        StreetName = tb_SteetName.Text,
        //        PostalCode = tb_PostalCode.Text,
        //        City = tb_City.Text
        //    };

        //    contacts.Add(contact);

        //    file.Save(JsonConvert.SerializeObject(contacts));
        //    ClearForm();
        //}
        //private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        //{
        //    //FILTRERA UT EN ANVÄNDARE! Vad ska man grabba tag i?
        //    //var contact = contacts.FirstOrDefault(x => x.clicked_tblock_DisplayName.text.ToLower() == DisplayName.ToLower);

        //      var button = sender as Button;
        //      var item = (CantactModel)button!.DataContext;
        //    //contacts.Remove(contact);

        //    file.Save(JsonConvert.SerializeObject(contacts));
        //    ClearForm();
        //}
        //private void ClearForm()
        //{
        //    tb_FirstName.Text = "";
        //    tb_LastName.Text = "";
        //    tb_PhoneNumber.Text = "";
        //    tb_Email.Text = "";
        //    tb_SteetName.Text = "";
        //    tb_PostalCode.Text = "";
        //    tb_City.Text = "";
        //}
    }
}
