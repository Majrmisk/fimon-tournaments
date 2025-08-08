using FImonTournaments.Core;
using FImonTournaments.Models.GameObjects.Tournaments;
using FImonTournaments.Models.GameObjects.Trainers;
using FImonTournaments.Utils;
using FImonTournaments.Utils.Constants;

namespace FImonTournaments;

public partial class NewTournamentPopup : Form
{
    private readonly DataHandler _dataHandler;
    private readonly TournamentsMenu _tournamentMenuForm;

    private TournamentSize _size = TournamentSize.Medium;
    private TournamentType _type = TournamentType.Standard;

    private IList<TextBox> _standardBoxes = [];
    private IList<TextBox> _groupsBoxes = [];

    public NewTournamentPopup(DataHandler dataHandler, TournamentsMenu tournamentMenuForm)
    {
        InitializeComponent();
        InitializeTextBoxLists();

        mediumRadioButton.Checked = true;
        standardTypeRadioButton.Checked = true;

        _dataHandler = dataHandler;
        _tournamentMenuForm = tournamentMenuForm;
    }

    private void InitializeTextBoxLists()
    {
        _standardBoxes = [
            idStandardBox1,
            idStandardBox2,
            idStandardBox3,
            idStandardBox4,
            idStandardBox5,
            idStandardBox6,
            idStandardBox7,
            idStandardBox8,
            idStandardBox9,
            idStandardBox10,
            idStandardBox11,
            idStandardBox12,
            idStandardBox13,
            idStandardBox14,
            idStandardBox15,
            idStandardBox16
        ];

        _groupsBoxes = [
            idGroupsBox1,
            idGroupsBox2,
            idGroupsBox3,
            idGroupsBox4,
            idGroupsBox5,
            idGroupsBox6,
            idGroupsBox7,
            idGroupsBox8,
            idGroupsBox9,
            idGroupsBox10,
            idGroupsBox11,
            idGroupsBox12,
            idGroupsBox13,
            idGroupsBox14,
            idGroupsBox15,
            idGroupsBox16
        ];
    }

    private void LargeRadioButton_Click(object sender, EventArgs e)
    {
        _size = TournamentSize.Large;
        UpdatePanels();
    }

    private void MediumRadioButton_Click(object sender, EventArgs e)
    {
        _size = TournamentSize.Medium;
        UpdatePanels();
    }

    private void SmalleRadioButton_Click(object sender, EventArgs e)
    {
        _size = TournamentSize.Small;
        UpdatePanels();
    }

    private void StandardTypeRadioButton_Click(object sender, EventArgs e)
    {
        _type = TournamentType.Standard;
        UpdatePanels();
    }

    private void GroupsTypeRadioButton_Click(object sender, EventArgs e)
    {
        _type = TournamentType.Groups;
        UpdatePanels();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void UpdatePanels()
    {
        smallStandardPanel.Visible = customTrainersCheckBox.Checked 
            && _type == TournamentType.Standard;
        mediumStandardPanel.Visible = customTrainersCheckBox.Checked 
            && _type == TournamentType.Standard 
            && _size != TournamentSize.Small;
        largeStandardPanel.Visible = customTrainersCheckBox.Checked
            && _type == TournamentType.Standard
            && _size == TournamentSize.Large;

        smallGroupsPanel.Visible = customTrainersCheckBox.Checked
            && _type == TournamentType.Groups;
        mediumGroupsPanel.Visible = customTrainersCheckBox.Checked
            && _type == TournamentType.Groups
            && _size != TournamentSize.Small;
        largeGroupsPanel.Visible = customTrainersCheckBox.Checked
            && _type == TournamentType.Groups
            && _size == TournamentSize.Large;

        idLabel.Visible = customTrainersCheckBox.Checked;

        standardTableLayoutPanel.Visible = customTrainersCheckBox.Checked
            && _type == TournamentType.Standard;
        groupsTableLayoutPanel.Visible = customTrainersCheckBox.Checked
            && _type == TournamentType.Groups;
    }

    private void CustomTrainersCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdatePanels();
    }

    private void StartTournamentButtom_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(nameBox.Text))
        {
            MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ProcessTrainers(out IList<Trainer> pickedTrainers))
        {
            return;
        }

        Tournament tournament = new(pickedTrainers, nameBox.Text, _size, _type);

        Close();
        _tournamentMenuForm.TournamentSet(tournament);
    }

    private bool ProcessTrainers(out IList<Trainer> pickedTrainers)
    {
        var sizeInt = TournamentConstants.TournamentSizeTrainerAmount[_size];

        if (sizeInt > _dataHandler.Trainers.Count)
        {
            MessageBox.Show("Not enough enough trainers for this tournament _size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pickedTrainers = [];
            return false;
        }

        if (!customTrainersCheckBox.Checked)
        {
            Random random = new();
            pickedTrainers = _dataHandler.Trainers.Values
                .OrderBy(x => random.Next())
                .Take(sizeInt)
                .ToList();
            return true;
        }

        return PickCustomTrainers(out pickedTrainers, sizeInt);
    }

    private bool PickCustomTrainers(out IList<Trainer> pickedTrainers, int sizeInt)
    {
        pickedTrainers = [];

        for (int i = 0; i < sizeInt; i++)
        {
            var id = -1;
            if ((_type == TournamentType.Standard && !int.TryParse(_standardBoxes[i].Text, out id))
                || (_type == TournamentType.Groups && !int.TryParse(_groupsBoxes[i].Text, out id)))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!_dataHandler.Trainers.TryGetValue(id, out Trainer? trainer))
            {
                MessageBox.Show("Trainer with ID " + id + " does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            pickedTrainers.Add(trainer);
        }

        if (pickedTrainers.Select(trainer => trainer.ID).Distinct().Count() != pickedTrainers.Count)
        {
            MessageBox.Show("Trainer IDs must be unique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}