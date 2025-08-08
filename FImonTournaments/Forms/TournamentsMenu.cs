using FImonTournaments.Core;
using FImonTournaments.Models.GameObjects.Tournaments;
using FImonTournaments.Utils;

namespace FImonTournaments;

public partial class TournamentsMenu : Form
{
    private readonly DataHandler _dataHandler;
    private readonly MainMenu _mainMenuForm;

    private NewTournamentPopup? _newTournamentForm;
    private Tournament? _tournament;

    public TournamentsMenu(MainMenu mainMenuForm, DataHandler dataHandler)
    {
        InitializeComponent();
        _dataHandler = dataHandler;
        _mainMenuForm = mainMenuForm;
        RefreshBox();
    }

    public void TournamentSet(Tournament tournament)
    {
        tournamentsListBox.Items.Clear();
        tournamentsListBox.Items.Add($"-----New Tournament - {tournament.Name}-----");
        tournamentsListBox.Items.Add($"Type - {tournament.Type}");
        tournamentsListBox.Items.Add($"Size - {tournament.Size}");
        _tournament = tournament;
        PrintTrainers();
        
        newTournamentButton.Visible = false;
        startTournamentButton.Visible = true;
    }

    private void PrintTrainers()
    {
        if (_tournament == null)
        {
            throw new NullReferenceException("[ERROR] Attempt to print trainers from a non-existant tournament.");
        }

        tournamentsListBox.Items.Add("");
        tournamentsListBox.Items.Add("----Trainers----");
        
        if (_tournament.Type == TournamentType.Standard)
        {
            var j = 1;
            for (int i = 0; i < _tournament.Trainers.Count; i += 2)
            {
                tournamentsListBox.Items.Add("");
                tournamentsListBox.Items.Add($"---Pair {j++}---");
                tournamentsListBox.Items.Add($"{_tournament.Trainers[i].Name} ({_tournament.Trainers[i].ID}) vs {_tournament.Trainers[i + 1].Name} ({_tournament.Trainers[i + 1].ID})");
            }
        }
        else if (_tournament.Type == TournamentType.Groups)
        {
            tournamentsListBox.Items.Add("");
            tournamentsListBox.Items.Add($"---Group One---");
            for (int i = 0; i < _tournament.Trainers.Count / 2; i++)
            {
                tournamentsListBox.Items.Add($"{_tournament.Trainers[i].Name} ({_tournament.Trainers[i].ID})");
            }

            tournamentsListBox.Items.Add("");
            tournamentsListBox.Items.Add($"---Group Two---");
            for (int i = _tournament.Trainers.Count / 2; i < _tournament.Trainers.Count; i++)
            {
                tournamentsListBox.Items.Add($"{_tournament.Trainers[i].Name} ({_tournament.Trainers[i].ID})");
            }
        }
    }

    private void RefreshBox()
    {
        tournamentsListBox.Items.Clear();
        foreach (var _tournament in _dataHandler.TournamentsHistory)
        {
            tournamentsListBox.Items.Add($"-----{_tournament.Name}-----");
            tournamentsListBox.Items.Add($"Winner - {_tournament.Winner.Name} ({_tournament.Winner.ID})");
            tournamentsListBox.Items.Add($"Type - {_tournament.Type} - {_tournament.Trainers.Count} Contestants");
            tournamentsListBox.Items.Add("");
        }
    }

    private void NewTournamentButton_Click(object sender, EventArgs e)
    {
        if (_newTournamentForm == null)
        {
            _newTournamentForm = new NewTournamentPopup(_dataHandler, this);
            _newTournamentForm.FormClosed += (s, args) => _newTournamentForm = null;
        }

        _newTournamentForm.ShowDialog(this);
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _dataHandler.SaveChanges();
        _newTournamentForm?.Close();
        _mainMenuForm.Location = Location;
        _mainMenuForm.Show();
        Close();
    }

    private void StartTournamentButton_Click(object sender, EventArgs e)
    {
        if (_tournament == null)
        {
            throw new NullReferenceException("[ERROR] Attempt to start a non-existant tournament.");
        }

        startTournamentButton.Visible = false;
        backButton.Visible = false;
        tournamentsListBox.Items.Clear();

        TournamentPlayer tournamentPlayer = new(_tournament, tournamentsListBox, _dataHandler);
        tournamentPlayer.Play();

        backButton.Visible = true;
    }
}