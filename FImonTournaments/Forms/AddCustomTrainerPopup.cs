using FImonTournaments.Core;
using FImonTournaments.Models.GameObjects.FImons;
using FImonTournaments.Models.GameObjects.FImons.Abstracts;
using FImonTournaments.Utils;
using FImonTournaments.Utils.Constants;

namespace FImonTournaments;

public partial class AddCustomTrainerPopup : Form
{
    private readonly DataHandler _dataHandler;

    private readonly TextBox[] _fimonNameTextBoxes;
    private readonly ComboBox[] _fimonTypeComboBoxes;
    private readonly NumericUpDown[] _fimonAttackTextBoxes;
    private readonly NumericUpDown[] _fimonSpeedTextBoxes;

    private readonly TableLayoutPanel _fimonTable;

    public AddCustomTrainerPopup(DataHandler dataHandler)
    {
        _dataHandler = dataHandler;
        InitializeComponent();

        _fimonNameTextBoxes = new TextBox[TournamentConstants.FImonsPerTrainer];
        _fimonTypeComboBoxes = new ComboBox[TournamentConstants.FImonsPerTrainer];
        _fimonAttackTextBoxes = new NumericUpDown[TournamentConstants.FImonsPerTrainer];
        _fimonSpeedTextBoxes = new NumericUpDown[TournamentConstants.FImonsPerTrainer];

        _fimonTable = InitializeFImonTable();

        groupBoxCustomFImon.Controls.Add(_fimonTable);
        groupBoxCustomFImon.Enabled = false;
    }

    private TableLayoutPanel InitializeFImonTable()
    {
        TableLayoutPanel _fimonTable = new()
        {
            RowCount = TournamentConstants.FImonsPerTrainer + 1,

            // I did not put these in a constants file because these values are not repeated and should not be changed anyway.
            ColumnCount = 4,
            Width = 480,
            Height = 380
        };

        _fimonTable.Controls.Add(new Label() { Text = "Type", TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
        _fimonTable.Controls.Add(new Label() { Text = "Name", TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
        _fimonTable.Controls.Add(new Label() { Text = "Speed", TextAlign = ContentAlignment.MiddleCenter }, 2, 0);
        _fimonTable.Controls.Add(new Label() { Text = "Attack", TextAlign = ContentAlignment.MiddleCenter }, 3, 0);

        for (int i = 0; i < TournamentConstants.FImonsPerTrainer; i++)
        {
            _fimonNameTextBoxes[i] = new TextBox();
            _fimonTypeComboBoxes[i] = new ComboBox();

            _fimonAttackTextBoxes[i] = new NumericUpDown
            {
                Minimum = FImonConstants.MinAttack,
                Maximum = FImonConstants.MaxAttack
            };
            _fimonSpeedTextBoxes[i] = new NumericUpDown
            {
                Minimum = FImonConstants.MinSpeed,
                Maximum = FImonConstants.MaxSpeed
            };

            foreach (var type in Enum.GetValues(typeof(FImonType)))
            {
                _fimonTypeComboBoxes[i].Items.Add(type);
            }

            _fimonTable.Controls.Add(_fimonNameTextBoxes[i], 1, i + 1);
            _fimonTable.Controls.Add(_fimonTypeComboBoxes[i], 0, i + 1);
            _fimonTable.Controls.Add(_fimonSpeedTextBoxes[i], 2, i + 1);
            _fimonTable.Controls.Add(_fimonAttackTextBoxes[i], 3, i + 1);
        }
        return _fimonTable;
    }

    private void CustomFImonCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        groupBoxCustomFImon.Enabled = !groupBoxCustomFImon.Enabled;
    }

    private void NameBox_Enter(object sender, EventArgs e)
    {
        if (nameBox.Text == "Trainer's name")
        {
            nameBox.Text = "";
            nameBox.ForeColor = Color.Navy;
        }
    }

    private void NameBoxLeave(object sender, EventArgs e)
    {
        if (nameBox.Text == "")
        {
            nameBox.Text = "Trainer's name";
            nameBox.ForeColor = Color.LightSteelBlue;
        }
    }

    private async void AddTrainerButtom_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(nameBox.Text) || nameBox.Text == "Trainer's name")
        {
            MessageBox.Show("Empty Trainer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!groupBoxCustomFImon.Enabled)
        {
            await _dataHandler.AddTrainer(new(nameBox.Text));
            Close();
            return;
        }

        IList<FImon> trainerFImon = [];

        for (int i = 0; i < _fimonTable.RowCount - 1; i++)
        {

            string fimonName = _fimonNameTextBoxes[i].Text;
            FImonType? fimonType = (FImonType?)_fimonTypeComboBoxes[i].SelectedItem;
            int fimonAttack = (int)_fimonAttackTextBoxes[i].Value;
            int fimonSpeed = (int)_fimonSpeedTextBoxes[i].Value;

            if (fimonType == null)
            {
                MessageBox.Show("Invalid FImon types.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(fimonName))
            {
                MessageBox.Show("Empty FImon names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FImon newFImon = fimonType switch
            {
                FImonType.Water => new Water(fimonName, fimonAttack, fimonSpeed, 20 - fimonAttack - fimonSpeed),
                FImonType.Leaf => new Leaf(fimonName, fimonAttack, fimonSpeed, 20 - fimonAttack - fimonSpeed),
                FImonType.Fire => new Fire(fimonName, fimonAttack, fimonSpeed, 20 - fimonAttack - fimonSpeed),
                _ => throw new InvalidOperationException("[ERROR] Use of not implemented FImonType."),
            };
            trainerFImon.Add(newFImon);
        }

        await _dataHandler.AddTrainer(new([.. trainerFImon], nameBox.Text));
        Close();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
