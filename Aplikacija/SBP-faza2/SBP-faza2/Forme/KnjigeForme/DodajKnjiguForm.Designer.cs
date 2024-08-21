namespace SBP_faza2.Forme.KnjigeForme
{
    partial class DodajKnjiguForm
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
            buttonDodajKnjigu = new Button();
            groupBoxKnjigaPodaci = new GroupBox();
            listBox1 = new ListBox();
            labelAutori = new Label();
            textBoxIsbn = new TextBox();
            labelIsbn = new Label();
            textBoxIzdavac = new TextBox();
            labelIzdavac = new Label();
            labelGodinaIzdanja = new Label();
            textBoxGodinaIzdanja = new TextBox();
            labelNaslovKnjige = new Label();
            textBoxNaslovKnjige = new TextBox();
            groupBoxKnjigaPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDodajKnjigu
            // 
            buttonDodajKnjigu.Location = new Point(158, 400);
            buttonDodajKnjigu.Name = "buttonDodajKnjigu";
            buttonDodajKnjigu.Size = new Size(221, 48);
            buttonDodajKnjigu.TabIndex = 25;
            buttonDodajKnjigu.Text = "Dodaj knjigu";
            buttonDodajKnjigu.UseVisualStyleBackColor = true;
            // 
            // groupBoxKnjigaPodaci
            // 
            groupBoxKnjigaPodaci.Controls.Add(listBox1);
            groupBoxKnjigaPodaci.Controls.Add(labelAutori);
            groupBoxKnjigaPodaci.Controls.Add(textBoxIsbn);
            groupBoxKnjigaPodaci.Controls.Add(labelIsbn);
            groupBoxKnjigaPodaci.Controls.Add(textBoxIzdavac);
            groupBoxKnjigaPodaci.Controls.Add(labelIzdavac);
            groupBoxKnjigaPodaci.Controls.Add(labelGodinaIzdanja);
            groupBoxKnjigaPodaci.Controls.Add(textBoxGodinaIzdanja);
            groupBoxKnjigaPodaci.Controls.Add(labelNaslovKnjige);
            groupBoxKnjigaPodaci.Controls.Add(textBoxNaslovKnjige);
            groupBoxKnjigaPodaci.Location = new Point(13, 12);
            groupBoxKnjigaPodaci.Name = "groupBoxKnjigaPodaci";
            groupBoxKnjigaPodaci.Size = new Size(493, 372);
            groupBoxKnjigaPodaci.TabIndex = 26;
            groupBoxKnjigaPodaci.TabStop = false;
            groupBoxKnjigaPodaci.Text = "Podaci o knjizi";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(158, 260);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(321, 100);
            listBox1.TabIndex = 23;
            // 
            // labelAutori
            // 
            labelAutori.AutoSize = true;
            labelAutori.Location = new Point(6, 262);
            labelAutori.Name = "labelAutori";
            labelAutori.Size = new Size(63, 24);
            labelAutori.TabIndex = 22;
            labelAutori.Text = "Autori";
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.BackColor = SystemColors.ButtonFace;
            textBoxIsbn.Location = new Point(158, 202);
            textBoxIsbn.MaxLength = 17;
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(321, 32);
            textBoxIsbn.TabIndex = 21;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Location = new Point(6, 210);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(48, 24);
            labelIsbn.TabIndex = 20;
            labelIsbn.Text = "ISBN";
            // 
            // textBoxIzdavac
            // 
            textBoxIzdavac.BackColor = SystemColors.ButtonFace;
            textBoxIzdavac.Location = new Point(158, 151);
            textBoxIzdavac.MaxLength = 40;
            textBoxIzdavac.Name = "textBoxIzdavac";
            textBoxIzdavac.Size = new Size(321, 32);
            textBoxIzdavac.TabIndex = 19;
            // 
            // labelIzdavac
            // 
            labelIzdavac.AutoSize = true;
            labelIzdavac.Location = new Point(6, 154);
            labelIzdavac.Name = "labelIzdavac";
            labelIzdavac.Size = new Size(71, 24);
            labelIzdavac.TabIndex = 4;
            labelIzdavac.Text = "Izdavac";
            // 
            // labelGodinaIzdanja
            // 
            labelGodinaIzdanja.AutoSize = true;
            labelGodinaIzdanja.Location = new Point(6, 98);
            labelGodinaIzdanja.Name = "labelGodinaIzdanja";
            labelGodinaIzdanja.Size = new Size(136, 24);
            labelGodinaIzdanja.TabIndex = 3;
            labelGodinaIzdanja.Text = "Godina izdanja";
            // 
            // textBoxGodinaIzdanja
            // 
            textBoxGodinaIzdanja.BackColor = SystemColors.ButtonFace;
            textBoxGodinaIzdanja.Location = new Point(158, 95);
            textBoxGodinaIzdanja.MaxLength = 4;
            textBoxGodinaIzdanja.Name = "textBoxGodinaIzdanja";
            textBoxGodinaIzdanja.Size = new Size(321, 32);
            textBoxGodinaIzdanja.TabIndex = 2;
            // 
            // labelNaslovKnjige
            // 
            labelNaslovKnjige.AutoSize = true;
            labelNaslovKnjige.Location = new Point(6, 45);
            labelNaslovKnjige.Name = "labelNaslovKnjige";
            labelNaslovKnjige.Size = new Size(66, 24);
            labelNaslovKnjige.TabIndex = 1;
            labelNaslovKnjige.Text = "Naslov";
            // 
            // textBoxNaslovKnjige
            // 
            textBoxNaslovKnjige.BackColor = SystemColors.ButtonFace;
            textBoxNaslovKnjige.Location = new Point(158, 42);
            textBoxNaslovKnjige.MaxLength = 40;
            textBoxNaslovKnjige.Name = "textBoxNaslovKnjige";
            textBoxNaslovKnjige.Size = new Size(321, 32);
            textBoxNaslovKnjige.TabIndex = 0;
            // 
            // DodajKnjiguForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(518, 467);
            Controls.Add(groupBoxKnjigaPodaci);
            Controls.Add(buttonDodajKnjigu);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajKnjiguForm";
            Text = "Dodaj knjigu";
            groupBoxKnjigaPodaci.ResumeLayout(false);
            groupBoxKnjigaPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
#pragma warning disable CS0169 // The field 'DodajKnjiguForm.numericUpDownBrojIzvestaja' is never used
        private NumericUpDown numericUpDownBrojIzvestaja;
#pragma warning restore CS0169 // The field 'DodajKnjiguForm.numericUpDownBrojIzvestaja' is never used
#pragma warning disable CS0169 // The field 'DodajKnjiguForm.labelBrojIzvestaja' is never used
        private Label labelBrojIzvestaja;
#pragma warning restore CS0169 // The field 'DodajKnjiguForm.labelBrojIzvestaja' is never used
#pragma warning disable CS0169 // The field 'DodajKnjiguForm.labelPreporuceniProgJezik' is never used
        private Label labelPreporuceniProgJezik;
#pragma warning restore CS0169 // The field 'DodajKnjiguForm.labelPreporuceniProgJezik' is never used
#pragma warning disable CS0169 // The field 'DodajKnjiguForm.comboBox2' is never used
        private ComboBox comboBox2;
#pragma warning restore CS0169 // The field 'DodajKnjiguForm.comboBox2' is never used
#pragma warning disable CS0169 // The field 'DodajKnjiguForm.labelPredmet' is never used
        private Label labelPredmet;
#pragma warning restore CS0169 // The field 'DodajKnjiguForm.labelPredmet' is never used
        private Button buttonDodajKnjigu;
        private GroupBox groupBoxKnjigaPodaci;
        private ListBox listBox1;
        private Label labelAutori;
        private TextBox textBoxIsbn;
        private Label labelIsbn;
        private TextBox textBoxIzdavac;
        private Label labelIzdavac;
        private Label labelGodinaIzdanja;
        private TextBox textBoxGodinaIzdanja;
        private Label labelNaslovKnjige;
        private TextBox textBoxNaslovKnjige;
    }
}