namespace FImonTournaments
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tournamentsButton = new Button();
            trainersButton = new Button();
            exitButton = new Button();
            LogoPictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentsButton
            // 
            tournamentsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tournamentsButton.BackColor = Color.FromArgb(60, 128, 128);
            tournamentsButton.Cursor = Cursors.Hand;
            tournamentsButton.FlatAppearance.BorderColor = Color.White;
            tournamentsButton.FlatAppearance.BorderSize = 0;
            tournamentsButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tournamentsButton.ForeColor = Color.White;
            tournamentsButton.Location = new Point(325, 68);
            tournamentsButton.Name = "tournamentsButton";
            tournamentsButton.Size = new Size(285, 59);
            tournamentsButton.TabIndex = 0;
            tournamentsButton.Text = "Tournaments";
            tournamentsButton.UseVisualStyleBackColor = false;
            tournamentsButton.Click += Tournaments_Click;
            // 
            // trainersButton
            // 
            trainersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            trainersButton.BackColor = Color.FromArgb(100, 60, 150);
            trainersButton.Cursor = Cursors.Hand;
            trainersButton.FlatAppearance.BorderSize = 0;
            trainersButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            trainersButton.ForeColor = Color.White;
            trainersButton.Location = new Point(325, 133);
            trainersButton.Name = "trainersButton";
            trainersButton.Size = new Size(285, 59);
            trainersButton.TabIndex = 1;
            trainersButton.Text = "Trainers";
            trainersButton.UseVisualStyleBackColor = false;
            trainersButton.Click += Trainers_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            exitButton.BackColor = Color.DarkRed;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(325, 198);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(285, 59);
            exitButton.TabIndex = 2;
            exitButton.Text = "Quit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Quit_Click;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogoPictureBox.BackColor = Color.Transparent;
            LogoPictureBox.Image = Properties.Resources.FImon_Tournaments_Logo2;
            LogoPictureBox.Location = new Point(3, 3);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(936, 215);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 4;
            LogoPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(LogoPictureBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(942, 553);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tournamentsButton, 0, 1);
            tableLayoutPanel2.Controls.Add(trainersButton, 0, 2);
            tableLayoutPanel2.Controls.Add(exitButton, 0, 3);
            tableLayoutPanel2.Location = new Point(3, 224);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(936, 326);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.Screenshot_2024_04_28_130125;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 553);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FImon Tournaments";
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button tournamentsButton;
        private Button trainersButton;
        private Button exitButton;
        private PictureBox LogoPictureBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
