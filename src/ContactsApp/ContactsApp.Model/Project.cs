using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает проект
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов в проекте
        /// </summary>
        public List<Contact> Contacts = new List<Contact>();

        /// <summary>
        /// Сортирует список по полному имени
        /// </summary>
        /// <returns>Отсортированный список</returns>
        public List<Contact> SortByName() 
        {
            return Contacts.OrderBy(c => c.FullName).ToList();
        }
        /// <summary>
        /// Находит контакты у которых сегодня день рождения
        /// </summary>
        /// <returns>Список именинников</returns>
        public List<Contact> FindBirthday() 
        {
            DateTime today = DateTime.Now;
            List<Contact> result = new List<Contact>();
            foreach (Contact contact in Contacts) 
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
            foreach (Contact contact in Contacts) 
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
