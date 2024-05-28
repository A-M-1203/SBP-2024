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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVratiStudenta = new Button();
            buttonStudenti = new Button();
            buttonTeorijskiProjekti = new Button();
            buttonPredmeti = new Button();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            buttonPrakticniProjekti = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVratiStudenta
            // 
            btnVratiStudenta.BackColor = SystemColors.ButtonFace;
            btnVratiStudenta.Location = new Point(154, 543);
            btnVratiStudenta.Margin = new Padding(4);
            btnVratiStudenta.Name = "btnVratiStudenta";
            btnVratiStudenta.Size = new Size(158, 35);
            btnVratiStudenta.TabIndex = 0;
            btnVratiStudenta.Text = "Vrati Studenta";
            btnVratiStudenta.UseVisualStyleBackColor = false;
            btnVratiStudenta.Click += btnVratiStudenta_Click;
            // 
            // buttonStudenti
            // 
            buttonStudenti.BackColor = SystemColors.ButtonFace;
            buttonStudenti.Location = new Point(91, 251);
            buttonStudenti.Margin = new Padding(4);
            buttonStudenti.Name = "buttonStudenti";
            buttonStudenti.Size = new Size(294, 41);
            buttonStudenti.TabIndex = 1;
            buttonStudenti.Text = "Studenti";
            buttonStudenti.UseVisualStyleBackColor = false;
            buttonStudenti.Click += buttonStudenti_Click;
            // 
            // buttonTeorijskiProjekti
            // 
            buttonTeorijskiProjekti.BackColor = SystemColors.ButtonFace;
            buttonTeorijskiProjekti.Location = new Point(91, 313);
            buttonTeorijskiProjekti.Margin = new Padding(4);
            buttonTeorijskiProjekti.Name = "buttonTeorijskiProjekti";
            buttonTeorijskiProjekti.Size = new Size(294, 41);
            buttonTeorijskiProjekti.TabIndex = 2;
            buttonTeorijskiProjekti.Text = "Teorijski projekti";
            buttonTeorijskiProjekti.UseVisualStyleBackColor = false;
            buttonTeorijskiProjekti.Click += buttonTeorijskiProjekti_Click;
            // 
            // buttonPredmeti
            // 
            buttonPredmeti.BackColor = SystemColors.ButtonFace;
            buttonPredmeti.Location = new Point(91, 445);
            buttonPredmeti.Margin = new Padding(4);
            buttonPredmeti.Name = "buttonPredmeti";
            buttonPredmeti.Size = new Size(294, 41);
            buttonPredmeti.TabIndex = 3;
            buttonPredmeti.Text = "Predmeti";
            buttonPredmeti.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(91, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            // buttonPrakticniProjekti
            // 
            buttonPrakticniProjekti.BackColor = SystemColors.ButtonFace;
            buttonPrakticniProjekti.Location = new Point(91, 378);
            buttonPrakticniProjekti.Margin = new Padding(4);
            buttonPrakticniProjekti.Name = "buttonPrakticniProjekti";
            buttonPrakticniProjekti.Size = new Size(294, 41);
            buttonPrakticniProjekti.TabIndex = 7;
            buttonPrakticniProjekti.Text = "Praktični projekti";
            buttonPrakticniProjekti.UseVisualStyleBackColor = false;
            buttonPrakticniProjekti.Click += buttonPrakticniProjekti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(479, 619);
            Controls.Add(buttonPrakticniProjekti);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPredmeti);
            Controls.Add(buttonTeorijskiProjekti);
            Controls.Add(buttonStudenti);
            Controls.Add(btnVratiStudenta);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Studentski projekti";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVratiStudenta;
        private Button buttonStudenti;
        private Button buttonTeorijskiProjekti;
        private Button buttonPredmeti;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button buttonPrakticniProjekti;
    }
}