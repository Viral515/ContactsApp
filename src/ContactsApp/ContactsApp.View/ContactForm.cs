using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Класс формы редактирования и создания контакта
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Цвет отсутствия ошибок
        /// </summary>
        private Color _noErrorColor = Color.White;
        
        /// <summary>
        /// Цвет ошибки
        /// </summary>
        private Color _errorColor = Color.LightPink;

        /// <summary>
        /// Объект контакта, содержащий основную информацию о нём
        /// </summary>
        private Contact _contact = new Contact("Mike Wazovsky", "qwe@gmail.com", 
            "+7(913)-111-22-33", DateTime.Today, "1111121"); 

        /// <summary>
        /// Переменная для вывода ошибок при изменении значения фио контакта
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// Переменная для вывода ошибок при изменении значения почты контакта
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Переменная для вывода ошибок при изменении значения номера телефона контакта
        /// </summary>
        private string _phoneNumberError;

        /// <summary>
        /// Переменная для вывода ошибок при изменении значения даты рождения контакта
        /// </summary>
        private string _dateOfBirthError;

        /// <summary>
        /// Переменная для вывода ошибок при изменении значения ссылки на ВК контакта
        /// </summary>
        private string _idVKError;

        /// <summary>
        /// Возвращает или задаёт данные о контакте
        /// </summary>
        public Contact Contact
        { 
            get 
            { 
                return _contact; 
            }
            set 
            {
                _contact = value;
            }
        }

        /// <summary>
        /// Инициализирует форму
        /// </summary>
        public ContactForm()
        {
            InitializeComponent(); 
            UpdateForm();
        }
        /// <summary>
        /// Обновляет информацию о контакте в полях на форме
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.IdVK;
        }
        /// <summary>
        /// Проверяет данные на наличие ошибок ввода
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            StringBuilder message = new StringBuilder();

            if (_fullNameError != "")
            {
                message.AppendLine(_fullNameError);
            }
            if (_emailError != "")
            {
                message.AppendLine(_emailError);
            }
            if (_phoneNumberError != "")
            {
                message.AppendLine(_phoneNumberError);
            }
            if (_idVKError != "")
            {
                message.AppendLine(_idVKError);
            }
            if (message.Length > 0)
            {
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Обновляет данные контакта
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.IdVK = VKTextBox.Text;
        }
        /// <summary>
        /// Обрабатывает событие наведения курсора на кнопку добавления фото контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
            AddPhotoButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }
        /// <summary>
        /// Обрабатывает событие покидания курсором кнопки добавления фото контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.BackColor = Color.White;
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки ОК на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors() == true)
            {
                UpdateContact();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        /// <summary>
        /// Обрабатывает нажатие кнопки отмены на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Обрабатывает событие изменения значения поля с фио контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = _noErrorColor;
                _fullNameError = "";
            }
            catch (Exception exception)
            {
                FullNameTextBox.BackColor = _errorColor;
                _fullNameError = exception.Message;
            }
        }
        /// <summary>
        /// Обрабатывает событие изменения значения поля с почтой контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = _noErrorColor;
                _emailError = "";
            }
            catch (Exception exception)
            {
                EmailTextBox.BackColor = _errorColor;
                _emailError = exception.Message;
            }
        }
        /// <summary>
        /// Обрабатывает событие изменения значения поля с номером телефона контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberTextBox.BackColor = _noErrorColor;
                _phoneNumberError = "";
            }
            catch (Exception exception)
            {
                PhoneNumberTextBox.BackColor = _errorColor;
                _phoneNumberError = exception.Message;
            }
        }
        /// <summary>
        /// Обрабатывает событие изменения значения поля с ссылкой на ВК контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IdVK = VKTextBox.Text;
                VKTextBox.BackColor = _noErrorColor;
                _idVKError = "";
            }
            catch (Exception exception)
            {
                VKTextBox.BackColor = _errorColor;
                _idVKError = exception.Message;
            }
        }
        /// <summary>
        /// Обрабатывает событие изменения значения поля с датой рождения контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                _dateOfBirthError = "";
            }
            catch (Exception exception)
            {
                _dateOfBirthError = exception.Message;
            }
        }
    }
}
