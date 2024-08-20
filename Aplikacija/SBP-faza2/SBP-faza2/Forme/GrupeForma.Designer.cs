namespace SBP_faza2.Forme
{
    partial class GrupeForma
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
            grupaToolStrip = new ToolStrip();
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
            grupaGroupBox = new GroupBox();
            brojGrupaLabel = new Label();
            brojPrikazanihGrupaLabel = new Label();
            successStatusLabel = new Label();
            projekatErrorLabel = new Label();
            tipProjektaErrorLabel = new Label();
            nazivGrupeErrorLabel = new Label();
            projekatComboBox = new ComboBox();
            tipProjektaComboBox = new ComboBox();
            tipProjektaLabel = new Label();
            nazivGrupeTextBox = new TextBox();
            projekatLabel = new Label();
            nazivGrupeLabel = new Label();
            grupaDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            nazivGrupeColumn = new DataGridViewTextBoxColumn();
            projekatColumn = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            pretragaPanel = new Panel();
            minimizePanelButton = new Button();
            ocistiPretraguButton = new Button();
            pretraziButton = new Button();
            projekatPretragaComboBox = new ComboBox();
            tipPretragaComboBox = new ComboBox();
            nazivPretragaTextBox = new TextBox();
            projekatPretragaLabel = new Label();
            tipPretragaLabel = new Label();
            nazivPretragaLabel = new Label();
            grupaToolStrip.SuspendLayout();
            grupaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grupaDataGridView).BeginInit();
            pretragaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // grupaToolStrip
            // 
            grupaToolStrip.AutoSize = false;
            grupaToolStrip.BackColor = Color.Gainsboro;
            grupaToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grupaToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            grupaToolStrip.ImageScalingSize = new Size(20, 20);
            grupaToolStrip.Items.AddRange(new ToolStripItem[] { dodajToolStripButton, toolStripSeparator1, izmeniToolStripButton, toolStripSeparator2, obrisiToolStripButton, toolStripSeparator3, sacuvajToolStripButton, toolStripSeparator4, odustaniToolStripButton, toolStripSeparator5, pretragaToolStripButton });
            grupaToolStrip.Location = new Point(0, 0);
            grupaToolStrip.Name = "grupaToolStrip";
            grupaToolStrip.Size = new Size(1100, 43);
            grupaToolStrip.TabIndex = 0;
            grupaToolStrip.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 43);
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
            // grupaGroupBox
            // 
            grupaGroupBox.Controls.Add(brojGrupaLabel);
            grupaGroupBox.Controls.Add(brojPrikazanihGrupaLabel);
            grupaGroupBox.Controls.Add(successStatusLabel);
            grupaGroupBox.Controls.Add(projekatErrorLabel);
            grupaGroupBox.Controls.Add(tipProjektaErrorLabel);
            grupaGroupBox.Controls.Add(nazivGrupeErrorLabel);
            grupaGroupBox.Controls.Add(projekatComboBox);
            grupaGroupBox.Controls.Add(tipProjektaComboBox);
            grupaGroupBox.Controls.Add(tipProjektaLabel);
            grupaGroupBox.Controls.Add(nazivGrupeTextBox);
            grupaGroupBox.Controls.Add(projekatLabel);
            grupaGroupBox.Controls.Add(nazivGrupeLabel);
            grupaGroupBox.Location = new Point(12, 46);
            grupaGroupBox.Name = "grupaGroupBox";
            grupaGroupBox.Size = new Size(527, 482);
            grupaGroupBox.TabIndex = 1;
            grupaGroupBox.TabStop = false;
            grupaGroupBox.Text = "Podaci";
            // 
            // brojGrupaLabel
            // 
            brojGrupaLabel.AutoSize = true;
            brojGrupaLabel.Location = new Point(235, 231);
            brojGrupaLabel.Name = "brojGrupaLabel";
            brojGrupaLabel.Size = new Size(0, 24);
            brojGrupaLabel.TabIndex = 20;
            // 
            // brojPrikazanihGrupaLabel
            // 
            brojPrikazanihGrupaLabel.AutoSize = true;
            brojPrikazanihGrupaLabel.Location = new Point(9, 231);
            brojPrikazanihGrupaLabel.Name = "brojPrikazanihGrupaLabel";
            brojPrikazanihGrupaLabel.Size = new Size(198, 24);
            brojPrikazanihGrupaLabel.TabIndex = 19;
            brojPrikazanihGrupaLabel.Text = "Broj prikazanih grupa:";
            // 
            // successStatusLabel
            // 
            successStatusLabel.Location = new Point(67, 289);
            successStatusLabel.Name = "successStatusLabel";
            successStatusLabel.Size = new Size(423, 54);
            successStatusLabel.TabIndex = 18;
            successStatusLabel.Text = "Polja označena zvezdicom su obavezna";
            successStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // projekatErrorLabel
            // 
            projekatErrorLabel.ForeColor = Color.Red;
            projekatErrorLabel.Location = new Point(9, 189);
            projekatErrorLabel.Name = "projekatErrorLabel";
            projekatErrorLabel.Size = new Size(481, 25);
            projekatErrorLabel.TabIndex = 17;
            // 
            // tipProjektaErrorLabel
            // 
            tipProjektaErrorLabel.ForeColor = Color.Red;
            tipProjektaErrorLabel.Location = new Point(9, 126);
            tipProjektaErrorLabel.Name = "tipProjektaErrorLabel";
            tipProjektaErrorLabel.Size = new Size(481, 25);
            tipProjektaErrorLabel.TabIndex = 16;
            // 
            // nazivGrupeErrorLabel
            // 
            nazivGrupeErrorLabel.ForeColor = Color.Red;
            nazivGrupeErrorLabel.Location = new Point(9, 60);
            nazivGrupeErrorLabel.Name = "nazivGrupeErrorLabel";
            nazivGrupeErrorLabel.Size = new Size(481, 25);
            nazivGrupeErrorLabel.TabIndex = 15;
            // 
            // projekatComboBox
            // 
            projekatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projekatComboBox.Enabled = false;
            projekatComboBox.FormattingEnabled = true;
            projekatComboBox.Location = new Point(172, 154);
            projekatComboBox.Name = "projekatComboBox";
            projekatComboBox.Size = new Size(318, 32);
            projekatComboBox.TabIndex = 5;
            // 
            // tipProjektaComboBox
            // 
            tipProjektaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tipProjektaComboBox.Enabled = false;
            tipProjektaComboBox.FormattingEnabled = true;
            tipProjektaComboBox.Items.AddRange(new object[] { "Teorijski", "Praktični" });
            tipProjektaComboBox.Location = new Point(329, 91);
            tipProjektaComboBox.Name = "tipProjektaComboBox";
            tipProjektaComboBox.Size = new Size(161, 32);
            tipProjektaComboBox.TabIndex = 4;
            tipProjektaComboBox.SelectedIndexChanged += tipProjektaComboBox_SelectedIndexChanged;
            tipProjektaComboBox.SelectedValueChanged += tipProjektaComboBox_SelectedValueChanged;
            // 
            // tipProjektaLabel
            // 
            tipProjektaLabel.AutoSize = true;
            tipProjektaLabel.Location = new Point(53, 94);
            tipProjektaLabel.Name = "tipProjektaLabel";
            tipProjektaLabel.Size = new Size(113, 24);
            tipProjektaLabel.TabIndex = 3;
            tipProjektaLabel.Text = "Tip projekta";
            // 
            // nazivGrupeTextBox
            // 
            nazivGrupeTextBox.Enabled = false;
            nazivGrupeTextBox.Location = new Point(172, 25);
            nazivGrupeTextBox.Name = "nazivGrupeTextBox";
            nazivGrupeTextBox.Size = new Size(318, 32);
            nazivGrupeTextBox.TabIndex = 2;
            // 
            // projekatLabel
            // 
            projekatLabel.AutoSize = true;
            projekatLabel.Location = new Point(72, 158);
            projekatLabel.Name = "projekatLabel";
            projekatLabel.Size = new Size(94, 24);
            projekatLabel.TabIndex = 1;
            projekatLabel.Text = "Projekat*";
            // 
            // nazivGrupeLabel
            // 
            nazivGrupeLabel.AutoSize = true;
            nazivGrupeLabel.Location = new Point(42, 29);
            nazivGrupeLabel.Name = "nazivGrupeLabel";
            nazivGrupeLabel.Size = new Size(124, 24);
            nazivGrupeLabel.TabIndex = 0;
            nazivGrupeLabel.Text = "Naziv grupe*";
            // 
            // grupaDataGridView
            // 
            grupaDataGridView.AllowUserToAddRows = false;
            grupaDataGridView.AllowUserToDeleteRows = false;
            grupaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grupaDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, nazivGrupeColumn, projekatColumn });
            grupaDataGridView.Dock = DockStyle.Right;
            grupaDataGridView.Location = new Point(545, 43);
            grupaDataGridView.MultiSelect = false;
            grupaDataGridView.Name = "grupaDataGridView";
            grupaDataGridView.ReadOnly = true;
            grupaDataGridView.RowHeadersVisible = false;
            grupaDataGridView.RowHeadersWidth = 51;
            grupaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grupaDataGridView.Size = new Size(555, 497);
            grupaDataGridView.TabIndex = 2;
            grupaDataGridView.CellMouseDoubleClick += grupaDataGridView_CellMouseDoubleClick;
            grupaDataGridView.SelectionChanged += grupaDataGridView_SelectionChanged;
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
            // nazivGrupeColumn
            // 
            nazivGrupeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nazivGrupeColumn.HeaderText = "Naziv grupe";
            nazivGrupeColumn.MinimumWidth = 6;
            nazivGrupeColumn.Name = "nazivGrupeColumn";
            nazivGrupeColumn.ReadOnly = true;
            // 
            // projekatColumn
            // 
            projekatColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            projekatColumn.HeaderText = "Naziv projekta";
            projekatColumn.MinimumWidth = 6;
            projekatColumn.Name = "projekatColumn";
            projekatColumn.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // pretragaPanel
            // 
            pretragaPanel.BorderStyle = BorderStyle.FixedSingle;
            pretragaPanel.Controls.Add(minimizePanelButton);
            pretragaPanel.Controls.Add(ocistiPretraguButton);
            pretragaPanel.Controls.Add(pretraziButton);
            pretragaPanel.Controls.Add(projekatPretragaComboBox);
            pretragaPanel.Controls.Add(tipPretragaComboBox);
            pretragaPanel.Controls.Add(nazivPretragaTextBox);
            pretragaPanel.Controls.Add(projekatPretragaLabel);
            pretragaPanel.Controls.Add(tipPretragaLabel);
            pretragaPanel.Controls.Add(nazivPretragaLabel);
            pretragaPanel.Location = new Point(545, 43);
            pretragaPanel.Name = "pretragaPanel";
            pretragaPanel.Size = new Size(437, 255);
            pretragaPanel.TabIndex = 3;
            pretragaPanel.Visible = false;
            // 
            // minimizePanelButton
            // 
            minimizePanelButton.Image = Properties.Resources.arrow_minimise_icon;
            minimizePanelButton.Location = new Point(3, 3);
            minimizePanelButton.Name = "minimizePanelButton";
            minimizePanelButton.Size = new Size(24, 24);
            minimizePanelButton.TabIndex = 24;
            minimizePanelButton.UseVisualStyleBackColor = true;
            minimizePanelButton.Click += minimizePanelButton_Click;
            // 
            // ocistiPretraguButton
            // 
            ocistiPretraguButton.Cursor = Cursors.Hand;
            ocistiPretraguButton.Image = Properties.Resources.broom_icon;
            ocistiPretraguButton.Location = new Point(251, 209);
            ocistiPretraguButton.Name = "ocistiPretraguButton";
            ocistiPretraguButton.Size = new Size(119, 33);
            ocistiPretraguButton.TabIndex = 23;
            ocistiPretraguButton.Text = "Očisti";
            ocistiPretraguButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ocistiPretraguButton.UseVisualStyleBackColor = true;
            ocistiPretraguButton.Click += ocistiPretraguButton_Click;
            // 
            // pretraziButton
            // 
            pretraziButton.Cursor = Cursors.Hand;
            pretraziButton.Image = Properties.Resources.search_research_icon;
            pretraziButton.Location = new Point(94, 209);
            pretraziButton.Name = "pretraziButton";
            pretraziButton.Size = new Size(119, 33);
            pretraziButton.TabIndex = 22;
            pretraziButton.Text = "Pretraži";
            pretraziButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            pretraziButton.UseVisualStyleBackColor = true;
            pretraziButton.Click += pretraziButton_Click;
            // 
            // projekatPretragaComboBox
            // 
            projekatPretragaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projekatPretragaComboBox.Enabled = false;
            projekatPretragaComboBox.FormattingEnabled = true;
            projekatPretragaComboBox.Location = new Point(94, 154);
            projekatPretragaComboBox.Name = "projekatPretragaComboBox";
            projekatPretragaComboBox.Size = new Size(318, 32);
            projekatPretragaComboBox.TabIndex = 21;
            // 
            // tipPretragaComboBox
            // 
            tipPretragaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tipPretragaComboBox.FormattingEnabled = true;
            tipPretragaComboBox.Items.AddRange(new object[] { "Teorijski", "Praktični" });
            tipPretragaComboBox.Location = new Point(251, 91);
            tipPretragaComboBox.Name = "tipPretragaComboBox";
            tipPretragaComboBox.Size = new Size(161, 32);
            tipPretragaComboBox.TabIndex = 21;
            tipPretragaComboBox.SelectedIndexChanged += tipPretragaComboBox_SelectedIndexChanged;
            // 
            // nazivPretragaTextBox
            // 
            nazivPretragaTextBox.Location = new Point(94, 25);
            nazivPretragaTextBox.Name = "nazivPretragaTextBox";
            nazivPretragaTextBox.Size = new Size(318, 32);
            nazivPretragaTextBox.TabIndex = 21;
            // 
            // projekatPretragaLabel
            // 
            projekatPretragaLabel.AutoSize = true;
            projekatPretragaLabel.Location = new Point(5, 157);
            projekatPretragaLabel.Name = "projekatPretragaLabel";
            projekatPretragaLabel.Size = new Size(83, 24);
            projekatPretragaLabel.TabIndex = 2;
            projekatPretragaLabel.Text = "Projekat";
            // 
            // tipPretragaLabel
            // 
            tipPretragaLabel.AutoSize = true;
            tipPretragaLabel.Location = new Point(51, 94);
            tipPretragaLabel.Name = "tipPretragaLabel";
            tipPretragaLabel.Size = new Size(37, 24);
            tipPretragaLabel.TabIndex = 1;
            tipPretragaLabel.Text = "Tip";
            // 
            // nazivPretragaLabel
            // 
            nazivPretragaLabel.AutoSize = true;
            nazivPretragaLabel.Location = new Point(29, 28);
            nazivPretragaLabel.Name = "nazivPretragaLabel";
            nazivPretragaLabel.Size = new Size(59, 24);
            nazivPretragaLabel.TabIndex = 0;
            nazivPretragaLabel.Text = "Naziv";
            // 
            // GrupeForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1100, 540);
            Controls.Add(pretragaPanel);
            Controls.Add(grupaDataGridView);
            Controls.Add(grupaGroupBox);
            Controls.Add(grupaToolStrip);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "GrupeForma";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Grupe";
            Activated += GrupeForma_Activated;
            grupaToolStrip.ResumeLayout(false);
            grupaToolStrip.PerformLayout();
            grupaGroupBox.ResumeLayout(false);
            grupaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grupaDataGridView).EndInit();
            pretragaPanel.ResumeLayout(false);
            pretragaPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip grupaToolStrip;
        private ToolStripButton dodajToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton izmeniToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton obrisiToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton sacuvajToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton odustaniToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton pretragaToolStripButton;
        private GroupBox grupaGroupBox;
        private Label projekatLabel;
        private Label nazivGrupeLabel;
        private ComboBox projekatComboBox;
        private ComboBox tipProjektaComboBox;
        private Label tipProjektaLabel;
        private TextBox nazivGrupeTextBox;
        private Label tipProjektaErrorLabel;
        private Label nazivGrupeErrorLabel;
        private Label projekatErrorLabel;
        private DataGridView grupaDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nazivGrupeColumn;
        private DataGridViewTextBoxColumn projekatColumn;
        private Label successStatusLabel;
        private Label brojGrupaLabel;
        private Label brojPrikazanihGrupaLabel;
        private System.Windows.Forms.Timer timer1;
        private Panel pretragaPanel;
        private Label projekatPretragaLabel;
        private Label tipPretragaLabel;
        private Label nazivPretragaLabel;
        private ComboBox projekatPretragaComboBox;
        private ComboBox tipPretragaComboBox;
        private TextBox nazivPretragaTextBox;
        private Button pretraziButton;
        private Button ocistiPretraguButton;
        private Button minimizePanelButton;
    }
}