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
            components = new System.ComponentModel.Container();
            buttonStudenti = new Button();
            buttonPredmeti = new Button();
            panel1 = new Panel();
            grupeButton = new Button();
            projektiButton = new Button();
            predmetiButton = new Button();
            studentiButton = new Button();
            closeButton = new Button();
            minButton = new Button();
            panel2 = new Panel();
            detaljiLinkLabel = new LinkLabel();
            dateTimeLabel = new Label();
            statusLabel = new Label();
            bazaLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStudenti
            // 
            buttonStudenti.BackColor = SystemColors.ButtonFace;
            buttonStudenti.Location = new Point(582, 367);
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
            buttonPredmeti.Location = new Point(582, 441);
            buttonPredmeti.Margin = new Padding(4);
            buttonPredmeti.Name = "buttonPredmeti";
            buttonPredmeti.Size = new Size(294, 41);
            buttonPredmeti.TabIndex = 3;
            buttonPredmeti.Text = "Predmeti";
            buttonPredmeti.UseVisualStyleBackColor = false;
            buttonPredmeti.Click += buttonPredmeti_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(grupeButton);
            panel1.Controls.Add(projektiButton);
            panel1.Controls.Add(predmetiButton);
            panel1.Controls.Add(studentiButton);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(minButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 61);
            panel1.TabIndex = 7;
            // 
            // grupeButton
            // 
            grupeButton.Cursor = Cursors.Hand;
            grupeButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grupeButton.Image = Properties.Resources.group_icon;
            grupeButton.Location = new Point(410, 11);
            grupeButton.Name = "grupeButton";
            grupeButton.Size = new Size(127, 41);
            grupeButton.TabIndex = 5;
            grupeButton.Text = "Grupe";
            grupeButton.TextAlign = ContentAlignment.MiddleRight;
            grupeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            grupeButton.UseVisualStyleBackColor = true;
            // 
            // projektiButton
            // 
            projektiButton.Cursor = Cursors.Hand;
            projektiButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projektiButton.Image = Properties.Resources.project_icon;
            projektiButton.Location = new Point(277, 11);
            projektiButton.Name = "projektiButton";
            projektiButton.Size = new Size(127, 41);
            projektiButton.TabIndex = 4;
            projektiButton.Text = "Projekti";
            projektiButton.TextAlign = ContentAlignment.MiddleRight;
            projektiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            projektiButton.UseVisualStyleBackColor = true;
            // 
            // predmetiButton
            // 
            predmetiButton.Cursor = Cursors.Hand;
            predmetiButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            predmetiButton.Image = Properties.Resources.book_icon;
            predmetiButton.Location = new Point(144, 11);
            predmetiButton.Name = "predmetiButton";
            predmetiButton.Size = new Size(127, 41);
            predmetiButton.TabIndex = 3;
            predmetiButton.Text = "Predmeti";
            predmetiButton.TextAlign = ContentAlignment.MiddleRight;
            predmetiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            predmetiButton.UseVisualStyleBackColor = true;
            // 
            // studentiButton
            // 
            studentiButton.Cursor = Cursors.Hand;
            studentiButton.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentiButton.Image = Properties.Resources.student_icon;
            studentiButton.Location = new Point(11, 11);
            studentiButton.Name = "studentiButton";
            studentiButton.Size = new Size(127, 41);
            studentiButton.TabIndex = 2;
            studentiButton.Text = "Studenti";
            studentiButton.TextAlign = ContentAlignment.MiddleRight;
            studentiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            studentiButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackgroundImage = Properties.Resources.close_icon;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Location = new Point(859, 19);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(24, 24);
            closeButton.TabIndex = 1;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // minButton
            // 
            minButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minButton.BackgroundImage = Properties.Resources.minimize_icon;
            minButton.Cursor = Cursors.Hand;
            minButton.Location = new Point(829, 19);
            minButton.Name = "minButton";
            minButton.Size = new Size(24, 24);
            minButton.TabIndex = 0;
            minButton.UseVisualStyleBackColor = true;
            minButton.Click += minButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(detaljiLinkLabel);
            panel2.Controls.Add(dateTimeLabel);
            panel2.Controls.Add(statusLabel);
            panel2.Controls.Add(bazaLabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 45);
            panel2.TabIndex = 8;
            // 
            // detaljiLinkLabel
            // 
            detaljiLinkLabel.AutoSize = true;
            detaljiLinkLabel.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detaljiLinkLabel.Location = new Point(320, 11);
            detaljiLinkLabel.Name = "detaljiLinkLabel";
            detaljiLinkLabel.Size = new Size(65, 24);
            detaljiLinkLabel.TabIndex = 4;
            detaljiLinkLabel.TabStop = true;
            detaljiLinkLabel.Text = "Detalji";
            detaljiLinkLabel.Visible = false;
            detaljiLinkLabel.LinkClicked += detaljiLinkLabel_LinkClicked;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimeLabel.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimeLabel.ForeColor = SystemColors.ControlText;
            dateTimeLabel.Location = new Point(581, 11);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(302, 24);
            dateTimeLabel.TabIndex = 3;
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(187, 11);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(127, 24);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "NEPOVEZAN";
            // 
            // bazaLabel
            // 
            bazaLabel.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bazaLabel.Image = Properties.Resources.database_icon;
            bazaLabel.ImageAlign = ContentAlignment.MiddleLeft;
            bazaLabel.Location = new Point(11, 11);
            bazaLabel.Name = "bazaLabel";
            bazaLabel.Size = new Size(170, 24);
            bazaLabel.TabIndex = 1;
            bazaLabel.Text = "Baza podataka:";
            bazaLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(896, 619);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonPredmeti);
            Controls.Add(buttonStudenti);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studentski projekti";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonStudenti;
        private Button buttonPredmeti;
        private Panel panel1;
        private Panel panel2;
        private Button closeButton;
        private Button minButton;
        private Button projektiButton;
        private Button predmetiButton;
        private Button studentiButton;
        private Button grupeButton;
        private Label bazaLabel;
        private Label statusLabel;
        private Label dateTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel detaljiLinkLabel;
    }
}