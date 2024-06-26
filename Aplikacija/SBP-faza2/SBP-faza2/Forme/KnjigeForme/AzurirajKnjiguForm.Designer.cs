﻿namespace SBP_faza2.Forme.KnjigeForme
{
    partial class AzurirajKnjiguForm
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
            groupBoxKnjigaPodaci = new GroupBox();
            textBoxIsbn = new TextBox();
            labelIsbn = new Label();
            textBoxIzdavac = new TextBox();
            labelIzdavac = new Label();
            labelGodinaIzdanja = new Label();
            textBoxImeRoditelja = new TextBox();
            labelNaslovKnjige = new Label();
            textBoxNaslovKnjige = new TextBox();
            labelAutori = new Label();
            listBox1 = new ListBox();
            buttonAzurirajKnjigu = new Button();
            groupBoxKnjigaPodaci.SuspendLayout();
            SuspendLayout();
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
            groupBoxKnjigaPodaci.Controls.Add(textBoxImeRoditelja);
            groupBoxKnjigaPodaci.Controls.Add(labelNaslovKnjige);
            groupBoxKnjigaPodaci.Controls.Add(textBoxNaslovKnjige);
            groupBoxKnjigaPodaci.Location = new Point(12, 12);
            groupBoxKnjigaPodaci.Name = "groupBoxKnjigaPodaci";
            groupBoxKnjigaPodaci.Size = new Size(493, 372);
            groupBoxKnjigaPodaci.TabIndex = 4;
            groupBoxKnjigaPodaci.TabStop = false;
            groupBoxKnjigaPodaci.Text = "Podaci o knjizi";
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
            // textBoxImeRoditelja
            // 
            textBoxImeRoditelja.BackColor = SystemColors.ButtonFace;
            textBoxImeRoditelja.Location = new Point(158, 95);
            textBoxImeRoditelja.MaxLength = 4;
            textBoxImeRoditelja.Name = "textBoxImeRoditelja";
            textBoxImeRoditelja.Size = new Size(321, 32);
            textBoxImeRoditelja.TabIndex = 2;
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
            // labelAutori
            // 
            labelAutori.AutoSize = true;
            labelAutori.Location = new Point(6, 262);
            labelAutori.Name = "labelAutori";
            labelAutori.Size = new Size(63, 24);
            labelAutori.TabIndex = 22;
            labelAutori.Text = "Autori";
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
            // buttonAzurirajKnjigu
            // 
            buttonAzurirajKnjigu.Location = new Point(142, 399);
            buttonAzurirajKnjigu.Name = "buttonAzurirajKnjigu";
            buttonAzurirajKnjigu.Size = new Size(221, 48);
            buttonAzurirajKnjigu.TabIndex = 26;
            buttonAzurirajKnjigu.Text = "Ažuriraj knjigu";
            buttonAzurirajKnjigu.UseVisualStyleBackColor = true;
            // 
            // AzurirajKnjiguForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(516, 467);
            Controls.Add(buttonAzurirajKnjigu);
            Controls.Add(groupBoxKnjigaPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AzurirajKnjiguForm";
            Text = "Azuriraj knjigu";
            groupBoxKnjigaPodaci.ResumeLayout(false);
            groupBoxKnjigaPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxKnjigaPodaci;
        private TextBox textBoxIsbn;
        private Label labelIsbn;
        private TextBox textBoxIzdavac;
        private Label labelIzdavac;
        private Label labelGodinaIzdanja;
        private TextBox textBoxImeRoditelja;
        private Label labelNaslovKnjige;
        private TextBox textBoxNaslovKnjige;
        private ListBox listBox1;
        private Label labelAutori;
        private Button buttonAzurirajKnjigu;
    }
}