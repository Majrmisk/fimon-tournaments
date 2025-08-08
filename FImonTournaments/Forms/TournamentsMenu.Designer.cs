namespace FImonTournaments
{
    partial class TournamentsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tournamentsListBox = new ListBox();
            tournamentsLabel = new Label();
            backButton = new Button();
            newTournamentButton = new Button();
            startTournamentButton = new Button();
            mainTableLayoutPanel = new TableLayoutPanel();
            rightTableLayoutPanel = new TableLayoutPanel();
            buttonsPanel = new Panel();
            listPanel = new Panel();
            mainTableLayoutPanel.SuspendLayout();
            rightTableLayoutPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            listPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentsListBox
            // 
            tournamentsListBox.BackColor = Color.LightCyan;
            tournamentsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentsListBox.Cursor = Cursors.IBeam;
            tournamentsListBox.Dock = DockStyle.Fill;
            tournamentsListBox.Font = new Font("Segoe UI", 10F);
            tournamentsListBox.ForeColor = Color.FromArgb(0, 64, 64);
            tournamentsListBox.FormattingEnabled = true;
            tournamentsListBox.HorizontalScrollbar = true;
            tournamentsListBox.ItemHeight = 23;
            tournamentsListBox.Location = new Point(0, 0);
            tournamentsListBox.Margin = new Padding(0);
            tournamentsListBox.Name = "tournamentsListBox";
            tournamentsListBox.Size = new Size(637, 531);
            tournamentsListBox.TabIndex = 8;
            // 
            // tournamentsLabel
            // 
            tournamentsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tournamentsLabel.AutoSize = true;
            tournamentsLabel.BackColor = Color.Transparent;
            tournamentsLabel.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tournamentsLabel.ForeColor = SystemColors.MenuBar;
            tournamentsLabel.Location = new Point(17, 153);
            tournamentsLabel.Name = "tournamentsLabel";
            tournamentsLabel.Size = new Size(242, 80);
            tournamentsLabel.TabIndex = 9;
            tournamentsLabel.Text = "Tournaments";
            tournamentsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.BackColor = Color.DarkRed;
            backButton.Cursor = Cursors.Hand;
            backButton.Dock = DockStyle.Fill;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(10, 323);
            backButton.Margin = new Padding(10);
            backButton.Name = "backButton";
            backButton.Size = new Size(257, 60);
            backButton.TabIndex = 10;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // newTournamentButton
            // 
            newTournamentButton.BackColor = Color.FromArgb(60, 128, 128);
            newTournamentButton.Cursor = Cursors.Hand;
            newTournamentButton.Dock = DockStyle.Fill;
            newTournamentButton.FlatAppearance.BorderSize = 0;
            newTournamentButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            newTournamentButton.ForeColor = Color.White;
            newTournamentButton.Location = new Point(0, 0);
            newTournamentButton.Margin = new Padding(0);
            newTournamentButton.Name = "newTournamentButton";
            newTournamentButton.Size = new Size(257, 60);
            newTournamentButton.TabIndex = 11;
            newTournamentButton.Text = "New Tournament";
            newTournamentButton.UseVisualStyleBackColor = false;
            newTournamentButton.Click += NewTournamentButton_Click;
            // 
            // startTournamentButton
            // 
            startTournamentButton.BackColor = Color.FromArgb(60, 200, 128);
            startTournamentButton.Cursor = Cursors.Hand;
            startTournamentButton.Dock = DockStyle.Fill;
            startTournamentButton.FlatAppearance.BorderSize = 0;
            startTournamentButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            startTournamentButton.ForeColor = Color.White;
            startTournamentButton.Location = new Point(0, 0);
            startTournamentButton.Margin = new Padding(10);
            startTournamentButton.Name = "startTournamentButton";
            startTournamentButton.Size = new Size(257, 60);
            startTournamentButton.TabIndex = 12;
            startTournamentButton.Text = "Start Tournament";
            startTournamentButton.UseVisualStyleBackColor = false;
            startTournamentButton.Visible = false;
            startTournamentButton.Click += StartTournamentButton_Click;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            mainTableLayoutPanel.Controls.Add(rightTableLayoutPanel, 1, 0);
            mainTableLayoutPanel.Controls.Add(listPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(942, 553);
            mainTableLayoutPanel.TabIndex = 13;
            // 
            // rightTableLayoutPanel
            // 
            rightTableLayoutPanel.ColumnCount = 1;
            rightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightTableLayoutPanel.Controls.Add(tournamentsLabel, 0, 1);
            rightTableLayoutPanel.Controls.Add(backButton, 0, 3);
            rightTableLayoutPanel.Controls.Add(buttonsPanel, 0, 2);
            rightTableLayoutPanel.Dock = DockStyle.Fill;
            rightTableLayoutPanel.Location = new Point(662, 3);
            rightTableLayoutPanel.Name = "rightTableLayoutPanel";
            rightTableLayoutPanel.RowCount = 5;
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightTableLayoutPanel.Size = new Size(277, 547);
            rightTableLayoutPanel.TabIndex = 1;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonsPanel.Controls.Add(startTournamentButton);
            buttonsPanel.Controls.Add(newTournamentButton);
            buttonsPanel.Location = new Point(10, 243);
            buttonsPanel.Margin = new Padding(10);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(257, 60);
            buttonsPanel.TabIndex = 13;
            // 
            // listPanel
            // 
            listPanel.BackColor = Color.LightCyan;
            listPanel.Controls.Add(tournamentsListBox);
            listPanel.Dock = DockStyle.Fill;
            listPanel.Location = new Point(11, 11);
            listPanel.Margin = new Padding(11);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(637, 531);
            listPanel.TabIndex = 0;
            // 
            // TournamentsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 55, 55);
            ClientSize = new Size(942, 553);
            ControlBox = false;
            Controls.Add(mainTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "TournamentsMenu";
            Text = "FImon Tournaments";
            mainTableLayoutPanel.ResumeLayout(false);
            rightTableLayoutPanel.ResumeLayout(false);
            rightTableLayoutPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            listPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox tournamentsListBox;
        private Label tournamentsLabel;
        private Button backButton;
        private Button newTournamentButton;
        private Button startTournamentButton;
        private TableLayoutPanel mainTableLayoutPanel;
        private Panel listPanel;
        private TableLayoutPanel rightTableLayoutPanel;
        private Panel buttonsPanel;
    }
}