namespace SBP_faza2.Forme
{
    partial class AzurirajStudentaForm
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
            groupBoxStudentPodaci = new GroupBox();
            label4 = new Label();
            comboBoxSmer = new ComboBox();
            label3 = new Label();
            textBoxBrojIndeksa = new TextBox();
            textBoxPrezimeStudenta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxImeRoditelja = new TextBox();
            labelImeStudenta = new Label();
            textBoxImeStudenta = new TextBox();
            buttonAzurirajStudenta = new Button();
            groupBoxStudentPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStudentPodaci
            // 
            groupBoxStudentPodaci.Controls.Add(label4);
            groupBoxStudentPodaci.Controls.Add(comboBoxSmer);
            groupBoxStudentPodaci.Controls.Add(label3);
            groupBoxStudentPodaci.Controls.Add(textBoxBrojIndeksa);
            groupBoxStudentPodaci.Controls.Add(textBoxPrezimeStudenta);
            groupBoxStudentPodaci.Controls.Add(label2);
            groupBoxStudentPodaci.Controls.Add(label1);
            groupBoxStudentPodaci.Controls.Add(textBoxImeRoditelja);
            groupBoxStudentPodaci.Controls.Add(labelImeStudenta);
            groupBoxStudentPodaci.Controls.Add(textBoxImeStudenta);
            groupBoxStudentPodaci.Location = new Point(12, 12);
            groupBoxStudentPodaci.Name = "groupBoxStudentPodaci";
            groupBoxStudentPodaci.Size = new Size(315, 304);
            groupBoxStudentPodaci.TabIndex = 1;
            groupBoxStudentPodaci.TabStop = false;
            groupBoxStudentPodaci.Text = "Podaci o studentu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 256);
            label4.Name = "label4";
            label4.Size = new Size(52, 24);
            label4.TabIndex = 10;
            label4.Text = "Smer";
            // 
            // comboBoxSmer
            // 
            comboBoxSmer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSmer.FormattingEnabled = true;
            comboBoxSmer.Items.AddRange(new object[] { "EEN", "RII", "ELK", "EKM", "US", "KIT" });
            comboBoxSmer.Location = new Point(139, 253);
            comboBoxSmer.Name = "comboBoxSmer";
            comboBoxSmer.Size = new Size(151, 32);
            comboBoxSmer.TabIndex = 9;
            comboBoxSmer.SelectedIndexChanged += comboBoxSmer_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 208);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 7;
            label3.Text = "Broj indeksa";
            // 
            // textBoxBrojIndeksa
            // 
            textBoxBrojIndeksa.Location = new Point(139, 205);
            textBoxBrojIndeksa.MaxLength = 5;
            textBoxBrojIndeksa.Name = "textBoxBrojIndeksa";
            textBoxBrojIndeksa.Size = new Size(151, 32);
            textBoxBrojIndeksa.TabIndex = 6;
            textBoxBrojIndeksa.TextChanged += textBoxBrojIndeksa_TextChanged;
            textBoxBrojIndeksa.KeyPress += textBoxBrojIndeksa_KeyPress;
            // 
            // textBoxPrezimeStudenta
            // 
            textBoxPrezimeStudenta.Location = new Point(139, 151);
            textBoxPrezimeStudenta.MaxLength = 30;
            textBoxPrezimeStudenta.Name = "textBoxPrezimeStudenta";
            textBoxPrezimeStudenta.Size = new Size(151, 32);
            textBoxPrezimeStudenta.TabIndex = 5;
            textBoxPrezimeStudenta.TextChanged += textBoxPrezimeStudenta_TextChanged;
            textBoxPrezimeStudenta.KeyPress += textBoxPrezimeStudenta_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 154);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 4;
            label2.Text = "Prezime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 98);
            label1.Name = "label1";
            label1.Size = new Size(117, 24);
            label1.TabIndex = 3;
            label1.Text = "Ime roditelja";
            // 
            // textBoxImeRoditelja
            // 
            textBoxImeRoditelja.Location = new Point(139, 95);
            textBoxImeRoditelja.MaxLength = 20;
            textBoxImeRoditelja.Name = "textBoxImeRoditelja";
            textBoxImeRoditelja.Size = new Size(151, 32);
            textBoxImeRoditelja.TabIndex = 2;
            textBoxImeRoditelja.TextChanged += textBoxImeRoditelja_TextChanged;
            textBoxImeRoditelja.KeyPress += textBoxImeRoditelja_KeyPress;
            // 
            // labelImeStudenta
            // 
            labelImeStudenta.AutoSize = true;
            labelImeStudenta.Location = new Point(16, 45);
            labelImeStudenta.Name = "labelImeStudenta";
            labelImeStudenta.Size = new Size(41, 24);
            labelImeStudenta.TabIndex = 1;
            labelImeStudenta.Text = "Ime";
            // 
            // textBoxImeStudenta
            // 
            textBoxImeStudenta.Location = new Point(139, 42);
            textBoxImeStudenta.MaxLength = 20;
            textBoxImeStudenta.Name = "textBoxImeStudenta";
            textBoxImeStudenta.Size = new Size(151, 32);
            textBoxImeStudenta.TabIndex = 0;
            textBoxImeStudenta.TextChanged += textBoxImeStudenta_TextChanged;
            textBoxImeStudenta.KeyPress += textBoxImeStudenta_KeyPress;
            // 
            // buttonAzurirajStudenta
            // 
            buttonAzurirajStudenta.Enabled = false;
            buttonAzurirajStudenta.Location = new Point(60, 338);
            buttonAzurirajStudenta.Name = "buttonAzurirajStudenta";
            buttonAzurirajStudenta.Size = new Size(221, 48);
            buttonAzurirajStudenta.TabIndex = 11;
            buttonAzurirajStudenta.Text = "Ažuriraj studenta";
            buttonAzurirajStudenta.UseVisualStyleBackColor = true;
            buttonAzurirajStudenta.Click += buttonAzurirajStudenta_Click;
            // 
            // AzurirajStudentaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(339, 416);
            Controls.Add(buttonAzurirajStudenta);
            Controls.Add(groupBoxStudentPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AzurirajStudentaForm";
            Text = "Azuriraj studenta";
            Load += AzurirajStudentaForm_Load;
            groupBoxStudentPodaci.ResumeLayout(false);
            groupBoxStudentPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxStudentPodaci;
        private Label label4;
        private ComboBox comboBoxSmer;
        private Label label3;
        private TextBox textBoxBrojIndeksa;
        private TextBox textBoxPrezimeStudenta;
        private Label label2;
        private Label label1;
        private TextBox textBoxImeRoditelja;
        private Label labelImeStudenta;
        private TextBox textBoxImeStudenta;
        private Button buttonAzurirajStudenta;
    }
}