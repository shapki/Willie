using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Willie.Models;

namespace Willie.AppForms
{
    public partial class CreateUpdateStudentForm : Form
    {
        private students _student;
        public CreateUpdateStudentForm()
        {
            InitializeComponent();
            _student = new students();
            titleLabel.Text = "ДОБАВЛЕНИЕ СТУДЕНТА";
            this.Text = "ВИЛЛИ | ДОБАВЛЕНИЕ СТУДЕНТА";
        }

        public CreateUpdateStudentForm(students student)
        {
            _student = student;
            InitializeComponent();
            titleLabel.Text = "ИЗМЕНЕНИЕ СТУДЕНТА";
            this.Text = "ВИЛЛИ | ИЗМЕНЕНИЕ | " + _student.fullName;
        }

        private void CreateUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.shapkin_06_WillieDataSet.gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.dominantHand". При необходимости она может быть перемещена или удалена.
            this.dominantHandTableAdapter.Fill(this.shapkin_06_WillieDataSet.dominantHand);

            if (!_student.isNew())
            {
                studentsBindingSource.DataSource = _student;
            }

            phoneMaskedTextBox.AsciiOnly = true;
        }

        private string GetSanitizedPhone()
        {
            // PKGH            
            // Подготовка введенной пользователем информации
            // о телефоне для сохранения в БД.

            string trimmedPhone = phoneMaskedTextBox.Text.Replace("+", "");
            trimmedPhone = trimmedPhone.Replace(" ", "");
            return trimmedPhone;
        }

        /// <summary>
        /// PKGH
        /// Проверка введенной пользователем информации. Если допущена ошибка,
        /// сообщить, в каком поле это случилось, и что можно вводить.
        /// </summary>
        /// <param name="pattern">Паттерн</param>
        /// <param name="userInputText">Текст, введенный пользователем в поле на форме.</param>
        /// <param name="field">Поле, в котором пользователь допустил ошибку.</param>
        /// <param name="messageAboutAllowedSymbols">Какие символы разрешено вводить в это поле.</param>
        /// <exception cref="ValidationException"></exception>
        private void ValidateGeneral(string userInputText, string field, string messageAboutAllowedSymbols = "поле не должно быть пустым.", string pattern = @"^.+$")
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            bool isValid = regex.IsMatch(userInputText.Trim());
            if (!isValid)
            {
                throw new ValidationException($"{field}: {messageAboutAllowedSymbols}");
            }
        }

        private void ValidateStudentName()
        {
            ValidateGeneral(fullNameTextBox.Text, "ФИО");
        }

        private void ValidatePhone()
        {
            ValidateGeneral(GetSanitizedPhone(), "Телефон", "должно быть 11 цифр.", @"^\d{11}$");
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void ValidateEmail()
        {
            if (!IsValidEmail(emailTextBox.Text.Trim()))
            {
                throw new ValidationException("Неверный формат электронной почты");
            }
        }

        private void ValidateNumCard()
        {
            ValidateGeneral(numcardMaskedTextBox.Text, "Номер карты", "не должно быть пустым..");
        }

        private void Validate()
        {
            ValidateStudentName();
            ValidatePhone();
            ValidateEmail();
            ValidateNumCard();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();

            if (_student.isNew())
            {
                Program.context.students.Add(_student);
            }

            DialogResult toBeSaved = MessageBox.Show("Сохранить?", "Запрос подтверждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (toBeSaved == DialogResult.No)
            {
                return;
            }

            try
            {
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Break point.
            }
        }

        private void FillModelFields()
        {
            _student.dateBirth = dateBirthDateTimePicker.Value;
            _student.fullName = fullNameTextBox.Text;
            _student.phone = phoneMaskedTextBox.Text;
            _student.email = emailTextBox.Text;
            _student.numcard = numcardMaskedTextBox.Text;
            _student.height = (int)heightNumericUpDown.Value;
            _student.DominantHandId = (int)dominantHandIdComboBox.SelectedValue;
            _student.genderId = (int)genderIdComboBox.SelectedValue; // Не удалось привести тип объекта "System.Int32" к типу "Willie.Models.gender"
        }
    }
}
