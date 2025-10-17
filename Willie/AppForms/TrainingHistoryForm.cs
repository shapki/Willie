using System;
using System.Linq;
using System.Windows.Forms;
using Willie.Models;
using Willie.Services;

namespace Willie.AppForms
{
    public partial class TrainingHistoryForm : Form
    {
        private students _student;
        private TrainingHistoryManager _historyManager;
        private WillieModel _context;
        private bool _isLoadingData = true;

        public TrainingHistoryForm(students student)
        {
            InitializeComponent();
            _student = student;
            _historyManager = new TrainingHistoryManager();
            _context = Program.context;

            titleLabel.Text = "ТРЕНИРОВКИ " + _student.fullName;
            this.Text = "ВИЛЛИ | ИСТОРИЯ ТРЕНИРОВОК | " + student.fullName;
        }

        private void TrainingHistoryForm_Load(object sender, System.EventArgs e)
        {
            _isLoadingData = true;
            LoadData();
            ConfigureDataGridView();
            _isLoadingData = false;
        }

        private void LoadData()
        {
            try
            {
                this.studentsTableAdapter.Fill(this.shapkin_06_WillieDataSet.students);
                this.boxerTypesTableAdapter.Fill(this.shapkin_06_WillieDataSet.boxerTypes);
                this.programsTableAdapter.Fill(this.shapkin_06_WillieDataSet.programs);

                var studentHistory = _context.trainingHistory
                    .Where(th => th.studentOneId == _student.idStudent)
                    .ToList();

                trainingHistoryBindingSource.DataSource = studentHistory;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            if (dataGridView1.Columns["studentOneIdDataGridViewTextBoxColumn"] != null)
            {
                dataGridView1.Columns["studentOneIdDataGridViewTextBoxColumn"].Visible = false;
            }

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridView1.DefaultValuesNeeded += (s, e) =>
            {
                e.Row.Cells["studentOneIdDataGridViewTextBoxColumn"].Value = _student.idStudent;
                e.Row.Cells["dateDataGridViewTextBoxColumn"].Value = DateTime.Today;
            };

            dataGridView1.DataBindingComplete += (s, e) =>
            {
                _isLoadingData = false;
            };
        }

        private void trainingHistorySave_Click(object sender, System.EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                dataGridView1.EndEdit();
                trainingHistoryBindingSource.EndEdit();

                SyncChangesWithContext();

                bool hasErrors = false;
                string errorMessage = "";

                foreach (var training in _context.trainingHistory.Local
                    .Where(t => t.studentOneId == _student.idStudent).ToList())
                {
                    var validationError = _historyManager.ValidateTrainingHistory(training);
                    if (!string.IsNullOrEmpty(validationError))
                    {
                        hasErrors = true;
                        errorMessage = validationError;
                        break;
                    }
                }

                if (hasErrors)
                {
                    MessageBox.Show($"Ошибка валидации: {errorMessage}", "Ошибка валидации",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _historyManager.SaveTrainingHistory();
                MessageBox.Show("Данные успешно сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SyncChangesWithContext()
        {
            try
            {
                foreach (var item in trainingHistoryBindingSource)
                {
                    if (item is trainingHistory training)
                    {
                        training.studentOneId = _student.idStudent;

                        if (training.date != DateTime.MinValue)
                        {
                            training.date = training.date.Date;
                        }

                        var existingTraining = _context.trainingHistory.Local
                            .FirstOrDefault(t => t.idHistory == training.idHistory);

                        if (existingTraining == null && training.idHistory == 0)
                        {
                            _context.trainingHistory.Add(training);
                        }
                        else if (existingTraining != null)
                        {
                            training.studentOneId = _student.idStudent;
                            training.date = training.date.Date;
                            _context.Entry(existingTraining).CurrentValues.SetValues(training);
                        }
                    }
                }

                var deletedTrainings = _context.trainingHistory.Local
                    .Where(t => t.studentOneId == _student.idStudent &&
                           !trainingHistoryBindingSource.Cast<trainingHistory>().Any(bt => bt.idHistory == t.idHistory))
                    .ToList();

                foreach (var deletedTraining in deletedTrainings)
                {
                    _context.trainingHistory.Remove(deletedTraining);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при синхронизации данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count) return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (e.ColumnIndex == dataGridView1.Columns["dateDataGridViewTextBoxColumn"].Index)
            {
                if (e.Value != null && e.Value is DateTime dateValue)
                {
                    e.Value = dateValue.ToString("dd.MM.yyyy");
                    e.FormattingApplied = true;
                }
            }

            else if (e.ColumnIndex == dataGridView1.Columns["programIdDataGridViewTextBoxColumn"].Index)
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int programId))
                {
                    var program = _context.programs.FirstOrDefault(p => p.idProgram == programId);
                    if (program != null)
                    {
                        var studentOneType = _context.boxerTypes.FirstOrDefault(b => b.idBoxer == program.studentOneBoxerId);
                        var studentTwoType = _context.boxerTypes.FirstOrDefault(b => b.idBoxer == program.studentTwoBoxerId);

                        string studentOneName = studentOneType?.boxerType ?? "Неизвестно";
                        string studentTwoName = studentTwoType?.boxerType ?? "Неизвестно";

                        e.Value = $"{studentOneName} - {studentTwoName} ({program.hits} уд.)";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["dateDataGridViewTextBoxColumn"].Index)
            {
                if (e.Value != null)
                {
                    if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                    {
                        e.Value = dateValue.Date;
                        e.ParsingApplied = true;
                    }
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

            if (e.Exception is FormatException || e.Exception is ArgumentException)
            {
                System.Diagnostics.Debug.WriteLine($"DataError: {e.Exception.Message}");
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isLoadingData || e.RowIndex < 0) return;
            if (e.ColumnIndex == dataGridView1.Columns["studentTwoBoxerIdDataGridViewTextBoxColumn"].Index)
            {
                UpdateProgramsForRow(e.RowIndex);
            }
        }

        private void UpdateProgramsForRow(int rowIndex)
        {
            if (_isLoadingData) return;

            var row = dataGridView1.Rows[rowIndex];
            if (row.IsNewRow) return;

            var studentTwoBoxerCell = row.Cells["studentTwoBoxerIdDataGridViewTextBoxColumn"];
            var programCell = row.Cells["programIdDataGridViewTextBoxColumn"] as DataGridViewComboBoxCell;

            if (studentTwoBoxerCell.Value != null && programCell != null)
            {
                int studentTwoBoxerId = Convert.ToInt32(studentTwoBoxerCell.Value);

                int studentOneBoxerId = _historyManager.GetBoxerType(_student);

                var availablePrograms = _context.programs
                    .Where(p => p.studentOneBoxerId == studentOneBoxerId && p.studentTwoBoxerId == studentTwoBoxerId)
                    .ToList();

                programCell.DataSource = null;
                programCell.DataSource = availablePrograms;
                programCell.DisplayMember = "hits";
                programCell.ValueMember = "idProgram";

                if (availablePrograms.Count == 1)
                {
                    var currentValue = programCell.Value;
                    if (currentValue == null || Convert.ToInt32(currentValue) != availablePrograms[0].idProgram)
                    {
                        programCell.Value = availablePrograms[0].idProgram;
                    }
                }
                else if (availablePrograms.Count == 0)
                {
                    programCell.Value = null;
                    MessageBox.Show("Для выбранной комбинации типов боксеров нет доступных программ", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isLoadingData && e.RowIndex >= 0)
            {
                UpdateProgramsForRow(e.RowIndex);
            }
        }
    }
}