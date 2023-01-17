using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAddressBook.MVVM.ViewModels;
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableObject currentViewModel;

    public MainViewModel()
    {
        CurrentViewModel = new ContactsViewModel();
    }
}
