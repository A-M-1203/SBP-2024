namespace SBP_faza2.Forme
{
    partial class StudentiForma
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
            studentToolStrip = new ToolStrip();
            dodajToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            izmeniToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            obrisiToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            sacuvajToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            odustaniToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            pretragaToolStripButton = new ToolStripButton();
            studentGroupBox = new GroupBox();
            brojStudenataLabel = new Label();
            ukupanBrojStudenataLabel = new Label();
            successStatusLabel = new Label();
            zvezdicaLabel = new Label();
            smerErrorLabel = new Label();
            brojIndeksaErrorLabel = new Label();
            prezimeErrorLabel = new Label();
            imeRoditeljaErrorLabel = new Label();
            licnoImeErrorLabel = new Label();
            smerComboBox = new ComboBox();
            brojIndeksaTextBox = new TextBox();
            prezimeTextBox = new TextBox();
            imeRoditeljaTextBox = new TextBox();
            licnoImeTextBox = new TextBox();
            smerLabel = new Label();
            brojIndeksaLabel = new Label();
            prezimeLabel = new Label();
            imeRoditeljaLabel = new Label();
            licnoImeLabel = new Label();
            studentDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            licnoImeColumn = new DataGridViewTextBoxColumn();
            imeRoditeljaColumn = new DataGridViewTextBoxColumn();
            prezimeColumn = new DataGridViewTextBoxColumn();
            brojIndeksaColumn = new DataGridViewTextBoxColumn();
            smerColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            pretragaPanel = new Panel();
            ocistiPretraguButton = new Button();
            pretraziButton = new Button();
            smerPretraziComboBox = new ComboBox();
            indeksPretraziTextBox = new TextBox();
            prezimePretaziTextBox = new TextBox();
            roditeljPretraziTextBox = new TextBox();
            imePretraziTextBox = new TextBox();
            smerPretragaLabel = new Label();
            indeksPretragaLabel = new Label();
            prezimePretragaLabel = new Label();
            roditeljPretragaLabel = new Label();
            imePretragaLabel = new Label();
            minimizePanelButton = new Button();
            studentToolStrip.SuspendLayout();
            studentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            pretragaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // studentToolStrip
            // 
            studentToolStrip.AutoSize = false;
            studentToolStrip.BackColor = Color.Gainsboro;
            studentToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            studentToolStrip.ImageScalingSize = new Size(20, 20);
            studentToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripSeparator1, izmeniToolStripButton, toolStripSeparator2, obrisiToolStripButton, toolStripSeparator3, sacuvajToolStripButton, toolStripSeparator4, odustaniToolStripButton, toolStripSeparator5, pretragaToolStripButton });
            studentToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            studentToolStrip.Location = new Point(0, 0);
            studentToolStrip.Name = "studentToolStrip";
            studentToolStrip.Size = new Size(1165, 43);
            studentToolStrip.TabIndex = 0;
            studentToolStrip.Text = "toolStrip1";
            // 
            // dodajToolStripButton
            // 
            dodajToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dodajToolStripButton.Image = Properties.Resources.add_icon;
            dodajToolStripButton.ImageTransparentColor = Color.Magenta;
            dodajToolStripButton.Name = "dodajToolStripButton";
            dodajToolStripButton.Size = new Size(85, 40);
            dodajToolStripButton.Text = "Dodaj";
            dodajToolStripButton.Click += dodajStudentaToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
            // 
            // izmeniToolStripButton
            // 
            izmeniToolStripButton.Enabled = false;
            izmeniToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            izmeniToolStripButton.Image = Properties.Resources.edit_icon;
            izmeniToolStripButton.ImageTransparentColor = Color.Magenta;
            izmeniToolStripButton.Name = "izmeniToolStripButton";
            izmeniToolStripButton.Size = new Size(92, 40);
            izmeniToolStripButton.Text = "Izmeni";
            izmeniToolStripButton.Click += izmeniStudentaToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 43);
            // 
            // obrisiToolStripButton
            // 
            obrisiToolStripButton.Enabled = false;
            obrisiToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            obrisiToolStripButton.Image = Properties.Resources.trash_can_icon;
            obrisiToolStripButton.ImageTransparentColor = Color.Magenta;
            obrisiToolStripButton.Name = "obrisiToolStripButton";
            obrisiToolStripButton.Size = new Size(85, 40);
            obrisiToolStripButton.Text = "Obriši";
            obrisiToolStripButton.Click += obrisiStudentaToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 43);
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
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 43);
            // 
            // odustaniToolStripButton
            // 
            odustaniToolStripButton.Enabled = false;
            odustaniToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            odustaniToolStripButton.Image = Properties.Resources.cancel_icon;
            odustaniToolStripButton.ImageTransparentColor = Color.Magenta;
            odustaniToolStripButton.Name = "odustaniToolStripButton";
            odustaniToolStripButton.Size = new Size(113, 40);
            odustaniToolStripButton.Text = "Odustani";
            odustaniToolStripButton.Click += odustaniToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 43);
            // 
            // pretragaToolStripButton
            // 
            pretragaToolStripButton.Image = Properties.Resources.magnifying_glass_icon;
            pretragaToolStripButton.ImageTransparentColor = Color.Magenta;
            pretragaToolStripButton.Name = "pretragaToolStripButton";
            pretragaToolStripButton.Size = new Size(109, 40);
            pretragaToolStripButton.Text = "Pretraga";
            pretragaToolStripButton.Click += pretragaToolStripButton_Click;
            // 
            // studentGroupBox
            // 
            studentGroupBox.BackColor = Color.DarkGray;
            studentGroupBox.Controls.Add(brojStudenataLabel);
            studentGroupBox.Controls.Add(ukupanBrojStudenataLabel);
            studentGroupBox.Controls.Add(successStatusLabel);
            studentGroupBox.Controls.Add(zvezdicaLabel);
            studentGroupBox.Controls.Add(smerErrorLabel);
            studentGroupBox.Controls.Add(brojIndeksaErrorLabel);
            studentGroupBox.Controls.Add(prezimeErrorLabel);
            studentGroupBox.Controls.Add(imeRoditeljaErrorLabel);
            studentGroupBox.Controls.Add(licnoImeErrorLabel);
            studentGroupBox.Controls.Add(smerComboBox);
            studentGroupBox.Controls.Add(brojIndeksaTextBox);
            studentGroupBox.Controls.Add(prezimeTextBox);
            studentGroupBox.Controls.Add(imeRoditeljaTextBox);
            studentGroupBox.Controls.Add(licnoImeTextBox);
            studentGroupBox.Controls.Add(smerLabel);
            studentGroupBox.Controls.Add(brojIndeksaLabel);
            studentGroupBox.Controls.Add(prezimeLabel);
            studentGroupBox.Controls.Add(imeRoditeljaLabel);
            studentGroupBox.Controls.Add(licnoImeLabel);
            studentGroupBox.Location = new Point(12, 46);
            studentGroupBox.Name = "studentGroupBox";
            studentGroupBox.Size = new Size(481, 482);
            studentGroupBox.TabIndex = 1;
            studentGroupBox.TabStop = false;
            studentGroupBox.Text = "Podaci";
            // 
            // brojStudenataLabel
            // 
            brojStudenataLabel.AutoSize = true;
            brojStudenataLabel.Location = new Point(303, 347);
            brojStudenataLabel.Name = "brojStudenataLabel";
            brojStudenataLabel.Size = new Size(0, 24);
            brojStudenataLabel.TabIndex = 18;
            // 
            // ukupanBrojStudenataLabel
            // 
            ukupanBrojStudenataLabel.AutoSize = true;
            ukupanBrojStudenataLabel.Location = new Point(6, 347);
            ukupanBrojStudenataLabel.Name = "ukupanBrojStudenataLabel";
            ukupanBrojStudenataLabel.Size = new Size(212, 24);
            ukupanBrojStudenataLabel.TabIndex = 17;
            ukupanBrojStudenataLabel.Text = "Ukupan broj studenata:";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = Color.Lime;
            successStatusLabel.Location = new Point(27, 388);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 16;
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // zvezdicaLabel
            // 
            zvezdicaLabel.AutoSize = true;
            zvezdicaLabel.Location = new Point(59, 442);
            zvezdicaLabel.Name = "zvezdicaLabel";
            zvezdicaLabel.Size = new Size(350, 24);
            zvezdicaLabel.TabIndex = 15;
            zvezdicaLabel.Text = "Polja označena zvezdicama su obavezna";
            // 
            // smerErrorLabel
            // 
            smerErrorLabel.ForeColor = Color.Red;
            smerErrorLabel.Location = new Point(32, 312);
            smerErrorLabel.Name = "smerErrorLabel";
            smerErrorLabel.Size = new Size(398, 25);
            smerErrorLabel.TabIndex = 14;
            // 
            // brojIndeksaErrorLabel
            // 
            brojIndeksaErrorLabel.ForeColor = Color.Red;
            brojIndeksaErrorLabel.Location = new Point(11, 249);
            brojIndeksaErrorLabel.Name = "brojIndeksaErrorLabel";
            brojIndeksaErrorLabel.Size = new Size(398, 25);
            brojIndeksaErrorLabel.TabIndex = 13;
            // 
            // prezimeErrorLabel
            // 
            prezimeErrorLabel.ForeColor = Color.Red;
            prezimeErrorLabel.Location = new Point(11, 186);
            prezimeErrorLabel.Name = "prezimeErrorLabel";
            prezimeErrorLabel.Size = new Size(398, 25);
            prezimeErrorLabel.TabIndex = 12;
            // 
            // imeRoditeljaErrorLabel
            // 
            imeRoditeljaErrorLabel.ForeColor = Color.Red;
            imeRoditeljaErrorLabel.Location = new Point(11, 123);
            imeRoditeljaErrorLabel.Name = "imeRoditeljaErrorLabel";
            imeRoditeljaErrorLabel.Size = new Size(398, 25);
            imeRoditeljaErrorLabel.TabIndex = 11;
            // 
            // licnoImeErrorLabel
            // 
            licnoImeErrorLabel.ForeColor = Color.Red;
            licnoImeErrorLabel.Location = new Point(11, 60);
            licnoImeErrorLabel.Name = "licnoImeErrorLabel";
            licnoImeErrorLabel.Size = new Size(398, 25);
            licnoImeErrorLabel.TabIndex = 10;
            // 
            // smerComboBox
            // 
            smerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            smerComboBox.Enabled = false;
            smerComboBox.FormattingEnabled = true;
            smerComboBox.Items.AddRange(new object[] { "EEN", "RII", "ELK", "EKM", "US", "KIT" });
            smerComboBox.Location = new Point(196, 277);
            smerComboBox.Name = "smerComboBox";
            smerComboBox.Size = new Size(254, 32);
            smerComboBox.TabIndex = 9;
            // 
            // brojIndeksaTextBox
            // 
            brojIndeksaTextBox.Enabled = false;
            brojIndeksaTextBox.Location = new Point(196, 214);
            brojIndeksaTextBox.MaxLength = 5;
            brojIndeksaTextBox.Name = "brojIndeksaTextBox";
            brojIndeksaTextBox.Size = new Size(254, 32);
            brojIndeksaTextBox.TabIndex = 8;
            brojIndeksaTextBox.KeyPress += brojIndeksaTextBox_KeyPress;
            // 
            // prezimeTextBox
            // 
            prezimeTextBox.Enabled = false;
            prezimeTextBox.Location = new Point(196, 151);
            prezimeTextBox.Name = "prezimeTextBox";
            prezimeTextBox.Size = new Size(254, 32);
            prezimeTextBox.TabIndex = 7;
            prezimeTextBox.KeyPress += prezimeTextBox_KeyPress;
            // 
            // imeRoditeljaTextBox
            // 
            imeRoditeljaTextBox.Enabled = false;
            imeRoditeljaTextBox.Location = new Point(196, 85);
            imeRoditeljaTextBox.Name = "imeRoditeljaTextBox";
            imeRoditeljaTextBox.Size = new Size(254, 32);
            imeRoditeljaTextBox.TabIndex = 6;
            imeRoditeljaTextBox.KeyPress += imeRoditeljaTextBox_KeyPress;
            // 
            // licnoImeTextBox
            // 
            licnoImeTextBox.Enabled = false;
            licnoImeTextBox.Location = new Point(196, 25);
            licnoImeTextBox.Name = "licnoImeTextBox";
            licnoImeTextBox.Size = new Size(254, 32);
            licnoImeTextBox.TabIndex = 5;
            licnoImeTextBox.KeyPress += licnoImeTextBox_KeyPress;
            // 
            // smerLabel
            // 
            smerLabel.AutoSize = true;
            smerLabel.Location = new Point(90, 280);
            smerLabel.Name = "smerLabel";
            smerLabel.Size = new Size(67, 24);
            smerLabel.TabIndex = 4;
            smerLabel.Text = "Smer*";
            // 
            // brojIndeksaLabel
            // 
            brojIndeksaLabel.AutoSize = true;
            brojIndeksaLabel.Location = new Point(32, 217);
            brojIndeksaLabel.Name = "brojIndeksaLabel";
            brojIndeksaLabel.Size = new Size(125, 24);
            brojIndeksaLabel.TabIndex = 3;
            brojIndeksaLabel.Text = "Broj indeksa*";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new Point(66, 154);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new Size(91, 24);
            prezimeLabel.TabIndex = 2;
            prezimeLabel.Text = "Prezime*";
            // 
            // imeRoditeljaLabel
            // 
            imeRoditeljaLabel.AutoSize = true;
            imeRoditeljaLabel.Location = new Point(27, 86);
            imeRoditeljaLabel.Name = "imeRoditeljaLabel";
            imeRoditeljaLabel.Size = new Size(130, 24);
            imeRoditeljaLabel.TabIndex = 1;
            imeRoditeljaLabel.Text = "Ime roditelja*";
            // 
            // licnoImeLabel
            // 
            licnoImeLabel.AutoSize = true;
            licnoImeLabel.Location = new Point(53, 28);
            licnoImeLabel.Name = "licnoImeLabel";
            licnoImeLabel.Size = new Size(104, 24);
            licnoImeLabel.TabIndex = 0;
            licnoImeLabel.Text = "Lično ime*";
            // 
            // studentDataGridView
            // 
            studentDataGridView.AllowUserToAddRows = false;
            studentDataGridView.AllowUserToDeleteRows = false;
            studentDataGridView.BackgroundColor = Color.DarkGray;
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, licnoImeColumn, imeRoditeljaColumn, prezimeColumn, brojIndeksaColumn, smerColumn });
            studentDataGridView.Dock = DockStyle.Right;
            studentDataGridView.Location = new Point(499, 43);
            studentDataGridView.MultiSelect = false;
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.ReadOnly = true;
            studentDataGridView.RowHeadersVisible = false;
            studentDataGridView.RowHeadersWidth = 51;
            studentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentDataGridView.Size = new Size(666, 497);
            studentDataGridView.TabIndex = 2;
            studentDataGridView.CellMouseDoubleClick += studentaDataGridView_CellMouseDoubleClick;
            studentDataGridView.SelectionChanged += studentaDataGridView_SelectionChanged;
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
            // licnoImeColumn
            // 
            licnoImeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            licnoImeColumn.HeaderText = "Lično ime";
            licnoImeColumn.MinimumWidth = 6;
            licnoImeColumn.Name = "licnoImeColumn";
            licnoImeColumn.ReadOnly = true;
            licnoImeColumn.Width = 122;
            // 
            // imeRoditeljaColumn
            // 
            imeRoditeljaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            imeRoditeljaColumn.HeaderText = "Ime roditelja";
            imeRoditeljaColumn.MinimumWidth = 6;
            imeRoditeljaColumn.Name = "imeRoditeljaColumn";
            imeRoditeljaColumn.ReadOnly = true;
            imeRoditeljaColumn.Width = 148;
            // 
            // prezimeColumn
            // 
            prezimeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            prezimeColumn.HeaderText = "Prezime";
            prezimeColumn.MinimumWidth = 6;
            prezimeColumn.Name = "prezimeColumn";
            prezimeColumn.ReadOnly = true;
            prezimeColumn.Width = 109;
            // 
            // brojIndeksaColumn
            // 
            brojIndeksaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            brojIndeksaColumn.HeaderText = "Broj indeksa";
            brojIndeksaColumn.MinimumWidth = 6;
            brojIndeksaColumn.Name = "brojIndeksaColumn";
            brojIndeksaColumn.ReadOnly = true;
            brojIndeksaColumn.Width = 143;
            // 
            // smerColumn
            // 
            smerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            smerColumn.HeaderText = "Smer";
            smerColumn.MinimumWidth = 6;
            smerColumn.Name = "smerColumn";
            smerColumn.ReadOnly = true;
            smerColumn.Width = 85;
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
            pretragaPanel.Controls.Add(pretraziButton);
            pretragaPanel.Controls.Add(smerPretraziComboBox);
            pretragaPanel.Controls.Add(indeksPretraziTextBox);
            pretragaPanel.Controls.Add(prezimePretaziTextBox);
            pretragaPanel.Controls.Add(roditeljPretraziTextBox);
            pretragaPanel.Controls.Add(imePretraziTextBox);
            pretragaPanel.Controls.Add(smerPretragaLabel);
            pretragaPanel.Controls.Add(indeksPretragaLabel);
            pretragaPanel.Controls.Add(prezimePretragaLabel);
            pretragaPanel.Controls.Add(roditeljPretragaLabel);
            pretragaPanel.Controls.Add(imePretragaLabel);
            pretragaPanel.Controls.Add(minimizePanelButton);
            pretragaPanel.Location = new Point(499, 46);
            pretragaPanel.Name = "pretragaPanel";
            pretragaPanel.Size = new Size(387, 398);
            pretragaPanel.TabIndex = 3;
            pretragaPanel.Visible = false;
            // 
            // ocistiPretraguButton
            // 
            ocistiPretraguButton.Image = Properties.Resources.broom_icon;
            ocistiPretraguButton.Location = new Point(254, 341);
            ocistiPretraguButton.Name = "ocistiPretraguButton";
            ocistiPretraguButton.Size = new Size(119, 33);
            ocistiPretraguButton.TabIndex = 12;
            ocistiPretraguButton.Text = "Očisti";
            ocistiPretraguButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ocistiPretraguButton.UseVisualStyleBackColor = true;
            ocistiPretraguButton.Click += ocistiPretraguButton_Click;
            // 
            // pretraziButton
            // 
            pretraziButton.Image = Properties.Resources.search_research_icon;
            pretraziButton.Location = new Point(119, 341);
            pretraziButton.Name = "pretraziButton";
            pretraziButton.Size = new Size(119, 33);
            pretraziButton.TabIndex = 11;
            pretraziButton.Text = "Pretraži";
            pretraziButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            pretraziButton.UseVisualStyleBackColor = true;
            pretraziButton.Click += pretraziButton_Click;
            // 
            // smerPretraziComboBox
            // 
            smerPretraziComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            smerPretraziComboBox.FormattingEnabled = true;
            smerPretraziComboBox.Items.AddRange(new object[] { "EEN", "RII", "ELK", "EKM", "US", "KIT" });
            smerPretraziComboBox.Location = new Point(119, 276);
            smerPretraziComboBox.Name = "smerPretraziComboBox";
            smerPretraziComboBox.Size = new Size(254, 32);
            smerPretraziComboBox.TabIndex = 10;
            // 
            // indeksPretraziTextBox
            // 
            indeksPretraziTextBox.Location = new Point(119, 213);
            indeksPretraziTextBox.MaxLength = 5;
            indeksPretraziTextBox.Name = "indeksPretraziTextBox";
            indeksPretraziTextBox.Size = new Size(254, 32);
            indeksPretraziTextBox.TabIndex = 9;
            indeksPretraziTextBox.KeyPress += indeksPretraziTextBox_KeyPress;
            // 
            // prezimePretaziTextBox
            // 
            prezimePretaziTextBox.Location = new Point(119, 150);
            prezimePretaziTextBox.Name = "prezimePretaziTextBox";
            prezimePretaziTextBox.Size = new Size(254, 32);
            prezimePretaziTextBox.TabIndex = 8;
            prezimePretaziTextBox.KeyPress += prezimePretaziTextBox_KeyPress;
            // 
            // roditeljPretraziTextBox
            // 
            roditeljPretraziTextBox.Location = new Point(119, 82);
            roditeljPretraziTextBox.Name = "roditeljPretraziTextBox";
            roditeljPretraziTextBox.Size = new Size(254, 32);
            roditeljPretraziTextBox.TabIndex = 7;
            roditeljPretraziTextBox.KeyPress += roditeljPretraziTextBox_KeyPress;
            // 
            // imePretraziTextBox
            // 
            imePretraziTextBox.Location = new Point(119, 24);
            imePretraziTextBox.Name = "imePretraziTextBox";
            imePretraziTextBox.Size = new Size(254, 32);
            imePretraziTextBox.TabIndex = 6;
            imePretraziTextBox.KeyPress += imePretraziTextBox_KeyPress;
            // 
            // smerPretragaLabel
            // 
            smerPretragaLabel.AutoSize = true;
            smerPretragaLabel.Location = new Point(34, 279);
            smerPretragaLabel.Name = "smerPretragaLabel";
            smerPretragaLabel.Size = new Size(56, 24);
            smerPretragaLabel.TabIndex = 5;
            smerPretragaLabel.Text = "Smer";
            // 
            // indeksPretragaLabel
            // 
            indeksPretragaLabel.AutoSize = true;
            indeksPretragaLabel.Location = new Point(24, 216);
            indeksPretragaLabel.Name = "indeksPretragaLabel";
            indeksPretragaLabel.Size = new Size(66, 24);
            indeksPretragaLabel.TabIndex = 4;
            indeksPretragaLabel.Text = "Indeks";
            // 
            // prezimePretragaLabel
            // 
            prezimePretragaLabel.AutoSize = true;
            prezimePretragaLabel.Location = new Point(10, 153);
            prezimePretragaLabel.Name = "prezimePretragaLabel";
            prezimePretragaLabel.Size = new Size(80, 24);
            prezimePretragaLabel.TabIndex = 3;
            prezimePretragaLabel.Text = "Prezime";
            // 
            // roditeljPretragaLabel
            // 
            roditeljPretragaLabel.AutoSize = true;
            roditeljPretragaLabel.Location = new Point(12, 85);
            roditeljPretragaLabel.Name = "roditeljPretragaLabel";
            roditeljPretragaLabel.Size = new Size(78, 24);
            roditeljPretragaLabel.TabIndex = 2;
            roditeljPretragaLabel.Text = "Roditelj";
            // 
            // imePretragaLabel
            // 
            imePretragaLabel.AutoSize = true;
            imePretragaLabel.Location = new Point(47, 27);
            imePretragaLabel.Name = "imePretragaLabel";
            imePretragaLabel.Size = new Size(43, 24);
            imePretragaLabel.TabIndex = 1;
            imePretragaLabel.Text = "Ime";
            // 
            // minimizePanelButton
            // 
            minimizePanelButton.Image = Properties.Resources.arrow_minimise_icon;
            minimizePanelButton.Location = new Point(3, 3);
            minimizePanelButton.Name = "minimizePanelButton";
            minimizePanelButton.Size = new Size(25, 25);
            minimizePanelButton.TabIndex = 0;
            minimizePanelButton.UseVisualStyleBackColor = true;
            minimizePanelButton.Click += minimizePanelButton_Click;
            // 
            // StudentiForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1165, 540);
            Controls.Add(pretragaPanel);
            Controls.Add(studentDataGridView);
            Controls.Add(studentGroupBox);
            Controls.Add(studentToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "StudentiForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Studenti";
            Activated += StudentiForma_Activated;
            studentToolStrip.ResumeLayout(false);
            studentToolStrip.PerformLayout();
            studentGroupBox.ResumeLayout(false);
            studentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            pretragaPanel.ResumeLayout(false);
            pretragaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip studentToolStrip;
        private ToolStripButton dodajToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton izmeniToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton obrisiToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton odustaniToolStripButton;
        private GroupBox studentGroupBox;
        private Label smerLabel;
        private Label brojIndeksaLabel;
        private Label prezimeLabel;
        private Label imeRoditeljaLabel;
        private Label licnoImeLabel;
        private TextBox prezimeTextBox;
        private TextBox imeRoditeljaTextBox;
        private TextBox licnoImeTextBox;
        private Label licnoImeErrorLabel;
        private ComboBox smerComboBox;
        private TextBox brojIndeksaTextBox;
        private Label brojIndeksaErrorLabel;
        private Label prezimeErrorLabel;
        private Label imeRoditeljaErrorLabel;
        private Label smerErrorLabel;
        private DataGridView studentDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn licnoImeColumn;
        private DataGridViewTextBoxColumn imeRoditeljaColumn;
        private DataGridViewTextBoxColumn prezimeColumn;
        private DataGridViewTextBoxColumn brojIndeksaColumn;
        private DataGridViewTextBoxColumn smerColumn;
        private ToolStripButton sacuvajToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private Label zvezdicaLabel;
        private Label successStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private Label brojStudenataLabel;
        private Label ukupanBrojStudenataLabel;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton pretragaToolStripButton;
        private Panel pretragaPanel;
        private Button minimizePanelButton;
        private Label imePretragaLabel;
        private Label smerPretragaLabel;
        private Label indeksPretragaLabel;
        private Label prezimePretragaLabel;
        private Label roditeljPretragaLabel;
        private ComboBox smerPretraziComboBox;
        private TextBox indeksPretraziTextBox;
        private TextBox prezimePretaziTextBox;
        private TextBox roditeljPretraziTextBox;
        private TextBox imePretraziTextBox;
        private Button pretraziButton;
        private Button ocistiPretraguButton;
    }
}