using FluentAssertions;
using WPFAddressBook_2.MVVM.Models;
using WPFAddressBook_2.Services;

namespace WPFAddressBook_2.Tests
{
    public class ContactService_Tests
    {
        [Fact]
        public void Should_Edit_Contact_In_List()
        {
            //arrange
            ContactModel testContact = new ContactModel { Id = new Guid("c2e79aae-411e-4938-a9d3-18cbb2ee0b47"), FirstName = "Charlotta" };
            ContactService.Add(testContact);
            int currentCount = ContactService.contacts.Count;

            //act
            ContactModel editedTestContact = new ContactModel { Id = new Guid("c2e79aae-411e-4938-a9d3-18cbb2ee0b47"), FirstName = "Lotta" };
            ContactService.Edit(editedTestContact);

            //assert
            Assert.Equal(currentCount, ContactService.contacts.Count);
            ContactService.contacts.Should().Contain(editedTestContact);

            //cleanup
            ContactService.Remove(editedTestContact);
        }
    }
}