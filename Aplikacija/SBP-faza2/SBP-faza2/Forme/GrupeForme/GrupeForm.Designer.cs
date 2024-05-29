namespace SBP_faza2.Forme.GrupeForme
{
    partial class GrupeForm
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
            groupBoxListaGrupa = new GroupBox();
            listViewStudenti = new ListView();
            groupBoxGrupa = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxClanovi = new GroupBox();
            buttonClanoviGrupe = new Button();
            groupBoxIzvestaji = new GroupBox();
            buttonIzvestaji = new Button();
            groupBoxListaGrupa.SuspendLayout();
            groupBoxGrupa.SuspendLayout();
            groupBoxClanovi.SuspendLayout();
            groupBoxIzvestaji.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxListaGrupa
            // 
            groupBoxListaGrupa.Controls.Add(listViewStudenti);
            groupBoxListaGrupa.Location = new Point(13, 10);
            groupBoxListaGrupa.Margin = new Padding(4);
            groupBoxListaGrupa.Name = "groupBoxListaGrupa";
            groupBoxListaGrupa.Padding = new Padding(4);
            groupBoxListaGrupa.Size = new Size(726, 581);
            groupBoxListaGrupa.TabIndex = 4;
            groupBoxListaGrupa.TabStop = false;
            groupBoxListaGrupa.Text = "Pregled grupa";
            // 
            // listViewStudenti
            // 
            listViewStudenti.BackColor = SystemColors.ButtonFace;
            listViewStudenti.Location = new Point(7, 31);
            listViewStudenti.Name = "listViewStudenti";
            listViewStudenti.Size = new Size(712, 543);
            listViewStudenti.TabIndex = 0;
            listViewStudenti.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxGrupa
            // 
            groupBoxGrupa.Controls.Add(buttonObrisiStudenta);
            groupBoxGrupa.Controls.Add(buttonAzuriraj);
            groupBoxGrupa.Controls.Add(buttonDodaj);
            groupBoxGrupa.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxGrupa.Location = new Point(747, 10);
            groupBoxGrupa.Margin = new Padding(4);
            groupBoxGrupa.Name = "groupBoxGrupa";
            groupBoxGrupa.Padding = new Padding(4);
            groupBoxGrupa.Size = new Size(236, 198);
            groupBoxGrupa.TabIndex = 5;
            groupBoxGrupa.TabStop = false;
            groupBoxGrupa.Text = "Grupa";
            // 
            // buttonObrisiStudenta
            // 
            buttonObrisiStudenta.BackColor = SystemColors.ButtonFace;
            buttonObrisiStudenta.Location = new Point(8, 143);
            buttonObrisiStudenta.Margin = new Padding(4);
            buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            buttonObrisiStudenta.Size = new Size(221, 48);
            buttonObrisiStudenta.TabIndex = 2;
            buttonObrisiStudenta.Text = "Obriši";
            buttonObrisiStudenta.UseVisualStyleBackColor = false;
            // 
            // buttonAzuriraj
            // 
            buttonAzuriraj.BackColor = SystemColors.ButtonFace;
            buttonAzuriraj.Location = new Point(8, 88);
            buttonAzuriraj.Margin = new Padding(4);
            buttonAzuriraj.Name = "buttonAzuriraj";
            buttonAzuriraj.Size = new Size(221, 48);
            buttonAzuriraj.TabIndex = 1;
            buttonAzuriraj.Text = "Ažuriraj";
            buttonAzuriraj.UseVisualStyleBackColor = false;
            buttonAzuriraj.Click += buttonAzuriraj_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.BackColor = SystemColors.ButtonFace;
            buttonDodaj.Location = new Point(8, 31);
            buttonDodaj.Margin = new Padding(4);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(221, 48);
            buttonDodaj.TabIndex = 0;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // groupBoxClanovi
            // 
            groupBoxClanovi.Controls.Add(buttonClanoviGrupe);
            groupBoxClanovi.Location = new Point(747, 215);
            groupBoxClanovi.Name = "groupBoxClanovi";
            groupBoxClanovi.Size = new Size(236, 95);
            groupBoxClanovi.TabIndex = 6;
            groupBoxClanovi.TabStop = false;
            groupBoxClanovi.Text = "Članovi";
            // 
            // buttonClanoviGrupe
            // 
            buttonClanoviGrupe.BackColor = SystemColors.ButtonFace;
            buttonClanoviGrupe.Location = new Point(8, 32);
            buttonClanoviGrupe.Margin = new Padding(4);
            buttonClanoviGrupe.Name = "buttonClanoviGrupe";
            buttonClanoviGrupe.Size = new Size(221, 48);
            buttonClanoviGrupe.TabIndex = 3;
            buttonClanoviGrupe.Text = "Članovi grupe";
            buttonClanoviGrupe.UseVisualStyleBackColor = false;
            buttonClanoviGrupe.Click += buttonClanoviGrupe_Click;
            // 
            // groupBoxIzvestaji
            // 
            groupBoxIzvestaji.Controls.Add(buttonIzvestaji);
            groupBoxIzvestaji.Location = new Point(747, 316);
            groupBoxIzvestaji.Name = "groupBoxIzvestaji";
            groupBoxIzvestaji.Size = new Size(236, 95);
            groupBoxIzvestaji.TabIndex = 7;
            groupBoxIzvestaji.TabStop = false;
            groupBoxIzvestaji.Text = "Izveštaji";
            // 
            // buttonIzvestaji
            // 
            buttonIzvestaji.BackColor = SystemColors.ButtonFace;
            buttonIzvestaji.Location = new Point(8, 32);
            buttonIzvestaji.Margin = new Padding(4);
            buttonIzvestaji.Name = "buttonIzvestaji";
            buttonIzvestaji.Size = new Size(221, 48);
            buttonIzvestaji.TabIndex = 3;
            buttonIzvestaji.Text = "Izveštaji";
            buttonIzvestaji.UseVisualStyleBackColor = false;
            buttonIzvestaji.Click += buttonIzvestaji_Click;
            // 
            // GrupeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxIzvestaji);
            Controls.Add(groupBoxClanovi);
            Controls.Add(groupBoxGrupa);
            Controls.Add(groupBoxListaGrupa);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GrupeForm";
            Text = "Grupe";
            groupBoxListaGrupa.ResumeLayout(false);
            groupBoxGrupa.ResumeLayout(false);
            groupBoxClanovi.ResumeLayout(false);
            groupBoxIzvestaji.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxListaGrupa;
        private ListView listViewStudenti;
        private GroupBox groupBoxGrupa;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private GroupBox groupBoxClanovi;
        private Button buttonClanoviGrupe;
        private GroupBox groupBoxIzvestaji;
        private Button buttonIzvestaji;
    }
}