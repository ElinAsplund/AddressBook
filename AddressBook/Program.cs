using AddressBook.Services;

var menu = new MenuService();
menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

menu.WelcomeMenu();