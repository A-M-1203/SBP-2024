namespace SBP_faza2.Forme
{
    partial class StudentiForm
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
            groupBoxStudent = new GroupBox();
            buttonObrisiStudenta = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxListaStudenata = new GroupBox();
            listViewStudenti = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBoxProjekti = new GroupBox();
            buttonTeorijskiProjekti = new Button();
            buttonPrakticniProjekti = new Button();
            groupBoxGrupe = new GroupBox();
            buttonGrupe = new Button();
            groupBoxStudent.SuspendLayout();
            groupBoxListaStudenata.SuspendLayout();
            groupBoxProjekti.SuspendLayout();
            groupBoxGrupe.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStudent
            // 
            groupBoxStudent.Controls.Add(buttonObrisiStudenta);
            groupBoxStudent.Controls.Add(buttonAzuriraj);
            groupBoxStudent.Controls.Add(buttonDodaj);
            groupBoxStudent.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxStudent.Location = new Point(749, 14);
            groupBoxStudent.Margin = new Padding(4);
            groupBoxStudent.Name = "groupBoxStudent";
            groupBoxStudent.Padding = new Padding(4);
            groupBoxStudent.Size = new Size(236, 198);
            groupBoxStudent.TabIndex = 1;
            groupBoxStudent.TabStop = false;
            groupBoxStudent.Text = "Student";
            // 
            // buttonObrisiStudenta
            // 
            buttonObrisiStudenta.BackColor = SystemColors.ButtonFace;
            buttonObrisiStudenta.Enabled = false;
            buttonObrisiStudenta.Location = new Point(8, 143);
            buttonObrisiStudenta.Margin = new Padding(4);
            buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            buttonObrisiStudenta.Size = new Size(221, 48);
            buttonObrisiStudenta.TabIndex = 2;
            buttonObrisiStudenta.Text = "Obriši";
            buttonObrisiStudenta.UseVisualStyleBackColor = false;
            buttonObrisiStudenta.Click += buttonObrisiStudenta_Click;
            // 
            // buttonAzuriraj
            // 
            buttonAzuriraj.BackColor = SystemColors.ButtonFace;
            buttonAzuriraj.Enabled = false;
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
            // groupBoxListaStudenata
            // 
            groupBoxListaStudenata.Controls.Add(listViewStudenti);
            groupBoxListaStudenata.Location = new Point(15, 14);
            groupBoxListaStudenata.Margin = new Padding(4);
            groupBoxListaStudenata.Name = "groupBoxListaStudenata";
            groupBoxListaStudenata.Padding = new Padding(4);
            groupBoxListaStudenata.Size = new Size(726, 581);
            groupBoxListaStudenata.TabIndex = 2;
            groupBoxListaStudenata.TabStop = false;
            groupBoxListaStudenata.Text = "Lista studenata";
            // 
            // listViewStudenti
            // 
            listViewStudenti.BackColor = SystemColors.ButtonFace;
            listViewStudenti.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewStudenti.FullRowSelect = true;
            listViewStudenti.GridLines = true;
            listViewStudenti.Location = new Point(7, 31);
            listViewStudenti.MultiSelect = false;
            listViewStudenti.Name = "listViewStudenti";
            listViewStudenti.Size = new Size(712, 543);
            listViewStudenti.TabIndex = 0;
            listViewStudenti.UseCompatibleStateImageBehavior = false;
            listViewStudenti.View = View.Details;
            listViewStudenti.SelectedIndexChanged += listViewStudenti_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ime roditelja";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prezime";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Broj indeksa";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Smer";
            columnHeader6.Width = 130;
            // 
            // groupBoxProjekti
            // 
            groupBoxProjekti.Controls.Add(buttonTeorijskiProjekti);
            groupBoxProjekti.Controls.Add(buttonPrakticniProjekti);
            groupBoxProjekti.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxProjekti.Location = new Point(749, 220);
            groupBoxProjekti.Margin = new Padding(4);
            groupBoxProjekti.Name = "groupBoxProjekti";
            groupBoxProjekti.Padding = new Padding(4);
            groupBoxProjekti.Size = new Size(236, 168);
            groupBoxProjekti.TabIndex = 3;
            groupBoxProjekti.TabStop = false;
            groupBoxProjekti.Text = "Projekti";
            // 
            // buttonTeorijskiProjekti
            // 
            buttonTeorijskiProjekti.BackColor = SystemColors.ButtonFace;
            buttonTeorijskiProjekti.Location = new Point(9, 104);
            buttonTeorijskiProjekti.Margin = new Padding(4);
            buttonTeorijskiProjekti.Name = "buttonTeorijskiProjekti";
            buttonTeorijskiProjekti.Size = new Size(221, 48);
            buttonTeorijskiProjekti.TabIndex = 1;
            buttonTeorijskiProjekti.Text = "Teorijski projekti";
            buttonTeorijskiProjekti.UseVisualStyleBackColor = false;
            buttonTeorijskiProjekti.Click += buttonTeorijskiProjekti_Click;
            // 
            // buttonPrakticniProjekti
            // 
            buttonPrakticniProjekti.BackColor = SystemColors.ButtonFace;
            buttonPrakticniProjekti.Location = new Point(9, 33);
            buttonPrakticniProjekti.Margin = new Padding(4);
            buttonPrakticniProjekti.Name = "buttonPrakticniProjekti";
            buttonPrakticniProjekti.Size = new Size(221, 48);
            buttonPrakticniProjekti.TabIndex = 0;
            buttonPrakticniProjekti.Text = "Praktični projekti";
            buttonPrakticniProjekti.UseVisualStyleBackColor = false;
            buttonPrakticniProjekti.Click += buttonPrakticniProjekti_Click;
            // 
            // groupBoxGrupe
            // 
            groupBoxGrupe.Controls.Add(buttonGrupe);
            groupBoxGrupe.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxGrupe.Location = new Point(749, 396);
            groupBoxGrupe.Margin = new Padding(4);
            groupBoxGrupe.Name = "groupBoxGrupe";
            groupBoxGrupe.Padding = new Padding(4);
            groupBoxGrupe.Size = new Size(236, 94);
            groupBoxGrupe.TabIndex = 4;
            groupBoxGrupe.TabStop = false;
            groupBoxGrupe.Text = "Grupe";
            // 
            // buttonGrupe
            // 
            buttonGrupe.BackColor = SystemColors.ButtonFace;
            buttonGrupe.Location = new Point(8, 31);
            buttonGrupe.Margin = new Padding(4);
            buttonGrupe.Name = "buttonGrupe";
            buttonGrupe.Size = new Size(221, 48);
            buttonGrupe.TabIndex = 0;
            buttonGrupe.Text = "Grupe";
            buttonGrupe.UseVisualStyleBackColor = false;
            buttonGrupe.Click += buttonGrupe_Click;
            // 
            // StudentiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxGrupe);
            Controls.Add(groupBoxProjekti);
            Controls.Add(groupBoxListaStudenata);
            Controls.Add(groupBoxStudent);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentiForm";
            Text = "Studenti";
            Activated += StudentiForm_Activated;
            Load += StudentiForm_Load;
            groupBoxStudent.ResumeLayout(false);
            groupBoxListaStudenata.ResumeLayout(false);
            groupBoxProjekti.ResumeLayout(false);
            groupBoxGrupe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxStudent;
        private GroupBox groupBoxListaStudenata;
        private GroupBox groupBoxProjekti;
        private GroupBox groupBoxGrupe;
        private Button buttonObrisiStudenta;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private Button buttonPrakticniProjekti;
        private Button buttonTeorijskiProjekti;
        private Button buttonGrupe;
        private ListView listViewStudenti;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}