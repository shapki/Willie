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

            var student = _context.students.FirstOrDefault(s => s.idStudent == training.studentOneId);
            if (student == null)
                return "Выбранный студент не существует";

            if (training.studentTwoBoxerId <= 0)
                return "Необходимо выбрать тип второго боксера";

            if (!_context.boxerTypes.Any(b => b.idBoxer == training.studentTwoBoxerId))
                return "Выбранный тип боксера не существует";

            if (training.programId <= 0)
                return "Необходимо выбрать программу";

            var program = _context.programs.FirstOrDefault(p => p.idProgram == training.programId);
            if (program == null)
                return "Выбранная программа не существует";

            int actualStudentOneBoxerId = GetBoxerType(student);
            if (program.studentOneBoxerId != actualStudentOneBoxerId || program.studentTwoBoxerId != training.studentTwoBoxerId)
            {
                return "Выбранная программа не соответствует типам боксеров";
            }

            if (training.date == DateTime.MinValue)
                return "Необходимо указать дату";

            if (training.date > DateTime.Now.Date)
                return "Дата тренировки не может быть в будущем";

            if (!string.IsNullOrEmpty(training.comment) && training.comment.Length > 500)
                return "Комментарий не может превышать 500 символов";

            return null;
        }

        public int GetBoxerType(students student)
        {
            var gender = _context.gender.FirstOrDefault(g => g.idGender == student.genderId);
            bool isMale = gender?.typeGender == "муж" || student.genderId == 1;
            
            if (isMale)
            {
                if (student.height >= 185)
                    return 1; // Высокий муж
                else if (student.height >= 175)
                    return 2; // Средний муж
                else
                    return 3; // Низкий муж
            }
            else
            {
                if (student.height >= 170)
                    return 4; // Высокая жен
                else if (student.height >= 160)
                    return 5; // Средняя жен
                else
                    return 6; // Низкая жен
            }
        }

        public IQueryable<programs> GetAvailablePrograms(int studentOneBoxerId, int studentTwoBoxerId)
        {
            return _context.programs
                .Where(p => p.studentOneBoxerId == studentOneBoxerId && p.studentTwoBoxerId == studentTwoBoxerId);
        }
    }
}