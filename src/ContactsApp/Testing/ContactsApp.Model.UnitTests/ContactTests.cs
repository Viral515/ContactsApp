using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp;
using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        // Тесты ФИО
        [TestCase("", "Должно возникать исключение, если фио - пустая строка",
            TestName = "Присвоение пустой строки в качестве фио.")]
        [TestCase("СмирновСмирновСмирновСмирновСмирновСмирновСмирнов" +
            "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов", "Должно возникать" +
            "исключение, если фамилия болльше 100 символов",
            TestName = "Присвоение неправильного фио больше 100 символов.")]
        public void FullName_SetIncorrectValue_ThrowException(string wrongFullName, string message)
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            
            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                contact.FullName = wrongFullName; 
            }, message);
        }

        [Test(Description = "Присвоение корректного значения в поле фио")]
        public void FullName_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "Иванов Иван Иванович";
            contact.FullName = expected;

            // Act
            var actual = contact.FullName;
            
            // Assert
            Assert.AreEqual(expected, actual, "Значение фио установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера фио")]
        public void FullName_GetValue_ReturnsValue()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "Иванов Иван Иванович";
            contact.FullName = expected;
            
            // Act
            var actual = contact.FullName;
            
            // Assert
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение фио");
        }

        // Тесты email
        [TestCase("", "Должно возникать исключение, если email - пустая строка",
            TestName = "Присвоение пустой строки в качестве email.")]
        [TestCase("СмирновСмирновСмирновСмирновСмирновСмирновСмирнов" +
            "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов@bk.ru", 
            "Должно возникать исключение, если фамилия болльше 100 символов",
            TestName = "Присвоение неправильного email больше 100 символов.")]
        public void Email_SetIncorrectValue_ThrowException(string wrongEmail, string message)
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            
            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                contact.Email = wrongEmail; 
            }, message);
        }

        [Test(Description = "Присвоение корректного значения в поле email")]
        public void Email_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "Ivan123@mail.ru";
            contact.Email = expected;
            // Act
            var actual = contact.Email;
            
            // Assert
            Assert.AreEqual(expected, actual, "Значение email установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера email")]
        public void Email_GetValue_ReturnsValue()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "Ivan123@mail.ru";
            contact.Email = expected;
            
            // Act
            var actual = contact.Email;
            
            // Assert
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение email");
        }

        // Тесты номера телефона
        [TestCase("", "Должно возникать исключение, если номер телефона - пустая строка",
            TestName = "Присвоение пустой строки в качестве номера телефона.")]
        [TestCase("899999999999999999999999999999999999999999999999999" +
            "99999999999999999999999999999999999999999999999999",
            "Должно возникать исключение, если номер телефона болльше 100 символов",
            TestName = "Присвоение неправильного номера телефона больше 100 символов.")]
        [TestCase("номер телефона", "Должно возникать исключение, если номер телефона" +
            "содержит недопустимые символы", 
            TestName = "Присвоение неправильного номера телефона, содержащего недопустимые символы")]
        public void PhoneNumber_SetIncorrectValue_ThrowException(string wrongPhoneNumber, string message)
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");

            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                contact.PhoneNumber = wrongPhoneNumber; 
            }, message);
        }

        [Test(Description = "Позитивный тест сеттера номера телефона")]
        public void PhoneNumber_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "+7 (953)-924-28-53";
            contact.PhoneNumber = expected;

            // Act
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "Значение номера телефона установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера номера телефона")]
        public void PhoneNumber_GetValue_ReturnsValue()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "+7 (953)-924-28-53";
            contact.PhoneNumber = expected;
            
            // Act
            var actual = contact.PhoneNumber;
            
            // Assert
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение номера телефона");
        }

        // Тесты даты рождения
        [Test(Description = "Негативный тест сеттера даты")]
        public void DateOfBirth_SetIncorrectValueEarlyData_ThrowException()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            
            // Act
            var expected = new DateTime(1000, 1, 1);
            
            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                contact.DateOfBirth = expected; 
            }, "Должно возникать исключение, если дата раньше 1900г.");
        }

        [Test(Description = "Негативный тест сеттера даты")]
        public void DateOfBirth_SetIncorrectValueLateDate_ThrowException()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            
            // Act
            var expected = new DateTime(2048, 1, 1);
            
            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                contact.DateOfBirth = expected; 
            }, "Должно возникать исключение, если дата позже текущей.");
        }

        [Test(Description = "Позитивный тест сеттера даты")]
        public void DateOfBirth_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = DateTime.Today;
            contact.DateOfBirth = expected;
            
            // Act
            var actual = contact.DateOfBirth;
            
            // Assert
            Assert.AreEqual(expected, actual, "Значение email установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера даты")]
        public void DateOfBirth_GetValue_ReturnsValue()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = DateTime.Today;
            contact.DateOfBirth = expected;
            
            // Act
            var actual = contact.DateOfBirth;
            
            // Assert
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение email");
        }

        // Тесты idVK
        [TestCase("", "Должно возникать исключение, если полное IdVK - пустая строка",
            TestName = "Присвоение пустой строки в качестве IdVK")]
        [TestCase("01234567890123456789012345678901234567890123456789a",
            "Должно возникать исключение, если IdVK длиннее 50 символов",
            TestName = "Присвоение неправильного IdVK более 50 символов")]
        public void IdVk_SetUncorrectValue_ArgumentException(string wrongIdVK, string message)
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            
            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                contact.IdVK = wrongIdVK; 
            }, message);
        }

        [Test(Description = "Позитивный тест сеттера IdVK")]
        public void IdVK_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "123456";
            contact.IdVK = expected;
            
            // Act
            var actual = contact.IdVK;
            
            // Assert
            Assert.AreEqual(expected, actual, "Значение IdVK установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера IdVK")]
        public void IdVK_GetValue_ReturnsValue()
        {
            // Setup
            Contact contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");
            var expected = "123456";
            contact.IdVK = expected;
            
            // Act
            var actual = contact.IdVK;
            
            // Assert
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение IdVK");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_SetCorrectParameters_ReturnsCorrectValues()
        {
            // Setup
            var correctFullName = "Иванов Иван Иванович";
            var expectedFullName = correctFullName;
            var correctEmail = "Ivan123@mail.com";
            var expectedEmail = correctEmail;
            var correctPhoneNumber = "+7 (953)-924-28-53";
            var expectedPhoneNumber = correctPhoneNumber;
            var correctDateOfBirth = DateTime.Today;
            var expectedDateOfBirth = correctDateOfBirth;
            var correctVkId = "1234567890";
            var expectedVkId = correctVkId;
            Contact contact = new Contact(correctFullName, correctEmail, correctPhoneNumber, correctDateOfBirth, correctVkId);

            // Act
            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.IdVK;

            // Assert
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(expectedFullName, actualFullName);
                    Assert.AreEqual(expectedEmail, actualEmail);
                    Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
                    Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
                    Assert.AreEqual(expectedVkId, actualIdVk);
                }
                );
        }

        [Test(Description = "Негативный тест конструктора с параметрами")]
        public void Constructor_SetInvalidParameter_ArgumentException()
        {
            // Setup
            var wrongFullName = "СмирновСмирновСмирновСмирновСмирновСмирновСмирнов" +
            "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов";
            var message = "Должно возникать исключение, если имя содержит больше 100 символов";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                new Contact(wrongFullName, "Ivan123@mail.com", "+7 (953)-924-28-53",
                    DateTime.Today, "1234567890");
            },
            message);
        }
    }
}
