namespace SBP_faza2.Forme.AutoriForme
{
    partial class AutoriForm
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
            groupBoxListaAutora = new GroupBox();
            listViewStudenti = new ListView();
            groupBoxAutor = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBoxListaAutora.SuspendLayout();
            groupBoxAutor.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxListaAutora
            // 
            groupBoxListaAutora.Controls.Add(listViewStudenti);
            groupBoxListaAutora.Location = new Point(13, 12);
            groupBoxListaAutora.Margin = new Padding(4);
            groupBoxListaAutora.Name = "groupBoxListaAutora";
            groupBoxListaAutora.Padding = new Padding(4);
            groupBoxListaAutora.Size = new Size(726, 581);
            groupBoxListaAutora.TabIndex = 5;
            groupBoxListaAutora.TabStop = false;
            groupBoxListaAutora.Text = "Pregled autora";
            // 
            // listViewStudenti
            // 
            listViewStudenti.BackColor = SystemColors.ButtonFace;
            listViewStudenti.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewStudenti.Location = new Point(7, 31);
            listViewStudenti.Name = "listViewStudenti";
            listViewStudenti.Size = new Size(712, 543);
            listViewStudenti.TabIndex = 0;
            listViewStudenti.UseCompatibleStateImageBehavior = false;
            listViewStudenti.View = View.Details;
            // 
            // groupBoxAutor
            // 
            groupBoxAutor.Controls.Add(buttonObrisiStudenta);
            groupBoxAutor.Controls.Add(buttonAzuriraj);
            groupBoxAutor.Controls.Add(buttonDodaj);
            groupBoxAutor.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxAutor.Location = new Point(751, 12);
            groupBoxAutor.Margin = new Padding(4);
            groupBoxAutor.Name = "groupBoxAutor";
            groupBoxAutor.Padding = new Padding(4);
            groupBoxAutor.Size = new Size(236, 198);
            groupBoxAutor.TabIndex = 6;
            groupBoxAutor.TabStop = false;
            groupBoxAutor.Text = "Autor";
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
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.Width = 200;
            // 
            // AutoriForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1000, 606);
            Controls.Add(groupBoxAutor);
            Controls.Add(groupBoxListaAutora);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutoriForm";
            Text = "Autori";
            Load += AutoriForm_Load;
            groupBoxListaAutora.ResumeLayout(false);
            groupBoxAutor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxListaAutora;
        private ListView listViewStudenti;
        private GroupBox groupBoxAutor;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}