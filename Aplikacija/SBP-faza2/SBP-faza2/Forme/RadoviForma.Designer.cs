namespace SBP_faza2.Forme
{
    partial class RadoviForma
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
            radToolStrip = new ToolStrip();
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
            radGroupBox = new GroupBox();
            successStatusLabel = new Label();
            brojRadovaLabel = new Label();
            brojPrikazanihRadovaLabel = new Label();
            urlErrorLabel = new Label();
            nazivKonferencijeErrorLabel = new Label();
            godinaIzdanjaErrorLabel = new Label();
            naslovErrorLabel = new Label();
            urlTextBox = new TextBox();
            nazivKonferencijeTextBox = new TextBox();
            godinaIzdanjaTextBox = new TextBox();
            naslovTextBox = new TextBox();
            urlLabel = new Label();
            nazivKonferencijeLabel = new Label();
            godinaIzdanjaLabel = new Label();
            naslovLabel = new Label();
            radDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            NaslovColumn = new DataGridViewTextBoxColumn();
            godinaIzdanjaColumn = new DataGridViewTextBoxColumn();
            nazivKonferencijeColumn = new DataGridViewTextBoxColumn();
            urlColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            radToolStrip.SuspendLayout();
            radGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radDataGridView).BeginInit();
            SuspendLayout();
            // 
            // radToolStrip
            // 
            radToolStrip.AutoSize = false;
            radToolStrip.BackColor = Color.Gainsboro;
            radToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            radToolStrip.ImageScalingSize = new Size(20, 20);
            radToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripButton2, izmeniToolStripButton, toolStripSeparator1, obrisiToolStripButton, toolStripSeparator2, sacuvajToolStripButton, toolStripSeparator3, odustaniToolStripButton, toolStripSeparator4, pretragaToolStripButton });
            radToolStrip.Location = new Point(0, 0);
            radToolStrip.Name = "radToolStrip";
            radToolStrip.Size = new Size(1100, 43);
            radToolStrip.TabIndex = 5;
            radToolStrip.Text = "toolStrip1";
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
            // radGroupBox
            // 
            radGroupBox.Controls.Add(successStatusLabel);
            radGroupBox.Controls.Add(brojRadovaLabel);
            radGroupBox.Controls.Add(brojPrikazanihRadovaLabel);
            radGroupBox.Controls.Add(urlErrorLabel);
            radGroupBox.Controls.Add(nazivKonferencijeErrorLabel);
            radGroupBox.Controls.Add(godinaIzdanjaErrorLabel);
            radGroupBox.Controls.Add(naslovErrorLabel);
            radGroupBox.Controls.Add(urlTextBox);
            radGroupBox.Controls.Add(nazivKonferencijeTextBox);
            radGroupBox.Controls.Add(godinaIzdanjaTextBox);
            radGroupBox.Controls.Add(naslovTextBox);
            radGroupBox.Controls.Add(urlLabel);
            radGroupBox.Controls.Add(nazivKonferencijeLabel);
            radGroupBox.Controls.Add(godinaIzdanjaLabel);
            radGroupBox.Controls.Add(naslovLabel);
            radGroupBox.Location = new Point(12, 46);
            radGroupBox.Name = "radGroupBox";
            radGroupBox.Size = new Size(492, 482);
            radGroupBox.TabIndex = 6;
            radGroupBox.TabStop = false;
            radGroupBox.Text = "Podaci";
            // 
            // successStatusLabel
            // 
            successStatusLabel.ForeColor = SystemColors.ControlText;
            successStatusLabel.Location = new Point(28, 392);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 39;
            successStatusLabel.Text = "Polja označena zvezdicom su obavezna";
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brojRadovaLabel
            // 
            brojRadovaLabel.AutoSize = true;
            brojRadovaLabel.Location = new Point(276, 325);
            brojRadovaLabel.Name = "brojRadovaLabel";
            brojRadovaLabel.Size = new Size(0, 24);
            brojRadovaLabel.TabIndex = 25;
            // 
            // brojPrikazanihRadovaLabel
            // 
            brojPrikazanihRadovaLabel.AutoSize = true;
            brojPrikazanihRadovaLabel.Location = new Point(6, 325);
            brojPrikazanihRadovaLabel.Name = "brojPrikazanihRadovaLabel";
            brojPrikazanihRadovaLabel.Size = new Size(207, 24);
            brojPrikazanihRadovaLabel.TabIndex = 24;
            brojPrikazanihRadovaLabel.Text = "Broj prikazanih radova:";
            // 
            // urlErrorLabel
            // 
            urlErrorLabel.ForeColor = Color.Red;
            urlErrorLabel.Location = new Point(6, 273);
            urlErrorLabel.Name = "urlErrorLabel";
            urlErrorLabel.Size = new Size(459, 25);
            urlErrorLabel.TabIndex = 22;
            // 
            // nazivKonferencijeErrorLabel
            // 
            nazivKonferencijeErrorLabel.ForeColor = Color.Red;
            nazivKonferencijeErrorLabel.Location = new Point(6, 210);
            nazivKonferencijeErrorLabel.Name = "nazivKonferencijeErrorLabel";
            nazivKonferencijeErrorLabel.Size = new Size(459, 25);
            nazivKonferencijeErrorLabel.TabIndex = 21;
            // 
            // godinaIzdanjaErrorLabel
            // 
            godinaIzdanjaErrorLabel.ForeColor = Color.Red;
            godinaIzdanjaErrorLabel.Location = new Point(6, 147);
            godinaIzdanjaErrorLabel.Name = "godinaIzdanjaErrorLabel";
            godinaIzdanjaErrorLabel.Size = new Size(459, 25);
            godinaIzdanjaErrorLabel.TabIndex = 20;
            // 
            // naslovErrorLabel
            // 
            naslovErrorLabel.ForeColor = Color.Red;
            naslovErrorLabel.Location = new Point(6, 84);
            naslovErrorLabel.Name = "naslovErrorLabel";
            naslovErrorLabel.Size = new Size(459, 25);
            naslovErrorLabel.TabIndex = 19;
            // 
            // urlTextBox
            // 
            urlTextBox.Enabled = false;
            urlTextBox.Location = new Point(181, 238);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(284, 32);
            urlTextBox.TabIndex = 7;
            // 
            // nazivKonferencijeTextBox
            // 
            nazivKonferencijeTextBox.Enabled = false;
            nazivKonferencijeTextBox.Location = new Point(181, 175);
            nazivKonferencijeTextBox.Name = "nazivKonferencijeTextBox";
            nazivKonferencijeTextBox.Size = new Size(284, 32);
            nazivKonferencijeTextBox.TabIndex = 6;
            // 
            // godinaIzdanjaTextBox
            // 
            godinaIzdanjaTextBox.Enabled = false;
            godinaIzdanjaTextBox.Location = new Point(181, 112);
            godinaIzdanjaTextBox.MaxLength = 4;
            godinaIzdanjaTextBox.Name = "godinaIzdanjaTextBox";
            godinaIzdanjaTextBox.Size = new Size(82, 32);
            godinaIzdanjaTextBox.TabIndex = 5;
            // 
            // naslovTextBox
            // 
            naslovTextBox.Enabled = false;
            naslovTextBox.Location = new Point(181, 49);
            naslovTextBox.Name = "naslovTextBox";
            naslovTextBox.Size = new Size(284, 32);
            naslovTextBox.TabIndex = 4;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(127, 241);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(48, 24);
            urlLabel.TabIndex = 3;
            urlLabel.Text = "URL";
            // 
            // nazivKonferencijeLabel
            // 
            nazivKonferencijeLabel.AutoSize = true;
            nazivKonferencijeLabel.Location = new Point(6, 178);
            nazivKonferencijeLabel.Name = "nazivKonferencijeLabel";
            nazivKonferencijeLabel.Size = new Size(169, 24);
            nazivKonferencijeLabel.TabIndex = 2;
            nazivKonferencijeLabel.Text = "Naziv konferencije";
            // 
            // godinaIzdanjaLabel
            // 
            godinaIzdanjaLabel.AutoSize = true;
            godinaIzdanjaLabel.Location = new Point(28, 115);
            godinaIzdanjaLabel.Name = "godinaIzdanjaLabel";
            godinaIzdanjaLabel.Size = new Size(147, 24);
            godinaIzdanjaLabel.TabIndex = 1;
            godinaIzdanjaLabel.Text = "Godina izdanja*";
            // 
            // naslovLabel
            // 
            naslovLabel.AutoSize = true;
            naslovLabel.Location = new Point(95, 52);
            naslovLabel.Name = "naslovLabel";
            naslovLabel.Size = new Size(80, 24);
            naslovLabel.TabIndex = 0;
            naslovLabel.Text = "Naslov*";
            // 
            // radDataGridView
            // 
            radDataGridView.AllowUserToAddRows = false;
            radDataGridView.AllowUserToDeleteRows = false;
            radDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            radDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, NaslovColumn, godinaIzdanjaColumn, nazivKonferencijeColumn, urlColumn });
            radDataGridView.Dock = DockStyle.Right;
            radDataGridView.Location = new Point(510, 43);
            radDataGridView.MultiSelect = false;
            radDataGridView.Name = "radDataGridView";
            radDataGridView.ReadOnly = true;
            radDataGridView.RowHeadersVisible = false;
            radDataGridView.RowHeadersWidth = 51;
            radDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            radDataGridView.Size = new Size(590, 497);
            radDataGridView.TabIndex = 7;
            radDataGridView.CellMouseDoubleClick += radDataGridView_CellMouseDoubleClick;
            radDataGridView.SelectionChanged += radDataGridView_SelectionChanged;
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
            // NaslovColumn
            // 
            NaslovColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NaslovColumn.HeaderText = "Naslov";
            NaslovColumn.MinimumWidth = 6;
            NaslovColumn.Name = "NaslovColumn";
            NaslovColumn.ReadOnly = true;
            NaslovColumn.Width = 98;
            // 
            // godinaIzdanjaColumn
            // 
            godinaIzdanjaColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            godinaIzdanjaColumn.HeaderText = "Godina izdanja";
            godinaIzdanjaColumn.MinimumWidth = 6;
            godinaIzdanjaColumn.Name = "godinaIzdanjaColumn";
            godinaIzdanjaColumn.ReadOnly = true;
            godinaIzdanjaColumn.Width = 151;
            // 
            // nazivKonferencijeColumn
            // 
            nazivKonferencijeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nazivKonferencijeColumn.HeaderText = "Naziv konferencije";
            nazivKonferencijeColumn.MinimumWidth = 6;
            nazivKonferencijeColumn.Name = "nazivKonferencijeColumn";
            nazivKonferencijeColumn.ReadOnly = true;
            nazivKonferencijeColumn.Width = 181;
            // 
            // urlColumn
            // 
            urlColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            urlColumn.HeaderText = "URL";
            urlColumn.MinimumWidth = 6;
            urlColumn.Name = "urlColumn";
            urlColumn.ReadOnly = true;
            urlColumn.Width = 77;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // RadoviForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1100, 540);
            Controls.Add(radDataGridView);
            Controls.Add(radGroupBox);
            Controls.Add(radToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "RadoviForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Radovi";
            Activated += RadoviForma_Activated;
            radToolStrip.ResumeLayout(false);
            radToolStrip.PerformLayout();
            radGroupBox.ResumeLayout(false);
            radGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip radToolStrip;
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
        private GroupBox radGroupBox;
        private DataGridView radDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn NaslovColumn;
        private DataGridViewTextBoxColumn godinaIzdanjaColumn;
        private DataGridViewTextBoxColumn nazivKonferencijeColumn;
        private DataGridViewTextBoxColumn urlColumn;
        private Label urlLabel;
        private Label nazivKonferencijeLabel;
        private Label godinaIzdanjaLabel;
        private Label naslovLabel;
        private TextBox urlTextBox;
        private TextBox nazivKonferencijeTextBox;
        private TextBox godinaIzdanjaTextBox;
        private TextBox naslovTextBox;
        private Label naslovErrorLabel;
        private Label urlErrorLabel;
        private Label nazivKonferencijeErrorLabel;
        private Label godinaIzdanjaErrorLabel;
        private Label brojRadovaLabel;
        private Label brojPrikazanihRadovaLabel;
        private Label successStatusLabel;
        private System.Windows.Forms.Timer timer1;
    }
}