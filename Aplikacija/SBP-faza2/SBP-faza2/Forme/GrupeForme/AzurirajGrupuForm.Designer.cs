namespace SBP_faza2.Forme.GrupeForme
{
    partial class AzurirajGrupuForm
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
            groupBoxGrupaPodaci = new GroupBox();
            listBoxIzvestaji = new ListBox();
            label2 = new Label();
            listBoxClanovi = new ListBox();
            labelClanovi = new Label();
            listBoxProjekat = new ListBox();
            label1 = new Label();
            textBoxNazivGrupe = new TextBox();
            labelNazivGrupe = new Label();
            buttonAzurirajGrupu = new Button();
            groupBoxGrupaPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGrupaPodaci
            // 
            groupBoxGrupaPodaci.Controls.Add(listBoxIzvestaji);
            groupBoxGrupaPodaci.Controls.Add(label2);
            groupBoxGrupaPodaci.Controls.Add(listBoxClanovi);
            groupBoxGrupaPodaci.Controls.Add(labelClanovi);
            groupBoxGrupaPodaci.Controls.Add(listBoxProjekat);
            groupBoxGrupaPodaci.Controls.Add(label1);
            groupBoxGrupaPodaci.Controls.Add(textBoxNazivGrupe);
            groupBoxGrupaPodaci.Controls.Add(labelNazivGrupe);
            groupBoxGrupaPodaci.Location = new Point(12, 12);
            groupBoxGrupaPodaci.Name = "groupBoxGrupaPodaci";
            groupBoxGrupaPodaci.Size = new Size(412, 480);
            groupBoxGrupaPodaci.TabIndex = 1;
            groupBoxGrupaPodaci.TabStop = false;
            groupBoxGrupaPodaci.Text = "Podaci o grupi";
            // 
            // listBoxIzvestaji
            // 
            listBoxIzvestaji.FormattingEnabled = true;
            listBoxIzvestaji.ItemHeight = 24;
            listBoxIzvestaji.Location = new Point(127, 364);
            listBoxIzvestaji.Name = "listBoxIzvestaji";
            listBoxIzvestaji.SelectionMode = SelectionMode.MultiSimple;
            listBoxIzvestaji.Size = new Size(267, 100);
            listBoxIzvestaji.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 364);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 6;
            label2.Text = "Izveštaji";
            // 
            // listBoxClanovi
            // 
            listBoxClanovi.FormattingEnabled = true;
            listBoxClanovi.ItemHeight = 24;
            listBoxClanovi.Location = new Point(127, 237);
            listBoxClanovi.Name = "listBoxClanovi";
            listBoxClanovi.SelectionMode = SelectionMode.MultiSimple;
            listBoxClanovi.Size = new Size(267, 100);
            listBoxClanovi.TabIndex = 5;
            // 
            // labelClanovi
            // 
            labelClanovi.AutoSize = true;
            labelClanovi.Location = new Point(15, 237);
            labelClanovi.Name = "labelClanovi";
            labelClanovi.Size = new Size(72, 24);
            labelClanovi.TabIndex = 4;
            labelClanovi.Text = "Članovi";
            // 
            // listBoxProjekat
            // 
            listBoxProjekat.FormattingEnabled = true;
            listBoxProjekat.ItemHeight = 24;
            listBoxProjekat.Location = new Point(127, 107);
            listBoxProjekat.Name = "listBoxProjekat";
            listBoxProjekat.Size = new Size(267, 100);
            listBoxProjekat.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 107);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 2;
            label1.Text = "Projekat";
            // 
            // textBoxNazivGrupe
            // 
            textBoxNazivGrupe.Location = new Point(127, 48);
            textBoxNazivGrupe.MaxLength = 50;
            textBoxNazivGrupe.Name = "textBoxNazivGrupe";
            textBoxNazivGrupe.Size = new Size(267, 32);
            textBoxNazivGrupe.TabIndex = 1;
            // 
            // labelNazivGrupe
            // 
            labelNazivGrupe.AutoSize = true;
            labelNazivGrupe.Location = new Point(15, 51);
            labelNazivGrupe.Name = "labelNazivGrupe";
            labelNazivGrupe.Size = new Size(55, 24);
            labelNazivGrupe.TabIndex = 0;
            labelNazivGrupe.Text = "Naziv";
            // 
            // buttonAzurirajGrupu
            // 
            buttonAzurirajGrupu.Location = new Point(115, 507);
            buttonAzurirajGrupu.Name = "buttonAzurirajGrupu";
            buttonAzurirajGrupu.Size = new Size(221, 48);
            buttonAzurirajGrupu.TabIndex = 27;
            buttonAzurirajGrupu.Text = "Ažuriraj grupu";
            buttonAzurirajGrupu.UseVisualStyleBackColor = true;
            // 
            // AzurirajGrupuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(437, 579);
            Controls.Add(buttonAzurirajGrupu);
            Controls.Add(groupBoxGrupaPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AzurirajGrupuForm";
            Text = "Azuriraj grupu";
            groupBoxGrupaPodaci.ResumeLayout(false);
            groupBoxGrupaPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGrupaPodaci;
        private ListBox listBoxIzvestaji;
        private Label label2;
        private ListBox listBoxClanovi;
        private Label labelClanovi;
        private ListBox listBoxProjekat;
        private Label label1;
        private TextBox textBoxNazivGrupe;
        private Label labelNazivGrupe;
        private Button buttonAzurirajGrupu;
    }
}