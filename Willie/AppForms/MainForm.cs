using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Willie.CustomControls;
using Willie.Models;

namespace Willie.AppForms
{
    public partial class MainForm : Form
    {
        public static MainForm Control { get; internal set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            List<students> students = Program.context.students.OrderBy(p => p.fullName).ToList();

            foreach (students student in students)
            {
                flowLayoutPanel.Controls.Add(new StudentsUserControl(student));
            }
        }

        public void RefreshStudents()
        {
            ClearStudentList();
            ShowStudents();
        }

        private void ClearStudentList()
        {
            splitContainer.Panel2.Controls[0].Controls.Clear();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            CreateUpdateStudentForm createUpdateStudent = new CreateUpdateStudentForm();
            DialogResult studentSaved = createUpdateStudent.ShowDialog();

            if (studentSaved == DialogResult.OK)
            {
                RefreshStudents();
            }
        }
    }
}
