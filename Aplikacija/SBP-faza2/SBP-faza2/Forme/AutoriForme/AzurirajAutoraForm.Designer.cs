namespace SBP_faza2.Forme.AutoriForme
{
    partial class AzurirajAutoraForm
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
            groupBoxAutorPodaci = new GroupBox();
            listBoxRad = new ListBox();
            listBoxClanak = new ListBox();
            listBoxKnjiga = new ListBox();
            labelRad = new Label();
            labelClanak = new Label();
            labelKnjiga = new Label();
            textBoxImeAutora = new TextBox();
            labelImeAutora = new Label();
            buttonAzurirajAutora = new Button();
            groupBoxAutorPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAutorPodaci
            // 
            groupBoxAutorPodaci.Controls.Add(listBoxRad);
            groupBoxAutorPodaci.Controls.Add(listBoxClanak);
            groupBoxAutorPodaci.Controls.Add(listBoxKnjiga);
            groupBoxAutorPodaci.Controls.Add(labelRad);
            groupBoxAutorPodaci.Controls.Add(labelClanak);
            groupBoxAutorPodaci.Controls.Add(labelKnjiga);
            groupBoxAutorPodaci.Controls.Add(textBoxImeAutora);
            groupBoxAutorPodaci.Controls.Add(labelImeAutora);
            groupBoxAutorPodaci.Location = new Point(12, 12);
            groupBoxAutorPodaci.Name = "groupBoxAutorPodaci";
            groupBoxAutorPodaci.Size = new Size(452, 456);
            groupBoxAutorPodaci.TabIndex = 1;
            groupBoxAutorPodaci.TabStop = false;
            groupBoxAutorPodaci.Text = "Podaci o autoru";
            // 
            // listBoxRad
            // 
            listBoxRad.FormattingEnabled = true;
            listBoxRad.ItemHeight = 24;
            listBoxRad.Location = new Point(107, 344);
            listBoxRad.Name = "listBoxRad";
            listBoxRad.Size = new Size(211, 100);
            listBoxRad.TabIndex = 7;
            // 
            // listBoxClanak
            // 
            listBoxClanak.FormattingEnabled = true;
            listBoxClanak.ItemHeight = 24;
            listBoxClanak.Location = new Point(107, 221);
            listBoxClanak.Name = "listBoxClanak";
            listBoxClanak.Size = new Size(211, 100);
            listBoxClanak.TabIndex = 6;
            // 
            // listBoxKnjiga
            // 
            listBoxKnjiga.FormattingEnabled = true;
            listBoxKnjiga.ItemHeight = 24;
            listBoxKnjiga.Location = new Point(107, 102);
            listBoxKnjiga.Name = "listBoxKnjiga";
            listBoxKnjiga.Size = new Size(211, 100);
            listBoxKnjiga.TabIndex = 5;
            // 
            // labelRad
            // 
            labelRad.AutoSize = true;
            labelRad.Location = new Point(6, 344);
            labelRad.Name = "labelRad";
            labelRad.Size = new Size(42, 24);
            labelRad.TabIndex = 4;
            labelRad.Text = "Rad";
            // 
            // labelClanak
            // 
            labelClanak.AutoSize = true;
            labelClanak.Location = new Point(6, 221);
            labelClanak.Name = "labelClanak";
            labelClanak.Size = new Size(66, 24);
            labelClanak.TabIndex = 3;
            labelClanak.Text = "Članak";
            // 
            // labelKnjiga
            // 
            labelKnjiga.AutoSize = true;
            labelKnjiga.Location = new Point(6, 102);
            labelKnjiga.Name = "labelKnjiga";
            labelKnjiga.Size = new Size(60, 24);
            labelKnjiga.TabIndex = 2;
            labelKnjiga.Text = "Knjiga";
            // 
            // textBoxImeAutora
            // 
            textBoxImeAutora.Location = new Point(107, 39);
            textBoxImeAutora.MaxLength = 50;
            textBoxImeAutora.Name = "textBoxImeAutora";
            textBoxImeAutora.Size = new Size(211, 32);
            textBoxImeAutora.TabIndex = 1;
            // 
            // labelImeAutora
            // 
            labelImeAutora.AutoSize = true;
            labelImeAutora.Location = new Point(6, 42);
            labelImeAutora.Name = "labelImeAutora";
            labelImeAutora.Size = new Size(41, 24);
            labelImeAutora.TabIndex = 0;
            labelImeAutora.Text = "Ime";
            // 
            // buttonAzurirajAutora
            // 
            buttonAzurirajAutora.Location = new Point(119, 488);
            buttonAzurirajAutora.Name = "buttonAzurirajAutora";
            buttonAzurirajAutora.Size = new Size(221, 48);
            buttonAzurirajAutora.TabIndex = 28;
            buttonAzurirajAutora.Text = "Ažuriraj autora";
            buttonAzurirajAutora.UseVisualStyleBackColor = true;
            // 
            // AzurirajAutoraForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(474, 562);
            Controls.Add(buttonAzurirajAutora);
            Controls.Add(groupBoxAutorPodaci);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AzurirajAutoraForm";
            Text = "AzurirajAutoraForm";
            groupBoxAutorPodaci.ResumeLayout(false);
            groupBoxAutorPodaci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAutorPodaci;
        private ListBox listBoxRad;
        private ListBox listBoxClanak;
        private ListBox listBoxKnjiga;
        private Label labelRad;
        private Label labelClanak;
        private Label labelKnjiga;
        private TextBox textBoxImeAutora;
        private Label labelImeAutora;
        private Button buttonAzurirajAutora;
    }
}