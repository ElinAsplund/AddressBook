using System.Windows;
using System.Windows.Controls;

namespace WPFAddressBook_2.MVVM.Views;

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
    }
    private void Btn_Hide_Click(object sender, RoutedEventArgs e)
    {
        //MyPopup.IsOpen = false;
    }
}
