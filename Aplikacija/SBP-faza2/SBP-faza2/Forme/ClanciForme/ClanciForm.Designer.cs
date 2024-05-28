namespace SBP_faza2.Forme.ClanciForme
{
    partial class ClanciForm
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
            groupBoxListaClanaka = new GroupBox();
            listViewStudenti = new ListView();
            groupBoxKnjiga = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxAutori = new GroupBox();
            button1 = new Button();
            groupBoxListaClanaka.SuspendLayout();
            groupBoxKnjiga.SuspendLayout();
            groupBoxAutori.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxListaClanaka
            // 
            groupBoxListaClanaka.Controls.Add(listViewStudenti);
            groupBoxListaClanaka.Location = new Point(13, 13);
            groupBoxListaClanaka.Margin = new Padding(4);
            groupBoxListaClanaka.Name = "groupBoxListaClanaka";
            groupBoxListaClanaka.Padding = new Padding(4);
            groupBoxListaClanaka.Size = new Size(726, 581);
            groupBoxListaClanaka.TabIndex = 4;
            groupBoxListaClanaka.TabStop = false;
            groupBoxListaClanaka.Text = "Pregled članaka";
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
            groupBoxKnjiga.Location = new Point(751, 13);
            groupBoxKnjiga.Margin = new Padding(4);
            groupBoxKnjiga.Name = "groupBoxKnjiga";
            groupBoxKnjiga.Padding = new Padding(4);
            groupBoxKnjiga.Size = new Size(236, 198);
            groupBoxKnjiga.TabIndex = 5;
            groupBoxKnjiga.TabStop = false;
            groupBoxKnjiga.Text = "Članak";
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
            groupBoxAutori.Controls.Add(button1);
            groupBoxAutori.Location = new Point(751, 232);
            groupBoxAutori.Name = "groupBoxAutori";
            groupBoxAutori.Size = new Size(236, 94);
            groupBoxAutori.TabIndex = 11;
            groupBoxAutori.TabStop = false;
            groupBoxAutori.Text = "Autori";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(9, 28);
            button1.Name = "button1";
            button1.Size = new Size(221, 48);
            button1.TabIndex = 1;
            button1.Text = "Autori";
            button1.UseVisualStyleBackColor = false;
            // 
            // ClanciForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1000, 606);
            Controls.Add(groupBoxAutori);
            Controls.Add(groupBoxKnjiga);
            Controls.Add(groupBoxListaClanaka);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClanciForm";
            Text = "Članci";
            groupBoxListaClanaka.ResumeLayout(false);
            groupBoxKnjiga.ResumeLayout(false);
            groupBoxAutori.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxListaClanaka;
        private ListView listViewStudenti;
        private GroupBox groupBoxKnjiga;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private GroupBox groupBoxAutori;
        private Button button1;
    }
}