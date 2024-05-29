namespace SBP_faza2.Forme.RadoviForme
{
    partial class RadoviForm
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
            groupBoxListaRadova = new GroupBox();
            listViewStudenti = new ListView();
            groupBoxRad = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxAutori = new GroupBox();
            button1 = new Button();
            groupBoxListaRadova.SuspendLayout();
            groupBoxRad.SuspendLayout();
            groupBoxAutori.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxListaRadova
            // 
            groupBoxListaRadova.Controls.Add(listViewStudenti);
            groupBoxListaRadova.Location = new Point(13, 10);
            groupBoxListaRadova.Margin = new Padding(4);
            groupBoxListaRadova.Name = "groupBoxListaRadova";
            groupBoxListaRadova.Padding = new Padding(4);
            groupBoxListaRadova.Size = new Size(726, 581);
            groupBoxListaRadova.TabIndex = 4;
            groupBoxListaRadova.TabStop = false;
            groupBoxListaRadova.Text = "Pregled radova";
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
            // groupBoxRad
            // 
            groupBoxRad.Controls.Add(buttonObrisiStudenta);
            groupBoxRad.Controls.Add(buttonAzuriraj);
            groupBoxRad.Controls.Add(buttonDodaj);
            groupBoxRad.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxRad.Location = new Point(747, 10);
            groupBoxRad.Margin = new Padding(4);
            groupBoxRad.Name = "groupBoxRad";
            groupBoxRad.Padding = new Padding(4);
            groupBoxRad.Size = new Size(236, 198);
            groupBoxRad.TabIndex = 5;
            groupBoxRad.TabStop = false;
            groupBoxRad.Text = "Rad";
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
            groupBoxAutori.Location = new Point(747, 227);
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
            button1.Click += button1_Click;
            // 
            // RadoviForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxAutori);
            Controls.Add(groupBoxRad);
            Controls.Add(groupBoxListaRadova);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RadoviForm";
            Text = "RadoviForm";
            groupBoxListaRadova.ResumeLayout(false);
            groupBoxRad.ResumeLayout(false);
            groupBoxAutori.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxListaRadova;
        private ListView listViewStudenti;
        private GroupBox groupBoxRad;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private GroupBox groupBoxAutori;
        private Button button1;
    }
}