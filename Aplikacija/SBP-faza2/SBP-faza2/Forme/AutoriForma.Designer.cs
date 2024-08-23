namespace SBP_faza2.Forme
{
    partial class AutoriForma
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
            autorToolStrip = new ToolStrip();
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
            autorGroupBox = new GroupBox();
            successStatusLabel = new Label();
            brojAutoraLabel = new Label();
            brojPrikazanihAutoraLabel = new Label();
            radErrorLabel = new Label();
            clanakErrorLabel = new Label();
            knjigaErrorLabel = new Label();
            imeAutoraErrorLabel = new Label();
            radComboBox = new ComboBox();
            clanakComboBox = new ComboBox();
            knjigaComboBox = new ComboBox();
            imeAutoraTextBox = new TextBox();
            radLabel = new Label();
            clanakLabel = new Label();
            knjigaLabel = new Label();
            imeAutoraLabel = new Label();
            autorDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            imeAutoraColumn = new DataGridViewTextBoxColumn();
            knjigaColumn = new DataGridViewTextBoxColumn();
            clanakColumn = new DataGridViewTextBoxColumn();
            radColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            autorToolStrip.SuspendLayout();
            autorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)autorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // autorToolStrip
            // 
            autorToolStrip.AutoSize = false;
            autorToolStrip.BackColor = Color.Gainsboro;
            autorToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autorToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            autorToolStrip.ImageScalingSize = new Size(20, 20);
            autorToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripButton2, izmeniToolStripButton, toolStripSeparator1, obrisiToolStripButton, toolStripSeparator2, sacuvajToolStripButton, toolStripSeparator3, odustaniToolStripButton, toolStripSeparator4, pretragaToolStripButton });
            autorToolStrip.Location = new Point(0, 0);
            autorToolStrip.Name = "autorToolStrip";
            autorToolStrip.Size = new Size(1100, 43);
            autorToolStrip.TabIndex = 6;
            autorToolStrip.Text = "toolStrip1";
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
            // autorGroupBox
            // 
            autorGroupBox.Controls.Add(successStatusLabel);
            autorGroupBox.Controls.Add(brojAutoraLabel);
            autorGroupBox.Controls.Add(brojPrikazanihAutoraLabel);
            autorGroupBox.Controls.Add(radErrorLabel);
            autorGroupBox.Controls.Add(clanakErrorLabel);
            autorGroupBox.Controls.Add(knjigaErrorLabel);
            autorGroupBox.Controls.Add(imeAutoraErrorLabel);
            autorGroupBox.Controls.Add(radComboBox);
            autorGroupBox.Controls.Add(clanakComboBox);
            autorGroupBox.Controls.Add(knjigaComboBox);
            autorGroupBox.Controls.Add(imeAutoraTextBox);
            autorGroupBox.Controls.Add(radLabel);
            autorGroupBox.Controls.Add(clanakLabel);
            autorGroupBox.Controls.Add(knjigaLabel);
            autorGroupBox.Controls.Add(imeAutoraLabel);
            autorGroupBox.Location = new Point(12, 46);
            autorGroupBox.Name = "autorGroupBox";
            autorGroupBox.Size = new Size(494, 482);
            autorGroupBox.TabIndex = 7;
            autorGroupBox.TabStop = false;
            autorGroupBox.Text = "Podaci";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = SystemColors.ControlText;
            successStatusLabel.Location = new Point(44, 375);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 40;
            successStatusLabel.Text = "Polja označena zvezdicom su obavezna";
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brojAutoraLabel
            // 
            brojAutoraLabel.AutoSize = true;
            brojAutoraLabel.Location = new Point(297, 319);
            brojAutoraLabel.Name = "brojAutoraLabel";
            brojAutoraLabel.Size = new Size(0, 24);
            brojAutoraLabel.TabIndex = 26;
            // 
            // brojPrikazanihAutoraLabel
            // 
            brojPrikazanihAutoraLabel.AutoSize = true;
            brojPrikazanihAutoraLabel.Location = new Point(8, 319);
            brojPrikazanihAutoraLabel.Name = "brojPrikazanihAutoraLabel";
            brojPrikazanihAutoraLabel.Size = new Size(205, 24);
            brojPrikazanihAutoraLabel.TabIndex = 25;
            brojPrikazanihAutoraLabel.Text = "Broj prikazanih autora:";
            // 
            // radErrorLabel
            // 
            radErrorLabel.ForeColor = Color.Red;
            radErrorLabel.Location = new Point(8, 266);
            radErrorLabel.Name = "radErrorLabel";
            radErrorLabel.Size = new Size(459, 25);
            radErrorLabel.TabIndex = 23;
            // 
            // clanakErrorLabel
            // 
            clanakErrorLabel.ForeColor = Color.Red;
            clanakErrorLabel.Location = new Point(8, 203);
            clanakErrorLabel.Name = "clanakErrorLabel";
            clanakErrorLabel.Size = new Size(459, 25);
            clanakErrorLabel.TabIndex = 22;
            // 
            // knjigaErrorLabel
            // 
            knjigaErrorLabel.ForeColor = Color.Red;
            knjigaErrorLabel.Location = new Point(8, 140);
            knjigaErrorLabel.Name = "knjigaErrorLabel";
            knjigaErrorLabel.Size = new Size(459, 25);
            knjigaErrorLabel.TabIndex = 21;
            // 
            // imeAutoraErrorLabel
            // 
            imeAutoraErrorLabel.ForeColor = Color.Red;
            imeAutoraErrorLabel.Location = new Point(8, 77);
            imeAutoraErrorLabel.Name = "imeAutoraErrorLabel";
            imeAutoraErrorLabel.Size = new Size(459, 25);
            imeAutoraErrorLabel.TabIndex = 20;
            // 
            // radComboBox
            // 
            radComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            radComboBox.FormattingEnabled = true;
            radComboBox.Location = new Point(155, 231);
            radComboBox.Name = "radComboBox";
            radComboBox.Size = new Size(312, 32);
            radComboBox.TabIndex = 7;
            // 
            // clanakComboBox
            // 
            clanakComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clanakComboBox.FormattingEnabled = true;
            clanakComboBox.Location = new Point(155, 168);
            clanakComboBox.Name = "clanakComboBox";
            clanakComboBox.Size = new Size(312, 32);
            clanakComboBox.TabIndex = 6;
            // 
            // knjigaComboBox
            // 
            knjigaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            knjigaComboBox.Enabled = false;
            knjigaComboBox.FormattingEnabled = true;
            knjigaComboBox.Location = new Point(155, 105);
            knjigaComboBox.Name = "knjigaComboBox";
            knjigaComboBox.Size = new Size(312, 32);
            knjigaComboBox.TabIndex = 5;
            // 
            // imeAutoraTextBox
            // 
            imeAutoraTextBox.Enabled = false;
            imeAutoraTextBox.Location = new Point(155, 42);
            imeAutoraTextBox.Name = "imeAutoraTextBox";
            imeAutoraTextBox.Size = new Size(312, 32);
            imeAutoraTextBox.TabIndex = 4;
            // 
            // radLabel
            // 
            radLabel.AutoSize = true;
            radLabel.Location = new Point(105, 234);
            radLabel.Name = "radLabel";
            radLabel.Size = new Size(44, 24);
            radLabel.TabIndex = 3;
            radLabel.Text = "Rad";
            // 
            // clanakLabel
            // 
            clanakLabel.AutoSize = true;
            clanakLabel.Location = new Point(81, 171);
            clanakLabel.Name = "clanakLabel";
            clanakLabel.Size = new Size(68, 24);
            clanakLabel.TabIndex = 2;
            clanakLabel.Text = "Članak";
            // 
            // knjigaLabel
            // 
            knjigaLabel.AutoSize = true;
            knjigaLabel.Location = new Point(84, 108);
            knjigaLabel.Name = "knjigaLabel";
            knjigaLabel.Size = new Size(65, 24);
            knjigaLabel.TabIndex = 1;
            knjigaLabel.Text = "Knjiga";
            // 
            // imeAutoraLabel
            // 
            imeAutoraLabel.AutoSize = true;
            imeAutoraLabel.Location = new Point(34, 45);
            imeAutoraLabel.Name = "imeAutoraLabel";
            imeAutoraLabel.Size = new Size(115, 24);
            imeAutoraLabel.TabIndex = 0;
            imeAutoraLabel.Text = "Ime autora*";
            // 
            // autorDataGridView
            // 
            autorDataGridView.AllowUserToAddRows = false;
            autorDataGridView.AllowUserToDeleteRows = false;
            autorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            autorDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, imeAutoraColumn, knjigaColumn, clanakColumn, radColumn });
            autorDataGridView.Dock = DockStyle.Right;
            autorDataGridView.Location = new Point(512, 43);
            autorDataGridView.MultiSelect = false;
            autorDataGridView.Name = "autorDataGridView";
            autorDataGridView.ReadOnly = true;
            autorDataGridView.RowHeadersVisible = false;
            autorDataGridView.RowHeadersWidth = 51;
            autorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            autorDataGridView.Size = new Size(588, 497);
            autorDataGridView.TabIndex = 8;
            autorDataGridView.CellMouseDoubleClick += autorDataGridView_CellMouseDoubleClick;
            autorDataGridView.SelectionChanged += autorDataGridView_SelectionChanged;
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
            // imeAutoraColumn
            // 
            imeAutoraColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imeAutoraColumn.HeaderText = "Autor";
            imeAutoraColumn.MinimumWidth = 6;
            imeAutoraColumn.Name = "imeAutoraColumn";
            imeAutoraColumn.ReadOnly = true;
            imeAutoraColumn.Width = 89;
            // 
            // knjigaColumn
            // 
            knjigaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            knjigaColumn.HeaderText = "Knjiga";
            knjigaColumn.MinimumWidth = 6;
            knjigaColumn.Name = "knjigaColumn";
            knjigaColumn.ReadOnly = true;
            knjigaColumn.Width = 94;
            // 
            // clanakColumn
            // 
            clanakColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clanakColumn.HeaderText = "Članak";
            clanakColumn.MinimumWidth = 6;
            clanakColumn.Name = "clanakColumn";
            clanakColumn.ReadOnly = true;
            clanakColumn.Width = 97;
            // 
            // radColumn
            // 
            radColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            radColumn.HeaderText = "Rad";
            radColumn.MinimumWidth = 6;
            radColumn.Name = "radColumn";
            radColumn.ReadOnly = true;
            radColumn.Width = 73;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // AutoriForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1100, 540);
            Controls.Add(autorDataGridView);
            Controls.Add(autorGroupBox);
            Controls.Add(autorToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AutoriForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Autori";
            Activated += AutoriForma_Activated;
            autorToolStrip.ResumeLayout(false);
            autorToolStrip.PerformLayout();
            autorGroupBox.ResumeLayout(false);
            autorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)autorDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip autorToolStrip;
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
        private GroupBox autorGroupBox;
        private Label radLabel;
        private Label clanakLabel;
        private Label knjigaLabel;
        private Label imeAutoraLabel;
        private ComboBox radComboBox;
        private ComboBox clanakComboBox;
        private ComboBox knjigaComboBox;
        private TextBox imeAutoraTextBox;
        private Label radErrorLabel;
        private Label clanakErrorLabel;
        private Label knjigaErrorLabel;
        private Label imeAutoraErrorLabel;
        private Label brojAutoraLabel;
        private Label brojPrikazanihAutoraLabel;
        private Label successStatusLabel;
        private DataGridView autorDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn imeAutoraColumn;
        private DataGridViewTextBoxColumn knjigaColumn;
        private DataGridViewTextBoxColumn clanakColumn;
        private DataGridViewTextBoxColumn radColumn;
        private System.Windows.Forms.Timer timer1;
    }
}