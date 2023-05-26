using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    internal class ProjectTests
    {
        //private Project _project = new Project();
        [Test(Description = "Позитивный тест для сортировки контактов в проекте")]
        public void SortByName_SortingContacts_ListIsSorted()
        {
            var project = new Project();
            var contact1 = new Contact("Петров Петр", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expectedFullName2 = contact1.FullName;
            var contact2 = new Contact("Иванов Иван", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expectedFullName1 = contact2.FullName;
            var contact3 = new Contact("Сидоров Сергей", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expectedFullName3 = contact3.FullName;

            project.Contacts.Add(contact1);
            project.Contacts.Add(contact2);
            project.Contacts.Add(contact3);
            var sortedContacts = project.SortByName();
            var actualFullName1 = sortedContacts[0].FullName;
            var actualFullName2 = sortedContacts[1].FullName;
            var actualFullName3 = sortedContacts[2].FullName;

            Assert.Multiple(
               () =>
               {
                   Assert.AreEqual(expectedFullName1, actualFullName1);
                   Assert.AreEqual(expectedFullName2, actualFullName2);
                   Assert.AreEqual(expectedFullName3, actualFullName3);
               }
               );
        }

        [Test(Description = "Позитивный тест поиска именинников")]
        public void FindBirthdayContact_FindContact_ReturnTrueValue()
        {
            var project = new Project();
            var contact1 = new Contact("Петров Петр", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expectedContact = contact1;
            var contact2 = new Contact("Иванов Иван", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000,1,1), "1111121");
            var contact3 = new Contact("Сидоров Сергей", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000,1,1), "1111121");

            project.Contacts.Add(contact1);
            project.Contacts.Add(contact2);
            project.Contacts.Add(contact3);
            var findedContacts = project.FindBirthdayContact();
            var actualContact = findedContacts[0];

            Assert.AreEqual(expectedContact, actualContact);
        }

        [Test(Description = "Позитивный тест поиска контакта по подстроке")]
        public void Search_FindContact_ReturnTrueValue()
        {
            var project = new Project();
            var contact1 = new Contact("Петров Петр", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var contact2 = new Contact("Иванов Иван", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000, 1, 1), "1111121");
            var expectedContact = contact2;
            var contact3 = new Contact("Сидоров Сергей", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000, 1, 1), "1111121");

            project.Contacts.Add(contact1);
            project.Contacts.Add(contact2);
            project.Contacts.Add(contact3);
            var findedContacts = project.Search("Иван");
            var actualContact = findedContacts[0];

            Assert.AreEqual(expectedContact, actualContact);
        }
    }
}
