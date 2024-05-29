namespace SBP_faza2.Forme.IzvestajiForme
{
    partial class IzvestajiForm
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
            groupBoxListaIzvestaja = new GroupBox();
            listViewStudenti = new ListView();
            groupBoxIzvestaj = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxListaIzvestaja.SuspendLayout();
            groupBoxIzvestaj.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxListaIzvestaja
            // 
            groupBoxListaIzvestaja.Controls.Add(listViewStudenti);
            groupBoxListaIzvestaja.Location = new Point(13, 13);
            groupBoxListaIzvestaja.Margin = new Padding(4);
            groupBoxListaIzvestaja.Name = "groupBoxListaIzvestaja";
            groupBoxListaIzvestaja.Padding = new Padding(4);
            groupBoxListaIzvestaja.Size = new Size(726, 581);
            groupBoxListaIzvestaja.TabIndex = 5;
            groupBoxListaIzvestaja.TabStop = false;
            groupBoxListaIzvestaja.Text = "Pregled izveštaja";
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
            // groupBoxIzvestaj
            // 
            groupBoxIzvestaj.Controls.Add(buttonObrisiStudenta);
            groupBoxIzvestaj.Controls.Add(buttonAzuriraj);
            groupBoxIzvestaj.Controls.Add(buttonDodaj);
            groupBoxIzvestaj.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxIzvestaj.Location = new Point(747, 13);
            groupBoxIzvestaj.Margin = new Padding(4);
            groupBoxIzvestaj.Name = "groupBoxIzvestaj";
            groupBoxIzvestaj.Padding = new Padding(4);
            groupBoxIzvestaj.Size = new Size(236, 198);
            groupBoxIzvestaj.TabIndex = 6;
            groupBoxIzvestaj.TabStop = false;
            groupBoxIzvestaj.Text = "Izveštaj";
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
            // IzvestajiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxIzvestaj);
            Controls.Add(groupBoxListaIzvestaja);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzvestajiForm";
            Text = "Izvestaji";
            groupBoxListaIzvestaja.ResumeLayout(false);
            groupBoxIzvestaj.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxListaIzvestaja;
        private ListView listViewStudenti;
        private GroupBox groupBoxIzvestaj;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
    }
}