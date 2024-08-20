namespace SBP_faza2.Forme
{
    partial class KnjigeForma
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
            knjigaToolStrip = new ToolStrip();
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
            knjigaGroupBox = new GroupBox();
            successStatusLabel = new Label();
            brojKnjigaLabel = new Label();
            izdavacErrorLabel = new Label();
            brojPrikazanihKnjigaLabel = new Label();
            isbnErrorLabel = new Label();
            godinaIzdanjaErrorLabel = new Label();
            naslovErrorLabel = new Label();
            izdavacTextBox = new TextBox();
            isbnMaskedTextBox = new MaskedTextBox();
            godinaIzdanjaTextBox = new TextBox();
            naslovTextBox = new TextBox();
            izdavacLabel = new Label();
            isbnLabel = new Label();
            godinaIzdanjaLabel = new Label();
            naslovLabel = new Label();
            knjigaDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            naslovColumn = new DataGridViewTextBoxColumn();
            godinaIzdanjaColumn = new DataGridViewTextBoxColumn();
            isbnColumn = new DataGridViewTextBoxColumn();
            izdavacColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            knjigaToolStrip.SuspendLayout();
            knjigaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)knjigaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // knjigaToolStrip
            // 
            knjigaToolStrip.AutoSize = false;
            knjigaToolStrip.BackColor = Color.Gainsboro;
            knjigaToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            knjigaToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            knjigaToolStrip.ImageScalingSize = new Size(20, 20);
            knjigaToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripButton2, izmeniToolStripButton, toolStripSeparator1, obrisiToolStripButton, toolStripSeparator2, sacuvajToolStripButton, toolStripSeparator3, odustaniToolStripButton, toolStripSeparator4, pretragaToolStripButton });
            knjigaToolStrip.Location = new Point(0, 0);
            knjigaToolStrip.Name = "knjigaToolStrip";
            knjigaToolStrip.Size = new Size(1100, 43);
            knjigaToolStrip.TabIndex = 3;
            knjigaToolStrip.Text = "toolStrip1";
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
            // knjigaGroupBox
            // 
            knjigaGroupBox.Controls.Add(successStatusLabel);
            knjigaGroupBox.Controls.Add(brojKnjigaLabel);
            knjigaGroupBox.Controls.Add(izdavacErrorLabel);
            knjigaGroupBox.Controls.Add(brojPrikazanihKnjigaLabel);
            knjigaGroupBox.Controls.Add(isbnErrorLabel);
            knjigaGroupBox.Controls.Add(godinaIzdanjaErrorLabel);
            knjigaGroupBox.Controls.Add(naslovErrorLabel);
            knjigaGroupBox.Controls.Add(izdavacTextBox);
            knjigaGroupBox.Controls.Add(isbnMaskedTextBox);
            knjigaGroupBox.Controls.Add(godinaIzdanjaTextBox);
            knjigaGroupBox.Controls.Add(naslovTextBox);
            knjigaGroupBox.Controls.Add(izdavacLabel);
            knjigaGroupBox.Controls.Add(isbnLabel);
            knjigaGroupBox.Controls.Add(godinaIzdanjaLabel);
            knjigaGroupBox.Controls.Add(naslovLabel);
            knjigaGroupBox.Location = new Point(12, 46);
            knjigaGroupBox.Name = "knjigaGroupBox";
            knjigaGroupBox.Size = new Size(492, 482);
            knjigaGroupBox.TabIndex = 4;
            knjigaGroupBox.TabStop = false;
            knjigaGroupBox.Text = "Podaci";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = SystemColors.ControlText;
            successStatusLabel.Location = new Point(24, 341);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 37;
            successStatusLabel.Text = "Polja označena zvezdicom su obavezna";
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brojKnjigaLabel
            // 
            brojKnjigaLabel.AutoSize = true;
            brojKnjigaLabel.Location = new Point(292, 289);
            brojKnjigaLabel.Name = "brojKnjigaLabel";
            brojKnjigaLabel.Size = new Size(0, 24);
            brojKnjigaLabel.TabIndex = 21;
            // 
            // izdavacErrorLabel
            // 
            izdavacErrorLabel.ForeColor = Color.Red;
            izdavacErrorLabel.Location = new Point(6, 249);
            izdavacErrorLabel.Name = "izdavacErrorLabel";
            izdavacErrorLabel.Size = new Size(459, 25);
            izdavacErrorLabel.TabIndex = 20;
            // 
            // brojPrikazanihKnjigaLabel
            // 
            brojPrikazanihKnjigaLabel.AutoSize = true;
            brojPrikazanihKnjigaLabel.Location = new Point(6, 289);
            brojPrikazanihKnjigaLabel.Name = "brojPrikazanihKnjigaLabel";
            brojPrikazanihKnjigaLabel.Size = new Size(200, 24);
            brojPrikazanihKnjigaLabel.TabIndex = 19;
            brojPrikazanihKnjigaLabel.Text = "Broj prikazanih knjiga:";
            // 
            // isbnErrorLabel
            // 
            isbnErrorLabel.ForeColor = Color.Red;
            isbnErrorLabel.Location = new Point(6, 186);
            isbnErrorLabel.Name = "isbnErrorLabel";
            isbnErrorLabel.Size = new Size(459, 25);
            isbnErrorLabel.TabIndex = 19;
            // 
            // godinaIzdanjaErrorLabel
            // 
            godinaIzdanjaErrorLabel.ForeColor = Color.Red;
            godinaIzdanjaErrorLabel.Location = new Point(6, 123);
            godinaIzdanjaErrorLabel.Name = "godinaIzdanjaErrorLabel";
            godinaIzdanjaErrorLabel.Size = new Size(459, 25);
            godinaIzdanjaErrorLabel.TabIndex = 18;
            // 
            // naslovErrorLabel
            // 
            naslovErrorLabel.ForeColor = Color.Red;
            naslovErrorLabel.Location = new Point(6, 60);
            naslovErrorLabel.Name = "naslovErrorLabel";
            naslovErrorLabel.Size = new Size(459, 25);
            naslovErrorLabel.TabIndex = 17;
            // 
            // izdavacTextBox
            // 
            izdavacTextBox.Enabled = false;
            izdavacTextBox.Location = new Point(159, 214);
            izdavacTextBox.Name = "izdavacTextBox";
            izdavacTextBox.Size = new Size(306, 32);
            izdavacTextBox.TabIndex = 7;
            // 
            // isbnMaskedTextBox
            // 
            isbnMaskedTextBox.Enabled = false;
            isbnMaskedTextBox.Location = new Point(292, 151);
            isbnMaskedTextBox.Mask = "000-0-000-00000-0";
            isbnMaskedTextBox.Name = "isbnMaskedTextBox";
            isbnMaskedTextBox.Size = new Size(173, 32);
            isbnMaskedTextBox.TabIndex = 6;
            isbnMaskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // godinaIzdanjaTextBox
            // 
            godinaIzdanjaTextBox.Enabled = false;
            godinaIzdanjaTextBox.Location = new Point(362, 88);
            godinaIzdanjaTextBox.MaxLength = 4;
            godinaIzdanjaTextBox.Name = "godinaIzdanjaTextBox";
            godinaIzdanjaTextBox.Size = new Size(103, 32);
            godinaIzdanjaTextBox.TabIndex = 5;
            // 
            // naslovTextBox
            // 
            naslovTextBox.Enabled = false;
            naslovTextBox.Location = new Point(159, 25);
            naslovTextBox.Name = "naslovTextBox";
            naslovTextBox.Size = new Size(306, 32);
            naslovTextBox.TabIndex = 4;
            // 
            // izdavacLabel
            // 
            izdavacLabel.AutoSize = true;
            izdavacLabel.Location = new Point(67, 217);
            izdavacLabel.Name = "izdavacLabel";
            izdavacLabel.Size = new Size(86, 24);
            izdavacLabel.TabIndex = 3;
            izdavacLabel.Text = "Izdavač*";
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new Point(87, 154);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(66, 24);
            isbnLabel.TabIndex = 2;
            isbnLabel.Text = "ISBN*";
            // 
            // godinaIzdanjaLabel
            // 
            godinaIzdanjaLabel.AutoSize = true;
            godinaIzdanjaLabel.Location = new Point(6, 91);
            godinaIzdanjaLabel.Name = "godinaIzdanjaLabel";
            godinaIzdanjaLabel.Size = new Size(147, 24);
            godinaIzdanjaLabel.TabIndex = 1;
            godinaIzdanjaLabel.Text = "Godina izdanja*";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new Point(73, 28);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(80, 24);
            naslovLabel.TabIndex = 0;
            naslovLabel.Text = "Naslov*";
            // 
            // knjigaDataGridView
            // 
            knjigaDataGridView.AllowUserToAddRows = false;
            knjigaDataGridView.AllowUserToDeleteRows = false;
            knjigaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            knjigaDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, naslovColumn, godinaIzdanjaColumn, isbnColumn, izdavacColumn });
            knjigaDataGridView.Dock = DockStyle.Right;
            knjigaDataGridView.Location = new Point(510, 43);
            knjigaDataGridView.MultiSelect = false;
            knjigaDataGridView.Name = "knjigaDataGridView";
            knjigaDataGridView.ReadOnly = true;
            knjigaDataGridView.RowHeadersVisible = false;
            knjigaDataGridView.RowHeadersWidth = 51;
            knjigaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            knjigaDataGridView.Size = new Size(590, 497);
            knjigaDataGridView.TabIndex = 5;
            knjigaDataGridView.CellMouseDoubleClick += knjigaDataGridView_CellMouseDoubleClick;
            knjigaDataGridView.SelectionChanged += knjigaDataGridView_SelectionChanged;
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
            // naslovColumn
            // 
            naslovColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            naslovColumn.HeaderText = "Naslov";
            naslovColumn.MinimumWidth = 6;
            naslovColumn.Name = "naslovColumn";
            naslovColumn.ReadOnly = true;
            naslovColumn.Width = 98;
            // 
            // godinaIzdanjaColumn
            // 
            godinaIzdanjaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            godinaIzdanjaColumn.HeaderText = "Godina izdanja";
            godinaIzdanjaColumn.MinimumWidth = 6;
            godinaIzdanjaColumn.Name = "godinaIzdanjaColumn";
            godinaIzdanjaColumn.ReadOnly = true;
            godinaIzdanjaColumn.Width = 165;
            // 
            // isbnColumn
            // 
            isbnColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            isbnColumn.HeaderText = "ISBN";
            isbnColumn.MinimumWidth = 6;
            isbnColumn.Name = "isbnColumn";
            isbnColumn.ReadOnly = true;
            isbnColumn.Width = 84;
            // 
            // izdavacColumn
            // 
            izdavacColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            izdavacColumn.HeaderText = "Izdavač";
            izdavacColumn.MinimumWidth = 6;
            izdavacColumn.Name = "izdavacColumn";
            izdavacColumn.ReadOnly = true;
            izdavacColumn.Width = 104;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // KnjigeForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1100, 540);
            Controls.Add(knjigaDataGridView);
            Controls.Add(knjigaGroupBox);
            Controls.Add(knjigaToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "KnjigeForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Knjige";
            Activated += KnjigeForma_Activated;
            knjigaToolStrip.ResumeLayout(false);
            knjigaToolStrip.PerformLayout();
            knjigaGroupBox.ResumeLayout(false);
            knjigaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)knjigaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip knjigaToolStrip;
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
        private GroupBox knjigaGroupBox;
        private Label izdavacLabel;
        private Label isbnLabel;
        private Label godinaIzdanjaLabel;
        private Label naslovLabel;
        private MaskedTextBox isbnMaskedTextBox;
        private TextBox godinaIzdanjaTextBox;
        private TextBox naslovTextBox;
        private TextBox izdavacTextBox;
        private Label naslovErrorLabel;
        private Label isbnErrorLabel;
        private Label godinaIzdanjaErrorLabel;
        private Label izdavacErrorLabel;
        private Label brojPrikazanihKnjigaLabel;
        private Label brojKnjigaLabel;
        private Label successStatusLabel;
        private DataGridView knjigaDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn naslovColumn;
        private DataGridViewTextBoxColumn godinaIzdanjaColumn;
        private DataGridViewTextBoxColumn isbnColumn;
        private DataGridViewTextBoxColumn izdavacColumn;
        private System.Windows.Forms.Timer timer1;
    }
}