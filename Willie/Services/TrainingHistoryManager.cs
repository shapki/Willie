namespace Willie.Services
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Willie.Models;

    public class TrainingHistoryManager
    {
        private WillieModel _context;

        public TrainingHistoryManager()
        {
            _context = Program.context;
        }

        public bool SaveTrainingHistory(int idStudent, int studentTwoBoxerId, int idProgram, string comment)
        {
            try
            {
                var trainingHistory = new trainingHistory
                {
                    date = DateTime.Now,
                    studentOneId = idStudent,
                    studentTwoBoxerId = studentTwoBoxerId,
                    programId = idProgram,
                    comment = comment
                };

                _context.trainingHistory.Add(trainingHistory);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении истории тренировки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LoadStudentHistory(DataGridView historyDgv, int idStudent)
        {
            try
            {
                var historyData = (from th in _context.trainingHistory
                                   where th.studentOneId == idStudent
                                   join p in _context.programs on th.programId equals p.idProgram
                                   join bt1 in _context.boxerTypes on p.studentOneBoxerId equals bt1.idBoxer
                                   join bt2 in _context.boxerTypes on p.studentTwoBoxerId equals bt2.idBoxer
                                   select new
                                   {
                                       Дата = th.date,
                                       ТипПрограммы = GetProgramDescription(bt1.boxerType, bt2.boxerType, p.hits),
                                       Комментарий = th.comment
                                   }).ToList();

                historyDgv.DataSource = historyData;

                historyDgv.Columns["Дата"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке истории: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetProgramDescription(string boxerType1, string boxerType2, string hits)
        {
            return $"{boxerType1} vs {boxerType2} - {hits}";
        }

        public object GetProgramsForComboBox()
        {
            return _context.programs
                .Select(p => new
                {
                    p.idProgram,
                    Description = $"{p.hits} (ID: {p.idProgram})"
                })
                .ToList();
        }

        public string GetSecondBoxerInfo(int studentTwoBoxerId)
        {
            var boxerType = _context.boxerTypes
                .FirstOrDefault(bt => bt.idBoxer == studentTwoBoxerId);

            return boxerType?.boxerType ?? "Неизвестный тип";
        }
    }
}
