using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Willie.Models;
using Willie.CustomControls;

namespace Willie.AppForms
{
    public partial class MainForm : Form
    {
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
    }
}
