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
        private Contact _contact = new Contact("Mike Wazovsky", "qwe@gmail.com",
            "+7(913)-111-22-33", DateTime.Today, "1111121");

        //Тесты ФИО
        [TestCase("", "Должно возникать исключение, если фио - пустая строка",
            TestName = "Присвоение пустой строки в качестве фио.")]
        [TestCase("СмирновСмирновСмирновСмирновСмирновСмирновСмирнов" +
            "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов", "Должно возникать" +
            "исключение, если фамилия болльше 100 символов",
            TestName = "Присвоение неправильного фио больше 100 символов.")]
        public void FullName_SetIncorrectValue_ThrowException(string wrongFullName, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.FullName = wrongFullName; }, message);
        }

        [Test(Description = "Присвоение корректного значения в поле фио")]
        public void FullName_SetCorrectValue_ValueIsSetted()
        {
            var excpected = "Иванов Иван Иванович";
            _contact.FullName = excpected;
            var actual = _contact.FullName;
            Assert.AreEqual(excpected, actual, "Значение фио установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера фио")]
        public void FullName_GetValue_ReturnsValue()
        {
            var expected = "Иванов Иван Иванович";
            _contact.FullName = expected;
            var actual = _contact.FullName;
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение фио");
        }

        //Тесты email
        [TestCase("", "Должно возникать исключение, если email - пустая строка",
            TestName = "Присвоение пустой строки в качестве email.")]
        [TestCase("СмирновСмирновСмирновСмирновСмирновСмирновСмирнов" +
            "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов@bk.ru", 
            "Должно возникать исключение, если фамилия болльше 100 символов",
            TestName = "Присвоение неправильного email больше 100 символов.")]
        public void Email_SetIncorrectValue_ThrowException(string wrongEmail, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.Email = wrongEmail; }, message);
        }

        [Test(Description = "Присвоение корректного значения в поле email")]
        public void Email_SetCorrectValue_ValueIsSetted()
        {
            var excpected = "Ivan123@mail.ru";
            _contact.Email = excpected;
            var actual = _contact.Email;
            Assert.AreEqual(excpected, actual, "Значение email установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера email")]
        public void Email_GetValue_ReturnsValue()
        {
            var expected = "Ivan123@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение email");
        }

        //Тесты номера телефона
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
            Assert.Throws<ArgumentException>(() => { _contact.PhoneNumber = wrongPhoneNumber; }, message);
        }

        [Test(Description = "Позитивный тест сеттера номера телефона")]
        public void PhoneNumber_SetCorrectValue_ValueIsSetted()
        {
            var excpected = "+7 (953)-924-28-53";
            _contact.PhoneNumber = excpected;
            var actual = _contact.PhoneNumber;
            Assert.AreEqual(excpected, actual, "Значение номера телефона установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера номера телефона")]
        public void PhoneNumber_GetValue_ReturnsValue()
        {
            var expected = "+7 (953)-924-28-53";
            _contact.PhoneNumber = expected;
            var actual = _contact.PhoneNumber;
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение номера телефона");
        }

        //Тесты даты рождения
        [Test(Description = "Негативный тест сеттера даты")]
        public void DateOfBirth_SetIncorrectValueEarlyData_ThrowException()
        {
            var excpected = new DateTime(1000, 1, 1);
            Assert.Throws<ArgumentException>(() => { _contact.DateOfBirth = excpected; }, "Должно возникать" +
                "исключение, если дата раньше 1900г.");
        }
        [Test(Description = "Негативный тест сеттера даты")]
        public void DateOfBirth_SetIncorrectValueLateDate_ThrowException()
        {
            var excpected = new DateTime(2048, 1, 1);
            Assert.Throws<ArgumentException>(() => { _contact.DateOfBirth = excpected; }, "Должно возникать" +
                "исключение, если дата позже текущей.");
        }

        [Test(Description = "Позитивный тест сеттера даты")]
        public void DateOfBirth_SetCorrectValue_ValueIsSetted()
        {
            var excpected = DateTime.Today;
            _contact.DateOfBirth = excpected;
            var actual = _contact.DateOfBirth;
            Assert.AreEqual(excpected, actual, "Значение email установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера даты")]
        public void DateOfBirth_GetValue_ReturnsValue()
        {
            var expected = DateTime.Today;
            _contact.DateOfBirth = expected;
            var actual = _contact.DateOfBirth;
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение email");
        }

        //Тесты idVK
        [TestCase("", "Должно возникать исключение, если полное IdVK - пустая строка",
            TestName = "Присвоение пустой строки в качестве IdVK")]
        [TestCase("01234567890123456789012345678901234567890123456789a",
            "Должно возникать исключение, если IdVK длиннее 50 символов",
            TestName = "Присвоение неправильного IdVK более 50 символов")]
        public void IdVk_SetUncorrectValue_ArgumentException(string wrongIdVK, string message)
        {
            Assert.Throws<ArgumentException>(() => { _contact.IdVK = wrongIdVK; }, message);
        }
        [Test(Description = "Позитивный тест сеттера IdVK")]
        public void IdVK_SetCorrectValue_ValueIsSetted()
        {
            var excpected = "123456";
            _contact.IdVK = excpected;
            var actual = _contact.IdVK;
            Assert.AreEqual(excpected, actual, "Значение IdVK установлено неправильно");
        }

        [Test(Description = "Позитивный тест геттера IdVK")]
        public void IdVK_GetValue_ReturnsValue()
        {
            var expected = "123456";
            _contact.IdVK = expected;
            var actual = _contact.IdVK;
            Assert.AreEqual(expected, actual, "Возвращается неправильное значение IdVK");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_SetCorrectParameters_ReturnsCorrectValues()
        {
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

            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.IdVK;

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
            var wrongFullName = "СмирновСмирновСмирновСмирновСмирновСмирновСмирнов" +
            "СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов";
            var message = "Должно возникать исключение, если имя содержит больше 100 символов";

            Assert.Throws<ArgumentException>(() =>
            {
                new Contact(wrongFullName, "Ivan123@mail.com", "+7 (953)-924-28-53", DateTime.Today, "1234567890");
            },
            message);
        }
    }
}
