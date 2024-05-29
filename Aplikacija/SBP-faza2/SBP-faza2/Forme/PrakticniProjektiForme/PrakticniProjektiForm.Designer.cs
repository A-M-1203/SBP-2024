namespace SBP_faza2.Forme
{
    partial class PrakticniProjektiForm
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
            groupBoxPrakticniProjekti = new GroupBox();
            listViewPrakticniProjekti = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBoxIzvestaji = new GroupBox();
            buttonIzvestaji = new Button();
            groupBoxPreporuceneStranice = new GroupBox();
            buttonPreporuceneStranice = new Button();
            groupBoxPrakticniProjekat = new GroupBox();
            buttonObrisi = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxPrakticniProjekti.SuspendLayout();
            groupBoxIzvestaji.SuspendLayout();
            groupBoxPreporuceneStranice.SuspendLayout();
            groupBoxPrakticniProjekat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPrakticniProjekti
            // 
            groupBoxPrakticniProjekti.Controls.Add(listViewPrakticniProjekti);
            groupBoxPrakticniProjekti.Location = new Point(12, 12);
            groupBoxPrakticniProjekti.Name = "groupBoxPrakticniProjekti";
            groupBoxPrakticniProjekti.Size = new Size(726, 580);
            groupBoxPrakticniProjekti.TabIndex = 0;
            groupBoxPrakticniProjekti.TabStop = false;
            groupBoxPrakticniProjekti.Text = "Lista praktičnih projekata";
            // 
            // listViewPrakticniProjekti
            // 
            listViewPrakticniProjekti.BackColor = SystemColors.ButtonFace;
            listViewPrakticniProjekti.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listViewPrakticniProjekti.Location = new Point(8, 31);
            listViewPrakticniProjekti.Name = "listViewPrakticniProjekti";
            listViewPrakticniProjekti.Size = new Size(712, 543);
            listViewPrakticniProjekti.TabIndex = 0;
            listViewPrakticniProjekti.UseCompatibleStateImageBehavior = false;
            listViewPrakticniProjekti.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Školska godina";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Grupni";
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Početak";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Završetak";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Rok";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Programski jezik";
            columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Opis";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Broj izveštaja";
            columnHeader10.Width = 130;
            // 
            // groupBoxIzvestaji
            // 
            groupBoxIzvestaji.Controls.Add(buttonIzvestaji);
            groupBoxIzvestaji.Location = new Point(744, 216);
            groupBoxIzvestaji.Name = "groupBoxIzvestaji";
            groupBoxIzvestaji.Size = new Size(236, 94);
            groupBoxIzvestaji.TabIndex = 1;
            groupBoxIzvestaji.TabStop = false;
            groupBoxIzvestaji.Text = "Izveštaji";
            // 
            // buttonIzvestaji
            // 
            buttonIzvestaji.BackColor = SystemColors.ButtonFace;
            buttonIzvestaji.Location = new Point(8, 31);
            buttonIzvestaji.Name = "buttonIzvestaji";
            buttonIzvestaji.Size = new Size(221, 48);
            buttonIzvestaji.TabIndex = 1;
            buttonIzvestaji.Text = "Izveštaji za projekat";
            buttonIzvestaji.UseVisualStyleBackColor = false;
            buttonIzvestaji.Click += buttonIzvestaji_Click;
            // 
            // groupBoxPreporuceneStranice
            // 
            groupBoxPreporuceneStranice.Controls.Add(buttonPreporuceneStranice);
            groupBoxPreporuceneStranice.Location = new Point(744, 316);
            groupBoxPreporuceneStranice.Name = "groupBoxPreporuceneStranice";
            groupBoxPreporuceneStranice.Size = new Size(236, 94);
            groupBoxPreporuceneStranice.TabIndex = 2;
            groupBoxPreporuceneStranice.TabStop = false;
            groupBoxPreporuceneStranice.Text = "Preporučene stranice";
            // 
            // buttonPreporuceneStranice
            // 
            buttonPreporuceneStranice.BackColor = SystemColors.ButtonFace;
            buttonPreporuceneStranice.Location = new Point(9, 31);
            buttonPreporuceneStranice.Name = "buttonPreporuceneStranice";
            buttonPreporuceneStranice.Size = new Size(221, 48);
            buttonPreporuceneStranice.TabIndex = 2;
            buttonPreporuceneStranice.Text = "Preporučene stranice";
            buttonPreporuceneStranice.UseVisualStyleBackColor = false;
            // 
            // groupBoxPrakticniProjekat
            // 
            groupBoxPrakticniProjekat.Controls.Add(buttonObrisi);
            groupBoxPrakticniProjekat.Controls.Add(buttonAzuriraj);
            groupBoxPrakticniProjekat.Controls.Add(buttonDodaj);
            groupBoxPrakticniProjekat.Location = new Point(744, 12);
            groupBoxPrakticniProjekat.Name = "groupBoxPrakticniProjekat";
            groupBoxPrakticniProjekat.Size = new Size(236, 198);
            groupBoxPrakticniProjekat.TabIndex = 3;
            groupBoxPrakticniProjekat.TabStop = false;
            groupBoxPrakticniProjekat.Text = "Praktični projekat";
            // 
            // buttonObrisi
            // 
            buttonObrisi.BackColor = SystemColors.ButtonFace;
            buttonObrisi.Location = new Point(8, 143);
            buttonObrisi.Margin = new Padding(4);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(221, 48);
            buttonObrisi.TabIndex = 3;
            buttonObrisi.Text = "Obriši";
            buttonObrisi.UseVisualStyleBackColor = false;
            // 
            // buttonAzuriraj
            // 
            buttonAzuriraj.BackColor = SystemColors.ButtonFace;
            buttonAzuriraj.Location = new Point(8, 89);
            buttonAzuriraj.Margin = new Padding(4);
            buttonAzuriraj.Name = "buttonAzuriraj";
            buttonAzuriraj.Size = new Size(221, 48);
            buttonAzuriraj.TabIndex = 2;
            buttonAzuriraj.Text = "Ažuriraj";
            buttonAzuriraj.UseVisualStyleBackColor = false;
            buttonAzuriraj.Click += buttonAzuriraj_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.BackColor = SystemColors.ButtonFace;
            buttonDodaj.Location = new Point(8, 32);
            buttonDodaj.Margin = new Padding(4);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(221, 48);
            buttonDodaj.TabIndex = 1;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // PrakticniProjektiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxPrakticniProjekat);
            Controls.Add(groupBoxPreporuceneStranice);
            Controls.Add(groupBoxIzvestaji);
            Controls.Add(groupBoxPrakticniProjekti);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrakticniProjektiForm";
            Text = "Praktični projekti";
            Activated += PrakticniProjektiForm_Activated;
            Load += PrakticniProjektiForm_Load;
            groupBoxPrakticniProjekti.ResumeLayout(false);
            groupBoxIzvestaji.ResumeLayout(false);
            groupBoxPreporuceneStranice.ResumeLayout(false);
            groupBoxPrakticniProjekat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPrakticniProjekti;
        private GroupBox groupBoxIzvestaji;
        private GroupBox groupBoxPreporuceneStranice;
        private GroupBox groupBoxPrakticniProjekat;
        private Button buttonObrisi;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private Button buttonIzvestaji;
        private Button buttonPreporuceneStranice;
        private ListView listViewPrakticniProjekti;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}