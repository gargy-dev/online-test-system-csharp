namespace p65_72_Korabsky_Pavol
{
    partial class Form_ZobrazVysledky
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_pozadie = new System.Windows.Forms.Panel();
            this.label_student_meno = new System.Windows.Forms.Label();
            this.comboBox_student = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_predmet = new System.Windows.Forms.Label();
            this.comboBox_predmety = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_vysledky = new System.Windows.Forms.Label();
            this.label_vysledky_studentov = new System.Windows.Forms.Label();
            this.VysledkyStudentovDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.oddelovac4 = new Guna.UI2.WinForms.Guna2Separator();
            this.label_studenti = new System.Windows.Forms.Label();
            this.label_predmety = new System.Windows.Forms.Label();
            this.label_otazky = new System.Windows.Forms.Label();
            this.label_nazov = new System.Windows.Forms.Label();
            this.panel_bocny = new System.Windows.Forms.Panel();
            this.label_o_programe = new System.Windows.Forms.Label();
            this.pictureBox_o_programe = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label_odhlasenie = new System.Windows.Forms.Label();
            this.pictureBox_odhlasenie = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label_student = new System.Windows.Forms.Label();
            this.pictureBox_student = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label_predmety1 = new System.Windows.Forms.Label();
            this.pictureBox_predmety = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_hlavny = new System.Windows.Forms.Panel();
            this.panel_pozadie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VysledkyStudentovDGV)).BeginInit();
            this.panel_bocny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmety)).BeginInit();
            this.panel_hlavny.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pozadie
            // 
            this.panel_pozadie.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_pozadie.Controls.Add(this.label_student_meno);
            this.panel_pozadie.Controls.Add(this.comboBox_student);
            this.panel_pozadie.Controls.Add(this.label_predmet);
            this.panel_pozadie.Controls.Add(this.comboBox_predmety);
            this.panel_pozadie.Controls.Add(this.label_vysledky);
            this.panel_pozadie.Controls.Add(this.label_vysledky_studentov);
            this.panel_pozadie.Controls.Add(this.VysledkyStudentovDGV);
            this.panel_pozadie.Controls.Add(this.oddelovac4);
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
            // label_student_meno
            // 
            this.label_student_meno.AutoSize = true;
            this.label_student_meno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_student_meno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_student_meno.Location = new System.Drawing.Point(849, 106);
            this.label_student_meno.Name = "label_student_meno";
            this.label_student_meno.Size = new System.Drawing.Size(82, 28);
            this.label_student_meno.TabIndex = 28;
            this.label_student_meno.Text = "Študent";
            // 
            // comboBox_student
            // 
            this.comboBox_student.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_student.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_student.FocusedColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_student.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_student.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_student.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_student.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_student.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_student.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_student.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox_student.ItemHeight = 30;
            this.comboBox_student.Location = new System.Drawing.Point(944, 103);
            this.comboBox_student.Name = "comboBox_student";
            this.comboBox_student.Size = new System.Drawing.Size(140, 36);
            this.comboBox_student.TabIndex = 27;
            this.comboBox_student.SelectionChangeCommitted += new System.EventHandler(this.comboBox_student_SelectionChangeCommitted);
            // 
            // label_predmet
            // 
            this.label_predmet.AutoSize = true;
            this.label_predmet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_predmet.Location = new System.Drawing.Point(357, 106);
            this.label_predmet.Name = "label_predmet";
            this.label_predmet.Size = new System.Drawing.Size(89, 28);
            this.label_predmet.TabIndex = 26;
            this.label_predmet.Text = "Predmet";
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
            this.comboBox_predmety.Location = new System.Drawing.Point(452, 103);
            this.comboBox_predmety.Name = "comboBox_predmety";
            this.comboBox_predmety.Size = new System.Drawing.Size(140, 36);
            this.comboBox_predmety.TabIndex = 25;
            this.comboBox_predmety.SelectionChangeCommitted += new System.EventHandler(this.comboBox_predmety_SelectionChangeCommitted);
            // 
            // label_vysledky
            // 
            this.label_vysledky.AutoSize = true;
            this.label_vysledky.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vysledky.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_vysledky.Location = new System.Drawing.Point(848, 32);
            this.label_vysledky.Name = "label_vysledky";
            this.label_vysledky.Size = new System.Drawing.Size(91, 28);
            this.label_vysledky.TabIndex = 24;
            this.label_vysledky.Text = "Výsledky";
            // 
            // label_vysledky_studentov
            // 
            this.label_vysledky_studentov.AutoSize = true;
            this.label_vysledky_studentov.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vysledky_studentov.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_vysledky_studentov.Location = new System.Drawing.Point(600, 73);
            this.label_vysledky_studentov.Name = "label_vysledky_studentov";
            this.label_vysledky_studentov.Size = new System.Drawing.Size(252, 28);
            this.label_vysledky_studentov.TabIndex = 23;
            this.label_vysledky_studentov.Text = "VÝSLEDKY ŠTUDENTOV";
            // 
            // VysledkyStudentovDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.VysledkyStudentovDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VysledkyStudentovDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VysledkyStudentovDGV.ColumnHeadersHeight = 24;
            this.VysledkyStudentovDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VysledkyStudentovDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.VysledkyStudentovDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VysledkyStudentovDGV.Location = new System.Drawing.Point(203, 149);
            this.VysledkyStudentovDGV.Name = "VysledkyStudentovDGV";
            this.VysledkyStudentovDGV.RowHeadersVisible = false;
            this.VysledkyStudentovDGV.RowHeadersWidth = 51;
            this.VysledkyStudentovDGV.RowTemplate.Height = 24;
            this.VysledkyStudentovDGV.Size = new System.Drawing.Size(1043, 503);
            this.VysledkyStudentovDGV.TabIndex = 22;
            this.VysledkyStudentovDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VysledkyStudentovDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VysledkyStudentovDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VysledkyStudentovDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VysledkyStudentovDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VysledkyStudentovDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VysledkyStudentovDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VysledkyStudentovDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VysledkyStudentovDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VysledkyStudentovDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VysledkyStudentovDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VysledkyStudentovDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VysledkyStudentovDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.VysledkyStudentovDGV.ThemeStyle.ReadOnly = false;
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.Height = 24;
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VysledkyStudentovDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // oddelovac4
            // 
            this.oddelovac4.Location = new System.Drawing.Point(854, 63);
            this.oddelovac4.Name = "oddelovac4";
            this.oddelovac4.Size = new System.Drawing.Size(81, 10);
            this.oddelovac4.TabIndex = 9;
            // 
            // label_studenti
            // 
            this.label_studenti.AutoSize = true;
            this.label_studenti.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_studenti.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_studenti.Location = new System.Drawing.Point(744, 32);
            this.label_studenti.Name = "label_studenti";
            this.label_studenti.Size = new System.Drawing.Size(87, 28);
            this.label_studenti.TabIndex = 4;
            this.label_studenti.Text = "Študenti";
            this.label_studenti.Click += new System.EventHandler(this.label_studenti_Click);
            // 
            // label_predmety
            // 
            this.label_predmety.AutoSize = true;
            this.label_predmety.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmety.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_predmety.Location = new System.Drawing.Point(617, 32);
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
            this.label_otazky.Location = new System.Drawing.Point(510, 32);
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
            this.panel_bocny.Controls.Add(this.label_predmety1);
            this.panel_bocny.Controls.Add(this.pictureBox_predmety);
            this.panel_bocny.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bocny.ForeColor = System.Drawing.Color.Silver;
            this.panel_bocny.Location = new System.Drawing.Point(0, 0);
            this.panel_bocny.Name = "panel_bocny";
            this.panel_bocny.Size = new System.Drawing.Size(200, 655);
            this.panel_bocny.TabIndex = 0;
            // 
            // label_o_programe
            // 
            this.label_o_programe.AutoSize = true;
            this.label_o_programe.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_o_programe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_o_programe.Location = new System.Drawing.Point(59, 408);
            this.label_o_programe.Name = "label_o_programe";
            this.label_o_programe.Size = new System.Drawing.Size(125, 34);
            this.label_o_programe.TabIndex = 33;
            this.label_o_programe.Text = "O programe";
            this.label_o_programe.Click += new System.EventHandler(this.label_o_programe_Click);
            // 
            // pictureBox_o_programe
            // 
            this.pictureBox_o_programe.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_o_programe.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_o_programe.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.pomoc;
            this.pictureBox_o_programe.ImageRotate = 0F;
            this.pictureBox_o_programe.Location = new System.Drawing.Point(24, 409);
            this.pictureBox_o_programe.Name = "pictureBox_o_programe";
            this.pictureBox_o_programe.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_o_programe.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_o_programe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_o_programe.TabIndex = 34;
            this.pictureBox_o_programe.TabStop = false;
            this.pictureBox_o_programe.UseTransparentBackground = true;
            // 
            // label_odhlasenie
            // 
            this.label_odhlasenie.AutoSize = true;
            this.label_odhlasenie.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_odhlasenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_odhlasenie.Location = new System.Drawing.Point(59, 329);
            this.label_odhlasenie.Name = "label_odhlasenie";
            this.label_odhlasenie.Size = new System.Drawing.Size(119, 34);
            this.label_odhlasenie.TabIndex = 31;
            this.label_odhlasenie.Text = "Odhlásiť sa";
            this.label_odhlasenie.Click += new System.EventHandler(this.label_odhlasenie_Click);
            // 
            // pictureBox_odhlasenie
            // 
            this.pictureBox_odhlasenie.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_odhlasenie.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_odhlasenie.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.koniec;
            this.pictureBox_odhlasenie.ImageRotate = 0F;
            this.pictureBox_odhlasenie.Location = new System.Drawing.Point(24, 332);
            this.pictureBox_odhlasenie.Name = "pictureBox_odhlasenie";
            this.pictureBox_odhlasenie.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_odhlasenie.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_odhlasenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_odhlasenie.TabIndex = 32;
            this.pictureBox_odhlasenie.TabStop = false;
            this.pictureBox_odhlasenie.UseTransparentBackground = true;
            // 
            // label_student
            // 
            this.label_student.AutoSize = true;
            this.label_student.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_student.Location = new System.Drawing.Point(59, 250);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(92, 34);
            this.label_student.TabIndex = 29;
            this.label_student.Text = "Študenti";
            this.label_student.Click += new System.EventHandler(this.label_student_Click);
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_student.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_student.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.student;
            this.pictureBox_student.ImageRotate = 0F;
            this.pictureBox_student.Location = new System.Drawing.Point(24, 253);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_student.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_student.TabIndex = 30;
            this.pictureBox_student.TabStop = false;
            this.pictureBox_student.UseTransparentBackground = true;
            // 
            // label_predmety1
            // 
            this.label_predmety1.AutoSize = true;
            this.label_predmety1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmety1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_predmety1.Location = new System.Drawing.Point(59, 171);
            this.label_predmety1.Name = "label_predmety1";
            this.label_predmety1.Size = new System.Drawing.Size(104, 34);
            this.label_predmety1.TabIndex = 27;
            this.label_predmety1.Text = "Predmety";
            this.label_predmety1.Click += new System.EventHandler(this.label_predmety1_Click);
            // 
            // pictureBox_predmety
            // 
            this.pictureBox_predmety.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_predmety.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_predmety.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.predmet;
            this.pictureBox_predmety.ImageRotate = 0F;
            this.pictureBox_predmety.Location = new System.Drawing.Point(24, 177);
            this.pictureBox_predmety.Name = "pictureBox_predmety";
            this.pictureBox_predmety.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_predmety.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_predmety.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_predmety.TabIndex = 28;
            this.pictureBox_predmety.TabStop = false;
            this.pictureBox_predmety.UseTransparentBackground = true;
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
            this.panel_hlavny.TabIndex = 2;
            // 
            // Form_ZobrazVysledky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 661);
            this.Controls.Add(this.panel_hlavny);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ZobrazVysledky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ZobrazVysledky";
            this.panel_pozadie.ResumeLayout(false);
            this.panel_pozadie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VysledkyStudentovDGV)).EndInit();
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmety)).EndInit();
            this.panel_hlavny.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pozadie;
        private System.Windows.Forms.Label label_vysledky_studentov;
        private Guna.UI2.WinForms.Guna2DataGridView VysledkyStudentovDGV;
        private Guna.UI2.WinForms.Guna2Separator oddelovac4;
        private System.Windows.Forms.Label label_studenti;
        private System.Windows.Forms.Label label_predmety;
        private System.Windows.Forms.Label label_otazky;
        private System.Windows.Forms.Label label_nazov;
        private System.Windows.Forms.Panel panel_bocny;
        private System.Windows.Forms.Label label_o_programe;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_o_programe;
        private System.Windows.Forms.Label label_odhlasenie;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_odhlasenie;
        private System.Windows.Forms.Label label_student;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_student;
        private System.Windows.Forms.Label label_predmety1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_predmety;
        private System.Windows.Forms.Panel panel_hlavny;
        private System.Windows.Forms.Label label_vysledky;
        private System.Windows.Forms.Label label_student_meno;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_student;
        private System.Windows.Forms.Label label_predmet;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_predmety;
    }
}