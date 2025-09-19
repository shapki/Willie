using System;
using System.Linq;
using System.Windows.Forms;
using Willie.Models;

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
    }
}
