using System;
using System.Collections.Generic;
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

namespace WPFAddressBook_2.MVVM.Views
{
    /// <summary>
    /// Interaction logic for DetailsView.xaml
    /// </summary>
    public partial class DetailsView : UserControl
    {
        public DetailsView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MyPopup.IsOpen = true;

            //if (MessageBox.Show("If the file save fails, do you want to automatically try again?",
            //        "Save file",
            //        MessageBoxButton.YesNo,
            //        MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    // Do something here
            //}
        }
        private void Btn_Hide_Click(object sender, RoutedEventArgs e)
        {
            //MyPopup.IsOpen = false;
        }
    }
}
