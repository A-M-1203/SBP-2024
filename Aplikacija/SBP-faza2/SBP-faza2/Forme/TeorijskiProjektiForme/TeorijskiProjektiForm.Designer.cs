namespace SBP_faza2.Forme
{
    partial class TeorijskiProjektiForm
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
            groupBoxTeorijskiProjekti = new GroupBox();
            listViewPrakticniProjekti = new ListView();
            groupBoxTeorijskiProjekat = new GroupBox();
            buttonObrisi = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxLiteratura = new GroupBox();
            buttonRadovi = new Button();
            buttonCasopisi = new Button();
            buttonKnjige = new Button();
            groupBoxTeorijskiProjekti.SuspendLayout();
            groupBoxTeorijskiProjekat.SuspendLayout();
            groupBoxLiteratura.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTeorijskiProjekti
            // 
            groupBoxTeorijskiProjekti.Controls.Add(listViewPrakticniProjekti);
            groupBoxTeorijskiProjekti.Location = new Point(12, 12);
            groupBoxTeorijskiProjekti.Name = "groupBoxTeorijskiProjekti";
            groupBoxTeorijskiProjekti.Size = new Size(726, 580);
            groupBoxTeorijskiProjekti.TabIndex = 1;
            groupBoxTeorijskiProjekti.TabStop = false;
            groupBoxTeorijskiProjekti.Text = "Lista teorijskih projekata";
            // 
            // listViewPrakticniProjekti
            // 
            listViewPrakticniProjekti.BackColor = SystemColors.ButtonFace;
            listViewPrakticniProjekti.Location = new Point(8, 31);
            listViewPrakticniProjekti.Name = "listViewPrakticniProjekti";
            listViewPrakticniProjekti.Size = new Size(712, 543);
            listViewPrakticniProjekti.TabIndex = 0;
            listViewPrakticniProjekti.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxTeorijskiProjekat
            // 
            groupBoxTeorijskiProjekat.Controls.Add(buttonObrisi);
            groupBoxTeorijskiProjekat.Controls.Add(buttonAzuriraj);
            groupBoxTeorijskiProjekat.Controls.Add(buttonDodaj);
            groupBoxTeorijskiProjekat.Location = new Point(744, 12);
            groupBoxTeorijskiProjekat.Name = "groupBoxTeorijskiProjekat";
            groupBoxTeorijskiProjekat.Size = new Size(236, 198);
            groupBoxTeorijskiProjekat.TabIndex = 4;
            groupBoxTeorijskiProjekat.TabStop = false;
            groupBoxTeorijskiProjekat.Text = "Teorijski projekat";
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
            // groupBoxLiteratura
            // 
            groupBoxLiteratura.Controls.Add(buttonRadovi);
            groupBoxLiteratura.Controls.Add(buttonCasopisi);
            groupBoxLiteratura.Controls.Add(buttonKnjige);
            groupBoxLiteratura.Location = new Point(744, 216);
            groupBoxLiteratura.Name = "groupBoxLiteratura";
            groupBoxLiteratura.Size = new Size(236, 222);
            groupBoxLiteratura.TabIndex = 5;
            groupBoxLiteratura.TabStop = false;
            groupBoxLiteratura.Text = "Literatura za projekat";
            // 
            // buttonRadovi
            // 
            buttonRadovi.BackColor = SystemColors.ButtonFace;
            buttonRadovi.Location = new Point(8, 160);
            buttonRadovi.Name = "buttonRadovi";
            buttonRadovi.Size = new Size(221, 48);
            buttonRadovi.TabIndex = 3;
            buttonRadovi.Text = "Radovi";
            buttonRadovi.UseVisualStyleBackColor = false;
            // 
            // buttonCasopisi
            // 
            buttonCasopisi.BackColor = SystemColors.ButtonFace;
            buttonCasopisi.Location = new Point(8, 95);
            buttonCasopisi.Name = "buttonCasopisi";
            buttonCasopisi.Size = new Size(221, 48);
            buttonCasopisi.TabIndex = 2;
            buttonCasopisi.Text = "Članci";
            buttonCasopisi.UseVisualStyleBackColor = false;
            buttonCasopisi.Click += buttonCasopisi_Click;
            // 
            // buttonKnjige
            // 
            buttonKnjige.BackColor = SystemColors.ButtonFace;
            buttonKnjige.Location = new Point(8, 31);
            buttonKnjige.Name = "buttonKnjige";
            buttonKnjige.Size = new Size(221, 48);
            buttonKnjige.TabIndex = 1;
            buttonKnjige.Text = "Knjige";
            buttonKnjige.UseVisualStyleBackColor = false;
            buttonKnjige.Click += buttonKnjige_Click;
            // 
            // TeorijskiProjektiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxLiteratura);
            Controls.Add(groupBoxTeorijskiProjekat);
            Controls.Add(groupBoxTeorijskiProjekti);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeorijskiProjektiForm";
            Text = "Teorijski projekti";
            groupBoxTeorijskiProjekti.ResumeLayout(false);
            groupBoxTeorijskiProjekat.ResumeLayout(false);
            groupBoxLiteratura.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTeorijskiProjekti;
        private ListView listViewPrakticniProjekti;
        private GroupBox groupBoxTeorijskiProjekat;
        private Button buttonObrisi;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private GroupBox groupBoxLiteratura;
        private Button buttonKnjige;
        private Button buttonRadovi;
        private Button buttonCasopisi;
    }
}