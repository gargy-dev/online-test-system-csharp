namespace p65_72_Korabsky_Pavol
{
    partial class Form_Studenti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_o_programe = new System.Windows.Forms.Label();
            this.label_zoznam_studentov = new System.Windows.Forms.Label();
            this.StudentiDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_reset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button_upravit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button_ulozit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label_odhlasenie = new System.Windows.Forms.Label();
            this.label_student = new System.Windows.Forms.Label();
            this.label_predmet1 = new System.Windows.Forms.Label();
            this.panel_hlavny = new System.Windows.Forms.Panel();
            this.panel_pozadie = new System.Windows.Forms.Panel();
            this.label_vysledky = new System.Windows.Forms.Label();
            this.textBox_mobil = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_heslo = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_adresa = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_vek = new Guna.UI2.WinForms.Guna2TextBox();
            this.oddelovac3 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBox_meno_priezvisko = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_studenti = new System.Windows.Forms.Label();
            this.label_predmety = new System.Windows.Forms.Label();
            this.label_otazky = new System.Windows.Forms.Label();
            this.label_nazov = new System.Windows.Forms.Label();
            this.panel_bocny = new System.Windows.Forms.Panel();
            this.pictureBox_o_programe = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_odhlasenie = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_student = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_predmet = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentiDGV)).BeginInit();
            this.panel_hlavny.SuspendLayout();
            this.panel_pozadie.SuspendLayout();
            this.panel_bocny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_o_programe
            // 
            this.label_o_programe.AutoSize = true;
            this.label_o_programe.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_o_programe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_o_programe.Location = new System.Drawing.Point(66, 392);
            this.label_o_programe.Name = "label_o_programe";
            this.label_o_programe.Size = new System.Drawing.Size(125, 34);
            this.label_o_programe.TabIndex = 33;
            this.label_o_programe.Text = "O programe";
            this.label_o_programe.Click += new System.EventHandler(this.label_o_programe_Click);
            // 
            // label_zoznam_studentov
            // 
            this.label_zoznam_studentov.AutoSize = true;
            this.label_zoznam_studentov.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zoznam_studentov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_zoznam_studentov.Location = new System.Drawing.Point(605, 291);
            this.label_zoznam_studentov.Name = "label_zoznam_studentov";
            this.label_zoznam_studentov.Size = new System.Drawing.Size(232, 28);
            this.label_zoznam_studentov.TabIndex = 23;
            this.label_zoznam_studentov.Text = "ZOZNAM ŠTUDENTOV";
            // 
            // StudentiDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.StudentiDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentiDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentiDGV.ColumnHeadersHeight = 25;
            this.StudentiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentiDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.StudentiDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentiDGV.Location = new System.Drawing.Point(203, 322);
            this.StudentiDGV.Name = "StudentiDGV";
            this.StudentiDGV.RowHeadersVisible = false;
            this.StudentiDGV.RowHeadersWidth = 51;
            this.StudentiDGV.RowTemplate.Height = 24;
            this.StudentiDGV.Size = new System.Drawing.Size(1043, 330);
            this.StudentiDGV.TabIndex = 22;
            this.StudentiDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentiDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentiDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentiDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentiDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentiDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudentiDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentiDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.StudentiDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudentiDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentiDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StudentiDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentiDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.StudentiDGV.ThemeStyle.ReadOnly = false;
            this.StudentiDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentiDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentiDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StudentiDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StudentiDGV.ThemeStyle.RowsStyle.Height = 24;
            this.StudentiDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentiDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentiDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentiDGV_CellContentClick);
            // 
            // button_reset
            // 
            this.button_reset.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_reset.BorderRadius = 13;
            this.button_reset.BorderThickness = 1;
            this.button_reset.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_reset.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_reset.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_reset.CheckedState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_reset.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_reset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_reset.FillColor = System.Drawing.Color.DodgerBlue;
            this.button_reset.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.button_reset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_reset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_reset.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_reset.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_reset.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_reset.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_reset.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_reset.Location = new System.Drawing.Point(800, 206);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(110, 34);
            this.button_reset.TabIndex = 21;
            this.button_reset.Text = "Reset";
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_upravit
            // 
            this.button_upravit.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_upravit.BorderRadius = 13;
            this.button_upravit.BorderThickness = 1;
            this.button_upravit.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_upravit.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_upravit.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_upravit.CheckedState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_upravit.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_upravit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_upravit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_upravit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_upravit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_upravit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_upravit.FillColor = System.Drawing.Color.DodgerBlue;
            this.button_upravit.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.button_upravit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_upravit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_upravit.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_upravit.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_upravit.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_upravit.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_upravit.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_upravit.Location = new System.Drawing.Point(671, 206);
            this.button_upravit.Name = "button_upravit";
            this.button_upravit.Size = new System.Drawing.Size(110, 34);
            this.button_upravit.TabIndex = 20;
            this.button_upravit.Text = "Upraviť";
            this.button_upravit.Click += new System.EventHandler(this.button_upravit_Click);
            // 
            // button_ulozit
            // 
            this.button_ulozit.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_ulozit.BorderRadius = 13;
            this.button_ulozit.BorderThickness = 1;
            this.button_ulozit.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_ulozit.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_ulozit.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_ulozit.CheckedState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_ulozit.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ulozit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_ulozit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_ulozit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ulozit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_ulozit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_ulozit.FillColor = System.Drawing.Color.DodgerBlue;
            this.button_ulozit.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.button_ulozit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_ulozit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_ulozit.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button_ulozit.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_ulozit.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_ulozit.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.button_ulozit.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ulozit.Location = new System.Drawing.Point(542, 206);
            this.button_ulozit.Name = "button_ulozit";
            this.button_ulozit.Size = new System.Drawing.Size(110, 34);
            this.button_ulozit.TabIndex = 19;
            this.button_ulozit.Text = "Uložiť";
            this.button_ulozit.Click += new System.EventHandler(this.button_ulozit_Click);
            // 
            // label_odhlasenie
            // 
            this.label_odhlasenie.AutoSize = true;
            this.label_odhlasenie.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_odhlasenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_odhlasenie.Location = new System.Drawing.Point(66, 313);
            this.label_odhlasenie.Name = "label_odhlasenie";
            this.label_odhlasenie.Size = new System.Drawing.Size(119, 34);
            this.label_odhlasenie.TabIndex = 31;
            this.label_odhlasenie.Text = "Odhlásiť sa";
            this.label_odhlasenie.Click += new System.EventHandler(this.label_odhlasenie_Click);
            // 
            // label_student
            // 
            this.label_student.AutoSize = true;
            this.label_student.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_student.Location = new System.Drawing.Point(66, 234);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(92, 34);
            this.label_student.TabIndex = 29;
            this.label_student.Text = "Študenti";
            // 
            // label_predmet1
            // 
            this.label_predmet1.AutoSize = true;
            this.label_predmet1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_predmet1.Location = new System.Drawing.Point(66, 155);
            this.label_predmet1.Name = "label_predmet1";
            this.label_predmet1.Size = new System.Drawing.Size(104, 34);
            this.label_predmet1.TabIndex = 27;
            this.label_predmet1.Text = "Predmety";
            this.label_predmet1.Click += new System.EventHandler(this.label_predmet1_Click);
            // 
            // panel_hlavny
            // 
            this.panel_hlavny.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_hlavny.Controls.Add(this.panel_pozadie);
            this.panel_hlavny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_hlavny.Location = new System.Drawing.Point(0, 0);
            this.panel_hlavny.Margin = new System.Windows.Forms.Padding(4);
            this.panel_hlavny.Name = "panel_hlavny";
            this.panel_hlavny.Size = new System.Drawing.Size(1255, 661);
            this.panel_hlavny.TabIndex = 1;
            // 
            // panel_pozadie
            // 
            this.panel_pozadie.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_pozadie.Controls.Add(this.label_vysledky);
            this.panel_pozadie.Controls.Add(this.label_zoznam_studentov);
            this.panel_pozadie.Controls.Add(this.StudentiDGV);
            this.panel_pozadie.Controls.Add(this.button_reset);
            this.panel_pozadie.Controls.Add(this.button_upravit);
            this.panel_pozadie.Controls.Add(this.button_ulozit);
            this.panel_pozadie.Controls.Add(this.textBox_mobil);
            this.panel_pozadie.Controls.Add(this.textBox_heslo);
            this.panel_pozadie.Controls.Add(this.textBox_adresa);
            this.panel_pozadie.Controls.Add(this.textBox_vek);
            this.panel_pozadie.Controls.Add(this.oddelovac3);
            this.panel_pozadie.Controls.Add(this.textBox_meno_priezvisko);
            this.panel_pozadie.Controls.Add(this.label_studenti);
            this.panel_pozadie.Controls.Add(this.label_predmety);
            this.panel_pozadie.Controls.Add(this.label_otazky);
            this.panel_pozadie.Controls.Add(this.label_nazov);
            this.panel_pozadie.Controls.Add(this.panel_bocny);
            this.panel_pozadie.Location = new System.Drawing.Point(3, 3);
            this.panel_pozadie.Name = "panel_pozadie";
            this.panel_pozadie.Size = new System.Drawing.Size(1249, 655);
            this.panel_pozadie.TabIndex = 0;
            // 
            // label_vysledky
            // 
            this.label_vysledky.AutoSize = true;
            this.label_vysledky.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vysledky.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_vysledky.Location = new System.Drawing.Point(914, 32);
            this.label_vysledky.Name = "label_vysledky";
            this.label_vysledky.Size = new System.Drawing.Size(91, 28);
            this.label_vysledky.TabIndex = 25;
            this.label_vysledky.Text = "Výsledky";
            this.label_vysledky.Click += new System.EventHandler(this.label_vysledky_Click);
            // 
            // textBox_mobil
            // 
            this.textBox_mobil.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_mobil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_mobil.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_mobil.DefaultText = "";
            this.textBox_mobil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_mobil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_mobil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_mobil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_mobil.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_mobil.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mobil.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mobil.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_mobil.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_mobil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_mobil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mobil.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mobil.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mobil.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_mobil.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_mobil.Location = new System.Drawing.Point(930, 149);
            this.textBox_mobil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_mobil.Name = "textBox_mobil";
            this.textBox_mobil.PasswordChar = '\0';
            this.textBox_mobil.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_mobil.PlaceholderText = "mobil";
            this.textBox_mobil.SelectedText = "";
            this.textBox_mobil.Size = new System.Drawing.Size(155, 34);
            this.textBox_mobil.TabIndex = 15;
            this.textBox_mobil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.textBox_heslo.Location = new System.Drawing.Point(744, 149);
            this.textBox_heslo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_heslo.Name = "textBox_heslo";
            this.textBox_heslo.PasswordChar = '\0';
            this.textBox_heslo.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_heslo.PlaceholderText = "heslo";
            this.textBox_heslo.SelectedText = "";
            this.textBox_heslo.Size = new System.Drawing.Size(155, 34);
            this.textBox_heslo.TabIndex = 14;
            this.textBox_heslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_adresa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_adresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_adresa.DefaultText = "";
            this.textBox_adresa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_adresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_adresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_adresa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_adresa.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_adresa.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_adresa.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_adresa.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_adresa.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_adresa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_adresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_adresa.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_adresa.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_adresa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_adresa.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_adresa.Location = new System.Drawing.Point(558, 149);
            this.textBox_adresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.PasswordChar = '\0';
            this.textBox_adresa.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_adresa.PlaceholderText = "adresa";
            this.textBox_adresa.SelectedText = "";
            this.textBox_adresa.Size = new System.Drawing.Size(155, 34);
            this.textBox_adresa.TabIndex = 13;
            this.textBox_adresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_vek
            // 
            this.textBox_vek.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_vek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_vek.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_vek.DefaultText = "";
            this.textBox_vek.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_vek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_vek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_vek.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_vek.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_vek.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_vek.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_vek.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_vek.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_vek.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_vek.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_vek.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_vek.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_vek.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_vek.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_vek.Location = new System.Drawing.Point(372, 149);
            this.textBox_vek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_vek.Name = "textBox_vek";
            this.textBox_vek.PasswordChar = '\0';
            this.textBox_vek.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_vek.PlaceholderText = "vek";
            this.textBox_vek.SelectedText = "";
            this.textBox_vek.Size = new System.Drawing.Size(155, 34);
            this.textBox_vek.TabIndex = 12;
            this.textBox_vek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oddelovac3
            // 
            this.oddelovac3.Location = new System.Drawing.Point(812, 55);
            this.oddelovac3.Name = "oddelovac3";
            this.oddelovac3.Size = new System.Drawing.Size(84, 10);
            this.oddelovac3.TabIndex = 10;
            // 
            // textBox_meno_priezvisko
            // 
            this.textBox_meno_priezvisko.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno_priezvisko.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_meno_priezvisko.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_meno_priezvisko.DefaultText = "";
            this.textBox_meno_priezvisko.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_meno_priezvisko.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_meno_priezvisko.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_meno_priezvisko.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_meno_priezvisko.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno_priezvisko.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno_priezvisko.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno_priezvisko.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_meno_priezvisko.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno_priezvisko.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_meno_priezvisko.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno_priezvisko.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno_priezvisko.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno_priezvisko.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_meno_priezvisko.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_meno_priezvisko.Location = new System.Drawing.Point(556, 93);
            this.textBox_meno_priezvisko.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_meno_priezvisko.Name = "textBox_meno_priezvisko";
            this.textBox_meno_priezvisko.PasswordChar = '\0';
            this.textBox_meno_priezvisko.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_meno_priezvisko.PlaceholderText = "MENO A PRIEZVISKO";
            this.textBox_meno_priezvisko.SelectedText = "";
            this.textBox_meno_priezvisko.Size = new System.Drawing.Size(345, 38);
            this.textBox_meno_priezvisko.TabIndex = 8;
            this.textBox_meno_priezvisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_studenti
            // 
            this.label_studenti.AutoSize = true;
            this.label_studenti.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_studenti.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_studenti.Location = new System.Drawing.Point(809, 32);
            this.label_studenti.Name = "label_studenti";
            this.label_studenti.Size = new System.Drawing.Size(87, 28);
            this.label_studenti.TabIndex = 4;
            this.label_studenti.Text = "Študenti";
            // 
            // label_predmety
            // 
            this.label_predmety.AutoSize = true;
            this.label_predmety.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmety.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_predmety.Location = new System.Drawing.Point(682, 32);
            this.label_predmety.Name = "label_predmety";
            this.label_predmety.Size = new System.Drawing.Size(99, 28);
            this.label_predmety.TabIndex = 3;
            this.label_predmety.Text = "Predmety";
            this.label_predmety.Click += new System.EventHandler(this.label_predmety_Click);
            // 
            // label_otazky
            // 
            this.label_otazky.AutoSize = true;
            this.label_otazky.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_otazky.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_otazky.Location = new System.Drawing.Point(575, 32);
            this.label_otazky.Name = "label_otazky";
            this.label_otazky.Size = new System.Drawing.Size(74, 28);
            this.label_otazky.TabIndex = 2;
            this.label_otazky.Text = "Otázky";
            this.label_otazky.Click += new System.EventHandler(this.label_otazky_Click);
            // 
            // label_nazov
            // 
            this.label_nazov.AutoSize = true;
            this.label_nazov.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_nazov.Location = new System.Drawing.Point(1113, 6);
            this.label_nazov.Name = "label_nazov";
            this.label_nazov.Size = new System.Drawing.Size(135, 34);
            this.label_nazov.TabIndex = 1;
            this.label_nazov.Text = "on-Test-line!";
            // 
            // panel_bocny
            // 
            this.panel_bocny.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_bocny.Controls.Add(this.label_o_programe);
            this.panel_bocny.Controls.Add(this.pictureBox_o_programe);
            this.panel_bocny.Controls.Add(this.label_odhlasenie);
            this.panel_bocny.Controls.Add(this.pictureBox_odhlasenie);
            this.panel_bocny.Controls.Add(this.label_student);
            this.panel_bocny.Controls.Add(this.pictureBox_student);
            this.panel_bocny.Controls.Add(this.label_predmet1);
            this.panel_bocny.Controls.Add(this.pictureBox_predmet);
            this.panel_bocny.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bocny.ForeColor = System.Drawing.Color.Silver;
            this.panel_bocny.Location = new System.Drawing.Point(0, 0);
            this.panel_bocny.Name = "panel_bocny";
            this.panel_bocny.Size = new System.Drawing.Size(200, 655);
            this.panel_bocny.TabIndex = 0;
            // 
            // pictureBox_o_programe
            // 
            this.pictureBox_o_programe.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_o_programe.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_o_programe.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.pomoc;
            this.pictureBox_o_programe.ImageRotate = 0F;
            this.pictureBox_o_programe.Location = new System.Drawing.Point(31, 393);
            this.pictureBox_o_programe.Name = "pictureBox_o_programe";
            this.pictureBox_o_programe.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_o_programe.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_o_programe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_o_programe.TabIndex = 34;
            this.pictureBox_o_programe.TabStop = false;
            this.pictureBox_o_programe.UseTransparentBackground = true;
            // 
            // pictureBox_odhlasenie
            // 
            this.pictureBox_odhlasenie.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_odhlasenie.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_odhlasenie.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.koniec;
            this.pictureBox_odhlasenie.ImageRotate = 0F;
            this.pictureBox_odhlasenie.Location = new System.Drawing.Point(31, 316);
            this.pictureBox_odhlasenie.Name = "pictureBox_odhlasenie";
            this.pictureBox_odhlasenie.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_odhlasenie.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_odhlasenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_odhlasenie.TabIndex = 32;
            this.pictureBox_odhlasenie.TabStop = false;
            this.pictureBox_odhlasenie.UseTransparentBackground = true;
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_student.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_student.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.student;
            this.pictureBox_student.ImageRotate = 0F;
            this.pictureBox_student.Location = new System.Drawing.Point(31, 237);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_student.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_student.TabIndex = 30;
            this.pictureBox_student.TabStop = false;
            this.pictureBox_student.UseTransparentBackground = true;
            // 
            // pictureBox_predmet
            // 
            this.pictureBox_predmet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_predmet.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_predmet.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.predmet;
            this.pictureBox_predmet.ImageRotate = 0F;
            this.pictureBox_predmet.Location = new System.Drawing.Point(31, 161);
            this.pictureBox_predmet.Name = "pictureBox_predmet";
            this.pictureBox_predmet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_predmet.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_predmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_predmet.TabIndex = 28;
            this.pictureBox_predmet.TabStop = false;
            this.pictureBox_predmet.UseTransparentBackground = true;
            // 
            // Form_Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 661);
            this.Controls.Add(this.panel_hlavny);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Studenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            ((System.ComponentModel.ISupportInitialize)(this.StudentiDGV)).EndInit();
            this.panel_hlavny.ResumeLayout(false);
            this.panel_pozadie.ResumeLayout(false);
            this.panel_pozadie.PerformLayout();
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_o_programe;
        private System.Windows.Forms.Label label_zoznam_studentov;
        private Guna.UI2.WinForms.Guna2DataGridView StudentiDGV;
        private Guna.UI2.WinForms.Guna2GradientButton button_reset;
        private Guna.UI2.WinForms.Guna2GradientButton button_upravit;
        private Guna.UI2.WinForms.Guna2GradientButton button_ulozit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_o_programe;
        private System.Windows.Forms.Label label_odhlasenie;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_odhlasenie;
        private System.Windows.Forms.Label label_student;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_student;
        private System.Windows.Forms.Label label_predmet1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_predmet;
        private System.Windows.Forms.Panel panel_hlavny;
        private System.Windows.Forms.Panel panel_pozadie;
        private Guna.UI2.WinForms.Guna2TextBox textBox_mobil;
        private Guna.UI2.WinForms.Guna2TextBox textBox_heslo;
        private Guna.UI2.WinForms.Guna2TextBox textBox_adresa;
        private Guna.UI2.WinForms.Guna2TextBox textBox_vek;
        private Guna.UI2.WinForms.Guna2Separator oddelovac3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_meno_priezvisko;
        private System.Windows.Forms.Label label_studenti;
        private System.Windows.Forms.Label label_predmety;
        private System.Windows.Forms.Label label_otazky;
        private System.Windows.Forms.Label label_nazov;
        private System.Windows.Forms.Panel panel_bocny;
        private System.Windows.Forms.Label label_vysledky;
    }
}