namespace SBP_faza2.Forme
{
    partial class KnjigeForm
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
            groupBoxListaKnjiga = new GroupBox();
            listViewStudenti = new ListView();
            groupBoxKnjiga = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxAutori = new GroupBox();
            buttonAutori = new Button();
            groupBoxListaKnjiga.SuspendLayout();
            groupBoxKnjiga.SuspendLayout();
            groupBoxAutori.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxListaKnjiga
            // 
            groupBoxListaKnjiga.Controls.Add(listViewStudenti);
            groupBoxListaKnjiga.Location = new Point(13, 10);
            groupBoxListaKnjiga.Margin = new Padding(4);
            groupBoxListaKnjiga.Name = "groupBoxListaKnjiga";
            groupBoxListaKnjiga.Padding = new Padding(4);
            groupBoxListaKnjiga.Size = new Size(726, 581);
            groupBoxListaKnjiga.TabIndex = 3;
            groupBoxListaKnjiga.TabStop = false;
            groupBoxListaKnjiga.Text = "Pregled knjiga";
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
            // groupBoxKnjiga
            // 
            groupBoxKnjiga.Controls.Add(buttonObrisiStudenta);
            groupBoxKnjiga.Controls.Add(buttonAzuriraj);
            groupBoxKnjiga.Controls.Add(buttonDodaj);
            groupBoxKnjiga.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxKnjiga.Location = new Point(747, 10);
            groupBoxKnjiga.Margin = new Padding(4);
            groupBoxKnjiga.Name = "groupBoxKnjiga";
            groupBoxKnjiga.Padding = new Padding(4);
            groupBoxKnjiga.Size = new Size(236, 198);
            groupBoxKnjiga.TabIndex = 4;
            groupBoxKnjiga.TabStop = false;
            groupBoxKnjiga.Text = "Knjiga";
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
            // groupBoxAutori
            // 
            groupBoxAutori.Controls.Add(buttonAutori);
            groupBoxAutori.Location = new Point(747, 226);
            groupBoxAutori.Name = "groupBoxAutori";
            groupBoxAutori.Size = new Size(236, 94);
            groupBoxAutori.TabIndex = 10;
            groupBoxAutori.TabStop = false;
            groupBoxAutori.Text = "Autori";
            // 
            // buttonAutori
            // 
            buttonAutori.BackColor = SystemColors.ButtonFace;
            buttonAutori.Location = new Point(9, 28);
            buttonAutori.Name = "buttonAutori";
            buttonAutori.Size = new Size(221, 48);
            buttonAutori.TabIndex = 1;
            buttonAutori.Text = "Autori";
            buttonAutori.UseVisualStyleBackColor = false;
            buttonAutori.Click += buttonAutori_Click;
            // 
            // KnjigeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxAutori);
            Controls.Add(groupBoxKnjiga);
            Controls.Add(groupBoxListaKnjiga);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KnjigeForm";
            Text = "Knjige";
            groupBoxListaKnjiga.ResumeLayout(false);
            groupBoxKnjiga.ResumeLayout(false);
            groupBoxAutori.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxListaKnjiga;
        private ListView listViewStudenti;
        private GroupBox groupBoxKnjiga;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private GroupBox groupBoxAutori;
        private Button buttonAutori;
    }
}