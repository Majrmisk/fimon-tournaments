using FImonTournaments.Core;

namespace FImonTournaments
{
    public partial class MainMenu : Form
    {
        private readonly DataHandler _dataHandler = new();

        private TrainersMenu? _trainersMenuForm;
        private TournamentsMenu? _tournamentsMenuForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Tournaments_Click(object sender, EventArgs e)
        {
            if (_tournamentsMenuForm == null)
            {
                _tournamentsMenuForm = new(this, _dataHandler)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location,
                    Size = this.Size
                };
                _tournamentsMenuForm.FormClosed += (s, args) => _tournamentsMenuForm = null;
            }
            _tournamentsMenuForm.Show();
            Hide();
        }

        private void Trainers_Click(object sender, EventArgs e)
        {
            if (_trainersMenuForm == null)
            {
                _trainersMenuForm = new(_dataHandler, this)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location,
                    Size = this.Size
                };
                _trainersMenuForm.FormClosed += (s, args) => _trainersMenuForm = null;
            }
            _trainersMenuForm.Show();
            Hide();
        }

        private async void Quit_Click(object sender, EventArgs e)
        {
            // Waits until everything is saved.
            await _dataHandler.ExitProgramCheckAsync();
            Application.Exit();
        }
    }
}
