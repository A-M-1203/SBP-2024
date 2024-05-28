namespace SBP_faza2.Forme.ClanciForme
{
    partial class DodajClankeForm
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
            buttonDodajClanak = new Button();
            groupBoxKnjigaPodaci = new GroupBox();
            listBoxAutori = new ListBox();
            labelAutor = new Label();
            textBoxBrojCasopisa = new TextBox();
            textBoxNazivCasopisa = new TextBox();
            labelNazivCasopisa = new Label();
            labelBrojCasopisa = new Label();
            textBoxIssn = new TextBox();
            labelIssn = new Label();
            labelGodinaIzdanja = new Label();
            textBoxImeRoditelja = new TextBox();
            labelNaslovKnjige = new Label();
            textBoxNaslovKnjige = new TextBox();
            groupBoxKnjigaPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDodajClanak
            // 
            buttonDodajClanak.Location = new Point(147, 478);
            buttonDodajClanak.Name = "buttonDodajClanak";
            buttonDodajClanak.Size = new Size(221, 48);
            buttonDodajClanak.TabIndex = 26;
            buttonDodajClanak.Text = "Dodaj članak";
            buttonDodajClanak.UseVisualStyleBackColor = true;
            // 
            // groupBoxKnjigaPodaci
            // 
            groupBoxKnjigaPodaci.Controls.Add(listBoxAutori);
            groupBoxKnjigaPodaci.Controls.Add(labelAutor);
            groupBoxKnjigaPodaci.Controls.Add(textBoxBrojCasopisa);
            groupBoxKnjigaPodaci.Controls.Add(textBoxNazivCasopisa);
            groupBoxKnjigaPodaci.Controls.Add(labelNazivCasopisa);
            groupBoxKnjigaPodaci.Controls.Add(labelBrojCasopisa);
            groupBoxKnjigaPodaci.Controls.Add(textBoxIssn);
            groupBoxKnjigaPodaci.Controls.Add(labelIssn);
            groupBoxKnjigaPodaci.Controls.Add(labelGodinaIzdanja);
            groupBoxKnjigaPodaci.Controls.Add(textBoxImeRoditelja);
            groupBoxKnjigaPodaci.Controls.Add(labelNaslovKnjige);
            groupBoxKnjigaPodaci.Controls.Add(textBoxNaslovKnjige);
            groupBoxKnjigaPodaci.Location = new Point(12, 12);
            groupBoxKnjigaPodaci.Name = "groupBoxKnjigaPodaci";
            groupBoxKnjigaPodaci.Size = new Size(493, 448);
            groupBoxKnjigaPodaci.TabIndex = 27;
            groupBoxKnjigaPodaci.TabStop = false;
            groupBoxKnjigaPodaci.Text = "Podaci o članku";
            // 
            // listBoxAutori
            // 
            listBoxAutori.FormattingEnabled = true;
            listBoxAutori.ItemHeight = 24;
            listBoxAutori.Location = new Point(158, 333);
            listBoxAutori.Name = "listBoxAutori";
            listBoxAutori.SelectionMode = SelectionMode.MultiSimple;
            listBoxAutori.Size = new Size(321, 100);
            listBoxAutori.TabIndex = 27;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.Location = new Point(6, 333);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(63, 24);
            labelAutor.TabIndex = 26;
            labelAutor.Text = "Autori";
            // 
            // textBoxBrojCasopisa
            // 
            textBoxBrojCasopisa.BackColor = SystemColors.ButtonFace;
            textBoxBrojCasopisa.Location = new Point(158, 216);
            textBoxBrojCasopisa.MaxLength = 5;
            textBoxBrojCasopisa.Name = "textBoxBrojCasopisa";
            textBoxBrojCasopisa.Size = new Size(321, 32);
            textBoxBrojCasopisa.TabIndex = 25;
            // 
            // textBoxNazivCasopisa
            // 
            textBoxNazivCasopisa.BackColor = SystemColors.ButtonFace;
            textBoxNazivCasopisa.Location = new Point(158, 154);
            textBoxNazivCasopisa.MaxLength = 50;
            textBoxNazivCasopisa.Name = "textBoxNazivCasopisa";
            textBoxNazivCasopisa.Size = new Size(321, 32);
            textBoxNazivCasopisa.TabIndex = 24;
            // 
            // labelNazivCasopisa
            // 
            labelNazivCasopisa.AutoSize = true;
            labelNazivCasopisa.Location = new Point(6, 157);
            labelNazivCasopisa.Name = "labelNazivCasopisa";
            labelNazivCasopisa.Size = new Size(131, 24);
            labelNazivCasopisa.TabIndex = 23;
            labelNazivCasopisa.Text = "Naziv časopisa";
            // 
            // labelBrojCasopisa
            // 
            labelBrojCasopisa.AutoSize = true;
            labelBrojCasopisa.Location = new Point(6, 219);
            labelBrojCasopisa.Name = "labelBrojCasopisa";
            labelBrojCasopisa.Size = new Size(120, 24);
            labelBrojCasopisa.TabIndex = 22;
            labelBrojCasopisa.Text = "Broj časopisa";
            // 
            // textBoxIssn
            // 
            textBoxIssn.BackColor = SystemColors.ButtonFace;
            textBoxIssn.Location = new Point(158, 273);
            textBoxIssn.MaxLength = 9;
            textBoxIssn.Name = "textBoxIssn";
            textBoxIssn.Size = new Size(321, 32);
            textBoxIssn.TabIndex = 21;
            // 
            // labelIssn
            // 
            labelIssn.AutoSize = true;
            labelIssn.Location = new Point(6, 276);
            labelIssn.Name = "labelIssn";
            labelIssn.Size = new Size(46, 24);
            labelIssn.TabIndex = 20;
            labelIssn.Text = "ISSN";
            // 
            // labelGodinaIzdanja
            // 
            labelGodinaIzdanja.AutoSize = true;
            labelGodinaIzdanja.Location = new Point(6, 98);
            labelGodinaIzdanja.Name = "labelGodinaIzdanja";
            labelGodinaIzdanja.Size = new Size(136, 24);
            labelGodinaIzdanja.TabIndex = 3;
            labelGodinaIzdanja.Text = "Godina izdanja";
            // 
            // textBoxImeRoditelja
            // 
            textBoxImeRoditelja.BackColor = SystemColors.ButtonFace;
            textBoxImeRoditelja.Location = new Point(158, 95);
            textBoxImeRoditelja.MaxLength = 4;
            textBoxImeRoditelja.Name = "textBoxImeRoditelja";
            textBoxImeRoditelja.Size = new Size(321, 32);
            textBoxImeRoditelja.TabIndex = 2;
            // 
            // labelNaslovKnjige
            // 
            labelNaslovKnjige.AutoSize = true;
            labelNaslovKnjige.Location = new Point(6, 45);
            labelNaslovKnjige.Name = "labelNaslovKnjige";
            labelNaslovKnjige.Size = new Size(66, 24);
            labelNaslovKnjige.TabIndex = 1;
            labelNaslovKnjige.Text = "Naslov";
            // 
            // textBoxNaslovKnjige
            // 
            textBoxNaslovKnjige.BackColor = SystemColors.ButtonFace;
            textBoxNaslovKnjige.Location = new Point(158, 42);
            textBoxNaslovKnjige.MaxLength = 50;
            textBoxNaslovKnjige.Name = "textBoxNaslovKnjige";
            textBoxNaslovKnjige.Size = new Size(321, 32);
            textBoxNaslovKnjige.TabIndex = 0;
            // 
            // DodajClankeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(518, 549);
            Controls.Add(groupBoxKnjigaPodaci);
            Controls.Add(buttonDodajClanak);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajClankeForm";
            Text = "Dodaj članak";
            groupBoxKnjigaPodaci.ResumeLayout(false);
            groupBoxKnjigaPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDodajClanak;
        private GroupBox groupBoxKnjigaPodaci;
        private ListBox listBoxAutori;
        private Label labelAutor;
        private TextBox textBoxBrojCasopisa;
        private TextBox textBoxNazivCasopisa;
        private Label labelNazivCasopisa;
        private Label labelBrojCasopisa;
        private TextBox textBoxIssn;
        private Label labelIssn;
        private Label labelGodinaIzdanja;
        private TextBox textBoxImeRoditelja;
        private Label labelNaslovKnjige;
        private TextBox textBoxNaslovKnjige;
    }
}