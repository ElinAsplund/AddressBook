using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public MainWindow()
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
}
