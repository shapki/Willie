using System;
using System.Drawing;
using System.Windows.Forms;
using Willie.Models;
using Willie.AppForms;

namespace Willie.CustomControls
{
    public partial class StudentsUserControl : UserControl
    {
        private students _student;
        public StudentsUserControl(students student)
        {
            InitializeComponent();
            _student = student;
            SetLabelTextValues();
        }

        private void SetLabelTextValues()
        {
            fullNameLabel.Text = _student.fullName;
            numcardLabel.Text = "Карта ученика: " + _student.numcard;
            dateWillie.Text = "Вилли: " + "? дн";
        }

        private void OpenStudentEditForm()
        {
            CreateUpdateStudentForm createUpdateStudent = new CreateUpdateStudentForm(_student);
            DialogResult studentSaved = createUpdateStudent.ShowDialog();

            if (studentSaved == DialogResult.OK)
            {
                MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;
                mainForm.RefreshStudents();
            }
        }

        private void StudentsUserControl_Click(object sender, EventArgs e)
        {
            OpenStudentEditForm();
        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {
            OpenStudentEditForm();
        }

        private void numcardLabel_Click(object sender, EventArgs e)
        {
            OpenStudentEditForm();
        }

        private void dateWillie_Click(object sender, EventArgs e)
        {
            OpenStudentEditForm();
        }
    }
}
