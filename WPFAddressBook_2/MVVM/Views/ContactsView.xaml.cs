using System.Windows;
using System.Windows.Controls;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.MVVM.Views;

/// <summary>
/// Interaction logic for ContactsView.xaml
/// </summary>
public partial class ContactsView : UserControl
{
    public ContactsView()
    {
        InitializeComponent();
    }

    private void Btn_Remove_Click(object sender, RoutedEventArgs e)
    {
        var button = sender as Button;
        var contact = (ContactModel)button!.DataContext;

        if (MessageBox.Show("Är du säker på att du vill ta bort kontakten?",
            "Ta bort kontakt",
            MessageBoxButton.YesNo,
            MessageBoxImage.Warning) == MessageBoxResult.Yes)
        {
            ContactService.Remove(contact);
        }
    }

    //private void Btn_Edit_Click(object sender, RoutedEventArgs e)
    //{
        //var button = sender as Button;
        //var item = (ContactModel)button!.DataContext;

        //var mainViewModel = new MainViewModel();
        //mainViewModel.GoToDetails();

        //MainViewModel.GoToDetails();
    //}

    //private void ListView_Selected(object sender, RoutedEventArgs e)
    //{
    //    var listViewItem = sender as ListViewItem;
    //    var contact = (ContactModel)listViewItem!.DataContext;

    //    MessageBox.Show(contact.DisplayName);
    //}
}
