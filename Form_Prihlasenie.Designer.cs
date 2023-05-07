namespace p65_72_Korabsky_Pavol
{
    partial class Form_Prihlasenie
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
            this.label_otestujte_sa = new System.Windows.Forms.Label();
            this.label_predmet = new System.Windows.Forms.Label();
            this.comboBox_predmety = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_nazov = new System.Windows.Forms.Label();
            this.textBox_meno = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_heslo = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_prihlasenie = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label_meno = new System.Windows.Forms.Label();
            this.label_heslo = new System.Windows.Forms.Label();
            this.label_admin_prihlasenie = new System.Windows.Forms.Label();
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
            this.panel_bocny.Controls.Add(this.label_otestujte_sa);
            this.panel_bocny.Controls.Add(this.label_predmet);
            this.panel_bocny.Controls.Add(this.comboBox_predmety);
            this.panel_bocny.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bocny.Location = new System.Drawing.Point(0, 0);
            this.panel_bocny.Name = "panel_bocny";
            this.panel_bocny.Size = new System.Drawing.Size(200, 401);
            this.panel_bocny.TabIndex = 0;
            // 
            // label_otestujte_sa
            // 
            this.label_otestujte_sa.AutoSize = true;
            this.label_otestujte_sa.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_otestujte_sa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_otestujte_sa.Location = new System.Drawing.Point(19, 223);
            this.label_otestujte_sa.Name = "label_otestujte_sa";
            this.label_otestujte_sa.Size = new System.Drawing.Size(135, 27);
            this.label_otestujte_sa.TabIndex = 20;
            this.label_otestujte_sa.Text = "Otestujte sa!";
            // 
            // label_predmet
            // 
            this.label_predmet.AutoSize = true;
            this.label_predmet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label_predmet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_predmet.Location = new System.Drawing.Point(26, 147);
            this.label_predmet.Name = "label_predmet";
            this.label_predmet.Size = new System.Drawing.Size(128, 19);
            this.label_predmet.TabIndex = 19;
            this.label_predmet.Text = "vyberte si predmet";
            // 
            // comboBox_predmety
            // 
            this.comboBox_predmety.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_predmety.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_predmety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_predmety.FocusedColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_predmety.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_predmety.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_predmety.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_predmety.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_predmety.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_predmety.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_predmety.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_predmety.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_predmety.ItemHeight = 30;
            this.comboBox_predmety.Location = new System.Drawing.Point(30, 174);
            this.comboBox_predmety.Name = "comboBox_predmety";
            this.comboBox_predmety.Size = new System.Drawing.Size(140, 36);
            this.comboBox_predmety.TabIndex = 18;
            // 
            // label_nazov
            // 
            this.label_nazov.AutoSize = true;
            this.label_nazov.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold);
            this.label_nazov.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_nazov.Location = new System.Drawing.Point(308, 8);
            this.label_nazov.Name = "label_nazov";
            this.label_nazov.Size = new System.Drawing.Size(304, 27);
            this.label_nazov.TabIndex = 4;
            this.label_nazov.Text = "SYSTÉM ONLINE TESTOVANIA";
            // 
            // textBox_meno
            // 
            this.textBox_meno.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_meno.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_meno.DefaultText = "";
            this.textBox_meno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_meno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_meno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_meno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_meno.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_meno.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_meno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_meno.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno.Location = new System.Drawing.Point(275, 179);
            this.textBox_meno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_meno.Name = "textBox_meno";
            this.textBox_meno.PasswordChar = '\0';
            this.textBox_meno.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno.PlaceholderText = "Užívateľské meno";
            this.textBox_meno.SelectedText = "";
            this.textBox_meno.Size = new System.Drawing.Size(363, 34);
            this.textBox_meno.TabIndex = 13;
            this.textBox_meno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.textBox_heslo.Location = new System.Drawing.Point(275, 261);
            this.textBox_heslo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_heslo.Name = "textBox_heslo";
            this.textBox_heslo.PasswordChar = '\0';
            this.textBox_heslo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.PlaceholderText = "Heslo";
            this.textBox_heslo.SelectedText = "";
            this.textBox_heslo.Size = new System.Drawing.Size(363, 34);
            this.textBox_heslo.TabIndex = 14;
            this.textBox_heslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.button_prihlasenie.Location = new System.Drawing.Point(377, 310);
            this.button_prihlasenie.Name = "button_prihlasenie";
            this.button_prihlasenie.Size = new System.Drawing.Size(160, 47);
            this.button_prihlasenie.TabIndex = 20;
            this.button_prihlasenie.Text = "PRIHLÁSIŤ SA";
            this.button_prihlasenie.Click += new System.EventHandler(this.button_prihlasenie_Click);
            // 
            // label_meno
            // 
            this.label_meno.AutoSize = true;
            this.label_meno.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_meno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_meno.Location = new System.Drawing.Point(271, 150);
            this.label_meno.Name = "label_meno";
            this.label_meno.Size = new System.Drawing.Size(172, 20);
            this.label_meno.TabIndex = 21;
            this.label_meno.Text = "Zadajte Užívateľské meno";
            // 
            // label_heslo
            // 
            this.label_heslo.AutoSize = true;
            this.label_heslo.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_heslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_heslo.Location = new System.Drawing.Point(271, 231);
            this.label_heslo.Name = "label_heslo";
            this.label_heslo.Size = new System.Drawing.Size(95, 20);
            this.label_heslo.TabIndex = 22;
            this.label_heslo.Text = "Zadajte Heslo";
            // 
            // label_admin_prihlasenie
            // 
            this.label_admin_prihlasenie.AutoSize = true;
            this.label_admin_prihlasenie.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_admin_prihlasenie.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_admin_prihlasenie.Location = new System.Drawing.Point(424, 364);
            this.label_admin_prihlasenie.Name = "label_admin_prihlasenie";
            this.label_admin_prihlasenie.Size = new System.Drawing.Size(72, 25);
            this.label_admin_prihlasenie.TabIndex = 29;
            this.label_admin_prihlasenie.Text = "ADMIN";
            this.label_admin_prihlasenie.Click += new System.EventHandler(this.label_admin_prihlasenie_Click);
            // 
            // pictureBox_ukoncit
            // 
            this.pictureBox_ukoncit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ukoncit.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.ukoncit;
            this.pictureBox_ukoncit.ImageRotate = 0F;
            this.pictureBox_ukoncit.Location = new System.Drawing.Point(676, 10);
            this.pictureBox_ukoncit.Name = "pictureBox_ukoncit";
            this.pictureBox_ukoncit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_ukoncit.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_ukoncit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_ukoncit.TabIndex = 28;
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
            this.pictureBox_uvod.Location = new System.Drawing.Point(419, 49);
            this.pictureBox_uvod.Name = "pictureBox_uvod";
            this.pictureBox_uvod.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_uvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_uvod.TabIndex = 27;
            this.pictureBox_uvod.TabStop = false;
            this.pictureBox_uvod.UseTransparentBackground = true;
            // 
            // Form_Prihlasenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 401);
            this.Controls.Add(this.label_admin_prihlasenie);
            this.Controls.Add(this.pictureBox_ukoncit);
            this.Controls.Add(this.pictureBox_uvod);
            this.Controls.Add(this.label_heslo);
            this.Controls.Add(this.label_meno);
            this.Controls.Add(this.button_prihlasenie);
            this.Controls.Add(this.textBox_heslo);
            this.Controls.Add(this.textBox_meno);
            this.Controls.Add(this.label_nazov);
            this.Controls.Add(this.panel_bocny);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Prihlasenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Prihlasenie";
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ukoncit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bocny;
        private System.Windows.Forms.Label label_nazov;
        private Guna.UI2.WinForms.Guna2TextBox textBox_meno;
        private Guna.UI2.WinForms.Guna2TextBox textBox_heslo;
        private Guna.UI2.WinForms.Guna2GradientButton button_prihlasenie;
        private System.Windows.Forms.Label label_meno;
        private System.Windows.Forms.Label label_heslo;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_uvod;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_predmety;
        private System.Windows.Forms.Label label_predmet;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_ukoncit;
        private System.Windows.Forms.Label label_otestujte_sa;
        private System.Windows.Forms.Label label_admin_prihlasenie;
    }
}