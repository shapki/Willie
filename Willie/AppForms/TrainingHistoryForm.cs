using System.Windows.Forms;

namespace Willie.AppForms
{
    public partial class TrainingHistoryForm : Form
    {
        public TrainingHistoryForm()
        {
            InitializeComponent();
        }

        private void TrainingHistoryForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.boxerTypes". При необходимости она может быть перемещена или удалена.
            this.boxerTypesTableAdapter.Fill(this.shapkin_06_WillieDataSet.boxerTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.programs". При необходимости она может быть перемещена или удалена.
            this.programsTableAdapter.Fill(this.shapkin_06_WillieDataSet.programs);

        }
    }
}
