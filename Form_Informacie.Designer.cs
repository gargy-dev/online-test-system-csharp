namespace p65_72_Korabsky_Pavol
{
    partial class Form_Informacie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Informacie));
            this.panel_pozadie = new System.Windows.Forms.Panel();
            this.richTextBox_info_text = new System.Windows.Forms.RichTextBox();
            this.oddelovac5 = new Guna.UI2.WinForms.Guna2Separator();
            this.label_informacie = new System.Windows.Forms.Label();
            this.label_nazov = new System.Windows.Forms.Label();
            this.panel_bocny = new System.Windows.Forms.Panel();
            this.label_zatvorit = new System.Windows.Forms.Label();
            this.pictureBox_ukoncit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_hlavny = new System.Windows.Forms.Panel();
            this.panel_pozadie.SuspendLayout();
            this.panel_bocny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ukoncit)).BeginInit();
            this.panel_hlavny.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pozadie
            // 
            this.panel_pozadie.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_pozadie.Controls.Add(this.richTextBox_info_text);
            this.panel_pozadie.Controls.Add(this.oddelovac5);
            this.panel_pozadie.Controls.Add(this.label_informacie);
            this.panel_pozadie.Controls.Add(this.label_nazov);
            this.panel_pozadie.Controls.Add(this.panel_bocny);
            this.panel_pozadie.Location = new System.Drawing.Point(3, 3);
            this.panel_pozadie.Name = "panel_pozadie";
            this.panel_pozadie.Size = new System.Drawing.Size(832, 338);
            this.panel_pozadie.TabIndex = 0;
            // 
            // richTextBox_info_text
            // 
            this.richTextBox_info_text.BackColor = System.Drawing.Color.DodgerBlue;
            this.richTextBox_info_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_info_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox_info_text.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_info_text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_info_text.Location = new System.Drawing.Point(167, 73);
            this.richTextBox_info_text.Name = "richTextBox_info_text";
            this.richTextBox_info_text.ReadOnly = true;
            this.richTextBox_info_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_info_text.Size = new System.Drawing.Size(558, 256);
            this.richTextBox_info_text.TabIndex = 11;
            this.richTextBox_info_text.Text = resources.GetString("richTextBox_info_text.Text");
            // 
            // oddelovac5
            // 
            this.oddelovac5.Location = new System.Drawing.Point(383, 57);
            this.oddelovac5.Name = "oddelovac5";
            this.oddelovac5.Size = new System.Drawing.Size(113, 10);
            this.oddelovac5.TabIndex = 9;
            // 
            // label_informacie
            // 
            this.label_informacie.AutoSize = true;
            this.label_informacie.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_informacie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_informacie.Location = new System.Drawing.Point(384, 26);
            this.label_informacie.Name = "label_informacie";
            this.label_informacie.Size = new System.Drawing.Size(118, 28);
            this.label_informacie.TabIndex = 3;
            this.label_informacie.Text = "Niečo viac...";
            // 
            // label_nazov
            // 
            this.label_nazov.AutoSize = true;
            this.label_nazov.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_nazov.Location = new System.Drawing.Point(688, 6);
            this.label_nazov.Name = "label_nazov";
            this.label_nazov.Size = new System.Drawing.Size(135, 34);
            this.label_nazov.TabIndex = 1;
            this.label_nazov.Text = "on-Test-line!";
            // 
            // panel_bocny
            // 
            this.panel_bocny.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_bocny.Controls.Add(this.label_zatvorit);
            this.panel_bocny.Controls.Add(this.pictureBox_ukoncit);
            this.panel_bocny.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bocny.ForeColor = System.Drawing.Color.Silver;
            this.panel_bocny.Location = new System.Drawing.Point(0, 0);
            this.panel_bocny.Name = "panel_bocny";
            this.panel_bocny.Size = new System.Drawing.Size(123, 338);
            this.panel_bocny.TabIndex = 0;
            // 
            // label_zatvorit
            // 
            this.label_zatvorit.AutoSize = true;
            this.label_zatvorit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.2F, System.Drawing.FontStyle.Bold);
            this.label_zatvorit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_zatvorit.Location = new System.Drawing.Point(44, 153);
            this.label_zatvorit.Name = "label_zatvorit";
            this.label_zatvorit.Size = new System.Drawing.Size(76, 29);
            this.label_zatvorit.TabIndex = 24;
            this.label_zatvorit.Text = "Zatvoriť";
            this.label_zatvorit.Click += new System.EventHandler(this.label_domov_Click);
            // 
            // pictureBox_ukoncit
            // 
            this.pictureBox_ukoncit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ukoncit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_ukoncit.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.ukoncit;
            this.pictureBox_ukoncit.ImageRotate = 0F;
            this.pictureBox_ukoncit.Location = new System.Drawing.Point(11, 151);
            this.pictureBox_ukoncit.Name = "pictureBox_ukoncit";
            this.pictureBox_ukoncit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_ukoncit.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_ukoncit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_ukoncit.TabIndex = 24;
            this.pictureBox_ukoncit.TabStop = false;
            this.pictureBox_ukoncit.UseTransparentBackground = true;
            // 
            // panel_hlavny
            // 
            this.panel_hlavny.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_hlavny.Controls.Add(this.panel_pozadie);
            this.panel_hlavny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_hlavny.Location = new System.Drawing.Point(0, 0);
            this.panel_hlavny.Margin = new System.Windows.Forms.Padding(4);
            this.panel_hlavny.Name = "panel_hlavny";
            this.panel_hlavny.Size = new System.Drawing.Size(838, 344);
            this.panel_hlavny.TabIndex = 2;
            // 
            // Form_Informacie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 344);
            this.Controls.Add(this.panel_hlavny);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Informacie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Informacie";
            this.panel_pozadie.ResumeLayout(false);
            this.panel_pozadie.PerformLayout();
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ukoncit)).EndInit();
            this.panel_hlavny.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pozadie;
        private Guna.UI2.WinForms.Guna2Separator oddelovac5;
        private System.Windows.Forms.Label label_informacie;
        private System.Windows.Forms.Label label_nazov;
        private System.Windows.Forms.Panel panel_bocny;
        private System.Windows.Forms.Label label_zatvorit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_ukoncit;
        private System.Windows.Forms.Panel panel_hlavny;
        private System.Windows.Forms.RichTextBox richTextBox_info_text;
    }
}