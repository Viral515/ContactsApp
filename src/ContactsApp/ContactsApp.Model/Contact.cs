using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Максимальный размер текста для полей имени и почты
        /// </summary>
        private const int _maxTextLength = 100;
        /// <summary>
        /// Максимальный размер текста для поля idVK
        /// </summary>
        private const int _maxTextIDLength = 50;
        /// <summary>
        /// Фамилия и имя контакта
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Адрес электронной почты контакта
        /// </summary>
        private string _email;
        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _dateOfBirth;
        /// <summary>
        /// ID аккаунта VK контакта
        /// </summary>
        private string _idVK;

        /// <summary>
        /// Возвращает или задаёт фамилию и имя контакта
        /// </summary>
        public string FullName
        { 
            get 
            { 
                return _fullName; 
            } 
            set 
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException($"The full name text must be greater than 0 characters.");
                }
                if (value.Length > _maxTextLength)
                {
                    throw new ArgumentException($"The full name text must be less than {_maxTextLength} characters.");
                }
                string fullNameString = value;
                string[] fullName = fullNameString.Split(' ');
                foreach (string s in fullName) 
                {
                    fullNameString += char.ToUpper(s[0]) + s.Substring(1) + ' ';
                }
                _fullName = fullNameString;
            } 
        }
        /// <summary>
        /// Возвращает или задаёт электронную почту контакта
        /// </summary>
        public string Email
        { 
            get 
            { 
                return _email; 
            } 
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException($"The email text must be greater than 0 characters.");
                }
                if (value.Length > _maxTextLength)
                {
                    throw new ArgumentException($"The email text must be less than {_maxTextLength} characters.");
                }
                _email = value; 
            } 
        }
        /// <summary>
        /// Возвращает или задаёт номер телефона контакта
        /// </summary>
        public string PhoneNumber
        { 
            get 
            { 
                return _phoneNumber; 
            } 
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException($"The phone number text must be greater than 0 characters.");
                }
                if (value.Length > _maxTextLength)
                {
                    throw new ArgumentException($"The phone number text must be less than " +
                        $"{_maxTextLength} characters.");
                }
                if (Regex.IsMatch(value, @"^[0-9()+\- ]+$") != true)
                {
                    throw new ArgumentException($"The expression (phone number) contains invalid symbols.");
                }
                _phoneNumber = value;
            } 
        }
        /// <summary>
        /// Возвращает или задаёт дату рождения контакта
        /// </summary>
        public DateTime DateOfBirth
        { 
            get 
            { 
                return _dateOfBirth; 
            }
            set
            {
                if ((value > new DateTime(1900, 1, 1)) && (value < DateTime.Now))
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException($"An uncorrected date value has been entered.");
                }
            }
        }
        /// <summary>
        /// Возвращает или задаёт ID VK контакта
        /// </summary>
        public string IdVK
        { 
            get 
            { 
                return _idVK; 
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException($"The idVK text must be greater than 0 characters.");
                }
                if (value.Length > _maxTextIDLength)
                {
                    throw new ArgumentException($"The idVK text must be less than {_maxTextIDLength} characters.");
                }
                _idVK = value;
            } 
        }

        /// <summary>
        /// Создаёт экземпляр <see cref="Contact">
        /// </summary>
        /// <param name="fullName">фамилия и имя контакта</param>
        /// <param name="email">электронная почта</param>
        /// <param name="phoneNumber">номер телефона</param>
        /// <param name="dateOfBirth">дата рождения</param>
        /// <param name="idVK">ссылка на ВК</param>
        public Contact (string fullName, string email, string phoneNumber, DateTime dateOfBirth, string idVK)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            IdVK = idVK;
        }
        /// <summary>
        /// Клонирует контакт
        /// </summary>
        /// <returns>Клон объекта контакт</returns>
        public object Clone()
        {
            return new Contact(_fullName, _email, _phoneNumber, _dateOfBirth, _idVK);
        }
    }
}
