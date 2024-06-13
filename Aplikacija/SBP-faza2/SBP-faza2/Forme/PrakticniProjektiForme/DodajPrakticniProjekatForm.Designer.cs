namespace SBP_faza2.Forme.PrakticniProjektiForme
{
    partial class DodajPrakticniProjekatForm
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
            groupBoxProjekatPodaci = new GroupBox();
            listViewPredmeti = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            textBoxKratakOpis = new TextBox();
            numericUpDownBrojIzvestaja = new NumericUpDown();
            labelBrojIzvestaja = new Label();
            labelKratakOpis = new Label();
            textBoxPreporuceniProgJezik = new TextBox();
            labelPreporuceniProgJezik = new Label();
            comboBoxGrupni = new ComboBox();
            labelPredmet = new Label();
            dateTimePickerRokZaZavrsetak = new DateTimePicker();
            dateTimePickerDatumPocetka = new DateTimePicker();
            labelRokZaZavrsetak = new Label();
            labelDatumPocetka = new Label();
            labelGrupni = new Label();
            labelSkolskaGodina = new Label();
            textBoxSkolskaGodina = new TextBox();
            labelNazivProjekta = new Label();
            textBoxNazivProjekta = new TextBox();
            buttonDodajPrakticniProjekat = new Button();
            groupBoxProjekatPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBrojIzvestaja).BeginInit();
            SuspendLayout();
            // 
            // groupBoxProjekatPodaci
            // 
            groupBoxProjekatPodaci.Controls.Add(listViewPredmeti);
            groupBoxProjekatPodaci.Controls.Add(textBoxKratakOpis);
            groupBoxProjekatPodaci.Controls.Add(numericUpDownBrojIzvestaja);
            groupBoxProjekatPodaci.Controls.Add(labelBrojIzvestaja);
            groupBoxProjekatPodaci.Controls.Add(labelKratakOpis);
            groupBoxProjekatPodaci.Controls.Add(textBoxPreporuceniProgJezik);
            groupBoxProjekatPodaci.Controls.Add(labelPreporuceniProgJezik);
            groupBoxProjekatPodaci.Controls.Add(comboBoxGrupni);
            groupBoxProjekatPodaci.Controls.Add(labelPredmet);
            groupBoxProjekatPodaci.Controls.Add(dateTimePickerRokZaZavrsetak);
            groupBoxProjekatPodaci.Controls.Add(dateTimePickerDatumPocetka);
            groupBoxProjekatPodaci.Controls.Add(labelRokZaZavrsetak);
            groupBoxProjekatPodaci.Controls.Add(labelDatumPocetka);
            groupBoxProjekatPodaci.Controls.Add(labelGrupni);
            groupBoxProjekatPodaci.Controls.Add(labelSkolskaGodina);
            groupBoxProjekatPodaci.Controls.Add(textBoxSkolskaGodina);
            groupBoxProjekatPodaci.Controls.Add(labelNazivProjekta);
            groupBoxProjekatPodaci.Controls.Add(textBoxNazivProjekta);
            groupBoxProjekatPodaci.Location = new Point(12, 12);
            groupBoxProjekatPodaci.Name = "groupBoxProjekatPodaci";
            groupBoxProjekatPodaci.Size = new Size(976, 405);
            groupBoxProjekatPodaci.TabIndex = 2;
            groupBoxProjekatPodaci.TabStop = false;
            groupBoxProjekatPodaci.Text = "Podaci o projektu";
            // 
            // listViewPredmeti
            // 
            listViewPredmeti.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewPredmeti.FullRowSelect = true;
            listViewPredmeti.GridLines = true;
            listViewPredmeti.Location = new Point(585, 42);
            listViewPredmeti.MultiSelect = false;
            listViewPredmeti.Name = "listViewPredmeti";
            listViewPredmeti.Size = new Size(385, 141);
            listViewPredmeti.TabIndex = 24;
            listViewPredmeti.UseCompatibleStateImageBehavior = false;
            listViewPredmeti.View = View.Details;
            listViewPredmeti.SelectedIndexChanged += listViewPredmeti_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.Width = 300;
            // 
            // textBoxKratakOpis
            // 
            textBoxKratakOpis.BackColor = SystemColors.ButtonFace;
            textBoxKratakOpis.Location = new Point(158, 305);
            textBoxKratakOpis.MaxLength = 300;
            textBoxKratakOpis.Multiline = true;
            textBoxKratakOpis.Name = "textBoxKratakOpis";
            textBoxKratakOpis.Size = new Size(812, 84);
            textBoxKratakOpis.TabIndex = 23;
            // 
            // numericUpDownBrojIzvestaja
            // 
            numericUpDownBrojIzvestaja.BackColor = SystemColors.ButtonFace;
            numericUpDownBrojIzvestaja.Location = new Point(757, 254);
            numericUpDownBrojIzvestaja.Name = "numericUpDownBrojIzvestaja";
            numericUpDownBrojIzvestaja.Size = new Size(213, 32);
            numericUpDownBrojIzvestaja.TabIndex = 22;
            // 
            // labelBrojIzvestaja
            // 
            labelBrojIzvestaja.AutoSize = true;
            labelBrojIzvestaja.Location = new Point(498, 256);
            labelBrojIzvestaja.Name = "labelBrojIzvestaja";
            labelBrojIzvestaja.Size = new Size(121, 24);
            labelBrojIzvestaja.TabIndex = 21;
            labelBrojIzvestaja.Text = "Broj izveštaja";
            // 
            // labelKratakOpis
            // 
            labelKratakOpis.AutoSize = true;
            labelKratakOpis.Location = new Point(6, 305);
            labelKratakOpis.Name = "labelKratakOpis";
            labelKratakOpis.Size = new Size(103, 24);
            labelKratakOpis.TabIndex = 20;
            labelKratakOpis.Text = "Kratak opis";
            // 
            // textBoxPreporuceniProgJezik
            // 
            textBoxPreporuceniProgJezik.BackColor = SystemColors.ButtonFace;
            textBoxPreporuceniProgJezik.Location = new Point(755, 205);
            textBoxPreporuceniProgJezik.MaxLength = 30;
            textBoxPreporuceniProgJezik.Name = "textBoxPreporuceniProgJezik";
            textBoxPreporuceniProgJezik.Size = new Size(215, 32);
            textBoxPreporuceniProgJezik.TabIndex = 19;
            // 
            // labelPreporuceniProgJezik
            // 
            labelPreporuceniProgJezik.AutoSize = true;
            labelPreporuceniProgJezik.Location = new Point(498, 208);
            labelPreporuceniProgJezik.Name = "labelPreporuceniProgJezik";
            labelPreporuceniProgJezik.Size = new Size(251, 24);
            labelPreporuceniProgJezik.TabIndex = 18;
            labelPreporuceniProgJezik.Text = "Preporučeni programski jezik";
            // 
            // comboBoxGrupni
            // 
            comboBoxGrupni.BackColor = SystemColors.ButtonFace;
            comboBoxGrupni.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrupni.FormattingEnabled = true;
            comboBoxGrupni.Items.AddRange(new object[] { "Da", "Ne" });
            comboBoxGrupni.Location = new Point(158, 151);
            comboBoxGrupni.Name = "comboBoxGrupni";
            comboBoxGrupni.Size = new Size(321, 32);
            comboBoxGrupni.TabIndex = 17;
            comboBoxGrupni.SelectedIndexChanged += comboBoxGrupni_SelectedIndexChanged;
            // 
            // labelPredmet
            // 
            labelPredmet.AutoSize = true;
            labelPredmet.Location = new Point(498, 45);
            labelPredmet.Name = "labelPredmet";
            labelPredmet.Size = new Size(81, 24);
            labelPredmet.TabIndex = 14;
            labelPredmet.Text = "Predmet";
            // 
            // dateTimePickerRokZaZavrsetak
            // 
            dateTimePickerRokZaZavrsetak.CalendarMonthBackground = SystemColors.ButtonFace;
            dateTimePickerRokZaZavrsetak.Format = DateTimePickerFormat.Short;
            dateTimePickerRokZaZavrsetak.Location = new Point(158, 250);
            dateTimePickerRokZaZavrsetak.Name = "dateTimePickerRokZaZavrsetak";
            dateTimePickerRokZaZavrsetak.Size = new Size(321, 32);
            dateTimePickerRokZaZavrsetak.TabIndex = 12;
            dateTimePickerRokZaZavrsetak.ValueChanged += dateTimePickerRokZaZavrsetak_ValueChanged;
            // 
            // dateTimePickerDatumPocetka
            // 
            dateTimePickerDatumPocetka.CalendarMonthBackground = SystemColors.ButtonFace;
            dateTimePickerDatumPocetka.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumPocetka.Location = new Point(158, 202);
            dateTimePickerDatumPocetka.Name = "dateTimePickerDatumPocetka";
            dateTimePickerDatumPocetka.Size = new Size(321, 32);
            dateTimePickerDatumPocetka.TabIndex = 11;
            dateTimePickerDatumPocetka.ValueChanged += dateTimePickerDatumPocetka_ValueChanged;
            // 
            // labelRokZaZavrsetak
            // 
            labelRokZaZavrsetak.AutoSize = true;
            labelRokZaZavrsetak.Location = new Point(6, 256);
            labelRokZaZavrsetak.Name = "labelRokZaZavrsetak";
            labelRokZaZavrsetak.Size = new Size(147, 24);
            labelRokZaZavrsetak.TabIndex = 10;
            labelRokZaZavrsetak.Text = "Rok za završetak";
            // 
            // labelDatumPocetka
            // 
            labelDatumPocetka.AutoSize = true;
            labelDatumPocetka.Location = new Point(6, 208);
            labelDatumPocetka.Name = "labelDatumPocetka";
            labelDatumPocetka.Size = new Size(137, 24);
            labelDatumPocetka.TabIndex = 7;
            labelDatumPocetka.Text = "Datum početka";
            // 
            // labelGrupni
            // 
            labelGrupni.AutoSize = true;
            labelGrupni.Location = new Point(6, 154);
            labelGrupni.Name = "labelGrupni";
            labelGrupni.Size = new Size(68, 24);
            labelGrupni.TabIndex = 4;
            labelGrupni.Text = "Grupni";
            // 
            // labelSkolskaGodina
            // 
            labelSkolskaGodina.AutoSize = true;
            labelSkolskaGodina.Location = new Point(6, 98);
            labelSkolskaGodina.Name = "labelSkolskaGodina";
            labelSkolskaGodina.Size = new Size(132, 24);
            labelSkolskaGodina.TabIndex = 3;
            labelSkolskaGodina.Text = "Školska godina";
            // 
            // textBoxSkolskaGodina
            // 
            textBoxSkolskaGodina.BackColor = SystemColors.ButtonFace;
            textBoxSkolskaGodina.Location = new Point(158, 95);
            textBoxSkolskaGodina.MaxLength = 9;
            textBoxSkolskaGodina.Name = "textBoxSkolskaGodina";
            textBoxSkolskaGodina.Size = new Size(321, 32);
            textBoxSkolskaGodina.TabIndex = 2;
            textBoxSkolskaGodina.TextChanged += textBoxSkolskaGodina_TextChanged;
            textBoxSkolskaGodina.KeyPress += textBoxSkolskaGodina_KeyPress;
            // 
            // labelNazivProjekta
            // 
            labelNazivProjekta.AutoSize = true;
            labelNazivProjekta.Location = new Point(6, 45);
            labelNazivProjekta.Name = "labelNazivProjekta";
            labelNazivProjekta.Size = new Size(55, 24);
            labelNazivProjekta.TabIndex = 1;
            labelNazivProjekta.Text = "Naziv";
            // 
            // textBoxNazivProjekta
            // 
            textBoxNazivProjekta.BackColor = SystemColors.ButtonFace;
            textBoxNazivProjekta.Location = new Point(158, 42);
            textBoxNazivProjekta.MaxLength = 50;
            textBoxNazivProjekta.Name = "textBoxNazivProjekta";
            textBoxNazivProjekta.Size = new Size(321, 32);
            textBoxNazivProjekta.TabIndex = 0;
            textBoxNazivProjekta.TextChanged += textBoxNazivProjekta_TextChanged;
            // 
            // buttonDodajPrakticniProjekat
            // 
            buttonDodajPrakticniProjekat.Enabled = false;
            buttonDodajPrakticniProjekat.Location = new Point(410, 439);
            buttonDodajPrakticniProjekat.Name = "buttonDodajPrakticniProjekat";
            buttonDodajPrakticniProjekat.Size = new Size(221, 48);
            buttonDodajPrakticniProjekat.TabIndex = 24;
            buttonDodajPrakticniProjekat.Text = "Dodaj praktični projekat";
            buttonDodajPrakticniProjekat.UseVisualStyleBackColor = true;
            buttonDodajPrakticniProjekat.Click += buttonDodajPrakticniProjekat_Click;
            // 
            // DodajPrakticniProjekatForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1000, 508);
            Controls.Add(buttonDodajPrakticniProjekat);
            Controls.Add(groupBoxProjekatPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajPrakticniProjekatForm";
            Text = "Dodaj praktični projekat";
            Load += DodajPrakticniProjekatForm_Load;
            groupBoxProjekatPodaci.ResumeLayout(false);
            groupBoxProjekatPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBrojIzvestaja).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProjekatPodaci;
        private TextBox textBoxPreporuceniProgJezik;
        private Label labelPreporuceniProgJezik;
        private ComboBox comboBoxGrupni;
        private Label labelPredmet;
        private DateTimePicker dateTimePickerRokZaZavrsetak;
        private DateTimePicker dateTimePickerDatumPocetka;
        private Label labelRokZaZavrsetak;
        private Label labelDatumPocetka;
        private Label labelGrupni;
        private Label labelSkolskaGodina;
        private TextBox textBoxSkolskaGodina;
        private Label labelNazivProjekta;
        private TextBox textBoxNazivProjekta;
        private TextBox textBoxKratakOpis;
        private NumericUpDown numericUpDownBrojIzvestaja;
        private Label labelBrojIzvestaja;
        private Label labelKratakOpis;
        private Button buttonDodajPrakticniProjekat;
        private ListView listViewPredmeti;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}