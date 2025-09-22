using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);

            if (!_student.isNew())
            {
                studentsBindingSource.DataSource = _student;
            }
        }
    }
}
