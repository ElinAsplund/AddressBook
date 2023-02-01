using AddressBook.Models;
using AddressBook.Services;

namespace AddressBook.Tests;

public class AddressBook_Tests
{
    private MenuService menuService;
    private Contact contact;

    public AddressBook_Tests()
    {
        // arrange
        menuService = new MenuService();
        contact = new Contact();
    }
    
    [Fact]
    public void Should_Add_Contact_To_List()
    {
        // act
        menuService.contacts.Add(contact);

        // assert
        Assert.Single(menuService.contacts);
    }

    [Fact]
    public void Should_Remove_Contact_From_List()
    {
        // arrange
        menuService.contacts.Add(contact);
        menuService.contacts.Add(contact);

        // act
        menuService.contacts.Remove(contact);

        // assert
        Assert.Single(menuService.contacts);
    }
}