namespace SBP_faza2.Forme
{
    partial class NastavniciForma
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
            nastavnikToolStrip = new ToolStrip();
            dodajToolStripButton = new ToolStripButton();
            toolStripButton2 = new ToolStripSeparator();
            izmeniToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            obrisiToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            sacuvajToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            odustaniToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            pretragaToolStripButton = new ToolStripButton();
            nastavnikGroupBox = new GroupBox();
            successStatusLabel = new Label();
            brojNastavnikaLabel = new Label();
            brojPrikazanihNastavnikaLabel = new Label();
            predmetErrorLabel = new Label();
            imePrezimeNastavnikaErrorLabel = new Label();
            predmetComboBox = new ComboBox();
            imePrezimeNastavnikaTextBox = new TextBox();
            predmetLabel = new Label();
            imePrezimeNastavnikaLabel = new Label();
            nastavnikDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            imePrezimeColumn = new DataGridViewTextBoxColumn();
            predmetColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            nastavnikToolStrip.SuspendLayout();
            nastavnikGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nastavnikDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nastavnikToolStrip
            // 
            nastavnikToolStrip.AutoSize = false;
            nastavnikToolStrip.BackColor = Color.Gainsboro;
            nastavnikToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nastavnikToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            nastavnikToolStrip.ImageScalingSize = new Size(20, 20);
            nastavnikToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripButton2, izmeniToolStripButton, toolStripSeparator1, obrisiToolStripButton, toolStripSeparator2, sacuvajToolStripButton, toolStripSeparator3, odustaniToolStripButton, toolStripSeparator4, pretragaToolStripButton });
            nastavnikToolStrip.Location = new Point(0, 0);
            nastavnikToolStrip.Name = "nastavnikToolStrip";
            nastavnikToolStrip.Size = new Size(1100, 43);
            nastavnikToolStrip.TabIndex = 2;
            nastavnikToolStrip.Text = "toolStrip1";
            // 
            // dodajToolStripButton
            // 
            dodajToolStripButton.Image = Properties.Resources.add_icon;
            dodajToolStripButton.ImageTransparentColor = Color.Magenta;
            dodajToolStripButton.Name = "dodajToolStripButton";
            dodajToolStripButton.Size = new Size(85, 40);
            dodajToolStripButton.Text = "Dodaj";
            dodajToolStripButton.Click += dodajToolStripButton_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(6, 43);
            // 
            // izmeniToolStripButton
            // 
            izmeniToolStripButton.Enabled = false;
            izmeniToolStripButton.Image = Properties.Resources.edit_icon;
            izmeniToolStripButton.ImageTransparentColor = Color.Magenta;
            izmeniToolStripButton.Name = "izmeniToolStripButton";
            izmeniToolStripButton.Size = new Size(92, 40);
            izmeniToolStripButton.Text = "Izmeni";
            izmeniToolStripButton.Click += izmeniToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
            // 
            // obrisiToolStripButton
            // 
            obrisiToolStripButton.Enabled = false;
            obrisiToolStripButton.Image = Properties.Resources.trash_can_icon;
            obrisiToolStripButton.ImageTransparentColor = Color.Magenta;
            obrisiToolStripButton.Name = "obrisiToolStripButton";
            obrisiToolStripButton.Size = new Size(85, 40);
            obrisiToolStripButton.Text = "Obriši";
            obrisiToolStripButton.Click += obrisiToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 43);
            // 
            // sacuvajToolStripButton
            // 
            sacuvajToolStripButton.Enabled = false;
            sacuvajToolStripButton.Image = Properties.Resources.save_icon;
            sacuvajToolStripButton.ImageTransparentColor = Color.Magenta;
            sacuvajToolStripButton.Name = "sacuvajToolStripButton";
            sacuvajToolStripButton.Size = new Size(101, 40);
            sacuvajToolStripButton.Text = "Sačuvaj";
            sacuvajToolStripButton.Click += sacuvajToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 43);
            // 
            // odustaniToolStripButton
            // 
            odustaniToolStripButton.Enabled = false;
            odustaniToolStripButton.Image = Properties.Resources.cancel_icon;
            odustaniToolStripButton.ImageTransparentColor = Color.Magenta;
            odustaniToolStripButton.Name = "odustaniToolStripButton";
            odustaniToolStripButton.Size = new Size(113, 40);
            odustaniToolStripButton.Text = "Odustani";
            odustaniToolStripButton.Click += odustaniToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 43);
            // 
            // pretragaToolStripButton
            // 
            pretragaToolStripButton.Image = Properties.Resources.magnifying_glass_icon;
            pretragaToolStripButton.ImageTransparentColor = Color.Magenta;
            pretragaToolStripButton.Name = "pretragaToolStripButton";
            pretragaToolStripButton.Size = new Size(109, 40);
            pretragaToolStripButton.Text = "Pretraga";
            // 
            // nastavnikGroupBox
            // 
            nastavnikGroupBox.Controls.Add(successStatusLabel);
            nastavnikGroupBox.Controls.Add(brojNastavnikaLabel);
            nastavnikGroupBox.Controls.Add(brojPrikazanihNastavnikaLabel);
            nastavnikGroupBox.Controls.Add(predmetErrorLabel);
            nastavnikGroupBox.Controls.Add(imePrezimeNastavnikaErrorLabel);
            nastavnikGroupBox.Controls.Add(predmetComboBox);
            nastavnikGroupBox.Controls.Add(imePrezimeNastavnikaTextBox);
            nastavnikGroupBox.Controls.Add(predmetLabel);
            nastavnikGroupBox.Controls.Add(imePrezimeNastavnikaLabel);
            nastavnikGroupBox.Location = new Point(12, 46);
            nastavnikGroupBox.Name = "nastavnikGroupBox";
            nastavnikGroupBox.Size = new Size(491, 482);
            nastavnikGroupBox.TabIndex = 3;
            nastavnikGroupBox.TabStop = false;
            nastavnikGroupBox.Text = "Podaci";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = SystemColors.ControlText;
            successStatusLabel.Location = new Point(46, 323);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 36;
            successStatusLabel.Text = "Polja označena zvezdicom su obavezna";
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brojNastavnikaLabel
            // 
            brojNastavnikaLabel.AutoSize = true;
            brojNastavnikaLabel.Location = new Point(333, 189);
            brojNastavnikaLabel.Name = "brojNastavnikaLabel";
            brojNastavnikaLabel.Size = new Size(0, 24);
            brojNastavnikaLabel.TabIndex = 19;
            // 
            // brojPrikazanihNastavnikaLabel
            // 
            brojPrikazanihNastavnikaLabel.AutoSize = true;
            brojPrikazanihNastavnikaLabel.Location = new Point(6, 189);
            brojPrikazanihNastavnikaLabel.Name = "brojPrikazanihNastavnikaLabel";
            brojPrikazanihNastavnikaLabel.Size = new Size(241, 24);
            brojPrikazanihNastavnikaLabel.TabIndex = 18;
            brojPrikazanihNastavnikaLabel.Text = "Broj prikazanih nastavnika:";
            // 
            // predmetErrorLabel
            // 
            predmetErrorLabel.ForeColor = Color.Red;
            predmetErrorLabel.Location = new Point(6, 146);
            predmetErrorLabel.Name = "predmetErrorLabel";
            predmetErrorLabel.Size = new Size(479, 25);
            predmetErrorLabel.TabIndex = 17;
            // 
            // imePrezimeNastavnikaErrorLabel
            // 
            imePrezimeNastavnikaErrorLabel.ForeColor = Color.Red;
            imePrezimeNastavnikaErrorLabel.Location = new Point(6, 83);
            imePrezimeNastavnikaErrorLabel.Name = "imePrezimeNastavnikaErrorLabel";
            imePrezimeNastavnikaErrorLabel.Size = new Size(479, 25);
            imePrezimeNastavnikaErrorLabel.TabIndex = 16;
            // 
            // predmetComboBox
            // 
            predmetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            predmetComboBox.Enabled = false;
            predmetComboBox.FormattingEnabled = true;
            predmetComboBox.Location = new Point(148, 111);
            predmetComboBox.Name = "predmetComboBox";
            predmetComboBox.Size = new Size(337, 32);
            predmetComboBox.TabIndex = 3;
            // 
            // imePrezimeNastavnikaTextBox
            // 
            imePrezimeNastavnikaTextBox.Enabled = false;
            imePrezimeNastavnikaTextBox.Location = new Point(148, 48);
            imePrezimeNastavnikaTextBox.MaxLength = 50;
            imePrezimeNastavnikaTextBox.Name = "imePrezimeNastavnikaTextBox";
            imePrezimeNastavnikaTextBox.Size = new Size(337, 32);
            imePrezimeNastavnikaTextBox.TabIndex = 2;
            // 
            // predmetLabel
            // 
            predmetLabel.AutoSize = true;
            predmetLabel.Location = new Point(46, 116);
            predmetLabel.Name = "predmetLabel";
            predmetLabel.Size = new Size(96, 24);
            predmetLabel.TabIndex = 1;
            predmetLabel.Text = "Predmet*";
            // 
            // imePrezimeNastavnikaLabel
            // 
            imePrezimeNastavnikaLabel.AutoSize = true;
            imePrezimeNastavnikaLabel.Location = new Point(6, 51);
            imePrezimeNastavnikaLabel.Name = "imePrezimeNastavnikaLabel";
            imePrezimeNastavnikaLabel.Size = new Size(136, 24);
            imePrezimeNastavnikaLabel.TabIndex = 0;
            imePrezimeNastavnikaLabel.Text = "Ime i prezime*";
            // 
            // nastavnikDataGridView
            // 
            nastavnikDataGridView.AllowUserToAddRows = false;
            nastavnikDataGridView.AllowUserToDeleteRows = false;
            nastavnikDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nastavnikDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, imePrezimeColumn, predmetColumn });
            nastavnikDataGridView.Dock = DockStyle.Right;
            nastavnikDataGridView.Location = new Point(509, 43);
            nastavnikDataGridView.MultiSelect = false;
            nastavnikDataGridView.Name = "nastavnikDataGridView";
            nastavnikDataGridView.ReadOnly = true;
            nastavnikDataGridView.RowHeadersVisible = false;
            nastavnikDataGridView.RowHeadersWidth = 51;
            nastavnikDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            nastavnikDataGridView.Size = new Size(591, 497);
            nastavnikDataGridView.TabIndex = 4;
            nastavnikDataGridView.CellMouseDoubleClick += nastavnikDataGridView_CellMouseDoubleClick;
            nastavnikDataGridView.SelectionChanged += nastavnikDataGridView_SelectionChanged;
            // 
            // idColumn
            // 
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            idColumn.HeaderText = "Id";
            idColumn.MinimumWidth = 6;
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Width = 56;
            // 
            // imePrezimeColumn
            // 
            imePrezimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imePrezimeColumn.HeaderText = "Ime i prezime";
            imePrezimeColumn.MinimumWidth = 6;
            imePrezimeColumn.Name = "imePrezimeColumn";
            imePrezimeColumn.ReadOnly = true;
            imePrezimeColumn.Width = 154;
            // 
            // predmetColumn
            // 
            predmetColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            predmetColumn.HeaderText = "Predmet";
            predmetColumn.MinimumWidth = 6;
            predmetColumn.Name = "predmetColumn";
            predmetColumn.ReadOnly = true;
            predmetColumn.Width = 114;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // NastavniciForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1100, 540);
            Controls.Add(nastavnikDataGridView);
            Controls.Add(nastavnikGroupBox);
            Controls.Add(nastavnikToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "NastavniciForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Nastavnici";
            Activated += NastavniciForma_Activated;
            nastavnikToolStrip.ResumeLayout(false);
            nastavnikToolStrip.PerformLayout();
            nastavnikGroupBox.ResumeLayout(false);
            nastavnikGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nastavnikDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip nastavnikToolStrip;
        private ToolStripButton dodajToolStripButton;
        private ToolStripSeparator toolStripButton2;
        private ToolStripButton izmeniToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton obrisiToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton sacuvajToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton odustaniToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton pretragaToolStripButton;
        private GroupBox nastavnikGroupBox;
        private TextBox imePrezimeNastavnikaTextBox;
        private Label predmetLabel;
        private Label imePrezimeNastavnikaLabel;
        private ComboBox predmetComboBox;
        private Label imePrezimeNastavnikaErrorLabel;
        private Label predmetErrorLabel;
        private Label brojPrikazanihNastavnikaLabel;
        private Label brojNastavnikaLabel;
        private Label successStatusLabel;
        private DataGridView nastavnikDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn imePrezimeColumn;
        private DataGridViewTextBoxColumn predmetColumn;
        private System.Windows.Forms.Timer timer1;
    }
}