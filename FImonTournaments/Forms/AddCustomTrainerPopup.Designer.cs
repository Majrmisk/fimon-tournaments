namespace FImonTournaments
{
    partial class AddCustomTrainerPopup
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
            nameBox = new TextBox();
            nameLabel = new Label();
            customFImonCheckBox = new CheckBox();
            backButton = new Button();
            addTrainerButtom = new Button();
            groupBoxCustomFImon = new GroupBox();
            customLabel = new Label();
            mainTableLayoutPanel = new TableLayoutPanel();
            nameTableLayoutPanel = new TableLayoutPanel();
            addBackTableLayoutPanel = new TableLayoutPanel();
            customTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.SuspendLayout();
            nameTableLayoutPanel.SuspendLayout();
            addBackTableLayoutPanel.SuspendLayout();
            customTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameBox.BackColor = SystemColors.GradientInactiveCaption;
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Segoe UI", 15F);
            nameBox.ForeColor = Color.Navy;
            nameBox.Location = new Point(156, 10);
            nameBox.Margin = new Padding(10);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(322, 41);
            nameBox.TabIndex = 9;
            nameBox.TextAlign = HorizontalAlignment.Center;
            nameBox.Enter += NameBox_Enter;
            nameBox.Leave += NameBoxLeave;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            nameLabel.ForeColor = SystemColors.Desktop;
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(140, 60);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customFImonCheckBox
            // 
            customFImonCheckBox.Anchor = AnchorStyles.Left;
            customFImonCheckBox.AutoSize = true;
            customFImonCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            customFImonCheckBox.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            customFImonCheckBox.Location = new Point(219, 11);
            customFImonCheckBox.Name = "customFImonCheckBox";
            customFImonCheckBox.Size = new Size(18, 17);
            customFImonCheckBox.TabIndex = 11;
            customFImonCheckBox.UseVisualStyleBackColor = true;
            customFImonCheckBox.CheckedChanged += CustomFImonCheckBox_CheckedChanged;
            // 
            // backButton
            // 
            backButton.BackColor = Color.DarkRed;
            backButton.Cursor = Cursors.Hand;
            backButton.Dock = DockStyle.Fill;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(3, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(233, 49);
            backButton.TabIndex = 13;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // addTrainerButtom
            // 
            addTrainerButtom.BackColor = Color.SteelBlue;
            addTrainerButtom.Cursor = Cursors.Hand;
            addTrainerButtom.Dock = DockStyle.Fill;
            addTrainerButtom.FlatAppearance.BorderSize = 0;
            addTrainerButtom.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            addTrainerButtom.ForeColor = Color.White;
            addTrainerButtom.Location = new Point(242, 3);
            addTrainerButtom.Name = "addTrainerButtom";
            addTrainerButtom.Size = new Size(233, 49);
            addTrainerButtom.TabIndex = 14;
            addTrainerButtom.Text = "Add Trainer";
            addTrainerButtom.UseVisualStyleBackColor = false;
            addTrainerButtom.Click += AddTrainerButtom_Click;
            // 
            // groupBoxCustomFImon
            // 
            groupBoxCustomFImon.Dock = DockStyle.Fill;
            groupBoxCustomFImon.Location = new Point(10, 130);
            groupBoxCustomFImon.Margin = new Padding(10);
            groupBoxCustomFImon.Name = "groupBoxCustomFImon";
            groupBoxCustomFImon.Size = new Size(468, 341);
            groupBoxCustomFImon.TabIndex = 12;
            groupBoxCustomFImon.TabStop = false;
            // 
            // customLabel
            // 
            customLabel.AutoSize = true;
            customLabel.BackColor = Color.Transparent;
            customLabel.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            customLabel.ForeColor = SystemColors.Desktop;
            customLabel.Location = new Point(3, 0);
            customLabel.Name = "customLabel";
            customLabel.Size = new Size(207, 35);
            customLabel.TabIndex = 15;
            customLabel.Text = "Custom FImons";
            customLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.BackColor = Color.Transparent;
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(groupBoxCustomFImon, 0, 2);
            mainTableLayoutPanel.Controls.Add(nameTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(addBackTableLayoutPanel, 0, 3);
            mainTableLayoutPanel.Controls.Add(customTableLayoutPanel, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(10);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 4;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainTableLayoutPanel.Size = new Size(488, 541);
            mainTableLayoutPanel.TabIndex = 16;
            // 
            // nameTableLayoutPanel
            // 
            nameTableLayoutPanel.ColumnCount = 2;
            nameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            nameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            nameTableLayoutPanel.Controls.Add(nameLabel, 0, 0);
            nameTableLayoutPanel.Controls.Add(nameBox, 1, 0);
            nameTableLayoutPanel.Dock = DockStyle.Fill;
            nameTableLayoutPanel.Location = new Point(0, 0);
            nameTableLayoutPanel.Margin = new Padding(0);
            nameTableLayoutPanel.Name = "nameTableLayoutPanel";
            nameTableLayoutPanel.RowCount = 1;
            nameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            nameTableLayoutPanel.Size = new Size(488, 60);
            nameTableLayoutPanel.TabIndex = 0;
            // 
            // addBackTableLayoutPanel
            // 
            addBackTableLayoutPanel.ColumnCount = 2;
            addBackTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addBackTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addBackTableLayoutPanel.Controls.Add(backButton, 0, 0);
            addBackTableLayoutPanel.Controls.Add(addTrainerButtom, 1, 0);
            addBackTableLayoutPanel.Dock = DockStyle.Fill;
            addBackTableLayoutPanel.Location = new Point(5, 481);
            addBackTableLayoutPanel.Margin = new Padding(5, 0, 5, 5);
            addBackTableLayoutPanel.Name = "addBackTableLayoutPanel";
            addBackTableLayoutPanel.RowCount = 1;
            addBackTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            addBackTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            addBackTableLayoutPanel.Size = new Size(478, 55);
            addBackTableLayoutPanel.TabIndex = 1;
            // 
            // customTableLayoutPanel
            // 
            customTableLayoutPanel.ColumnCount = 2;
            customTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 216F));
            customTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            customTableLayoutPanel.Controls.Add(customFImonCheckBox, 1, 0);
            customTableLayoutPanel.Controls.Add(customLabel, 0, 0);
            customTableLayoutPanel.Dock = DockStyle.Fill;
            customTableLayoutPanel.Location = new Point(10, 70);
            customTableLayoutPanel.Margin = new Padding(10);
            customTableLayoutPanel.Name = "customTableLayoutPanel";
            customTableLayoutPanel.RowCount = 1;
            customTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            customTableLayoutPanel.Size = new Size(468, 40);
            customTableLayoutPanel.TabIndex = 13;
            // 
            // AddCustomTrainerPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(488, 541);
            ControlBox = false;
            Controls.Add(mainTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomTrainerPopup";
            Opacity = 0.95D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FImon Tournaments";
            mainTableLayoutPanel.ResumeLayout(false);
            nameTableLayoutPanel.ResumeLayout(false);
            nameTableLayoutPanel.PerformLayout();
            addBackTableLayoutPanel.ResumeLayout(false);
            customTableLayoutPanel.ResumeLayout(false);
            customTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameBox;
        private Label nameLabel;
        private CheckBox customFImonCheckBox;
        private Button backButton;
        private Button addTrainerButtom;
        private Label customLabel;
        private GroupBox groupBoxCustomFImon;
        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel nameTableLayoutPanel;
        private TableLayoutPanel addBackTableLayoutPanel;
        private TableLayoutPanel customTableLayoutPanel;
    }
}