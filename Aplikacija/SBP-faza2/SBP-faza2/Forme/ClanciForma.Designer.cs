namespace SBP_faza2.Forme
{
    partial class ClanciForma
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
            clanakToolStrip = new ToolStrip();
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
            clanakGroupBox = new GroupBox();
            successStatusLabel = new Label();
            brojClanakaLabel = new Label();
            brojPrikazanihClanakaLabel = new Label();
            issnErrorLabel = new Label();
            brojCasopisaErrorLabel = new Label();
            nazivCasopisaErrorLabel = new Label();
            godinaIzdanjaErrorLabel = new Label();
            naslovErrorLabel = new Label();
            issnMaskedTextBox = new MaskedTextBox();
            brojCasopisaTextBox = new TextBox();
            nazivCasopisaTextBox = new TextBox();
            godinaIzdanjaTextBox = new TextBox();
            naslovTextBox = new TextBox();
            issnLabel = new Label();
            brojCasopisaLabel = new Label();
            nazivCasopisaLabel = new Label();
            godinaIzdanjaLabel = new Label();
            naslovLabel = new Label();
            clanakDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            naslovColumn = new DataGridViewTextBoxColumn();
            godinaIzdanjaColumn = new DataGridViewTextBoxColumn();
            nazivCasopisaColumn = new DataGridViewTextBoxColumn();
            brojCasopisaColumn = new DataGridViewTextBoxColumn();
            issnColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            clanakToolStrip.SuspendLayout();
            clanakGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clanakDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clanakToolStrip
            // 
            clanakToolStrip.AutoSize = false;
            clanakToolStrip.BackColor = Color.Gainsboro;
            clanakToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clanakToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            clanakToolStrip.ImageScalingSize = new Size(20, 20);
            clanakToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripButton2, izmeniToolStripButton, toolStripSeparator1, obrisiToolStripButton, toolStripSeparator2, sacuvajToolStripButton, toolStripSeparator3, odustaniToolStripButton, toolStripSeparator4, pretragaToolStripButton });
            clanakToolStrip.Location = new Point(0, 0);
            clanakToolStrip.Name = "clanakToolStrip";
            clanakToolStrip.Size = new Size(1100, 43);
            clanakToolStrip.TabIndex = 4;
            clanakToolStrip.Text = "toolStrip1";
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
            // clanakGroupBox
            // 
            clanakGroupBox.Controls.Add(successStatusLabel);
            clanakGroupBox.Controls.Add(brojClanakaLabel);
            clanakGroupBox.Controls.Add(brojPrikazanihClanakaLabel);
            clanakGroupBox.Controls.Add(issnErrorLabel);
            clanakGroupBox.Controls.Add(brojCasopisaErrorLabel);
            clanakGroupBox.Controls.Add(nazivCasopisaErrorLabel);
            clanakGroupBox.Controls.Add(godinaIzdanjaErrorLabel);
            clanakGroupBox.Controls.Add(naslovErrorLabel);
            clanakGroupBox.Controls.Add(issnMaskedTextBox);
            clanakGroupBox.Controls.Add(brojCasopisaTextBox);
            clanakGroupBox.Controls.Add(nazivCasopisaTextBox);
            clanakGroupBox.Controls.Add(godinaIzdanjaTextBox);
            clanakGroupBox.Controls.Add(naslovTextBox);
            clanakGroupBox.Controls.Add(issnLabel);
            clanakGroupBox.Controls.Add(brojCasopisaLabel);
            clanakGroupBox.Controls.Add(nazivCasopisaLabel);
            clanakGroupBox.Controls.Add(godinaIzdanjaLabel);
            clanakGroupBox.Controls.Add(naslovLabel);
            clanakGroupBox.Location = new Point(12, 46);
            clanakGroupBox.Name = "clanakGroupBox";
            clanakGroupBox.Size = new Size(491, 482);
            clanakGroupBox.TabIndex = 5;
            clanakGroupBox.TabStop = false;
            clanakGroupBox.Text = "Podaci";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = SystemColors.ControlText;
            successStatusLabel.Location = new Point(21, 407);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 38;
            successStatusLabel.Text = "Polja označena zvezdicom su obavezna";
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brojClanakaLabel
            // 
            brojClanakaLabel.AutoSize = true;
            brojClanakaLabel.Location = new Point(302, 365);
            brojClanakaLabel.Name = "brojClanakaLabel";
            brojClanakaLabel.Size = new Size(0, 24);
            brojClanakaLabel.TabIndex = 24;
            // 
            // brojPrikazanihClanakaLabel
            // 
            brojPrikazanihClanakaLabel.AutoSize = true;
            brojPrikazanihClanakaLabel.Location = new Point(8, 365);
            brojPrikazanihClanakaLabel.Name = "brojPrikazanihClanakaLabel";
            brojPrikazanihClanakaLabel.Size = new Size(213, 24);
            brojPrikazanihClanakaLabel.TabIndex = 23;
            brojPrikazanihClanakaLabel.Text = "Broj prikazanih članaka:";
            // 
            // issnErrorLabel
            // 
            issnErrorLabel.ForeColor = Color.Red;
            issnErrorLabel.Location = new Point(8, 323);
            issnErrorLabel.Name = "issnErrorLabel";
            issnErrorLabel.Size = new Size(459, 25);
            issnErrorLabel.TabIndex = 22;
            // 
            // brojCasopisaErrorLabel
            // 
            brojCasopisaErrorLabel.ForeColor = Color.Red;
            brojCasopisaErrorLabel.Location = new Point(8, 261);
            brojCasopisaErrorLabel.Name = "brojCasopisaErrorLabel";
            brojCasopisaErrorLabel.Size = new Size(459, 25);
            brojCasopisaErrorLabel.TabIndex = 21;
            // 
            // nazivCasopisaErrorLabel
            // 
            nazivCasopisaErrorLabel.ForeColor = Color.Red;
            nazivCasopisaErrorLabel.Location = new Point(8, 198);
            nazivCasopisaErrorLabel.Name = "nazivCasopisaErrorLabel";
            nazivCasopisaErrorLabel.Size = new Size(459, 25);
            nazivCasopisaErrorLabel.TabIndex = 20;
            // 
            // godinaIzdanjaErrorLabel
            // 
            godinaIzdanjaErrorLabel.ForeColor = Color.Red;
            godinaIzdanjaErrorLabel.Location = new Point(8, 135);
            godinaIzdanjaErrorLabel.Name = "godinaIzdanjaErrorLabel";
            godinaIzdanjaErrorLabel.Size = new Size(459, 25);
            godinaIzdanjaErrorLabel.TabIndex = 19;
            // 
            // naslovErrorLabel
            // 
            naslovErrorLabel.ForeColor = Color.Red;
            naslovErrorLabel.Location = new Point(8, 74);
            naslovErrorLabel.Name = "naslovErrorLabel";
            naslovErrorLabel.Size = new Size(459, 25);
            naslovErrorLabel.TabIndex = 18;
            // 
            // issnMaskedTextBox
            // 
            issnMaskedTextBox.Enabled = false;
            issnMaskedTextBox.Location = new Point(364, 288);
            issnMaskedTextBox.Mask = "0000-0000";
            issnMaskedTextBox.Name = "issnMaskedTextBox";
            issnMaskedTextBox.Size = new Size(103, 32);
            issnMaskedTextBox.TabIndex = 9;
            issnMaskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // brojCasopisaTextBox
            // 
            brojCasopisaTextBox.Enabled = false;
            brojCasopisaTextBox.Location = new Point(364, 226);
            brojCasopisaTextBox.Name = "brojCasopisaTextBox";
            brojCasopisaTextBox.Size = new Size(103, 32);
            brojCasopisaTextBox.TabIndex = 8;
            // 
            // nazivCasopisaTextBox
            // 
            nazivCasopisaTextBox.Enabled = false;
            nazivCasopisaTextBox.Location = new Point(159, 163);
            nazivCasopisaTextBox.Name = "nazivCasopisaTextBox";
            nazivCasopisaTextBox.Size = new Size(308, 32);
            nazivCasopisaTextBox.TabIndex = 7;
            // 
            // godinaIzdanjaTextBox
            // 
            godinaIzdanjaTextBox.Enabled = false;
            godinaIzdanjaTextBox.Location = new Point(364, 103);
            godinaIzdanjaTextBox.Name = "godinaIzdanjaTextBox";
            godinaIzdanjaTextBox.Size = new Size(103, 32);
            godinaIzdanjaTextBox.TabIndex = 6;
            // 
            // naslovTextBox
            // 
            naslovTextBox.Enabled = false;
            naslovTextBox.Location = new Point(159, 39);
            naslovTextBox.Name = "naslovTextBox";
            naslovTextBox.Size = new Size(308, 32);
            naslovTextBox.TabIndex = 5;
            // 
            // issnLabel
            // 
            issnLabel.AutoSize = true;
            issnLabel.Location = new Point(87, 291);
            issnLabel.Name = "issnLabel";
            issnLabel.Size = new Size(66, 24);
            issnLabel.TabIndex = 4;
            issnLabel.Text = "ISSN*";
            // 
            // brojCasopisaLabel
            // 
            brojCasopisaLabel.AutoSize = true;
            brojCasopisaLabel.Location = new Point(21, 229);
            brojCasopisaLabel.Name = "brojCasopisaLabel";
            brojCasopisaLabel.Size = new Size(132, 24);
            brojCasopisaLabel.TabIndex = 3;
            brojCasopisaLabel.Text = "Broj časopisa*";
            // 
            // nazivCasopisaLabel
            // 
            nazivCasopisaLabel.AutoSize = true;
            nazivCasopisaLabel.Location = new Point(7, 166);
            nazivCasopisaLabel.Name = "nazivCasopisaLabel";
            nazivCasopisaLabel.Size = new Size(146, 24);
            nazivCasopisaLabel.TabIndex = 2;
            nazivCasopisaLabel.Text = "Naziv časopisa*";
            // 
            // godinaIzdanjaLabel
            // 
            godinaIzdanjaLabel.AutoSize = true;
            godinaIzdanjaLabel.Location = new Point(6, 106);
            godinaIzdanjaLabel.Name = "godinaIzdanjaLabel";
            godinaIzdanjaLabel.Size = new Size(147, 24);
            godinaIzdanjaLabel.TabIndex = 1;
            godinaIzdanjaLabel.Text = "Godina izdanja*";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new Point(73, 42);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(80, 24);
            naslovLabel.TabIndex = 0;
            naslovLabel.Text = "Naslov*";
            // 
            // clanakDataGridView
            // 
            clanakDataGridView.AllowUserToAddRows = false;
            clanakDataGridView.AllowUserToDeleteRows = false;
            clanakDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clanakDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, naslovColumn, godinaIzdanjaColumn, nazivCasopisaColumn, brojCasopisaColumn, issnColumn });
            clanakDataGridView.Dock = DockStyle.Right;
            clanakDataGridView.Location = new Point(509, 43);
            clanakDataGridView.MultiSelect = false;
            clanakDataGridView.Name = "clanakDataGridView";
            clanakDataGridView.ReadOnly = true;
            clanakDataGridView.RowHeadersVisible = false;
            clanakDataGridView.RowHeadersWidth = 51;
            clanakDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clanakDataGridView.Size = new Size(591, 497);
            clanakDataGridView.TabIndex = 6;
            clanakDataGridView.CellMouseDoubleClick += clanakDataGridView_CellMouseDoubleClick;
            clanakDataGridView.SelectionChanged += clanakDataGridView_SelectionChanged;
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
            // nazivCasopisaColumn
            // 
            nazivCasopisaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nazivCasopisaColumn.HeaderText = "Naziv časopisa";
            nazivCasopisaColumn.MinimumWidth = 6;
            nazivCasopisaColumn.Name = "nazivCasopisaColumn";
            nazivCasopisaColumn.ReadOnly = true;
            nazivCasopisaColumn.Width = 164;
            // 
            // brojCasopisaColumn
            // 
            brojCasopisaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            brojCasopisaColumn.HeaderText = "Broj časopisa";
            brojCasopisaColumn.MinimumWidth = 6;
            brojCasopisaColumn.Name = "brojCasopisaColumn";
            brojCasopisaColumn.ReadOnly = true;
            brojCasopisaColumn.Width = 150;
            // 
            // issnColumn
            // 
            issnColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            issnColumn.HeaderText = "ISSN";
            issnColumn.MinimumWidth = 6;
            issnColumn.Name = "issnColumn";
            issnColumn.ReadOnly = true;
            issnColumn.Width = 84;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // ClanciForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1100, 540);
            Controls.Add(clanakDataGridView);
            Controls.Add(clanakGroupBox);
            Controls.Add(clanakToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ClanciForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Clanci";
            Activated += ClanciForma_Activated;
            clanakToolStrip.ResumeLayout(false);
            clanakToolStrip.PerformLayout();
            clanakGroupBox.ResumeLayout(false);
            clanakGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clanakDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip clanakToolStrip;
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
        private GroupBox clanakGroupBox;
        private Label issnLabel;
        private Label brojCasopisaLabel;
        private Label nazivCasopisaLabel;
        private Label godinaIzdanjaLabel;
        private Label naslovLabel;
        private TextBox naslovTextBox;
        private TextBox godinaIzdanjaTextBox;
        private MaskedTextBox issnMaskedTextBox;
        private TextBox brojCasopisaTextBox;
        private TextBox nazivCasopisaTextBox;
        private Label issnErrorLabel;
        private Label brojCasopisaErrorLabel;
        private Label nazivCasopisaErrorLabel;
        private Label godinaIzdanjaErrorLabel;
        private Label naslovErrorLabel;
        private Label brojClanakaLabel;
        private Label brojPrikazanihClanakaLabel;
        private Label successStatusLabel;
        private DataGridView clanakDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn naslovColumn;
        private DataGridViewTextBoxColumn godinaIzdanjaColumn;
        private DataGridViewTextBoxColumn nazivCasopisaColumn;
        private DataGridViewTextBoxColumn brojCasopisaColumn;
        private DataGridViewTextBoxColumn issnColumn;
        private System.Windows.Forms.Timer timer1;
    }
}