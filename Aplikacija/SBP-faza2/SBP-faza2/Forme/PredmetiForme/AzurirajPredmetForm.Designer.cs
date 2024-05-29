namespace SBP_faza2.Forme.PredmetiForme
{
    partial class AzurirajPredmetForm
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
            groupBoxPredmetPodaci = new GroupBox();
            listBoxProjekti = new ListBox();
            labelProjekti = new Label();
            comboBoxSemestar = new ComboBox();
            comboBoxKatedra = new ComboBox();
            textBoxSifraPredmeta = new TextBox();
            textBoxNazivPredmeta = new TextBox();
            labelSemestar = new Label();
            labelKatedra = new Label();
            labelSifraPredmeta = new Label();
            labelNazivPredmeta = new Label();
            buttonAzurirajPredmet = new Button();
            groupBoxPredmetPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPredmetPodaci
            // 
            groupBoxPredmetPodaci.Controls.Add(listBoxProjekti);
            groupBoxPredmetPodaci.Controls.Add(labelProjekti);
            groupBoxPredmetPodaci.Controls.Add(comboBoxSemestar);
            groupBoxPredmetPodaci.Controls.Add(comboBoxKatedra);
            groupBoxPredmetPodaci.Controls.Add(textBoxSifraPredmeta);
            groupBoxPredmetPodaci.Controls.Add(textBoxNazivPredmeta);
            groupBoxPredmetPodaci.Controls.Add(labelSemestar);
            groupBoxPredmetPodaci.Controls.Add(labelKatedra);
            groupBoxPredmetPodaci.Controls.Add(labelSifraPredmeta);
            groupBoxPredmetPodaci.Controls.Add(labelNazivPredmeta);
            groupBoxPredmetPodaci.Location = new Point(12, 12);
            groupBoxPredmetPodaci.Name = "groupBoxPredmetPodaci";
            groupBoxPredmetPodaci.Size = new Size(433, 393);
            groupBoxPredmetPodaci.TabIndex = 1;
            groupBoxPredmetPodaci.TabStop = false;
            groupBoxPredmetPodaci.Text = "Podaci o predmetu";
            // 
            // listBoxProjekti
            // 
            listBoxProjekti.FormattingEnabled = true;
            listBoxProjekti.ItemHeight = 24;
            listBoxProjekti.Location = new Point(126, 276);
            listBoxProjekti.Name = "listBoxProjekti";
            listBoxProjekti.SelectionMode = SelectionMode.MultiSimple;
            listBoxProjekti.Size = new Size(286, 100);
            listBoxProjekti.TabIndex = 9;
            // 
            // labelProjekti
            // 
            labelProjekti.AutoSize = true;
            labelProjekti.Location = new Point(15, 276);
            labelProjekti.Name = "labelProjekti";
            labelProjekti.Size = new Size(73, 24);
            labelProjekti.TabIndex = 8;
            labelProjekti.Text = "Projekti";
            // 
            // comboBoxSemestar
            // 
            comboBoxSemestar.FormattingEnabled = true;
            comboBoxSemestar.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            comboBoxSemestar.Location = new Point(126, 215);
            comboBoxSemestar.Name = "comboBoxSemestar";
            comboBoxSemestar.Size = new Size(286, 32);
            comboBoxSemestar.TabIndex = 7;
            // 
            // comboBoxKatedra
            // 
            comboBoxKatedra.FormattingEnabled = true;
            comboBoxKatedra.Items.AddRange(new object[] { "Automatika", "Elektronika", "Energetika", "Matematika", "Merenja", "Mikroelektronika", "Računarstvo", "Telekomunikacije", "Teorijska elektrotehnika", "Opšte obrazovni predmeti" });
            comboBoxKatedra.Location = new Point(126, 158);
            comboBoxKatedra.MaxDropDownItems = 10;
            comboBoxKatedra.Name = "comboBoxKatedra";
            comboBoxKatedra.Size = new Size(286, 32);
            comboBoxKatedra.TabIndex = 6;
            // 
            // textBoxSifraPredmeta
            // 
            textBoxSifraPredmeta.Location = new Point(126, 104);
            textBoxSifraPredmeta.MaxLength = 8;
            textBoxSifraPredmeta.Name = "textBoxSifraPredmeta";
            textBoxSifraPredmeta.Size = new Size(286, 32);
            textBoxSifraPredmeta.TabIndex = 5;
            // 
            // textBoxNazivPredmeta
            // 
            textBoxNazivPredmeta.Location = new Point(126, 45);
            textBoxNazivPredmeta.MaxLength = 50;
            textBoxNazivPredmeta.Name = "textBoxNazivPredmeta";
            textBoxNazivPredmeta.Size = new Size(286, 32);
            textBoxNazivPredmeta.TabIndex = 4;
            // 
            // labelSemestar
            // 
            labelSemestar.AutoSize = true;
            labelSemestar.Location = new Point(15, 218);
            labelSemestar.Name = "labelSemestar";
            labelSemestar.Size = new Size(87, 24);
            labelSemestar.TabIndex = 3;
            labelSemestar.Text = "Semestar";
            // 
            // labelKatedra
            // 
            labelKatedra.AutoSize = true;
            labelKatedra.Location = new Point(15, 161);
            labelKatedra.Name = "labelKatedra";
            labelKatedra.Size = new Size(75, 24);
            labelKatedra.TabIndex = 2;
            labelKatedra.Text = "Katedra";
            // 
            // labelSifraPredmeta
            // 
            labelSifraPredmeta.AutoSize = true;
            labelSifraPredmeta.Location = new Point(15, 107);
            labelSifraPredmeta.Name = "labelSifraPredmeta";
            labelSifraPredmeta.Size = new Size(47, 24);
            labelSifraPredmeta.TabIndex = 1;
            labelSifraPredmeta.Text = "Šifra";
            // 
            // labelNazivPredmeta
            // 
            labelNazivPredmeta.AutoSize = true;
            labelNazivPredmeta.Location = new Point(15, 48);
            labelNazivPredmeta.Name = "labelNazivPredmeta";
            labelNazivPredmeta.Size = new Size(55, 24);
            labelNazivPredmeta.TabIndex = 0;
            labelNazivPredmeta.Text = "Naziv";
            // 
            // buttonAzurirajPredmet
            // 
            buttonAzurirajPredmet.Location = new Point(119, 421);
            buttonAzurirajPredmet.Name = "buttonAzurirajPredmet";
            buttonAzurirajPredmet.Size = new Size(221, 48);
            buttonAzurirajPredmet.TabIndex = 26;
            buttonAzurirajPredmet.Text = "Ažuriraj predmet";
            buttonAzurirajPredmet.UseVisualStyleBackColor = true;
            // 
            // AzurirajPredmet
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(457, 490);
            Controls.Add(buttonAzurirajPredmet);
            Controls.Add(groupBoxPredmetPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AzurirajPredmet";
            Text = "Azuriraj predmet";
            groupBoxPredmetPodaci.ResumeLayout(false);
            groupBoxPredmetPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPredmetPodaci;
        private ListBox listBoxProjekti;
        private Label labelProjekti;
        private ComboBox comboBoxSemestar;
        private ComboBox comboBoxKatedra;
        private TextBox textBoxSifraPredmeta;
        private TextBox textBoxNazivPredmeta;
        private Label labelSemestar;
        private Label labelKatedra;
        private Label labelSifraPredmeta;
        private Label labelNazivPredmeta;
        private Button buttonAzurirajPredmet;
    }
}