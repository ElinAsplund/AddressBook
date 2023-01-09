using AddressBook.Models;

namespace AddressBook.Services;

internal class Menu
{
    private List<IContact> contacts = new List<IContact>();
    private bool isRunning = true;
    public void WelcomeMenu()
    {

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till ADRESSBOKEN!");
            Console.WriteLine("1. Skapa en kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Visa en specifik kontakt");
            Console.WriteLine("4. Ta bort en specifik kontakt");
            Console.WriteLine("5. Avsluta Adressboken");
            Console.Write("Välj ett av alternativen ovan: ");
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
                    isRunning= false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("SKRIV EN SIFFRA 1-5!");
                    Console.ReadKey();
                    WelcomeMenu();
                    break;
            }
        }
    }
    private void OptionOne()
    {
        Console.Clear();
        IContact contact = new Contact();

        Console.WriteLine("-- SKAPA EN NY KONTAKT --");

        Console.Write("Ange förnamn: ");
        contact.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange efternamn: ");
        contact.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange telefonnummer: ");
        contact.PhoneNumber = Console.ReadLine() ?? "";

        Console.Write("Ange email: ");
        contact.Email = Console.ReadLine() ?? "";

        Console.WriteLine("-- ADRESS --");
        Console.Write("Ange gatunamn: ");
        contact.StreetName = Console.ReadLine() ?? "";

        Console.Write("Ange gatunummer: ");
        contact.StreetNumber = Console.ReadLine() ?? "";

        Console.Write("Ange postkod: ");
        contact.PostalCode = Console.ReadLine() ?? "";

        Console.Write("Ange poststad: ");
        contact.City = Console.ReadLine() ?? "";

        var displayContact = contact.DisplayContact;
        var displayAddress = contact.DisplayAddress;

        Console.WriteLine($"\nDu har skapat kontakten: {displayContact}\nMed postadressen: {displayAddress}");

        contacts.Add(contact);
        Console.WriteLine("Första namnet i kontaktlistan: " + contacts[0].FirstName);

        Console.ReadKey();
    }

    private void OptionTwo()
    {
        Console.Clear();
        Console.WriteLine("-- ALLA KONTAKTER --");
        Console.ReadKey();
    }
    private void OptionThree()
    {
        Console.Clear();
        Console.WriteLine("-- EN SPECIFIK KONTAKT --");
        Console.ReadKey();
    }
    private void OptionFour()
    {
        Console.Clear();
        Console.WriteLine("-- TA BORT EN SPECIFIK KONTAKT --");
        Console.ReadKey();
    }
}
