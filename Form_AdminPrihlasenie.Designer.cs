namespace p65_72_Korabsky_Pavol
{
    partial class Form_AdminPrihlasenie
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
            this.panel_bocny = new System.Windows.Forms.Panel();
            this.label_admin = new System.Windows.Forms.Label();
            this.label_heslo = new System.Windows.Forms.Label();
            this.button_prihlasenie = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textBox_heslo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_nazov = new System.Windows.Forms.Label();
            this.label_naspat = new System.Windows.Forms.Label();
            this.pictureBox_ukoncit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_uvod = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_bocny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ukoncit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uvod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bocny
            // 
            this.panel_bocny.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_bocny.Controls.Add(this.label_admin);
            this.panel_bocny.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bocny.Location = new System.Drawing.Point(0, 0);
            this.panel_bocny.Name = "panel_bocny";
            this.panel_bocny.Size = new System.Drawing.Size(200, 300);
            this.panel_bocny.TabIndex = 30;
            // 
            // label_admin
            // 
            this.label_admin.AutoSize = true;
            this.label_admin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_admin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_admin.Location = new System.Drawing.Point(68, 136);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(78, 27);
            this.label_admin.TabIndex = 20;
            this.label_admin.Text = "ADMIN";
            // 
            // label_heslo
            // 
            this.label_heslo.AutoSize = true;
            this.label_heslo.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_heslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_heslo.Location = new System.Drawing.Point(277, 127);
            this.label_heslo.Name = "label_heslo";
            this.label_heslo.Size = new System.Drawing.Size(95, 20);
            this.label_heslo.TabIndex = 36;
            this.label_heslo.Text = "Zadajte Heslo";
            // 
            // button_prihlasenie
            // 
            this.button_prihlasenie.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasenie.BorderRadius = 20;
            this.button_prihlasenie.BorderThickness = 1;
            this.button_prihlasenie.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_prihlasenie.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_prihlasenie.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasenie.CheckedState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_prihlasenie.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_prihlasenie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_prihlasenie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_prihlasenie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_prihlasenie.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_prihlasenie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_prihlasenie.FillColor = System.Drawing.Color.Green;
            this.button_prihlasenie.FillColor2 = System.Drawing.Color.LimeGreen;
            this.button_prihlasenie.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.button_prihlasenie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasenie.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.button_prihlasenie.HoverState.BorderColor = System.Drawing.Color.ForestGreen;
            this.button_prihlasenie.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.button_prihlasenie.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasenie.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_prihlasenie.HoverState.ForeColor = System.Drawing.Color.Lime;
            this.button_prihlasenie.Location = new System.Drawing.Point(383, 206);
            this.button_prihlasenie.Name = "button_prihlasenie";
            this.button_prihlasenie.Size = new System.Drawing.Size(160, 47);
            this.button_prihlasenie.TabIndex = 34;
            this.button_prihlasenie.Text = "PRIHLÁSIŤ SA";
            this.button_prihlasenie.Click += new System.EventHandler(this.button_prihlasenie_Click);
            // 
            // textBox_heslo
            // 
            this.textBox_heslo.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_heslo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_heslo.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_heslo.DefaultText = "";
            this.textBox_heslo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_heslo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_heslo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_heslo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_heslo.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_heslo.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_heslo.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_heslo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_heslo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_heslo.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_heslo.Location = new System.Drawing.Point(281, 157);
            this.textBox_heslo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_heslo.Name = "textBox_heslo";
            this.textBox_heslo.PasswordChar = '\0';
            this.textBox_heslo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.PlaceholderText = "Heslo";
            this.textBox_heslo.SelectedText = "";
            this.textBox_heslo.Size = new System.Drawing.Size(363, 34);
            this.textBox_heslo.TabIndex = 33;
            this.textBox_heslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_nazov
            // 
            this.label_nazov.AutoSize = true;
            this.label_nazov.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold);
            this.label_nazov.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_nazov.Location = new System.Drawing.Point(315, 9);
            this.label_nazov.Name = "label_nazov";
            this.label_nazov.Size = new System.Drawing.Size(304, 27);
            this.label_nazov.TabIndex = 31;
            this.label_nazov.Text = "SYSTÉM ONLINE TESTOVANIA";
            // 
            // label_naspat
            // 
            this.label_naspat.AutoSize = true;
            this.label_naspat.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_naspat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_naspat.Location = new System.Drawing.Point(429, 260);
            this.label_naspat.Name = "label_naspat";
            this.label_naspat.Size = new System.Drawing.Size(69, 25);
            this.label_naspat.TabIndex = 39;
            this.label_naspat.Text = "naspäť";
            this.label_naspat.Click += new System.EventHandler(this.label_naspat_Click);
            // 
            // pictureBox_ukoncit
            // 
            this.pictureBox_ukoncit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ukoncit.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.ukoncit;
            this.pictureBox_ukoncit.ImageRotate = 0F;
            this.pictureBox_ukoncit.Location = new System.Drawing.Point(682, 6);
            this.pictureBox_ukoncit.Name = "pictureBox_ukoncit";
            this.pictureBox_ukoncit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_ukoncit.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_ukoncit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_ukoncit.TabIndex = 38;
            this.pictureBox_ukoncit.TabStop = false;
            this.pictureBox_ukoncit.UseTransparentBackground = true;
            this.pictureBox_ukoncit.Click += new System.EventHandler(this.pictureBox_ukoncit_Click);
            // 
            // pictureBox_uvod
            // 
            this.pictureBox_uvod.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_uvod.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_uvod.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.uvod;
            this.pictureBox_uvod.ImageRotate = 0F;
            this.pictureBox_uvod.Location = new System.Drawing.Point(425, 46);
            this.pictureBox_uvod.Name = "pictureBox_uvod";
            this.pictureBox_uvod.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_uvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_uvod.TabIndex = 37;
            this.pictureBox_uvod.TabStop = false;
            this.pictureBox_uvod.UseTransparentBackground = true;
            // 
            // Form_AdminPrihlasenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 300);
            this.Controls.Add(this.panel_bocny);
            this.Controls.Add(this.pictureBox_ukoncit);
            this.Controls.Add(this.pictureBox_uvod);
            this.Controls.Add(this.label_heslo);
            this.Controls.Add(this.button_prihlasenie);
            this.Controls.Add(this.textBox_heslo);
            this.Controls.Add(this.label_nazov);
            this.Controls.Add(this.label_naspat);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AdminPrihlasenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdminPrihlasenie";
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ukoncit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bocny;
        private System.Windows.Forms.Label label_admin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_ukoncit;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_uvod;
        private System.Windows.Forms.Label label_heslo;
        private Guna.UI2.WinForms.Guna2GradientButton button_prihlasenie;
        private Guna.UI2.WinForms.Guna2TextBox textBox_heslo;
        private System.Windows.Forms.Label label_nazov;
        private System.Windows.Forms.Label label_naspat;
    }
}