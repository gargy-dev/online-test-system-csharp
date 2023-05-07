namespace p65_72_Korabsky_Pavol
{
    partial class Form_Predmety
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
            this.label_odhlasenie = new System.Windows.Forms.Label();
            this.label_student = new System.Windows.Forms.Label();
            this.label_zoznam_predmetov = new System.Windows.Forms.Label();
            this.PredmetyDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_reset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button_upravit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button_ulozit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label_predmet1 = new System.Windows.Forms.Label();
            this.oddelovac2 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBox_nazov_predmetu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_studenti = new System.Windows.Forms.Label();
            this.label_o_programe = new System.Windows.Forms.Label();
            this.label_predmety = new System.Windows.Forms.Label();
            this.label_otazky = new System.Windows.Forms.Label();
            this.label_nazov = new System.Windows.Forms.Label();
            this.panel_bocny = new System.Windows.Forms.Panel();
            this.pictureBox_o_programe = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_odhlasenie = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_student = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox_predmet = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_hlavny = new System.Windows.Forms.Panel();
            this.panel_pozadie = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PredmetyDGV)).BeginInit();
            this.panel_bocny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmet)).BeginInit();
            this.panel_hlavny.SuspendLayout();
            this.panel_pozadie.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_odhlasenie
            // 
            this.label_odhlasenie.AutoSize = true;
            this.label_odhlasenie.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_odhlasenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_odhlasenie.Location = new System.Drawing.Point(71, 312);
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
            this.label_student.Location = new System.Drawing.Point(71, 233);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(92, 34);
            this.label_student.TabIndex = 29;
            this.label_student.Text = "Študenti";
            this.label_student.Click += new System.EventHandler(this.label_student_Click);
            // 
            // label_zoznam_predmetov
            // 
            this.label_zoznam_predmetov.AutoSize = true;
            this.label_zoznam_predmetov.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zoznam_predmetov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_zoznam_predmetov.Location = new System.Drawing.Point(609, 291);
            this.label_zoznam_predmetov.Name = "label_zoznam_predmetov";
            this.label_zoznam_predmetov.Size = new System.Drawing.Size(236, 28);
            this.label_zoznam_predmetov.TabIndex = 23;
            this.label_zoznam_predmetov.Text = "ZOZNAM PREDMETOV";
            // 
            // PredmetyDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PredmetyDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PredmetyDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PredmetyDGV.ColumnHeadersHeight = 24;
            this.PredmetyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PredmetyDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PredmetyDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PredmetyDGV.Location = new System.Drawing.Point(203, 322);
            this.PredmetyDGV.Name = "PredmetyDGV";
            this.PredmetyDGV.RowHeadersVisible = false;
            this.PredmetyDGV.RowHeadersWidth = 51;
            this.PredmetyDGV.RowTemplate.Height = 24;
            this.PredmetyDGV.Size = new System.Drawing.Size(1043, 330);
            this.PredmetyDGV.TabIndex = 22;
            this.PredmetyDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PredmetyDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PredmetyDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PredmetyDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PredmetyDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PredmetyDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PredmetyDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PredmetyDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PredmetyDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PredmetyDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PredmetyDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PredmetyDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PredmetyDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.PredmetyDGV.ThemeStyle.ReadOnly = false;
            this.PredmetyDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PredmetyDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PredmetyDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PredmetyDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PredmetyDGV.ThemeStyle.RowsStyle.Height = 24;
            this.PredmetyDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PredmetyDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PredmetyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PredmetyDGV_CellContentClick);
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
            this.button_reset.Location = new System.Drawing.Point(800, 164);
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
            this.button_upravit.Location = new System.Drawing.Point(671, 164);
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
            this.button_ulozit.Location = new System.Drawing.Point(542, 164);
            this.button_ulozit.Name = "button_ulozit";
            this.button_ulozit.Size = new System.Drawing.Size(110, 34);
            this.button_ulozit.TabIndex = 19;
            this.button_ulozit.Text = "Uložiť";
            this.button_ulozit.Click += new System.EventHandler(this.button_ulozit_Click);
            // 
            // label_predmet1
            // 
            this.label_predmet1.AutoSize = true;
            this.label_predmet1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_predmet1.Location = new System.Drawing.Point(71, 154);
            this.label_predmet1.Name = "label_predmet1";
            this.label_predmet1.Size = new System.Drawing.Size(104, 34);
            this.label_predmet1.TabIndex = 27;
            this.label_predmet1.Text = "Predmety";
            // 
            // oddelovac2
            // 
            this.oddelovac2.Location = new System.Drawing.Point(685, 57);
            this.oddelovac2.Name = "oddelovac2";
            this.oddelovac2.Size = new System.Drawing.Size(92, 10);
            this.oddelovac2.TabIndex = 9;
            // 
            // textBox_nazov_predmetu
            // 
            this.textBox_nazov_predmetu.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_nazov_predmetu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_nazov_predmetu.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_nazov_predmetu.DefaultText = "";
            this.textBox_nazov_predmetu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_nazov_predmetu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_nazov_predmetu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nazov_predmetu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nazov_predmetu.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_nazov_predmetu.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nazov_predmetu.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nazov_predmetu.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_nazov_predmetu.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_nazov_predmetu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_nazov_predmetu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nazov_predmetu.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nazov_predmetu.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nazov_predmetu.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_nazov_predmetu.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_nazov_predmetu.Location = new System.Drawing.Point(556, 93);
            this.textBox_nazov_predmetu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_nazov_predmetu.Name = "textBox_nazov_predmetu";
            this.textBox_nazov_predmetu.PasswordChar = '\0';
            this.textBox_nazov_predmetu.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nazov_predmetu.PlaceholderText = "NÁZOV PREDMETU";
            this.textBox_nazov_predmetu.SelectedText = "";
            this.textBox_nazov_predmetu.Size = new System.Drawing.Size(345, 38);
            this.textBox_nazov_predmetu.TabIndex = 8;
            this.textBox_nazov_predmetu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label_studenti.Click += new System.EventHandler(this.label_studenti_Click);
            // 
            // label_o_programe
            // 
            this.label_o_programe.AutoSize = true;
            this.label_o_programe.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_o_programe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_o_programe.Location = new System.Drawing.Point(71, 391);
            this.label_o_programe.Name = "label_o_programe";
            this.label_o_programe.Size = new System.Drawing.Size(125, 34);
            this.label_o_programe.TabIndex = 33;
            this.label_o_programe.Text = "O programe";
            this.label_o_programe.Click += new System.EventHandler(this.label_o_programe_Click);
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
            this.pictureBox_o_programe.Location = new System.Drawing.Point(36, 392);
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
            this.pictureBox_odhlasenie.Location = new System.Drawing.Point(36, 315);
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
            this.pictureBox_student.Location = new System.Drawing.Point(36, 236);
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
            this.pictureBox_predmet.Location = new System.Drawing.Point(36, 160);
            this.pictureBox_predmet.Name = "pictureBox_predmet";
            this.pictureBox_predmet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_predmet.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_predmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_predmet.TabIndex = 28;
            this.pictureBox_predmet.TabStop = false;
            this.pictureBox_predmet.UseTransparentBackground = true;
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
            this.panel_pozadie.Controls.Add(this.label_zoznam_predmetov);
            this.panel_pozadie.Controls.Add(this.PredmetyDGV);
            this.panel_pozadie.Controls.Add(this.button_reset);
            this.panel_pozadie.Controls.Add(this.button_upravit);
            this.panel_pozadie.Controls.Add(this.button_ulozit);
            this.panel_pozadie.Controls.Add(this.oddelovac2);
            this.panel_pozadie.Controls.Add(this.textBox_nazov_predmetu);
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
            // Form_Predmety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 661);
            this.Controls.Add(this.panel_hlavny);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Predmety";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predmety";
            ((System.ComponentModel.ISupportInitialize)(this.PredmetyDGV)).EndInit();
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmet)).EndInit();
            this.panel_hlavny.ResumeLayout(false);
            this.panel_pozadie.ResumeLayout(false);
            this.panel_pozadie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_odhlasenie;
        private System.Windows.Forms.Label label_student;
        private System.Windows.Forms.Label label_zoznam_predmetov;
        private Guna.UI2.WinForms.Guna2DataGridView PredmetyDGV;
        private Guna.UI2.WinForms.Guna2GradientButton button_reset;
        private Guna.UI2.WinForms.Guna2GradientButton button_upravit;
        private Guna.UI2.WinForms.Guna2GradientButton button_ulozit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_student;
        private System.Windows.Forms.Label label_predmet1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_predmet;
        private Guna.UI2.WinForms.Guna2Separator oddelovac2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_odhlasenie;
        private Guna.UI2.WinForms.Guna2TextBox textBox_nazov_predmetu;
        private System.Windows.Forms.Label label_studenti;
        private System.Windows.Forms.Label label_o_programe;
        private System.Windows.Forms.Label label_predmety;
        private System.Windows.Forms.Label label_otazky;
        private System.Windows.Forms.Label label_nazov;
        private System.Windows.Forms.Panel panel_bocny;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_o_programe;
        private System.Windows.Forms.Panel panel_hlavny;
        private System.Windows.Forms.Panel panel_pozadie;
    }
}