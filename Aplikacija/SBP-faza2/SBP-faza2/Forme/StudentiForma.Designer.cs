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
            studentToolStrip = new ToolStrip();
            dodajStudentaToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            izmeniStudentaToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            obrisiStudentaToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            sacuvajToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            odustaniToolStripButton = new ToolStripButton();
            studentGroupBox = new GroupBox();
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
            studentaDataGridView = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            licnoImeColumn = new DataGridViewTextBoxColumn();
            imeRoditeljaColumn = new DataGridViewTextBoxColumn();
            prezimeColumn = new DataGridViewTextBoxColumn();
            brojIndeksaColumn = new DataGridViewTextBoxColumn();
            smerColumn = new DataGridViewTextBoxColumn();
            studentToolStrip.SuspendLayout();
            studentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // studentToolStrip
            // 
            studentToolStrip.AutoSize = false;
            studentToolStrip.BackColor = Color.Gainsboro;
            studentToolStrip.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            studentToolStrip.ImageScalingSize = new Size(20, 20);
            studentToolStrip.Items.AddRange(new ToolStripItem[] { dodajStudentaToolStripButton, toolStripSeparator1, izmeniStudentaToolStripButton, toolStripSeparator2, obrisiStudentaToolStripButton, toolStripSeparator3, sacuvajToolStripButton, toolStripSeparator4, odustaniToolStripButton });
            studentToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            studentToolStrip.Location = new Point(0, 0);
            studentToolStrip.Name = "studentToolStrip";
            studentToolStrip.Size = new Size(1164, 43);
            studentToolStrip.TabIndex = 0;
            studentToolStrip.Text = "toolStrip1";
            // 
            // dodajStudentaToolStripButton
            // 
            dodajStudentaToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dodajStudentaToolStripButton.Image = Properties.Resources.add_icon;
            dodajStudentaToolStripButton.ImageTransparentColor = Color.Magenta;
            dodajStudentaToolStripButton.Name = "dodajStudentaToolStripButton";
            dodajStudentaToolStripButton.Size = new Size(85, 40);
            dodajStudentaToolStripButton.Text = "Dodaj";
            dodajStudentaToolStripButton.Click += dodajStudentaToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
            // 
            // izmeniStudentaToolStripButton
            // 
            izmeniStudentaToolStripButton.Enabled = false;
            izmeniStudentaToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            izmeniStudentaToolStripButton.Image = Properties.Resources.edit_icon;
            izmeniStudentaToolStripButton.ImageTransparentColor = Color.Magenta;
            izmeniStudentaToolStripButton.Name = "izmeniStudentaToolStripButton";
            izmeniStudentaToolStripButton.Size = new Size(92, 40);
            izmeniStudentaToolStripButton.Text = "Izmeni";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 43);
            // 
            // obrisiStudentaToolStripButton
            // 
            obrisiStudentaToolStripButton.Enabled = false;
            obrisiStudentaToolStripButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            obrisiStudentaToolStripButton.Image = Properties.Resources.trash_can_icon;
            obrisiStudentaToolStripButton.ImageTransparentColor = Color.Magenta;
            obrisiStudentaToolStripButton.Name = "obrisiStudentaToolStripButton";
            obrisiStudentaToolStripButton.Size = new Size(85, 40);
            obrisiStudentaToolStripButton.Text = "Obriši";
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
            // studentGroupBox
            // 
            studentGroupBox.BackColor = Color.DarkGray;
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
            studentGroupBox.Size = new Size(427, 482);
            studentGroupBox.TabIndex = 1;
            studentGroupBox.TabStop = false;
            studentGroupBox.Text = "Podaci";
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
            smerErrorLabel.Location = new Point(11, 312);
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
            smerComboBox.Items.AddRange(new object[] { "RI", "UUR" });
            smerComboBox.Location = new Point(155, 277);
            smerComboBox.Name = "smerComboBox";
            smerComboBox.Size = new Size(254, 32);
            smerComboBox.TabIndex = 9;
            // 
            // brojIndeksaTextBox
            // 
            brojIndeksaTextBox.Enabled = false;
            brojIndeksaTextBox.Location = new Point(155, 214);
            brojIndeksaTextBox.Name = "brojIndeksaTextBox";
            brojIndeksaTextBox.Size = new Size(254, 32);
            brojIndeksaTextBox.TabIndex = 8;
            // 
            // prezimeTextBox
            // 
            prezimeTextBox.Enabled = false;
            prezimeTextBox.Location = new Point(155, 151);
            prezimeTextBox.Name = "prezimeTextBox";
            prezimeTextBox.Size = new Size(254, 32);
            prezimeTextBox.TabIndex = 7;
            // 
            // imeRoditeljaTextBox
            // 
            imeRoditeljaTextBox.Enabled = false;
            imeRoditeljaTextBox.Location = new Point(155, 88);
            imeRoditeljaTextBox.Name = "imeRoditeljaTextBox";
            imeRoditeljaTextBox.Size = new Size(254, 32);
            imeRoditeljaTextBox.TabIndex = 6;
            // 
            // licnoImeTextBox
            // 
            licnoImeTextBox.Enabled = false;
            licnoImeTextBox.Location = new Point(155, 25);
            licnoImeTextBox.Name = "licnoImeTextBox";
            licnoImeTextBox.Size = new Size(254, 32);
            licnoImeTextBox.TabIndex = 5;
            // 
            // smerLabel
            // 
            smerLabel.AutoSize = true;
            smerLabel.Location = new Point(69, 280);
            smerLabel.Name = "smerLabel";
            smerLabel.Size = new Size(67, 24);
            smerLabel.TabIndex = 4;
            smerLabel.Text = "Smer*";
            // 
            // brojIndeksaLabel
            // 
            brojIndeksaLabel.AutoSize = true;
            brojIndeksaLabel.Location = new Point(11, 217);
            brojIndeksaLabel.Name = "brojIndeksaLabel";
            brojIndeksaLabel.Size = new Size(125, 24);
            brojIndeksaLabel.TabIndex = 3;
            brojIndeksaLabel.Text = "Broj indeksa*";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new Point(45, 154);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new Size(91, 24);
            prezimeLabel.TabIndex = 2;
            prezimeLabel.Text = "Prezime*";
            // 
            // imeRoditeljaLabel
            // 
            imeRoditeljaLabel.AutoSize = true;
            imeRoditeljaLabel.Location = new Point(6, 91);
            imeRoditeljaLabel.Name = "imeRoditeljaLabel";
            imeRoditeljaLabel.Size = new Size(130, 24);
            imeRoditeljaLabel.TabIndex = 1;
            imeRoditeljaLabel.Text = "Ime roditelja*";
            // 
            // licnoImeLabel
            // 
            licnoImeLabel.AutoSize = true;
            licnoImeLabel.Location = new Point(32, 28);
            licnoImeLabel.Name = "licnoImeLabel";
            licnoImeLabel.Size = new Size(104, 24);
            licnoImeLabel.TabIndex = 0;
            licnoImeLabel.Text = "Lično ime*";
            // 
            // studentaDataGridView
            // 
            studentaDataGridView.AllowUserToAddRows = false;
            studentaDataGridView.AllowUserToDeleteRows = false;
            studentaDataGridView.BackgroundColor = Color.DarkGray;
            studentaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentaDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, licnoImeColumn, imeRoditeljaColumn, prezimeColumn, brojIndeksaColumn, smerColumn });
            studentaDataGridView.Dock = DockStyle.Right;
            studentaDataGridView.Location = new Point(445, 43);
            studentaDataGridView.MultiSelect = false;
            studentaDataGridView.Name = "studentaDataGridView";
            studentaDataGridView.ReadOnly = true;
            studentaDataGridView.RowHeadersWidth = 51;
            studentaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentaDataGridView.Size = new Size(719, 497);
            studentaDataGridView.TabIndex = 2;
            studentaDataGridView.SelectionChanged += studentaDataGridView_SelectionChanged;
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
            // StudentiForma
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1164, 540);
            Controls.Add(studentaDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)studentaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip studentToolStrip;
        private ToolStripButton dodajStudentaToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton izmeniStudentaToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton obrisiStudentaToolStripButton;
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
        private DataGridView studentaDataGridView;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn licnoImeColumn;
        private DataGridViewTextBoxColumn imeRoditeljaColumn;
        private DataGridViewTextBoxColumn prezimeColumn;
        private DataGridViewTextBoxColumn brojIndeksaColumn;
        private DataGridViewTextBoxColumn smerColumn;
        private ToolStripButton sacuvajToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private Label zvezdicaLabel;
    }
}