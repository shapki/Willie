using System;
using System.Linq;
using System.Windows.Forms;
using Willie.AppForms;
using Willie.Models;

namespace Willie.CustomControls
{
    public partial class StudentsUserControl : UserControl
    {
        private students _student;
        private WillieModel _context;

        public StudentsUserControl(students student)
        {
            InitializeComponent();
            _student = student;
            _context = Program.context;
            SetLabelTextValues();
        }

        private void SetLabelTextValues()
        {
            fullNameLabel.Text = _student.fullName;
            numcardLabel.Text = "Карта ученика: " + _student.numcard;

            string willieDaysText = GetLastWillieTrainingDays();
            dateWillie.Text = "Вилли: " + willieDaysText;
        }

        private string GetLastWillieTrainingDays()
        {
            try
            {
                var lastTraining = _context.trainingHistory
                    .Where(th => th.studentOneId == _student.idStudent)
                    .OrderByDescending(th => th.date)
                    .FirstOrDefault();

                if (lastTraining != null)
                {
                    DateTime lastTrainingDate = lastTraining.date;
                    TimeSpan timeSinceLastTraining = DateTime.Now - lastTrainingDate;
                    int daysSinceLastTraining = (int)timeSinceLastTraining.TotalDays;

                    if (daysSinceLastTraining == 0)
                        return "сегодня";
                    else if (daysSinceLastTraining == 1)
                        return "вчера";
                    else
                        return $"{daysSinceLastTraining} дн. назад";
                }
                else
                {
                    return "нет данных";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка при получении данных тренировок: {ex.Message}");
                return "нет данных";
            }
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

        private void trainingHistoryButton_Click(object sender, EventArgs e)
        {
            TrainingHistoryForm trainingHistoryForm = new TrainingHistoryForm(_student);
            DialogResult studentSaved = trainingHistoryForm.ShowDialog();

            if (studentSaved == DialogResult.OK)
            {
                SetLabelTextValues();
            }
        }
    }
}