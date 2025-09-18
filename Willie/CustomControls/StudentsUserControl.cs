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
            phoneLabel.Text = _student.phone;
            emailLabel.Text = _student.email;
            heightLabel.Text = $"Рост: {_student.height}";

            var genderVar = Program.context.gender.FirstOrDefault(dh => dh.idGender == _student.genderId);
            genderLabel.Text = $"Пол: {genderVar.typeGender}";

            var dominantHandVar = Program.context.dominantHand.FirstOrDefault(dh => dh.idDominantHand == _student.DominantHandId);
            dominantHandLabel.Text = dominantHandVar.typeDominantHand;

            DateTime birthVar = _student.dateBirth;
            dateBirthLabel.Text = birthVar.ToString("dd/MM/yyyy");
        }
    }
}
