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



    }
}
