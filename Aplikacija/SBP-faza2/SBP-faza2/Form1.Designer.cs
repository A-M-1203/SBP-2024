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
            btnVratiStudenta = new Button();
            SuspendLayout();
            // 
            // btnVratiStudenta
            // 
            btnVratiStudenta.Location = new Point(151, 101);
            btnVratiStudenta.Name = "btnVratiStudenta";
            btnVratiStudenta.Size = new Size(126, 29);
            btnVratiStudenta.TabIndex = 0;
            btnVratiStudenta.Text = "Vrati Studenta";
            btnVratiStudenta.UseVisualStyleBackColor = true;
            btnVratiStudenta.Click += btnVratiStudenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVratiStudenta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVratiStudenta;
    }
}
