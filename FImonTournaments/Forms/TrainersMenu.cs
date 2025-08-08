using FImonTournaments.Core;
using FImonTournaments.Models.GameObjects.Trainers;
using FImonTournaments.Utils;

namespace FImonTournaments;

public partial class TrainersMenu : Form
{
    private readonly DataHandler _dataHandler;
    private readonly MainMenu _mainMenuForm;

    private AddCustomTrainerPopup? customTrainerForm;

    public TrainersMenu(DataHandler dataHandler, MainMenu mainMenuForm)
    {
        InitializeComponent();

        _dataHandler = dataHandler;
        _mainMenuForm = mainMenuForm;

        RefreshBox();
    }

    private async void RemoveButton_Click(object sender, EventArgs e)
    {
        string enteredId = idBox.Text;
        idBox.Text = "ID";
        idBox.ForeColor = Color.Tan;

        if (!int.TryParse(enteredId, out int trainerId))
        {
            MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!await _dataHandler.RemoveTrainer(trainerId))
        {
            MessageBox.Show("Trainer with ID " + trainerId + " does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        RefreshBox();
    }

    private async void AddRandomButton_Click(object sender, EventArgs e)
    {
        await _dataHandler.AddTrainer(new(Randomizer.GetRandomTrainerName()));
        RefreshBox();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        customTrainerForm?.Close();
        _dataHandler.SaveChanges();
        _mainMenuForm.Location = Location;
        _mainMenuForm.Show();
        Close();
    }

    private void IdBox_GotFocus(object sender, EventArgs e)
    {
        if (idBox.Text == "ID")
        {
            idBox.Text = "";
            idBox.ForeColor = Color.Black;
        }
    }

    private void IdBox_LostFocus(object sender, EventArgs e)
    {
        if (idBox.Text == "")
        {
            idBox.Text = "ID";
            idBox.ForeColor = Color.Tan;
        }
    }

    private void AddCustomButton_Click(object sender, EventArgs e)
    {
        if (customTrainerForm == null)
        {
            customTrainerForm = new(_dataHandler);
            customTrainerForm.FormClosed += (s, args) => customTrainerForm = null;
            customTrainerForm.FormClosed += (s, args) => RefreshBox();
        }

        customTrainerForm.ShowDialog(this);
    }

    private void RefreshBox()
    {
        trainersListBox.Items.Clear();
        foreach (Trainer trainer in _dataHandler.Trainers
            .OrderBy(pair => pair.Key)
            .Select(pair => pair.Value))
        {
            var trainerKD = trainer.TotalBattles == 0 ? "N/A" : $"{trainer.BattlesWon / (float)trainer.TotalBattles:N2}";
            trainersListBox.Items.Add($"-----{trainer.Name} ({trainer.ID})-----");
            trainersListBox.Items.Add($"Battle Win/Lose Ratio - {trainerKD}");
            trainersListBox.Items.Add($"Tournaments Won - {trainer.TournamentsWon}");
            if (fimonsCheckBox.Checked)
            {
                PrintFImons(trainer);
            }
            trainersListBox.Items.Add("");
        }
    }

    private void PrintFImons(Trainer trainer)
    {
        trainersListBox.Items.Add("---------");
        foreach (var fimon in trainer.FImons)
        {
            trainersListBox.Items.Add($"{fimon.Name} - {fimon.MaxHP} HP - {fimon.Attack} Attack - {fimon.Speed} Speed");
        }
    }

    private void FimonsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        RefreshBox();
    }
}