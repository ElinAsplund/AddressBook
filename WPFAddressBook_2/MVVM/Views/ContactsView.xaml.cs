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

        private void Btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var item = (ContactModel)button!.DataContext;

            if (MessageBox.Show("Är du säker på att du vill ta bort kontakten?",
                "Ta bort kontakt",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                ContactService.Remove(item);
            }
        }
    }
}
