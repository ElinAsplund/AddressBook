﻿using AddressBook.Services;

var menu = new Menu();
menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

menu.WelcomeMenu();