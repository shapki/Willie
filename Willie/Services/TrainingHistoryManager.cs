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

        public void SaveTrainingHistory()
        {
            try
            {
                int changes = _context.SaveChanges();
                if (changes > 0)
                {
                    MessageBox.Show($"Сохранено изменений: {changes}", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                MessageBox.Show($"Ошибки валидации: {fullErrorMessage}", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                var innerException = ex.InnerException?.InnerException ?? ex.InnerException ?? ex;
                MessageBox.Show($"Ошибка обновления базы данных: {innerException.Message}", "Ошибка базы данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public string ValidateTrainingHistory(trainingHistory training)
        {
            if (training == null)
                return "Запись тренировки не может быть пустой";

            if (training.studentOneId <= 0)
                return "Необходимо указать студента";

            if (!_context.students.Any(s => s.idStudent == training.studentOneId))
                return "Выбранный студент не существует";

            if (training.studentTwoBoxerId <= 0)
                return "Необходимо выбрать тип второго боксера";

            if (!_context.boxerTypes.Any(b => b.idBoxer == training.studentTwoBoxerId))
                return "Выбранный тип боксера не существует";

            if (training.programId <= 0)
                return "Необходимо выбрать программу";

            if (!_context.programs.Any(p => p.idProgram == training.programId))
                return "Выбранная программа не существует";

            if (training.date == DateTime.MinValue)
                return "Необходимо указать дату";

            if (training.date > DateTime.Now.Date)
                return "Дата тренировки не может быть в будущем";

            if (!string.IsNullOrEmpty(training.comment) && training.comment.Length > 500)
                return "Комментарий не может превышать 500 символов";

            return null;
        }
    }
}