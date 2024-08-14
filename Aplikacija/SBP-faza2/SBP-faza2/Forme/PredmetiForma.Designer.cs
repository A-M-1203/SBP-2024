namespace SBP_faza2.Forme
{
    partial class PredmetiForma
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
            predmetGroupBox = new GroupBox();
            brojPredmetaLabel = new Label();
            ukupanBrojPredmetaLabel = new Label();
            successStatusLabel = new Label();
            zvezdicaLabel = new Label();
            semestarErrorLabel = new Label();
            katedraErrorLabel = new Label();
            nazivPredmetaErrorLabel = new Label();
            sifraPredmetaErrorLabel = new Label();
            semestarComboBox = new ComboBox();
            katedraComboBox = new ComboBox();
            nazivPredmetaTextBox = new TextBox();
            sifraPredmetaTextBox = new TextBox();
            semestarLabel = new Label();
            katedraLabel = new Label();
            nazivPredmetaLabel = new Label();
            sifraPredmetaLabel = new Label();
            predmetToolStrip = new ToolStrip();
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
            pretagaToolStripButton = new ToolStripButton();
            predmetDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            sifraPredmetaColumn = new DataGridViewTextBoxColumn();
            nazivPredmetaColumn = new DataGridViewTextBoxColumn();
            katedraColumn = new DataGridViewTextBoxColumn();
            semestarColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            pretragaPanel = new Panel();
            ocistiPretraguButton = new Button();
            minimizePanelButton = new Button();
            pretraziButton = new Button();
            semestarPretraziComboBox = new ComboBox();
            katedraPretaziComboBox = new ComboBox();
            nazivPretraziTextBox = new TextBox();
            sifraPretraziTextBox = new TextBox();
            semestarPretragaLabel = new Label();
            katedraPretragaLabel = new Label();
            nazivPretragaLabel = new Label();
            sifraPretragaLabel = new Label();
            predmetGroupBox.SuspendLayout();
            predmetToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)predmetDataGridView).BeginInit();
            pretragaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // predmetGroupBox
            // 
            predmetGroupBox.Controls.Add(brojPredmetaLabel);
            predmetGroupBox.Controls.Add(ukupanBrojPredmetaLabel);
            predmetGroupBox.Controls.Add(successStatusLabel);
            predmetGroupBox.Controls.Add(zvezdicaLabel);
            predmetGroupBox.Controls.Add(semestarErrorLabel);
            predmetGroupBox.Controls.Add(katedraErrorLabel);
            predmetGroupBox.Controls.Add(nazivPredmetaErrorLabel);
            predmetGroupBox.Controls.Add(sifraPredmetaErrorLabel);
            predmetGroupBox.Controls.Add(semestarComboBox);
            predmetGroupBox.Controls.Add(katedraComboBox);
            predmetGroupBox.Controls.Add(nazivPredmetaTextBox);
            predmetGroupBox.Controls.Add(sifraPredmetaTextBox);
            predmetGroupBox.Controls.Add(semestarLabel);
            predmetGroupBox.Controls.Add(katedraLabel);
            predmetGroupBox.Controls.Add(nazivPredmetaLabel);
            predmetGroupBox.Controls.Add(sifraPredmetaLabel);
            predmetGroupBox.Location = new Point(12, 46);
            predmetGroupBox.Name = "predmetGroupBox";
            predmetGroupBox.Size = new Size(481, 482);
            predmetGroupBox.TabIndex = 0;
            predmetGroupBox.TabStop = false;
            predmetGroupBox.Text = "Podaci";
            // 
            // brojPredmetaLabel
            // 
            brojPredmetaLabel.AutoSize = true;
            brojPredmetaLabel.Location = new Point(285, 292);
            brojPredmetaLabel.Name = "brojPredmetaLabel";
            brojPredmetaLabel.Size = new Size(0, 24);
            brojPredmetaLabel.TabIndex = 15;
            // 
            // ukupanBrojPredmetaLabel
            // 
            ukupanBrojPredmetaLabel.AutoSize = true;
            ukupanBrojPredmetaLabel.Location = new Point(20, 292);
            ukupanBrojPredmetaLabel.Name = "ukupanBrojPredmetaLabel";
            ukupanBrojPredmetaLabel.Size = new Size(209, 24);
            ukupanBrojPredmetaLabel.TabIndex = 14;
            ukupanBrojPredmetaLabel.Text = "Ukupan broj predmeta:";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Location = new Point(29, 358);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 13;
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // zvezdicaLabel
            // 
            zvezdicaLabel.AutoSize = true;
            zvezdicaLabel.Location = new Point(75, 438);
            zvezdicaLabel.Name = "zvezdicaLabel";
            zvezdicaLabel.Size = new Size(350, 24);
            zvezdicaLabel.TabIndex = 12;
            zvezdicaLabel.Text = "Polja označena zvezdicama su obavezna";
            // 
            // semestarErrorLabel
            // 
            semestarErrorLabel.ForeColor = Color.Red;
            semestarErrorLabel.Location = new Point(28, 249);
            semestarErrorLabel.Name = "semestarErrorLabel";
            semestarErrorLabel.Size = new Size(398, 25);
            semestarErrorLabel.TabIndex = 11;
            // 
            // katedraErrorLabel
            // 
            katedraErrorLabel.ForeColor = Color.Red;
            katedraErrorLabel.Location = new Point(28, 186);
            katedraErrorLabel.Name = "katedraErrorLabel";
            katedraErrorLabel.Size = new Size(398, 25);
            katedraErrorLabel.TabIndex = 10;
            // 
            // nazivPredmetaErrorLabel
            // 
            nazivPredmetaErrorLabel.ForeColor = Color.Red;
            nazivPredmetaErrorLabel.Location = new Point(28, 123);
            nazivPredmetaErrorLabel.Name = "nazivPredmetaErrorLabel";
            nazivPredmetaErrorLabel.Size = new Size(447, 25);
            nazivPredmetaErrorLabel.TabIndex = 9;
            // 
            // sifraPredmetaErrorLabel
            // 
            sifraPredmetaErrorLabel.ForeColor = Color.Red;
            sifraPredmetaErrorLabel.Location = new Point(28, 60);
            sifraPredmetaErrorLabel.Name = "sifraPredmetaErrorLabel";
            sifraPredmetaErrorLabel.Size = new Size(398, 25);
            sifraPredmetaErrorLabel.TabIndex = 8;
            // 
            // semestarComboBox
            // 
            semestarComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semestarComboBox.Enabled = false;
            semestarComboBox.FormattingEnabled = true;
            semestarComboBox.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            semestarComboBox.Location = new Point(198, 214);
            semestarComboBox.Name = "semestarComboBox";
            semestarComboBox.Size = new Size(254, 32);
            semestarComboBox.TabIndex = 7;
            // 
            // katedraComboBox
            // 
            katedraComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            katedraComboBox.Enabled = false;
            katedraComboBox.FormattingEnabled = true;
            katedraComboBox.Items.AddRange(new object[] { "Automatika", "Elektronika", "Energetika", "Matematika", "Merenja", "Mikroelektronika", "Računarstvo", "Telekomunikacije", "Teorijska elektrotehnika", "Opšte obrazovni predmeti" });
            katedraComboBox.Location = new Point(198, 151);
            katedraComboBox.Name = "katedraComboBox";
            katedraComboBox.Size = new Size(254, 32);
            katedraComboBox.TabIndex = 6;
            // 
            // nazivPredmetaTextBox
            // 
            nazivPredmetaTextBox.Enabled = false;
            nazivPredmetaTextBox.Location = new Point(198, 88);
            nazivPredmetaTextBox.Name = "nazivPredmetaTextBox";
            nazivPredmetaTextBox.Size = new Size(254, 32);
            nazivPredmetaTextBox.TabIndex = 5;
            nazivPredmetaTextBox.KeyPress += nazivPredmetaTextBox_KeyPress;
            // 
            // sifraPredmetaTextBox
            // 
            sifraPredmetaTextBox.Enabled = false;
            sifraPredmetaTextBox.Location = new Point(198, 25);
            sifraPredmetaTextBox.MaxLength = 8;
            sifraPredmetaTextBox.Name = "sifraPredmetaTextBox";
            sifraPredmetaTextBox.Size = new Size(254, 32);
            sifraPredmetaTextBox.TabIndex = 4;
            sifraPredmetaTextBox.TextChanged += sifraPredmetaTextBox_TextChanged;
            sifraPredmetaTextBox.KeyPress += sifraPredmetaTextBox_KeyPress;
            // 
            // semestarLabel
            // 
            semestarLabel.AutoSize = true;
            semestarLabel.Location = new Point(75, 217);
            semestarLabel.Name = "semestarLabel";
            semestarLabel.Size = new Size(103, 24);
            semestarLabel.TabIndex = 3;
            semestarLabel.Text = "Semestar*";
            // 
            // katedraLabel
            // 
            katedraLabel.AutoSize = true;
            katedraLabel.Location = new Point(88, 154);
            katedraLabel.Name = "katedraLabel";
            katedraLabel.Size = new Size(90, 24);
            katedraLabel.TabIndex = 2;
            katedraLabel.Text = "Katedra*";
            // 
            // nazivPredmetaLabel
            // 
            nazivPredmetaLabel.AutoSize = true;
            nazivPredmetaLabel.Location = new Point(20, 91);
            nazivPredmetaLabel.Name = "nazivPredmetaLabel";
            nazivPredmetaLabel.Size = new Size(158, 24);
            nazivPredmetaLabel.TabIndex = 1;
            nazivPredmetaLabel.Text = "Naziv predmeta*";
            // 
            // sifraPredmetaLabel
            // 
            sifraPredmetaLabel.AutoSize = true;
            sifraPredmetaLabel.Location = new Point(28, 28);
            sifraPredmetaLabel.Name = "sifraPredmetaLabel";
            sifraPredmetaLabel.Size = new Size(150, 24);
            sifraPredmetaLabel.TabIndex = 0;
            sifraPredmetaLabel.Text = "Šifra predmeta*";
            // 
            // predmetToolStrip
            // 
            predmetToolStrip.AutoSize = false;
            predmetToolStrip.BackColor = Color.Gainsboro;
            predmetToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            predmetToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            predmetToolStrip.ImageScalingSize = new Size(20, 20);
            predmetToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripButton2, izmeniToolStripButton, toolStripSeparator1, obrisiToolStripButton, toolStripSeparator2, sacuvajToolStripButton, toolStripSeparator3, odustaniToolStripButton, toolStripSeparator4, pretagaToolStripButton });
            predmetToolStrip.Location = new Point(0, 0);
            predmetToolStrip.Name = "predmetToolStrip";
            predmetToolStrip.Size = new Size(1165, 43);
            predmetToolStrip.TabIndex = 1;
            predmetToolStrip.Text = "toolStrip1";
            // 
            // dodajToolStripButton
            // 
            dodajToolStripButton.Image = Properties.Resources.add_icon;
            dodajToolStripButton.ImageTransparentColor = Color.Magenta;
            dodajToolStripButton.Name = "dodajToolStripButton";
            dodajToolStripButton.Size = new Size(85, 40);
            dodajToolStripButton.Text = "Dodaj";
            dodajToolStripButton.Click += dodajPredmetToolStripButton_Click;
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
            // pretagaToolStripButton
            // 
            pretagaToolStripButton.Image = Properties.Resources.magnifying_glass_icon;
            pretagaToolStripButton.ImageTransparentColor = Color.Magenta;
            pretagaToolStripButton.Name = "pretagaToolStripButton";
            pretagaToolStripButton.Size = new Size(109, 40);
            pretagaToolStripButton.Text = "Pretraga";
            pretagaToolStripButton.Click += pretagaToolStripButton_Click;
            // 
            // predmetDataGridView
            // 
            predmetDataGridView.AllowUserToAddRows = false;
            predmetDataGridView.AllowUserToDeleteRows = false;
            predmetDataGridView.BackgroundColor = Color.DarkGray;
            predmetDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            predmetDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, sifraPredmetaColumn, nazivPredmetaColumn, katedraColumn, semestarColumn });
            predmetDataGridView.Dock = DockStyle.Right;
            predmetDataGridView.Location = new Point(499, 43);
            predmetDataGridView.MultiSelect = false;
            predmetDataGridView.Name = "predmetDataGridView";
            predmetDataGridView.ReadOnly = true;
            predmetDataGridView.RowHeadersVisible = false;
            predmetDataGridView.RowHeadersWidth = 51;
            predmetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            predmetDataGridView.Size = new Size(666, 497);
            predmetDataGridView.TabIndex = 2;
            predmetDataGridView.CellMouseDoubleClick += predmetDataGridView_CellMouseDoubleClick;
            predmetDataGridView.SelectionChanged += predmetDataGridView_SelectionChanged;
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
            // sifraPredmetaColumn
            // 
            sifraPredmetaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sifraPredmetaColumn.HeaderText = "Šifra predmeta";
            sifraPredmetaColumn.MinimumWidth = 6;
            sifraPredmetaColumn.Name = "sifraPredmetaColumn";
            sifraPredmetaColumn.ReadOnly = true;
            sifraPredmetaColumn.Width = 154;
            // 
            // nazivPredmetaColumn
            // 
            nazivPredmetaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nazivPredmetaColumn.HeaderText = "Naziv predmeta";
            nazivPredmetaColumn.MinimumWidth = 6;
            nazivPredmetaColumn.Name = "nazivPredmetaColumn";
            nazivPredmetaColumn.ReadOnly = true;
            nazivPredmetaColumn.Width = 161;
            // 
            // katedraColumn
            // 
            katedraColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            katedraColumn.HeaderText = "Katedra";
            katedraColumn.MinimumWidth = 6;
            katedraColumn.Name = "katedraColumn";
            katedraColumn.ReadOnly = true;
            katedraColumn.Width = 108;
            // 
            // semestarColumn
            // 
            semestarColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            semestarColumn.HeaderText = "Semestar";
            semestarColumn.MinimumWidth = 6;
            semestarColumn.Name = "semestarColumn";
            semestarColumn.ReadOnly = true;
            semestarColumn.Width = 121;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // pretragaPanel
            // 
            pretragaPanel.BorderStyle = BorderStyle.FixedSingle;
            pretragaPanel.Controls.Add(ocistiPretraguButton);
            pretragaPanel.Controls.Add(minimizePanelButton);
            pretragaPanel.Controls.Add(pretraziButton);
            pretragaPanel.Controls.Add(semestarPretraziComboBox);
            pretragaPanel.Controls.Add(katedraPretaziComboBox);
            pretragaPanel.Controls.Add(nazivPretraziTextBox);
            pretragaPanel.Controls.Add(sifraPretraziTextBox);
            pretragaPanel.Controls.Add(semestarPretragaLabel);
            pretragaPanel.Controls.Add(katedraPretragaLabel);
            pretragaPanel.Controls.Add(nazivPretragaLabel);
            pretragaPanel.Controls.Add(sifraPretragaLabel);
            pretragaPanel.Location = new Point(499, 46);
            pretragaPanel.Name = "pretragaPanel";
            pretragaPanel.Size = new Size(387, 316);
            pretragaPanel.TabIndex = 3;
            pretragaPanel.Visible = false;
            // 
            // ocistiPretraguButton
            // 
            ocistiPretraguButton.Image = Properties.Resources.broom_icon;
            ocistiPretraguButton.Location = new Point(254, 269);
            ocistiPretraguButton.Name = "ocistiPretraguButton";
            ocistiPretraguButton.Size = new Size(119, 33);
            ocistiPretraguButton.TabIndex = 12;
            ocistiPretraguButton.Text = "Očisti";
            ocistiPretraguButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ocistiPretraguButton.UseVisualStyleBackColor = true;
            ocistiPretraguButton.Click += ocistiPretraguButton_Click;
            // 
            // minimizePanelButton
            // 
            minimizePanelButton.Image = Properties.Resources.arrow_minimise_icon;
            minimizePanelButton.Location = new Point(3, 3);
            minimizePanelButton.Name = "minimizePanelButton";
            minimizePanelButton.Size = new Size(24, 24);
            minimizePanelButton.TabIndex = 11;
            minimizePanelButton.UseVisualStyleBackColor = true;
            minimizePanelButton.Click += minimizePanelButton_Click;
            // 
            // pretraziButton
            // 
            pretraziButton.Image = Properties.Resources.search_research_icon;
            pretraziButton.Location = new Point(119, 269);
            pretraziButton.Name = "pretraziButton";
            pretraziButton.Size = new Size(119, 33);
            pretraziButton.TabIndex = 8;
            pretraziButton.Text = "Pretraži";
            pretraziButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            pretraziButton.UseVisualStyleBackColor = true;
            pretraziButton.Click += pretraziButton_Click;
            // 
            // semestarPretraziComboBox
            // 
            semestarPretraziComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semestarPretraziComboBox.FormattingEnabled = true;
            semestarPretraziComboBox.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            semestarPretraziComboBox.Location = new Point(119, 214);
            semestarPretraziComboBox.Name = "semestarPretraziComboBox";
            semestarPretraziComboBox.Size = new Size(254, 32);
            semestarPretraziComboBox.TabIndex = 7;
            // 
            // katedraPretaziComboBox
            // 
            katedraPretaziComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            katedraPretaziComboBox.FormattingEnabled = true;
            katedraPretaziComboBox.Items.AddRange(new object[] { "Automatika", "Elektronika", "Energetika", "Matematika", "Merenja", "Mikroelektronika", "Računarstvo", "Telekomunikacije", "Teorijska elektrotehnika", "Opšte obrazovni predmeti" });
            katedraPretaziComboBox.Location = new Point(119, 151);
            katedraPretaziComboBox.Name = "katedraPretaziComboBox";
            katedraPretaziComboBox.Size = new Size(254, 32);
            katedraPretaziComboBox.TabIndex = 6;
            // 
            // nazivPretraziTextBox
            // 
            nazivPretraziTextBox.Location = new Point(119, 88);
            nazivPretraziTextBox.Name = "nazivPretraziTextBox";
            nazivPretraziTextBox.Size = new Size(254, 32);
            nazivPretraziTextBox.TabIndex = 5;
            nazivPretraziTextBox.KeyPress += nazivPretraziTextBox_KeyPress;
            // 
            // sifraPretraziTextBox
            // 
            sifraPretraziTextBox.Location = new Point(119, 25);
            sifraPretraziTextBox.MaxLength = 8;
            sifraPretraziTextBox.Name = "sifraPretraziTextBox";
            sifraPretraziTextBox.Size = new Size(254, 32);
            sifraPretraziTextBox.TabIndex = 4;
            sifraPretraziTextBox.TextChanged += sifraPretraziTextBox_TextChanged;
            sifraPretraziTextBox.KeyPress += sifraPretraziTextBox_KeyPress;
            // 
            // semestarPretragaLabel
            // 
            semestarPretragaLabel.AutoSize = true;
            semestarPretragaLabel.Location = new Point(12, 217);
            semestarPretragaLabel.Name = "semestarPretragaLabel";
            semestarPretragaLabel.Size = new Size(92, 24);
            semestarPretragaLabel.TabIndex = 3;
            semestarPretragaLabel.Text = "Semestar";
            // 
            // katedraPretragaLabel
            // 
            katedraPretragaLabel.AutoSize = true;
            katedraPretragaLabel.Location = new Point(25, 154);
            katedraPretragaLabel.Name = "katedraPretragaLabel";
            katedraPretragaLabel.Size = new Size(79, 24);
            katedraPretragaLabel.TabIndex = 2;
            katedraPretragaLabel.Text = "Katedra";
            // 
            // nazivPretragaLabel
            // 
            nazivPretragaLabel.AutoSize = true;
            nazivPretragaLabel.Location = new Point(45, 91);
            nazivPretragaLabel.Name = "nazivPretragaLabel";
            nazivPretragaLabel.Size = new Size(59, 24);
            nazivPretragaLabel.TabIndex = 1;
            nazivPretragaLabel.Text = "Naziv";
            // 
            // sifraPretragaLabel
            // 
            sifraPretragaLabel.AutoSize = true;
            sifraPretragaLabel.Location = new Point(53, 28);
            sifraPretragaLabel.Name = "sifraPretragaLabel";
            sifraPretragaLabel.Size = new Size(51, 24);
            sifraPretragaLabel.TabIndex = 0;
            sifraPretragaLabel.Text = "Šifra";
            // 
            // PredmetiForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1165, 540);
            Controls.Add(pretragaPanel);
            Controls.Add(predmetDataGridView);
            Controls.Add(predmetToolStrip);
            Controls.Add(predmetGroupBox);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PredmetiForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Predmeti";
            Activated += PredmetiForma_Activated;
            predmetGroupBox.ResumeLayout(false);
            predmetGroupBox.PerformLayout();
            predmetToolStrip.ResumeLayout(false);
            predmetToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)predmetDataGridView).EndInit();
            pretragaPanel.ResumeLayout(false);
            pretragaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox predmetGroupBox;
        private ToolStrip predmetToolStrip;
        private DataGridView predmetDataGridView;
        private ToolStripButton dodajToolStripButton;
        private ToolStripSeparator toolStripButton2;
        private ToolStripButton izmeniToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton obrisiToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton sacuvajToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton odustaniToolStripButton;
        private Label semestarLabel;
        private Label katedraLabel;
        private Label nazivPredmetaLabel;
        private Label sifraPredmetaLabel;
        private TextBox sifraPredmetaTextBox;
        private ComboBox semestarComboBox;
        private ComboBox katedraComboBox;
        private TextBox nazivPredmetaTextBox;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn sifraPredmetaColumn;
        private DataGridViewTextBoxColumn nazivPredmetaColumn;
        private DataGridViewTextBoxColumn katedraColumn;
        private DataGridViewTextBoxColumn semestarColumn;
        private Label sifraPredmetaErrorLabel;
        private Label katedraErrorLabel;
        private Label nazivPredmetaErrorLabel;
        private Label semestarErrorLabel;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton pretagaToolStripButton;
        private Label zvezdicaLabel;
        private Label successStatusLabel;
        private Label ukupanBrojPredmetaLabel;
        private Label brojPredmetaLabel;
        private System.Windows.Forms.Timer timer1;
        private Panel pretragaPanel;
        private Label semestarPretragaLabel;
        private Label katedraPretragaLabel;
        private Label nazivPretragaLabel;
        private Label sifraPretragaLabel;
        private ComboBox semestarPretraziComboBox;
        private ComboBox katedraPretaziComboBox;
        private TextBox nazivPretraziTextBox;
        private TextBox sifraPretraziTextBox;
        private Button pretraziButton;
        private Button minimizePanelButton;
        private Button ocistiPretraguButton;
    }
}