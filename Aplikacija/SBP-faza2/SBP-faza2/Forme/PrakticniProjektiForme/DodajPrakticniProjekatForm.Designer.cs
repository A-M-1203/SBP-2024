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
            textBox2 = new TextBox();
            numericUpDownBrojIzvestaja = new NumericUpDown();
            labelBrojIzvestaja = new Label();
            labelKratakOpis = new Label();
            textBox1 = new TextBox();
            labelPreporuceniProgJezik = new Label();
            comboBoxGrupni = new ComboBox();
            labelPredmet = new Label();
            dateTimePickerRokZaZavrsetak = new DateTimePicker();
            dateTimePickerDatumPocetka = new DateTimePicker();
            labelRokZaZavrsetak = new Label();
            labelDatumPocetka = new Label();
            labelGrupni = new Label();
            labelSkolskaGodina = new Label();
            textBoxImeRoditelja = new TextBox();
            labelNazivProjekta = new Label();
            textBoxImeStudenta = new TextBox();
            buttonDodajPrakticniProjekat = new Button();
            listBoxPredmet = new ListBox();
            groupBoxProjekatPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBrojIzvestaja).BeginInit();
            SuspendLayout();
            // 
            // groupBoxProjekatPodaci
            // 
            groupBoxProjekatPodaci.Controls.Add(listBoxPredmet);
            groupBoxProjekatPodaci.Controls.Add(textBox2);
            groupBoxProjekatPodaci.Controls.Add(numericUpDownBrojIzvestaja);
            groupBoxProjekatPodaci.Controls.Add(labelBrojIzvestaja);
            groupBoxProjekatPodaci.Controls.Add(labelKratakOpis);
            groupBoxProjekatPodaci.Controls.Add(textBox1);
            groupBoxProjekatPodaci.Controls.Add(labelPreporuceniProgJezik);
            groupBoxProjekatPodaci.Controls.Add(comboBoxGrupni);
            groupBoxProjekatPodaci.Controls.Add(labelPredmet);
            groupBoxProjekatPodaci.Controls.Add(dateTimePickerRokZaZavrsetak);
            groupBoxProjekatPodaci.Controls.Add(dateTimePickerDatumPocetka);
            groupBoxProjekatPodaci.Controls.Add(labelRokZaZavrsetak);
            groupBoxProjekatPodaci.Controls.Add(labelDatumPocetka);
            groupBoxProjekatPodaci.Controls.Add(labelGrupni);
            groupBoxProjekatPodaci.Controls.Add(labelSkolskaGodina);
            groupBoxProjekatPodaci.Controls.Add(textBoxImeRoditelja);
            groupBoxProjekatPodaci.Controls.Add(labelNazivProjekta);
            groupBoxProjekatPodaci.Controls.Add(textBoxImeStudenta);
            groupBoxProjekatPodaci.Location = new Point(12, 12);
            groupBoxProjekatPodaci.Name = "groupBoxProjekatPodaci";
            groupBoxProjekatPodaci.Size = new Size(976, 405);
            groupBoxProjekatPodaci.TabIndex = 2;
            groupBoxProjekatPodaci.TabStop = false;
            groupBoxProjekatPodaci.Text = "Podaci o projektu";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonFace;
            textBox2.Location = new Point(158, 305);
            textBox2.MaxLength = 300;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(812, 84);
            textBox2.TabIndex = 23;
            // 
            // numericUpDownBrojIzvestaja
            // 
            numericUpDownBrojIzvestaja.BackColor = SystemColors.ButtonFace;
            numericUpDownBrojIzvestaja.Location = new Point(757, 206);
            numericUpDownBrojIzvestaja.Name = "numericUpDownBrojIzvestaja";
            numericUpDownBrojIzvestaja.Size = new Size(213, 32);
            numericUpDownBrojIzvestaja.TabIndex = 22;
            // 
            // labelBrojIzvestaja
            // 
            labelBrojIzvestaja.AutoSize = true;
            labelBrojIzvestaja.Location = new Point(498, 210);
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(757, 151);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 32);
            textBox1.TabIndex = 19;
            // 
            // labelPreporuceniProgJezik
            // 
            labelPreporuceniProgJezik.AutoSize = true;
            labelPreporuceniProgJezik.Location = new Point(498, 154);
            labelPreporuceniProgJezik.Name = "labelPreporuceniProgJezik";
            labelPreporuceniProgJezik.Size = new Size(251, 24);
            labelPreporuceniProgJezik.TabIndex = 18;
            labelPreporuceniProgJezik.Text = "Preporučeni programski jezik";
            // 
            // comboBoxGrupni
            // 
            comboBoxGrupni.BackColor = SystemColors.ButtonFace;
            comboBoxGrupni.FormattingEnabled = true;
            comboBoxGrupni.Items.AddRange(new object[] { "Da", "Ne" });
            comboBoxGrupni.Location = new Point(158, 151);
            comboBoxGrupni.Name = "comboBoxGrupni";
            comboBoxGrupni.Size = new Size(321, 32);
            comboBoxGrupni.TabIndex = 17;
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
            // 
            // dateTimePickerDatumPocetka
            // 
            dateTimePickerDatumPocetka.CalendarMonthBackground = SystemColors.ButtonFace;
            dateTimePickerDatumPocetka.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumPocetka.Location = new Point(158, 202);
            dateTimePickerDatumPocetka.Name = "dateTimePickerDatumPocetka";
            dateTimePickerDatumPocetka.Size = new Size(321, 32);
            dateTimePickerDatumPocetka.TabIndex = 11;
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
            // textBoxImeRoditelja
            // 
            textBoxImeRoditelja.BackColor = SystemColors.ButtonFace;
            textBoxImeRoditelja.Location = new Point(158, 95);
            textBoxImeRoditelja.MaxLength = 9;
            textBoxImeRoditelja.Name = "textBoxImeRoditelja";
            textBoxImeRoditelja.Size = new Size(321, 32);
            textBoxImeRoditelja.TabIndex = 2;
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
            // textBoxImeStudenta
            // 
            textBoxImeStudenta.BackColor = SystemColors.ButtonFace;
            textBoxImeStudenta.Location = new Point(158, 42);
            textBoxImeStudenta.MaxLength = 50;
            textBoxImeStudenta.Name = "textBoxImeStudenta";
            textBoxImeStudenta.Size = new Size(321, 32);
            textBoxImeStudenta.TabIndex = 0;
            // 
            // buttonDodajPrakticniProjekat
            // 
            buttonDodajPrakticniProjekat.Location = new Point(410, 439);
            buttonDodajPrakticniProjekat.Name = "buttonDodajPrakticniProjekat";
            buttonDodajPrakticniProjekat.Size = new Size(221, 48);
            buttonDodajPrakticniProjekat.TabIndex = 24;
            buttonDodajPrakticniProjekat.Text = "Dodaj praktični projekat";
            buttonDodajPrakticniProjekat.UseVisualStyleBackColor = true;
            // 
            // listBoxPredmet
            // 
            listBoxPredmet.FormattingEnabled = true;
            listBoxPredmet.ItemHeight = 24;
            listBoxPredmet.Location = new Point(757, 42);
            listBoxPredmet.Name = "listBoxPredmet";
            listBoxPredmet.Size = new Size(213, 100);
            listBoxPredmet.TabIndex = 25;
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
            groupBoxProjekatPodaci.ResumeLayout(false);
            groupBoxProjekatPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBrojIzvestaja).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProjekatPodaci;
        private TextBox textBox1;
        private Label labelPreporuceniProgJezik;
        private ComboBox comboBoxGrupni;
        private Label labelPredmet;
        private DateTimePicker dateTimePickerRokZaZavrsetak;
        private DateTimePicker dateTimePickerDatumPocetka;
        private Label labelRokZaZavrsetak;
        private Label labelDatumPocetka;
        private Label labelGrupni;
        private Label labelSkolskaGodina;
        private TextBox textBoxImeRoditelja;
        private Label labelNazivProjekta;
        private TextBox textBoxImeStudenta;
        private TextBox textBox2;
        private NumericUpDown numericUpDownBrojIzvestaja;
        private Label labelBrojIzvestaja;
        private Label labelKratakOpis;
        private Button buttonDodajPrakticniProjekat;
        private ListBox listBoxPredmet;
    }
}