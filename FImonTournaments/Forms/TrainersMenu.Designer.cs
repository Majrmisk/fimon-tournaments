namespace FImonTournaments
{
    partial class TrainersMenu
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
            components = new System.ComponentModel.Container();
            backButton = new Button();
            trainersLabel = new Label();
            trainersListBox = new ListBox();
            idBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            removeButton = new Button();
            addRandomButton = new Button();
            addCustomButton = new Button();
            fimonsLabel = new Label();
            fimonsCheckBox = new CheckBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            rightTableLayoutPanel = new TableLayoutPanel();
            delTableLayoutPanel = new TableLayoutPanel();
            fimonTableLayoutPanel = new TableLayoutPanel();
            listPanel = new Panel();
            mainTableLayoutPanel.SuspendLayout();
            rightTableLayoutPanel.SuspendLayout();
            delTableLayoutPanel.SuspendLayout();
            fimonTableLayoutPanel.SuspendLayout();
            listPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.DarkRed;
            backButton.Cursor = Cursors.Hand;
            backButton.Dock = DockStyle.Fill;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(10, 357);
            backButton.Margin = new Padding(10);
            backButton.Name = "backButton";
            backButton.Size = new Size(351, 60);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // trainersLabel
            // 
            trainersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            trainersLabel.AutoSize = true;
            trainersLabel.BackColor = Color.Transparent;
            trainersLabel.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            trainersLabel.ForeColor = SystemColors.MenuBar;
            trainersLabel.Location = new Point(107, 39);
            trainersLabel.Name = "trainersLabel";
            trainersLabel.Size = new Size(157, 80);
            trainersLabel.TabIndex = 6;
            trainersLabel.Text = "Trainers";
            trainersLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trainersListBox
            // 
            trainersListBox.BackColor = Color.Thistle;
            trainersListBox.BorderStyle = BorderStyle.FixedSingle;
            trainersListBox.Dock = DockStyle.Fill;
            trainersListBox.Font = new Font("Segoe UI", 10F);
            trainersListBox.ForeColor = Color.Indigo;
            trainersListBox.FormattingEnabled = true;
            trainersListBox.HorizontalScrollbar = true;
            trainersListBox.ItemHeight = 23;
            trainersListBox.Location = new Point(0, 0);
            trainersListBox.Name = "trainersListBox";
            trainersListBox.Size = new Size(543, 531);
            trainersListBox.TabIndex = 7;
            // 
            // idBox
            // 
            idBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            idBox.BackColor = Color.Thistle;
            idBox.BorderStyle = BorderStyle.FixedSingle;
            idBox.Font = new Font("Segoe UI", 18F);
            idBox.ForeColor = Color.FromArgb(200, 170, 200);
            idBox.Location = new Point(10, 10);
            idBox.Margin = new Padding(10);
            idBox.Name = "idBox";
            idBox.Size = new Size(136, 47);
            idBox.TabIndex = 8;
            idBox.Text = "ID";
            idBox.TextAlign = HorizontalAlignment.Center;
            idBox.Enter += IdBox_GotFocus;
            idBox.Leave += IdBox_LostFocus;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.FromArgb(192, 0, 0);
            removeButton.Cursor = Cursors.Hand;
            removeButton.Dock = DockStyle.Fill;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(166, 10);
            removeButton.Margin = new Padding(10);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(195, 48);
            removeButton.TabIndex = 10;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += RemoveButton_Click;
            // 
            // addRandomButton
            // 
            addRandomButton.BackColor = Color.FromArgb(100, 60, 150);
            addRandomButton.Cursor = Cursors.Hand;
            addRandomButton.Dock = DockStyle.Fill;
            addRandomButton.FlatAppearance.BorderSize = 0;
            addRandomButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            addRandomButton.ForeColor = Color.White;
            addRandomButton.Location = new Point(10, 277);
            addRandomButton.Margin = new Padding(10);
            addRandomButton.Name = "addRandomButton";
            addRandomButton.Size = new Size(351, 60);
            addRandomButton.TabIndex = 11;
            addRandomButton.Text = "Add random";
            addRandomButton.UseVisualStyleBackColor = false;
            addRandomButton.Click += AddRandomButton_Click;
            // 
            // addCustomButton
            // 
            addCustomButton.BackColor = Color.FromArgb(150, 70, 200);
            addCustomButton.Cursor = Cursors.Hand;
            addCustomButton.Dock = DockStyle.Fill;
            addCustomButton.FlatAppearance.BorderSize = 0;
            addCustomButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            addCustomButton.ForeColor = Color.White;
            addCustomButton.Location = new Point(10, 197);
            addCustomButton.Margin = new Padding(10);
            addCustomButton.Name = "addCustomButton";
            addCustomButton.Size = new Size(351, 60);
            addCustomButton.TabIndex = 12;
            addCustomButton.Text = "Add custom";
            addCustomButton.UseVisualStyleBackColor = false;
            addCustomButton.Click += AddCustomButton_Click;
            // 
            // fimonsLabel
            // 
            fimonsLabel.Anchor = AnchorStyles.Bottom;
            fimonsLabel.AutoSize = true;
            fimonsLabel.BackColor = Color.Transparent;
            fimonsLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            fimonsLabel.ForeColor = SystemColors.MenuBar;
            fimonsLabel.Location = new Point(88, 10);
            fimonsLabel.Name = "fimonsLabel";
            fimonsLabel.Size = new Size(194, 35);
            fimonsLabel.TabIndex = 13;
            fimonsLabel.Text = "Show FImons";
            fimonsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fimonsCheckBox
            // 
            fimonsCheckBox.Anchor = AnchorStyles.Top;
            fimonsCheckBox.AutoSize = true;
            fimonsCheckBox.CheckAlign = ContentAlignment.BottomCenter;
            fimonsCheckBox.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            fimonsCheckBox.Location = new Point(176, 48);
            fimonsCheckBox.Name = "fimonsCheckBox";
            fimonsCheckBox.Size = new Size(18, 17);
            fimonsCheckBox.TabIndex = 26;
            fimonsCheckBox.UseVisualStyleBackColor = true;
            fimonsCheckBox.CheckedChanged += FimonsCheckBox_CheckedChanged;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.BackColor = Color.Transparent;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainTableLayoutPanel.Controls.Add(rightTableLayoutPanel, 1, 0);
            mainTableLayoutPanel.Controls.Add(listPanel, 0, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(942, 553);
            mainTableLayoutPanel.TabIndex = 27;
            // 
            // rightTableLayoutPanel
            // 
            rightTableLayoutPanel.ColumnCount = 1;
            rightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightTableLayoutPanel.Controls.Add(trainersLabel, 0, 1);
            rightTableLayoutPanel.Controls.Add(backButton, 0, 5);
            rightTableLayoutPanel.Controls.Add(addRandomButton, 0, 4);
            rightTableLayoutPanel.Controls.Add(addCustomButton, 0, 3);
            rightTableLayoutPanel.Controls.Add(delTableLayoutPanel, 0, 2);
            rightTableLayoutPanel.Controls.Add(fimonTableLayoutPanel, 0, 6);
            rightTableLayoutPanel.Dock = DockStyle.Fill;
            rightTableLayoutPanel.Location = new Point(568, 3);
            rightTableLayoutPanel.Name = "rightTableLayoutPanel";
            rightTableLayoutPanel.RowCount = 8;
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            rightTableLayoutPanel.Size = new Size(371, 547);
            rightTableLayoutPanel.TabIndex = 0;
            // 
            // delTableLayoutPanel
            // 
            delTableLayoutPanel.ColumnCount = 2;
            delTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            delTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            delTableLayoutPanel.Controls.Add(removeButton, 1, 0);
            delTableLayoutPanel.Controls.Add(idBox, 0, 0);
            delTableLayoutPanel.Dock = DockStyle.Fill;
            delTableLayoutPanel.Location = new Point(0, 119);
            delTableLayoutPanel.Margin = new Padding(0);
            delTableLayoutPanel.Name = "delTableLayoutPanel";
            delTableLayoutPanel.RowCount = 1;
            delTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            delTableLayoutPanel.Size = new Size(371, 68);
            delTableLayoutPanel.TabIndex = 13;
            // 
            // fimonTableLayoutPanel
            // 
            fimonTableLayoutPanel.ColumnCount = 1;
            fimonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            fimonTableLayoutPanel.Controls.Add(fimonsCheckBox, 0, 1);
            fimonTableLayoutPanel.Controls.Add(fimonsLabel, 0, 0);
            fimonTableLayoutPanel.Dock = DockStyle.Fill;
            fimonTableLayoutPanel.Location = new Point(0, 427);
            fimonTableLayoutPanel.Margin = new Padding(0);
            fimonTableLayoutPanel.Name = "fimonTableLayoutPanel";
            fimonTableLayoutPanel.Padding = new Padding(0, 10, 0, 0);
            fimonTableLayoutPanel.RowCount = 2;
            fimonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fimonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fimonTableLayoutPanel.Size = new Size(371, 80);
            fimonTableLayoutPanel.TabIndex = 14;
            // 
            // listPanel
            // 
            listPanel.Controls.Add(trainersListBox);
            listPanel.Dock = DockStyle.Fill;
            listPanel.Location = new Point(11, 11);
            listPanel.Margin = new Padding(11);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(543, 531);
            listPanel.TabIndex = 1;
            // 
            // TrainersMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 0, 35);
            ClientSize = new Size(942, 553);
            ControlBox = false;
            Controls.Add(mainTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "TrainersMenu";
            ShowIcon = false;
            Text = "FImon Tournaments";
            mainTableLayoutPanel.ResumeLayout(false);
            rightTableLayoutPanel.ResumeLayout(false);
            rightTableLayoutPanel.PerformLayout();
            delTableLayoutPanel.ResumeLayout(false);
            delTableLayoutPanel.PerformLayout();
            fimonTableLayoutPanel.ResumeLayout(false);
            fimonTableLayoutPanel.PerformLayout();
            listPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Label trainersLabel;
        private ListBox trainersListBox;
        private TextBox idBox;
        private ContextMenuStrip contextMenuStrip1;
        private Button removeButton;
        private Button addRandomButton;
        private Button addCustomButton;
        private Label fimonsLabel;
        private CheckBox fimonsCheckBox;
        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel rightTableLayoutPanel;
        private Panel listPanel;
        private TableLayoutPanel delTableLayoutPanel;
        private TableLayoutPanel fimonTableLayoutPanel;
    }
}