namespace p65_72_Korabsky_Pavol
{
    partial class Ucitel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucitel));
            this.panel_ucitel_main = new System.Windows.Forms.Panel();
            this.pictureBox_koniec = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_ucitel_sidebar = new System.Windows.Forms.Panel();
            this.button_odhlasit_sa = new Guna.UI2.WinForms.Guna2Button();
            this.button_vysledky_studentov = new Guna.UI2.WinForms.Guna2Button();
            this.button_zobrazit_vymazat_otazku = new Guna.UI2.WinForms.Guna2Button();
            this.button_aktualizovat_otazku = new Guna.UI2.WinForms.Guna2Button();
            this.button_pridat_otazku = new Guna.UI2.WinForms.Guna2Button();
            this.label_ucitel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_PridatNovuOtazku1 = new p65_72_Korabsky_Pavol.Ucitel_UC.UC_PridatNovuOtazku();
            this.uC_AktualizovatOtazku1 = new p65_72_Korabsky_Pavol.Ucitel_UC.UC_AktualizovatOtazku();
            this.panel_ucitel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_koniec)).BeginInit();
            this.panel_ucitel_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ucitel_main
            // 
            this.panel_ucitel_main.BackgroundImage = global::p65_72_Korabsky_Pavol.Properties.Resources.ucitel_tema;
            this.panel_ucitel_main.Controls.Add(this.uC_AktualizovatOtazku1);
            this.panel_ucitel_main.Controls.Add(this.uC_PridatNovuOtazku1);
            this.panel_ucitel_main.Location = new System.Drawing.Point(265, 0);
            this.panel_ucitel_main.Name = "panel_ucitel_main";
            this.panel_ucitel_main.Size = new System.Drawing.Size(1035, 700);
            this.panel_ucitel_main.TabIndex = 1;
            // 
            // pictureBox_koniec
            // 
            this.pictureBox_koniec.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_koniec.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox_koniec.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.koniec_programu;
            this.pictureBox_koniec.ImageRotate = 0F;
            this.pictureBox_koniec.Location = new System.Drawing.Point(118, 648);
            this.pictureBox_koniec.Name = "pictureBox_koniec";
            this.pictureBox_koniec.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_koniec.Size = new System.Drawing.Size(32, 40);
            this.pictureBox_koniec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_koniec.TabIndex = 0;
            this.pictureBox_koniec.TabStop = false;
            this.pictureBox_koniec.UseTransparentBackground = true;
            this.pictureBox_koniec.Click += new System.EventHandler(this.pictureBox_koniec_Click);
            // 
            // panel_ucitel_sidebar
            // 
            this.panel_ucitel_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.panel_ucitel_sidebar.BackgroundImage = global::p65_72_Korabsky_Pavol.Properties.Resources.ucitel_sidebar;
            this.panel_ucitel_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ucitel_sidebar.Controls.Add(this.pictureBox_koniec);
            this.panel_ucitel_sidebar.Controls.Add(this.button_odhlasit_sa);
            this.panel_ucitel_sidebar.Controls.Add(this.button_vysledky_studentov);
            this.panel_ucitel_sidebar.Controls.Add(this.button_zobrazit_vymazat_otazku);
            this.panel_ucitel_sidebar.Controls.Add(this.button_aktualizovat_otazku);
            this.panel_ucitel_sidebar.Controls.Add(this.button_pridat_otazku);
            this.panel_ucitel_sidebar.Controls.Add(this.label_ucitel);
            this.panel_ucitel_sidebar.Controls.Add(this.pictureBox1);
            this.panel_ucitel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_ucitel_sidebar.Name = "panel_ucitel_sidebar";
            this.panel_ucitel_sidebar.Size = new System.Drawing.Size(267, 700);
            this.panel_ucitel_sidebar.TabIndex = 0;
            // 
            // button_odhlasit_sa
            // 
            this.button_odhlasit_sa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_odhlasit_sa.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_odhlasit_sa.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_odhlasit_sa.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_odhlasit_sa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_odhlasit_sa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_odhlasit_sa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_odhlasit_sa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_odhlasit_sa.FillColor = System.Drawing.Color.Transparent;
            this.button_odhlasit_sa.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_odhlasit_sa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_odhlasit_sa.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.odhlasit_sa;
            this.button_odhlasit_sa.Location = new System.Drawing.Point(12, 588);
            this.button_odhlasit_sa.Name = "button_odhlasit_sa";
            this.button_odhlasit_sa.Size = new System.Drawing.Size(255, 54);
            this.button_odhlasit_sa.TabIndex = 6;
            this.button_odhlasit_sa.Text = "Odhlásiť sa";
            // 
            // button_vysledky_studentov
            // 
            this.button_vysledky_studentov.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_vysledky_studentov.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_vysledky_studentov.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_vysledky_studentov.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_vysledky_studentov.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_vysledky_studentov.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_vysledky_studentov.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_vysledky_studentov.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_vysledky_studentov.FillColor = System.Drawing.Color.Transparent;
            this.button_vysledky_studentov.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_vysledky_studentov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_vysledky_studentov.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.vysledky_studentov;
            this.button_vysledky_studentov.Location = new System.Drawing.Point(12, 510);
            this.button_vysledky_studentov.Name = "button_vysledky_studentov";
            this.button_vysledky_studentov.Size = new System.Drawing.Size(255, 54);
            this.button_vysledky_studentov.TabIndex = 5;
            this.button_vysledky_studentov.Text = "Výsledky študentov";
            // 
            // button_zobrazit_vymazat_otazku
            // 
            this.button_zobrazit_vymazat_otazku.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_zobrazit_vymazat_otazku.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_zobrazit_vymazat_otazku.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_zobrazit_vymazat_otazku.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_zobrazit_vymazat_otazku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_zobrazit_vymazat_otazku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_zobrazit_vymazat_otazku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_zobrazit_vymazat_otazku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_zobrazit_vymazat_otazku.FillColor = System.Drawing.Color.Transparent;
            this.button_zobrazit_vymazat_otazku.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zobrazit_vymazat_otazku.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_zobrazit_vymazat_otazku.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.zobrazit_vymazat_otazky;
            this.button_zobrazit_vymazat_otazku.Location = new System.Drawing.Point(12, 432);
            this.button_zobrazit_vymazat_otazku.Name = "button_zobrazit_vymazat_otazku";
            this.button_zobrazit_vymazat_otazku.Size = new System.Drawing.Size(255, 54);
            this.button_zobrazit_vymazat_otazku.TabIndex = 4;
            this.button_zobrazit_vymazat_otazku.Text = "Zobraziť/Vymazať otázky";
            // 
            // button_aktualizovat_otazku
            // 
            this.button_aktualizovat_otazku.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_aktualizovat_otazku.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_aktualizovat_otazku.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_aktualizovat_otazku.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_aktualizovat_otazku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_aktualizovat_otazku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_aktualizovat_otazku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_aktualizovat_otazku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_aktualizovat_otazku.FillColor = System.Drawing.Color.Transparent;
            this.button_aktualizovat_otazku.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_aktualizovat_otazku.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_aktualizovat_otazku.Image = ((System.Drawing.Image)(resources.GetObject("button_aktualizovat_otazku.Image")));
            this.button_aktualizovat_otazku.Location = new System.Drawing.Point(12, 354);
            this.button_aktualizovat_otazku.Name = "button_aktualizovat_otazku";
            this.button_aktualizovat_otazku.Size = new System.Drawing.Size(255, 54);
            this.button_aktualizovat_otazku.TabIndex = 3;
            this.button_aktualizovat_otazku.Text = "Aktualizovať otázku";
            this.button_aktualizovat_otazku.Click += new System.EventHandler(this.button_aktualizovat_otazku_Click);
            // 
            // button_pridat_otazku
            // 
            this.button_pridat_otazku.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_pridat_otazku.CheckedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_pridat_otazku.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_pridat_otazku.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_pridat_otazku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_pridat_otazku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_pridat_otazku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_pridat_otazku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_pridat_otazku.FillColor = System.Drawing.Color.Transparent;
            this.button_pridat_otazku.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pridat_otazku.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_pridat_otazku.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.pridat_otazku;
            this.button_pridat_otazku.Location = new System.Drawing.Point(12, 276);
            this.button_pridat_otazku.Name = "button_pridat_otazku";
            this.button_pridat_otazku.Size = new System.Drawing.Size(255, 54);
            this.button_pridat_otazku.TabIndex = 2;
            this.button_pridat_otazku.Text = "Pridať novú otázku";
            this.button_pridat_otazku.Click += new System.EventHandler(this.button_pridat_otazku_Click);
            // 
            // label_ucitel
            // 
            this.label_ucitel.AutoSize = true;
            this.label_ucitel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ucitel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_ucitel.Location = new System.Drawing.Point(89, 217);
            this.label_ucitel.Name = "label_ucitel";
            this.label_ucitel.Size = new System.Drawing.Size(88, 34);
            this.label_ucitel.TabIndex = 1;
            this.label_ucitel.Text = "Učiteľ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.ucitel;
            this.pictureBox1.Location = new System.Drawing.Point(32, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel_ucitel_main;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel_ucitel_main;
            // 
            // uC_PridatNovuOtazku1
            // 
            this.uC_PridatNovuOtazku1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_PridatNovuOtazku1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uC_PridatNovuOtazku1.Location = new System.Drawing.Point(1, 0);
            this.uC_PridatNovuOtazku1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_PridatNovuOtazku1.Name = "uC_PridatNovuOtazku1";
            this.uC_PridatNovuOtazku1.Size = new System.Drawing.Size(1035, 700);
            this.uC_PridatNovuOtazku1.TabIndex = 1;
            // 
            // uC_AktualizovatOtazku1
            // 
            this.uC_AktualizovatOtazku1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uC_AktualizovatOtazku1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uC_AktualizovatOtazku1.Location = new System.Drawing.Point(0, 0);
            this.uC_AktualizovatOtazku1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AktualizovatOtazku1.Name = "uC_AktualizovatOtazku1";
            this.uC_AktualizovatOtazku1.Size = new System.Drawing.Size(1035, 700);
            this.uC_AktualizovatOtazku1.TabIndex = 2;
            // 
            // Ucitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel_ucitel_main);
            this.Controls.Add(this.panel_ucitel_sidebar);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ucitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Učiteľ";
            this.Load += new System.EventHandler(this.Ucitel_Load);
            this.panel_ucitel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_koniec)).EndInit();
            this.panel_ucitel_sidebar.ResumeLayout(false);
            this.panel_ucitel_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ucitel_sidebar;
        private System.Windows.Forms.Panel panel_ucitel_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_ucitel;
        private Guna.UI2.WinForms.Guna2Button button_pridat_otazku;
        private Guna.UI2.WinForms.Guna2Button button_odhlasit_sa;
        private Guna.UI2.WinForms.Guna2Button button_vysledky_studentov;
        private Guna.UI2.WinForms.Guna2Button button_zobrazit_vymazat_otazku;
        private Guna.UI2.WinForms.Guna2Button button_aktualizovat_otazku;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_koniec;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Ucitel_UC.UC_PridatNovuOtazku uC_PridatNovuOtazku1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Ucitel_UC.UC_AktualizovatOtazku uC_AktualizovatOtazku1;
    }
}