using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Класс главной формы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект проекта
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Объект менеджера проекта
        /// </summary>
        private ProjectManager _projectManager = new ProjectManager();

        /// <summary>
        /// Список отображаемых на форме контактов
        /// </summary>
        private List<Contact> _displayContacts;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public MainForm()
        {
            InitializeComponent(); 
            _project = _projectManager.LoadProject();
            UpdateListBox();
        }

        /// <summary>
        /// Обновляет список контактов на форме
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            _project.Contacts = _project.SortByName();
            if (FindTextBox.Text != "")
            {
                _displayContacts = _project.Search(FindTextBox.Text);
            }
            else
            {
                _displayContacts = _project.Contacts;
            }
            foreach (var item in _displayContacts)
            {
                ContactsListBox.Items.Add(item.FullName);
            }
            string birthdayPeople = "";
            foreach (var item in _project.FindBirthdayContact())
            {
                birthdayPeople += item.FullName + ", ";
            }
            BirthdaySurnamesLabel.Text = birthdayPeople;
        }

        /// <summary>
        /// Добавляет контакт в проект
        /// </summary>
        private void AddContact()
        {
            var contact = new ContactForm();
            DialogResult result = contact.ShowDialog();
            if (result == DialogResult.OK)
            {
                var updatedContact = contact.Contact;
                _project.Contacts.Add(updatedContact);
            }
            else
            {
                contact.Close();
            }
        }

        /// <summary>
        /// Удаляет выбранный контакт из проекта
        /// </summary>
        /// <param name="index">Номер выбранного контакта</param>
        private void RemoveContact(int index) 
        {
            if (index == -1)
            {
                return;
            }
            DialogResult result = MessageBox.Show($"Do you really want to remove " +
                $"{ContactsListBox.SelectedItem}?", "Confirmation", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                foreach (var item in _project.Contacts)
                {
                    if (item == _displayContacts[index])
                    {
                        _project.Contacts.Remove(item);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Редактирует выбранный контакт
        /// </summary>
        /// <param name="index"></param>
        private void EditContact(int index) 
        {
            var selectedContact = _displayContacts[index];
            var contact = new ContactForm();
            contact.Contact = (Contact)selectedContact.Clone();

            DialogResult result = contact.ShowDialog();
            if (result == DialogResult.OK)
            {
                var updatedContact = contact.Contact;
                _project.Contacts.Remove(selectedContact);
                _project.Contacts.Add(updatedContact);
            }
        }

        /// <summary>
        /// Обновляет информацию о контакте на форме
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact contact = _displayContacts[index];
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            DateOfBirthTimePicker.Value = contact.DateOfBirth;
            VKTextBox.Text = contact.IdVK;
        }

        /// <summary>
        /// Очищает информацию о контакте, если ничего не выбрано
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = null;
            EmailTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            DateOfBirthTimePicker.Value = DateTime.Today;
            VKTextBox.Text = null;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
            _projectManager.SaveProject(_project);
        }

        /// <summary>
        /// Обрабатывает событие наведения курсора на кнопку добавления контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Обрабатывает событие покидания курсором кнопки добавления контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки редактирования контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
            _projectManager.SaveProject(_project);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
            _projectManager.SaveProject(_project);
        }

        /// <summary>
        /// Обрабатывает событие наведения курсора на кнопку удаления контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// Обрабатывает событие покидания курсором кнопки удаления контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обрабатывает событие наведения курсора на кнопку редактирования контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Обрабатывает событие покидания курсором кнопки редактирования контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Запрещает редактирование текстового поля с фио
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает редактирование текстового поля с электронной почтой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает редактирование текстового поля с номером телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Запрещает редактирование текстового поля с ссылкой на ВК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Вызывает форму со справочной информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Скрывает панель с именинниками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            this.BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// Обрабатывает событие выбора контакта из списка на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                ClearSelectedContact();
            }
            else
            {
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Обрабатывает событие закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _projectManager.SaveProject(_project);
            DialogResult result = MessageBox.Show($"Do you really want to exit?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Выполняет поиск контакта по подстроке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
