﻿using AddressBook.Models;
using Newtonsoft.Json;

namespace AddressBook.Services;

internal class Menu
{
    private List<Contact> contacts = new List<Contact>();
    private bool isRunning = true;
    private FileService file = new FileService();
    public string FilePath { get; set; } = null!;
    public void WelcomeMenu()
    {

        while (isRunning)
        {
            PopulateContactsList();
            Console.Clear();
            Console.WriteLine("-- Välkommen till ADRESSBOKEN! --\n");
            Console.WriteLine("1. Skapa en kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Visa detaljerad kontakt-information");
            Console.WriteLine("4. Ta bort en kontakt");
            Console.WriteLine("5. Avsluta adressboken\n");
            Console.Write("VÄLJ ett av alternativen ovan: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    OptionOne();
                    break;
                case "2":
                    OptionTwo();
                    break;
                case "3":
                    OptionThree();
                    break;
                case "4":
                    OptionFour();
                    break;
                case "5":
                    OptionFive();
                    break;
                default:
                    SwitchDefault();
                    break;
            }
        }
    }

    private void PopulateContactsList() 
    {
        try
        {
            var items = JsonConvert.DeserializeObject<List<Contact>>(file.Read(FilePath));

            if (items != null)
                contacts = items;
        }
        catch { }
    }
    private void OptionOne()
    {
        Console.Clear();
        Contact contact = new Contact();

        Console.WriteLine("-- SKAPA EN NY KONTAKT --\n");

        Console.Write("Ange förnamn: ");
        contact.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange efternamn: ");
        contact.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange telefonnummer: ");
        contact.PhoneNumber = Console.ReadLine() ?? "";

        Console.Write("Ange email: ");
        contact.Email = Console.ReadLine() ?? "";

        Console.WriteLine("-- ADRESS --");
        Console.Write("Ange gatuadress: ");
        contact.StreetName = Console.ReadLine() ?? "";

        Console.Write("Ange postkod: ");
        contact.PostalCode = Console.ReadLine() ?? "";

        Console.Write("Ange poststad: ");
        contact.City = Console.ReadLine() ?? "";

        contacts.Add(contact);
        file.Save(FilePath, JsonConvert.SerializeObject(contacts));
        Console.Write("\nKontakten är nu skapad!");

        Console.ReadKey();
    }
    private void OptionTwo()
    {
        Console.Clear();
        Console.WriteLine("-- ALLA KONTAKTER --\n");
        if (contacts.Count == 0)
        {
            Console.Write("Här finns inga kontakter just nu!\n\n(tryck på en valfri knapp för att komma vidare...)");
        }
        else
        {
            foreach (Contact contact in contacts) 
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.Email}>");
            }
        }
        Console.ReadKey();
    }
    private void OptionThree()
    {
        Console.Clear();
        Console.WriteLine("-- DETALJERAD KONTAKT-INFORMATION --\n");

        if (contacts.Count == 0)
        {
            Console.Write("Här finns inga kontakter just nu!\n\n(tryck på en valfri knapp för att komma vidare...)");
        }
        else
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.Email}>");
            }
            Console.Write("\nSkriv förnamnet på kontakten du vill se den detailjerade informationen om: ");
            var readFirstName = Console.ReadLine();
            Console.Clear();

            if(readFirstName != null && readFirstName != "")
            {
                string firstCapitalizedChar = makeCapitalizedFirstChar(readFirstName);

                var foundContact = contacts.FirstOrDefault(x => x.FirstName.ToLower() == readFirstName.ToLower());

                if(foundContact != null)
                {
                    Console.WriteLine($"-- LÅT MIG PRESENTERA! --\n");
                    Console.WriteLine($"Förnamn: {foundContact.FirstName}");
                    Console.WriteLine($"Efternamn: {foundContact.LastName}");
                    Console.WriteLine($"Email: {foundContact.Email}");
                    Console.WriteLine($"Telefonnummer: {foundContact.PhoneNumber}");
                    Console.WriteLine($"Adress: {foundContact.StreetName}, {foundContact.PostalCode} {foundContact.City}");
                }
                else
                {
                    Console.WriteLine("-- TOMT! --\n");
                    Console.WriteLine($"Ingen kontakt med namnet {firstCapitalizedChar} hittades!");
                }
            }
            else
            {
                ErrorMessege();
            }
        }
        Console.ReadKey();
    }
    private void OptionFour()
    {
        Console.Clear();
        Console.WriteLine("-- TA BORT EN KONTAKT --\n");

        if(contacts.Count == 0)
        {
            Console.Write("Här finns inget att ta bort!\n\n(tryck på en valfri knapp för att komma vidare...)");
            Console.ReadKey();
        }
        else
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.Email}>");
            }
            Console.Write("\nSkriv förnamnet på kontakten du vill ta bort: ");
            var readFirstName = Console.ReadLine();
            Console.Clear();

            if (readFirstName != null && readFirstName != "")
            {
                //string firstCapitalizedName = char.ToUpper(readFirstName.First()) + readFirstName.Substring(1).ToLower();
                string firstCapitalizedChar = makeCapitalizedFirstChar(readFirstName);

                var foundContact = contacts.FirstOrDefault(x => x.FirstName.ToLower() == readFirstName.ToLower());

                if (foundContact != null)
                {
                    contacts.Remove(foundContact);
                    file.Save(FilePath, JsonConvert.SerializeObject(contacts));
                    Console.WriteLine($"-- RADERAD --\n");
                    Console.WriteLine($"Kontakten med namnet {firstCapitalizedChar}, är nu borttagen!");
                }
                else
                {
                    Console.WriteLine("-- TOMT! --\n");
                    Console.WriteLine($"Kontakten med namnet: {firstCapitalizedChar} hittades inte i adressboken!");
                }
            }
            else
            {
                ErrorMessege();
            }

            Console.ReadKey();
        }
    }
    private void OptionFive()
    {
        Console.Clear();
        Console.WriteLine("             _________\r\n            / ======= \\\r\n           / __________\\\r\n          | ___________ |\r\n          | | -       | |\r\n          | |         | |\r\n          | |_________| |________________________\r\n          \\=____________/        BYE BYE! <3     )\r\n          / \"\"\"\"\"\"\"\"\"\"\" \\                       /\r\n         / ::::::::::::: \\                  =D-'\r\n        (_________________)");
        Console.WriteLine("\n           __..--''``---....___   _..._    __\r\n /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / // /\r\n///_.-' _..--.'_    \\                    `( ) ) // //\r\n/ (_..-' // (< _     ;_..__               ; `' / ///\r\n / // // //  `-._,_)' // / ``--...____..-' /// / //");
        Console.ReadKey();
        isRunning = false;
    }
    private void SwitchDefault()
    {
        Console.Clear();
        Console.WriteLine("-- OJ! NÅGOT GICK FEL --\n\nVänligen ange en SIFFRA 1-5!\n(tryck på en valfri knapp för att komma vidare...)");
        Console.ReadKey();
    }
    private void ErrorMessege()
    {
        Console.WriteLine("-- OJ! NÅGOT GICK FEL, FÖRSÖK IGEN --\n\n(tryck på en valfri knapp för att komma vidare...)");
    }
    private string makeCapitalizedFirstChar(string readString)
    {
        string firstCapitalizedFirstChar = char.ToUpper(readString.First()) + readString.Substring(1).ToLower();
        return firstCapitalizedFirstChar;
    }
}
