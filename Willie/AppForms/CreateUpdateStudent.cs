using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Willie.AppForms
{
    public partial class CreateUpdateStudent : Form
    {
        public CreateUpdateStudent()
        {
            InitializeComponent();
        }

        private void CreateUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shapkin_06_WillieDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);

        }
    }
}
