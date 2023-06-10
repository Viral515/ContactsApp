using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using System.Diagnostics.Contracts;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    internal class ProjectTests
    {
        [Test(Description = "Позитивный тест для сортировки контактов в проекте")]
        public void SortByName_SortingContacts_ListIsSorted()
        {
            // Setup
            var project = new Project();
            Contact[] contacts = new Contact[3];
            contacts[0] = new Contact("Петров Петр", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            contacts[1] = new Contact("Иванов Иван", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            contacts[2] = new Contact("Сидоров Сергей", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            string[] expectedFullNames = new string[contacts.Count()];
            expectedFullNames[0] = contacts[1].FullName;
            expectedFullNames[1] = contacts[0].FullName;
            expectedFullNames[2] = contacts[2].FullName;

            // Act
            for (int i = 0; i < contacts.Count(); i++)
            {
                project.Contacts.Add(contacts[i]);
            }
            var sortedContacts = project.SortByName();
            string[] actualFullNames = new string[contacts.Count()];
            
            // Assert
            for (int i = 0; i < contacts.Count(); i++)
            {
                actualFullNames[i] = sortedContacts[i].FullName;
                Assert.AreEqual(expectedFullNames[i], actualFullNames[i]);
            }
        }

        [Test(Description = "Позитивный тест поиска именинников")]
        public void FindBirthdayContact_FindContact_ReturnTrueValue()
        {
            // Setup
            var project = new Project();
            var contact1 = new Contact("Петров Петр", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expectedContact = contact1;
            var contact2 = new Contact("Иванов Иван", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000,1,1), "1111121");
            var contact3 = new Contact("Сидоров Сергей", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000,1,1), "1111121");

            // Act
            project.Contacts.Add(contact1);
            project.Contacts.Add(contact2);
            project.Contacts.Add(contact3);
            var findedContacts = project.FindBirthdayContact(DateTime.Today);
            var actualContact = findedContacts[0];

            // Assert
            Assert.AreEqual(expectedContact, actualContact);
        }

        [Test(Description = "Позитивный тест поиска контакта по подстроке")]
        public void Search_FindContact_ReturnTrueValue()
        {
            // Setup
            var project = new Project();
            var contact1 = new Contact("Петров Петр", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var contact2 = new Contact("Иванов Иван", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000, 1, 1), "1111121");
            var expectedContact = contact2;
            var contact3 = new Contact("Сидоров Сергей", "qwe@gmail.com",
            "+7(913)-111-22-33", new DateTime(2000, 1, 1), "1111121");
            
            // Act            
            project.Contacts.Add(contact1);
            project.Contacts.Add(contact2);
            project.Contacts.Add(contact3);
            var findedContacts = project.FindContact("Иван");
            var actualContact = findedContacts[0];

            // Assert
            Assert.AreEqual(expectedContact, actualContact);
        }
    }
}
