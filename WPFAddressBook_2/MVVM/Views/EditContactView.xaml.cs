﻿using System;
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
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;


namespace WPFAddressBook_2.MVVM.Views;

/// <summary>
/// Interaction logic for EditContactView.xaml
/// </summary>
public partial class EditContactView : UserControl
{
    public EditContactView()
    {
        InitializeComponent();
    }
}