namespace SBP_faza2.Forme.GrupeForme
{
    partial class DodajGrupuForm
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
            groupBoxGrupaPodaci = new GroupBox();
            labelNazivGrupe = new Label();
            textBoxNazivGrupe = new TextBox();
            label1 = new Label();
            listBoxProjekat = new ListBox();
            labelClanovi = new Label();
            listBoxClanovi = new ListBox();
            label2 = new Label();
            listBoxIzvestaji = new ListBox();
            buttonDodajGrupu = new Button();
            groupBoxGrupaPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGrupaPodaci
            // 
            groupBoxGrupaPodaci.Controls.Add(listBoxIzvestaji);
            groupBoxGrupaPodaci.Controls.Add(label2);
            groupBoxGrupaPodaci.Controls.Add(listBoxClanovi);
            groupBoxGrupaPodaci.Controls.Add(labelClanovi);
            groupBoxGrupaPodaci.Controls.Add(listBoxProjekat);
            groupBoxGrupaPodaci.Controls.Add(label1);
            groupBoxGrupaPodaci.Controls.Add(textBoxNazivGrupe);
            groupBoxGrupaPodaci.Controls.Add(labelNazivGrupe);
            groupBoxGrupaPodaci.Location = new Point(12, 12);
            groupBoxGrupaPodaci.Name = "groupBoxGrupaPodaci";
            groupBoxGrupaPodaci.Size = new Size(412, 480);
            groupBoxGrupaPodaci.TabIndex = 0;
            groupBoxGrupaPodaci.TabStop = false;
            groupBoxGrupaPodaci.Text = "Podaci o grupi";
            // 
            // labelNazivGrupe
            // 
            labelNazivGrupe.AutoSize = true;
            labelNazivGrupe.Location = new Point(15, 51);
            labelNazivGrupe.Name = "labelNazivGrupe";
            labelNazivGrupe.Size = new Size(55, 24);
            labelNazivGrupe.TabIndex = 0;
            labelNazivGrupe.Text = "Naziv";
            // 
            // textBoxNazivGrupe
            // 
            textBoxNazivGrupe.Location = new Point(127, 48);
            textBoxNazivGrupe.MaxLength = 50;
            textBoxNazivGrupe.Name = "textBoxNazivGrupe";
            textBoxNazivGrupe.Size = new Size(267, 32);
            textBoxNazivGrupe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 107);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 2;
            label1.Text = "Projekat";
            // 
            // listBoxProjekat
            // 
            listBoxProjekat.FormattingEnabled = true;
            listBoxProjekat.ItemHeight = 24;
            listBoxProjekat.Location = new Point(127, 107);
            listBoxProjekat.Name = "listBoxProjekat";
            listBoxProjekat.Size = new Size(267, 100);
            listBoxProjekat.TabIndex = 3;
            // 
            // labelClanovi
            // 
            labelClanovi.AutoSize = true;
            labelClanovi.Location = new Point(15, 237);
            labelClanovi.Name = "labelClanovi";
            labelClanovi.Size = new Size(72, 24);
            labelClanovi.TabIndex = 4;
            labelClanovi.Text = "Članovi";
            // 
            // listBoxClanovi
            // 
            listBoxClanovi.FormattingEnabled = true;
            listBoxClanovi.ItemHeight = 24;
            listBoxClanovi.Location = new Point(127, 237);
            listBoxClanovi.Name = "listBoxClanovi";
            listBoxClanovi.SelectionMode = SelectionMode.MultiSimple;
            listBoxClanovi.Size = new Size(267, 100);
            listBoxClanovi.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 364);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 6;
            label2.Text = "Izveštaji";
            // 
            // listBoxIzvestaji
            // 
            listBoxIzvestaji.FormattingEnabled = true;
            listBoxIzvestaji.ItemHeight = 24;
            listBoxIzvestaji.Location = new Point(127, 364);
            listBoxIzvestaji.Name = "listBoxIzvestaji";
            listBoxIzvestaji.SelectionMode = SelectionMode.MultiSimple;
            listBoxIzvestaji.Size = new Size(267, 100);
            listBoxIzvestaji.TabIndex = 7;
            // 
            // buttonDodajGrupu
            // 
            buttonDodajGrupu.Location = new Point(111, 512);
            buttonDodajGrupu.Name = "buttonDodajGrupu";
            buttonDodajGrupu.Size = new Size(221, 48);
            buttonDodajGrupu.TabIndex = 26;
            buttonDodajGrupu.Text = "Dodaj grupu";
            buttonDodajGrupu.UseVisualStyleBackColor = true;
            // 
            // DodajGrupuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(437, 579);
            Controls.Add(buttonDodajGrupu);
            Controls.Add(groupBoxGrupaPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajGrupuForm";
            Text = "Dodaj grupu";
            groupBoxGrupaPodaci.ResumeLayout(false);
            groupBoxGrupaPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGrupaPodaci;
        private Label labelClanovi;
        private ListBox listBoxProjekat;
        private Label label1;
        private TextBox textBoxNazivGrupe;
        private Label labelNazivGrupe;
        private ListBox listBoxClanovi;
        private ListBox listBoxIzvestaji;
        private Label label2;
        private Button buttonDodajGrupu;
    }
}