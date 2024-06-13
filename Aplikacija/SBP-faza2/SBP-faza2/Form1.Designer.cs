namespace SBP_faza2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStudenti = new Button();
            buttonPredmeti = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStudenti
            // 
            buttonStudenti.BackColor = SystemColors.ButtonFace;
            buttonStudenti.Location = new Point(91, 197);
            buttonStudenti.Margin = new Padding(4);
            buttonStudenti.Name = "buttonStudenti";
            buttonStudenti.Size = new Size(294, 41);
            buttonStudenti.TabIndex = 1;
            buttonStudenti.Text = "Studenti";
            buttonStudenti.UseVisualStyleBackColor = false;
            buttonStudenti.Click += buttonStudenti_Click;
            // 
            // buttonPredmeti
            // 
            buttonPredmeti.BackColor = SystemColors.ButtonFace;
            buttonPredmeti.Location = new Point(91, 296);
            buttonPredmeti.Margin = new Padding(4);
            buttonPredmeti.Name = "buttonPredmeti";
            buttonPredmeti.Size = new Size(294, 41);
            buttonPredmeti.TabIndex = 3;
            buttonPredmeti.Text = "Predmeti";
            buttonPredmeti.UseVisualStyleBackColor = false;
            buttonPredmeti.Click += buttonPredmeti_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 593);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(479, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.ButtonFace;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(402, 20);
            toolStripStatusLabel1.Text = "SBP Projekat 2023/2024 - Aleksa Milošević i Stevan Trifunov";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(479, 619);
            Controls.Add(statusStrip1);
            Controls.Add(buttonPredmeti);
            Controls.Add(buttonStudenti);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Studentski projekti";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonStudenti;
        private Button buttonPredmeti;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}