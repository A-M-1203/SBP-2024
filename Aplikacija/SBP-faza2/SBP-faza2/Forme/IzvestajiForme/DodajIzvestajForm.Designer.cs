namespace SBP_faza2.Forme.IzvestajiForme
{
    partial class DodajIzvestajForm
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
            groupBoxIzvestajPodaci = new GroupBox();
            labelVremeZavrsetka = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelOpis = new Label();
            textBoxOpis = new TextBox();
            labelStudent = new Label();
            labelGrupa = new Label();
            labelProjekat = new Label();
            listBoxStudent = new ListBox();
            listBoxGrupa = new ListBox();
            listBoxProjekat = new ListBox();
            buttonDodajIzvestaj = new Button();
            groupBoxIzvestajPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIzvestajPodaci
            // 
            groupBoxIzvestajPodaci.Controls.Add(listBoxProjekat);
            groupBoxIzvestajPodaci.Controls.Add(listBoxGrupa);
            groupBoxIzvestajPodaci.Controls.Add(listBoxStudent);
            groupBoxIzvestajPodaci.Controls.Add(labelProjekat);
            groupBoxIzvestajPodaci.Controls.Add(labelGrupa);
            groupBoxIzvestajPodaci.Controls.Add(labelStudent);
            groupBoxIzvestajPodaci.Controls.Add(textBoxOpis);
            groupBoxIzvestajPodaci.Controls.Add(labelOpis);
            groupBoxIzvestajPodaci.Controls.Add(dateTimePicker1);
            groupBoxIzvestajPodaci.Controls.Add(labelVremeZavrsetka);
            groupBoxIzvestajPodaci.Location = new Point(12, 12);
            groupBoxIzvestajPodaci.Name = "groupBoxIzvestajPodaci";
            groupBoxIzvestajPodaci.Size = new Size(488, 658);
            groupBoxIzvestajPodaci.TabIndex = 0;
            groupBoxIzvestajPodaci.TabStop = false;
            groupBoxIzvestajPodaci.Text = "Podaci o izveštaju";
            // 
            // labelVremeZavrsetka
            // 
            labelVremeZavrsetka.AutoSize = true;
            labelVremeZavrsetka.Location = new Point(16, 41);
            labelVremeZavrsetka.Name = "labelVremeZavrsetka";
            labelVremeZavrsetka.Size = new Size(147, 24);
            labelVremeZavrsetka.TabIndex = 0;
            labelVremeZavrsetka.Text = "Vreme završetka";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(169, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 32);
            dateTimePicker1.TabIndex = 1;
            // 
            // labelOpis
            // 
            labelOpis.AutoSize = true;
            labelOpis.Location = new Point(16, 103);
            labelOpis.Name = "labelOpis";
            labelOpis.Size = new Size(47, 24);
            labelOpis.TabIndex = 2;
            labelOpis.Text = "Opis";
            // 
            // textBoxOpis
            // 
            textBoxOpis.Location = new Point(169, 103);
            textBoxOpis.MaxLength = 300;
            textBoxOpis.Multiline = true;
            textBoxOpis.Name = "textBoxOpis";
            textBoxOpis.Size = new Size(306, 133);
            textBoxOpis.TabIndex = 3;
            // 
            // labelStudent
            // 
            labelStudent.AutoSize = true;
            labelStudent.Location = new Point(16, 271);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(76, 24);
            labelStudent.TabIndex = 4;
            labelStudent.Text = "Student";
            // 
            // labelGrupa
            // 
            labelGrupa.AutoSize = true;
            labelGrupa.Location = new Point(16, 408);
            labelGrupa.Name = "labelGrupa";
            labelGrupa.Size = new Size(62, 24);
            labelGrupa.TabIndex = 5;
            labelGrupa.Text = "Grupa";
            // 
            // labelProjekat
            // 
            labelProjekat.AutoSize = true;
            labelProjekat.Location = new Point(16, 542);
            labelProjekat.Name = "labelProjekat";
            labelProjekat.Size = new Size(79, 24);
            labelProjekat.TabIndex = 6;
            labelProjekat.Text = "Projekat";
            // 
            // listBoxStudent
            // 
            listBoxStudent.FormattingEnabled = true;
            listBoxStudent.ItemHeight = 24;
            listBoxStudent.Location = new Point(169, 269);
            listBoxStudent.Name = "listBoxStudent";
            listBoxStudent.Size = new Size(306, 100);
            listBoxStudent.TabIndex = 7;
            // 
            // listBoxGrupa
            // 
            listBoxGrupa.FormattingEnabled = true;
            listBoxGrupa.ItemHeight = 24;
            listBoxGrupa.Location = new Point(169, 408);
            listBoxGrupa.Name = "listBoxGrupa";
            listBoxGrupa.Size = new Size(306, 100);
            listBoxGrupa.TabIndex = 8;
            // 
            // listBoxProjekat
            // 
            listBoxProjekat.FormattingEnabled = true;
            listBoxProjekat.ItemHeight = 24;
            listBoxProjekat.Location = new Point(169, 542);
            listBoxProjekat.Name = "listBoxProjekat";
            listBoxProjekat.Size = new Size(306, 100);
            listBoxProjekat.TabIndex = 9;
            // 
            // buttonDodajIzvestaj
            // 
            buttonDodajIzvestaj.Location = new Point(147, 688);
            buttonDodajIzvestaj.Name = "buttonDodajIzvestaj";
            buttonDodajIzvestaj.Size = new Size(221, 48);
            buttonDodajIzvestaj.TabIndex = 27;
            buttonDodajIzvestaj.Text = "Dodaj izveštaj";
            buttonDodajIzvestaj.UseVisualStyleBackColor = true;
            // 
            // DodajIzvestajForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(512, 752);
            Controls.Add(buttonDodajIzvestaj);
            Controls.Add(groupBoxIzvestajPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajIzvestajForm";
            Text = "Dodaj izveštaj";
            groupBoxIzvestajPodaci.ResumeLayout(false);
            groupBoxIzvestajPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIzvestajPodaci;
        private TextBox textBoxOpis;
        private Label labelOpis;
        private DateTimePicker dateTimePicker1;
        private Label labelVremeZavrsetka;
        private ListBox listBoxProjekat;
        private ListBox listBoxGrupa;
        private ListBox listBoxStudent;
        private Label labelProjekat;
        private Label labelGrupa;
        private Label labelStudent;
        private Button buttonDodajIzvestaj;
    }
}