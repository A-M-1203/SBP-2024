namespace SBP_faza2.Forme.PredmetiForme
{
    partial class PredmetiForm
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
            groupBoxPredmeta = new GroupBox();
            listViewPredmeti = new ListView();
            groupBoxPredmet = new GroupBox();
            buttonObrisi = new Button();
            buttonAzuriraj = new Button();
            buttonDodaj = new Button();
            groupBoxProjekti = new GroupBox();
            buttonTeorijskiProjekti = new Button();
            buttonPrakticniProjekti = new Button();
            groupBoxPredmeta.SuspendLayout();
            groupBoxPredmet.SuspendLayout();
            groupBoxProjekti.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPredmeta
            // 
            groupBoxPredmeta.Controls.Add(listViewPredmeti);
            groupBoxPredmeta.Location = new Point(12, 12);
            groupBoxPredmeta.Name = "groupBoxPredmeta";
            groupBoxPredmeta.Size = new Size(726, 580);
            groupBoxPredmeta.TabIndex = 1;
            groupBoxPredmeta.TabStop = false;
            groupBoxPredmeta.Text = "Lista predmeta";
            // 
            // listViewPredmeti
            // 
            listViewPredmeti.BackColor = SystemColors.ButtonFace;
            listViewPredmeti.FullRowSelect = true;
            listViewPredmeti.GridLines = true;
            listViewPredmeti.Location = new Point(8, 31);
            listViewPredmeti.Name = "listViewPredmeti";
            listViewPredmeti.Size = new Size(712, 543);
            listViewPredmeti.TabIndex = 0;
            listViewPredmeti.UseCompatibleStateImageBehavior = false;
            listViewPredmeti.View = View.Details;
            listViewPredmeti.SelectedIndexChanged += listViewPredmeti_SelectedIndexChanged;
            // 
            // groupBoxPredmet
            // 
            groupBoxPredmet.Controls.Add(buttonObrisi);
            groupBoxPredmet.Controls.Add(buttonAzuriraj);
            groupBoxPredmet.Controls.Add(buttonDodaj);
            groupBoxPredmet.Location = new Point(744, 12);
            groupBoxPredmet.Name = "groupBoxPredmet";
            groupBoxPredmet.Size = new Size(236, 198);
            groupBoxPredmet.TabIndex = 4;
            groupBoxPredmet.TabStop = false;
            groupBoxPredmet.Text = "Predmet";
            // 
            // buttonObrisi
            // 
            buttonObrisi.BackColor = SystemColors.ButtonFace;
            buttonObrisi.Enabled = false;
            buttonObrisi.Location = new Point(8, 143);
            buttonObrisi.Margin = new Padding(4);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(221, 48);
            buttonObrisi.TabIndex = 3;
            buttonObrisi.Text = "Obriši";
            buttonObrisi.UseVisualStyleBackColor = false;
            buttonObrisi.Click += buttonObrisi_Click;
            // 
            // buttonAzuriraj
            // 
            buttonAzuriraj.BackColor = SystemColors.ButtonFace;
            buttonAzuriraj.Enabled = false;
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
            // groupBoxProjekti
            // 
            groupBoxProjekti.Controls.Add(buttonTeorijskiProjekti);
            groupBoxProjekti.Controls.Add(buttonPrakticniProjekti);
            groupBoxProjekti.Location = new Point(744, 226);
            groupBoxProjekti.Name = "groupBoxProjekti";
            groupBoxProjekti.Size = new Size(236, 154);
            groupBoxProjekti.TabIndex = 5;
            groupBoxProjekti.TabStop = false;
            groupBoxProjekti.Text = "Projekti";
            // 
            // buttonTeorijskiProjekti
            // 
            buttonTeorijskiProjekti.BackColor = SystemColors.ButtonFace;
            buttonTeorijskiProjekti.Enabled = false;
            buttonTeorijskiProjekti.Location = new Point(7, 88);
            buttonTeorijskiProjekti.Margin = new Padding(4);
            buttonTeorijskiProjekti.Name = "buttonTeorijskiProjekti";
            buttonTeorijskiProjekti.Size = new Size(221, 48);
            buttonTeorijskiProjekti.TabIndex = 5;
            buttonTeorijskiProjekti.Text = "Teorijski projekti";
            buttonTeorijskiProjekti.UseVisualStyleBackColor = false;
            buttonTeorijskiProjekti.Click += buttonTeorijskiProjekti_Click;
            // 
            // buttonPrakticniProjekti
            // 
            buttonPrakticniProjekti.BackColor = SystemColors.ButtonFace;
            buttonPrakticniProjekti.Enabled = false;
            buttonPrakticniProjekti.Location = new Point(7, 32);
            buttonPrakticniProjekti.Margin = new Padding(4);
            buttonPrakticniProjekti.Name = "buttonPrakticniProjekti";
            buttonPrakticniProjekti.Size = new Size(221, 48);
            buttonPrakticniProjekti.TabIndex = 4;
            buttonPrakticniProjekti.Text = "Praktični projekti";
            buttonPrakticniProjekti.UseVisualStyleBackColor = false;
            buttonPrakticniProjekti.Click += buttonPrakticniProjekti_Click;
            // 
            // PredmetiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(992, 604);
            Controls.Add(groupBoxProjekti);
            Controls.Add(groupBoxPredmet);
            Controls.Add(groupBoxPredmeta);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PredmetiForm";
            Text = "Predmeti";
            Activated += PredmetiForm_Activated;
            Load += PredmetiForm_Load;
            groupBoxPredmeta.ResumeLayout(false);
            groupBoxPredmet.ResumeLayout(false);
            groupBoxProjekti.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPredmeta;
        private ListView listViewPredmeti;
        private GroupBox groupBoxPredmet;
        private Button buttonObrisi;
        private Button buttonAzuriraj;
        private Button buttonDodaj;
        private GroupBox groupBoxProjekti;
        private Button buttonTeorijskiProjekti;
        private Button buttonPrakticniProjekti;
    }
}