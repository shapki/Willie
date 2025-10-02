using System.Windows.Forms;
using Willie.Models;

namespace Willie.AppForms
{
    public partial class TrainingHistoryForm : Form
    {
        private students _student;

        public TrainingHistoryForm(students student)
        {
            InitializeComponent();
            _student = student;
            titleLabel.Text = "ТРЕНИРОВКИ " + _student.fullName;
            this.Text = "ВИЛЛИ | ИСТОРИЯ ТРЕНИРОВОК | " + student.fullName;
        }

        private void TrainingHistoryForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.trainingHistory". При необходимости она может быть перемещена или удалена.
            this.trainingHistoryTableAdapter.Fill(this.shapkin_06_WillieDataSet.trainingHistory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.boxerTypes". При необходимости она может быть перемещена или удалена.
            this.boxerTypesTableAdapter.Fill(this.shapkin_06_WillieDataSet.boxerTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.programs". При необходимости она может быть перемещена или удалена.
            this.programsTableAdapter.Fill(this.shapkin_06_WillieDataSet.programs);

        }

        private void trainingHistorySave_Click(object sender, System.EventArgs e)
        {

        }
    }
}
