using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает проект
    /// </summary>
    internal class Project
    {
        /// <summary>
        /// Список контактов в проекте
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Добавляет контакт в список
        /// </summary>
        /// <param name="contact">Новый контакт, который необходимо добавить в список</param>
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        /// <summary>
        /// Удаляет контакт из списка
        /// </summary>
        /// <param name="email">Email удаляемого контакта</param>
        /// <returns>Логическая переменная обозначающая удалился ли данный контакт</returns>
        public bool RemoveContact(string email)
        {
            foreach (Contact contact in _contacts) 
            {
                if (contact.Email == email)
                {
                    _contacts.Remove(contact);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Сортирует список по полному имени
        /// </summary>
        /// <returns>Отсортированный список</returns>
        public List<Contact> SortByName() 
        {
            return _contacts.OrderBy(c => c.FullName).ToList();
        }
        /// <summary>
        /// Находит контакты у которых сегодня день рождения
        /// </summary>
        /// <returns>Список именинников</returns>
        public List<Contact> FindBirthday() 
        {
            DateTime today = DateTime.Now;
            List<Contact> result = new List<Contact>();
            foreach (Contact contact in _contacts) 
            {
                if ((contact.DateOfBirth.Month == today.Month) && (contact.DateOfBirth.Day == today.Day))
                {
                    result.Add(contact);
                }
            }
            return result;
        }
        /// <summary>
        /// Выполняет поиск по подстроке имени, номера или email'а
        /// </summary>
        /// <param name="substring">Подстрока имени, номера или email'а</param>
        /// <returns>Список найденных контактов</returns>
        public List<Contact> Search(string substring)
        {
            List<Contact> result = new List<Contact>();
            foreach (Contact contact in _contacts) 
            {
                if (contact.FullName.Contains(substring) || contact.PhoneNumber.Contains(substring) ||
                    contact.Email.Contains(substring))
                {
                    result.Add(contact);
                }
            }
            return result;
        }
    }
}
