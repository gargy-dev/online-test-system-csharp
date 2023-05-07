namespace p65_72_Korabsky_Pavol
{
    partial class Form_Otazky
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
            this.panel_hlavny = new System.Windows.Forms.Panel();
            this.panel_pozadie = new System.Windows.Forms.Panel();
            this.label_zoznam_otazok = new System.Windows.Forms.Label();
            this.OtazkyDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_reset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button_upravit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button_ulozit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label_predmet = new System.Windows.Forms.Label();
            this.comboBox_predmety = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBox_spravna_odpoved = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_moznost4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_moznost3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_moznost2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_moznost1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.oddelovac1 = new Guna.UI2.WinForms.Guna2Separator();
            this.textBox_otazka_popis = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pictureBox_predmet = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_hlavny.SuspendLayout();
            this.panel_pozadie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtazkyDGV)).BeginInit();
            this.panel_bocny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmet)).BeginInit();
            this.SuspendLayout();
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
            this.panel_hlavny.TabIndex = 0;
            // 
            // panel_pozadie
            // 
            this.panel_pozadie.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_pozadie.Controls.Add(this.label_zoznam_otazok);
            this.panel_pozadie.Controls.Add(this.OtazkyDGV);
            this.panel_pozadie.Controls.Add(this.button_reset);
            this.panel_pozadie.Controls.Add(this.button_upravit);
            this.panel_pozadie.Controls.Add(this.button_ulozit);
            this.panel_pozadie.Controls.Add(this.label_predmet);
            this.panel_pozadie.Controls.Add(this.comboBox_predmety);
            this.panel_pozadie.Controls.Add(this.textBox_spravna_odpoved);
            this.panel_pozadie.Controls.Add(this.textBox_moznost4);
            this.panel_pozadie.Controls.Add(this.textBox_moznost3);
            this.panel_pozadie.Controls.Add(this.textBox_moznost2);
            this.panel_pozadie.Controls.Add(this.textBox_moznost1);
            this.panel_pozadie.Controls.Add(this.oddelovac1);
            this.panel_pozadie.Controls.Add(this.textBox_otazka_popis);
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
            // label_zoznam_otazok
            // 
            this.label_zoznam_otazok.AutoSize = true;
            this.label_zoznam_otazok.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zoznam_otazok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_zoznam_otazok.Location = new System.Drawing.Point(627, 291);
            this.label_zoznam_otazok.Name = "label_zoznam_otazok";
            this.label_zoznam_otazok.Size = new System.Drawing.Size(190, 28);
            this.label_zoznam_otazok.TabIndex = 23;
            this.label_zoznam_otazok.Text = "ZOZNAM OTÁZOK";
            // 
            // OtazkyDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.OtazkyDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OtazkyDGV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.OtazkyDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OtazkyDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OtazkyDGV.ColumnHeadersHeight = 24;
            this.OtazkyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OtazkyDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OtazkyDGV.GridColor = System.Drawing.Color.WhiteSmoke;
            this.OtazkyDGV.Location = new System.Drawing.Point(203, 322);
            this.OtazkyDGV.Name = "OtazkyDGV";
            this.OtazkyDGV.RowHeadersVisible = false;
            this.OtazkyDGV.RowHeadersWidth = 51;
            this.OtazkyDGV.RowTemplate.Height = 24;
            this.OtazkyDGV.Size = new System.Drawing.Size(1043, 330);
            this.OtazkyDGV.TabIndex = 22;
            this.OtazkyDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OtazkyDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OtazkyDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OtazkyDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OtazkyDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OtazkyDGV.ThemeStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.OtazkyDGV.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.OtazkyDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.OtazkyDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OtazkyDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OtazkyDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.OtazkyDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OtazkyDGV.ThemeStyle.HeaderStyle.Height = 24;
            this.OtazkyDGV.ThemeStyle.ReadOnly = false;
            this.OtazkyDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OtazkyDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.OtazkyDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OtazkyDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OtazkyDGV.ThemeStyle.RowsStyle.Height = 24;
            this.OtazkyDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.OtazkyDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.OtazkyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OtazkyDGV_CellContentClick);
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
            // label_predmet
            // 
            this.label_predmet.AutoSize = true;
            this.label_predmet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_predmet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_predmet.Location = new System.Drawing.Point(1012, 64);
            this.label_predmet.Name = "label_predmet";
            this.label_predmet.Size = new System.Drawing.Size(89, 28);
            this.label_predmet.TabIndex = 18;
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
            this.comboBox_predmety.Location = new System.Drawing.Point(1017, 95);
            this.comboBox_predmety.Name = "comboBox_predmety";
            this.comboBox_predmety.Size = new System.Drawing.Size(140, 36);
            this.comboBox_predmety.TabIndex = 17;
            // 
            // textBox_spravna_odpoved
            // 
            this.textBox_spravna_odpoved.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_spravna_odpoved.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_spravna_odpoved.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_spravna_odpoved.DefaultText = "";
            this.textBox_spravna_odpoved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_spravna_odpoved.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_spravna_odpoved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_spravna_odpoved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_spravna_odpoved.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_spravna_odpoved.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_spravna_odpoved.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_spravna_odpoved.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_spravna_odpoved.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_spravna_odpoved.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_spravna_odpoved.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_spravna_odpoved.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_spravna_odpoved.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_spravna_odpoved.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_spravna_odpoved.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_spravna_odpoved.Location = new System.Drawing.Point(1017, 149);
            this.textBox_spravna_odpoved.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_spravna_odpoved.Name = "textBox_spravna_odpoved";
            this.textBox_spravna_odpoved.PasswordChar = '\0';
            this.textBox_spravna_odpoved.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_spravna_odpoved.PlaceholderText = "správna odpoveď";
            this.textBox_spravna_odpoved.SelectedText = "";
            this.textBox_spravna_odpoved.Size = new System.Drawing.Size(155, 34);
            this.textBox_spravna_odpoved.TabIndex = 16;
            this.textBox_spravna_odpoved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_moznost4
            // 
            this.textBox_moznost4.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_moznost4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_moznost4.DefaultText = "";
            this.textBox_moznost4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_moznost4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_moznost4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost4.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost4.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost4.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost4.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost4.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_moznost4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost4.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost4.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost4.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost4.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost4.Location = new System.Drawing.Point(831, 149);
            this.textBox_moznost4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_moznost4.Name = "textBox_moznost4";
            this.textBox_moznost4.PasswordChar = '\0';
            this.textBox_moznost4.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost4.PlaceholderText = "možnosť 4";
            this.textBox_moznost4.SelectedText = "";
            this.textBox_moznost4.Size = new System.Drawing.Size(155, 34);
            this.textBox_moznost4.TabIndex = 15;
            this.textBox_moznost4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_moznost3
            // 
            this.textBox_moznost3.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_moznost3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_moznost3.DefaultText = "";
            this.textBox_moznost3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_moznost3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_moznost3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost3.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost3.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost3.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost3.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost3.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_moznost3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost3.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost3.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost3.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost3.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost3.Location = new System.Drawing.Point(645, 149);
            this.textBox_moznost3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_moznost3.Name = "textBox_moznost3";
            this.textBox_moznost3.PasswordChar = '\0';
            this.textBox_moznost3.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost3.PlaceholderText = "možnosť 3";
            this.textBox_moznost3.SelectedText = "";
            this.textBox_moznost3.Size = new System.Drawing.Size(155, 34);
            this.textBox_moznost3.TabIndex = 14;
            this.textBox_moznost3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_moznost2
            // 
            this.textBox_moznost2.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_moznost2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_moznost2.DefaultText = "";
            this.textBox_moznost2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_moznost2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_moznost2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost2.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost2.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost2.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost2.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost2.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_moznost2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost2.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost2.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost2.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost2.Location = new System.Drawing.Point(459, 149);
            this.textBox_moznost2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_moznost2.Name = "textBox_moznost2";
            this.textBox_moznost2.PasswordChar = '\0';
            this.textBox_moznost2.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost2.PlaceholderText = "možnosť 2";
            this.textBox_moznost2.SelectedText = "";
            this.textBox_moznost2.Size = new System.Drawing.Size(155, 34);
            this.textBox_moznost2.TabIndex = 13;
            this.textBox_moznost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_moznost1
            // 
            this.textBox_moznost1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_moznost1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_moznost1.DefaultText = "";
            this.textBox_moznost1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_moznost1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_moznost1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_moznost1.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost1.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost1.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost1.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost1.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_moznost1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost1.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost1.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost1.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_moznost1.Location = new System.Drawing.Point(273, 149);
            this.textBox_moznost1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_moznost1.Name = "textBox_moznost1";
            this.textBox_moznost1.PasswordChar = '\0';
            this.textBox_moznost1.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_moznost1.PlaceholderText = "možnosť 1";
            this.textBox_moznost1.SelectedText = "";
            this.textBox_moznost1.Size = new System.Drawing.Size(155, 34);
            this.textBox_moznost1.TabIndex = 12;
            this.textBox_moznost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oddelovac1
            // 
            this.oddelovac1.Location = new System.Drawing.Point(578, 57);
            this.oddelovac1.Name = "oddelovac1";
            this.oddelovac1.Size = new System.Drawing.Size(69, 10);
            this.oddelovac1.TabIndex = 9;
            // 
            // textBox_otazka_popis
            // 
            this.textBox_otazka_popis.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_otazka_popis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_otazka_popis.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_otazka_popis.DefaultText = "";
            this.textBox_otazka_popis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_otazka_popis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_otazka_popis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_otazka_popis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_otazka_popis.FillColor = System.Drawing.Color.DodgerBlue;
            this.textBox_otazka_popis.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_otazka_popis.FocusedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_otazka_popis.FocusedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_otazka_popis.FocusedState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_otazka_popis.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_otazka_popis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_otazka_popis.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_otazka_popis.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_otazka_popis.HoverState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_otazka_popis.HoverState.PlaceholderForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox_otazka_popis.Location = new System.Drawing.Point(556, 93);
            this.textBox_otazka_popis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_otazka_popis.Name = "textBox_otazka_popis";
            this.textBox_otazka_popis.PasswordChar = '\0';
            this.textBox_otazka_popis.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_otazka_popis.PlaceholderText = "OTÁZKA";
            this.textBox_otazka_popis.SelectedText = "";
            this.textBox_otazka_popis.Size = new System.Drawing.Size(345, 38);
            this.textBox_otazka_popis.TabIndex = 8;
            this.textBox_otazka_popis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel_bocny.Controls.Add(this.pictureBox_predmet);
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
            this.label_o_programe.Location = new System.Drawing.Point(65, 405);
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
            this.pictureBox_o_programe.Location = new System.Drawing.Point(32, 403);
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
            this.label_odhlasenie.Location = new System.Drawing.Point(65, 326);
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
            this.pictureBox_odhlasenie.Location = new System.Drawing.Point(32, 326);
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
            this.label_student.Location = new System.Drawing.Point(65, 247);
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
            this.pictureBox_student.Location = new System.Drawing.Point(32, 247);
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
            this.label_predmety1.Location = new System.Drawing.Point(65, 168);
            this.label_predmety1.Name = "label_predmety1";
            this.label_predmety1.Size = new System.Drawing.Size(104, 34);
            this.label_predmety1.TabIndex = 27;
            this.label_predmety1.Text = "Predmety";
            this.label_predmety1.Click += new System.EventHandler(this.label_predmety1_Click);
            // 
            // pictureBox_predmet
            // 
            this.pictureBox_predmet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_predmet.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_predmet.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.predmet;
            this.pictureBox_predmet.ImageRotate = 0F;
            this.pictureBox_predmet.Location = new System.Drawing.Point(32, 171);
            this.pictureBox_predmet.Name = "pictureBox_predmet";
            this.pictureBox_predmet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_predmet.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_predmet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_predmet.TabIndex = 28;
            this.pictureBox_predmet.TabStop = false;
            this.pictureBox_predmet.UseTransparentBackground = true;
            // 
            // Form_Otazky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 661);
            this.Controls.Add(this.panel_hlavny);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Otazky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otazky";
            this.panel_hlavny.ResumeLayout(false);
            this.panel_pozadie.ResumeLayout(false);
            this.panel_pozadie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtazkyDGV)).EndInit();
            this.panel_bocny.ResumeLayout(false);
            this.panel_bocny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_o_programe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_odhlasenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_predmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_hlavny;
        private System.Windows.Forms.Panel panel_pozadie;
        private System.Windows.Forms.Panel panel_bocny;
        private System.Windows.Forms.Label label_nazov;
        private System.Windows.Forms.Label label_otazky;
        private System.Windows.Forms.Label label_studenti;
        private System.Windows.Forms.Label label_predmety;
        private Guna.UI2.WinForms.Guna2Separator oddelovac1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_otazka_popis;
        private Guna.UI2.WinForms.Guna2TextBox textBox_moznost3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_moznost2;
        private Guna.UI2.WinForms.Guna2TextBox textBox_moznost1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_spravna_odpoved;
        private Guna.UI2.WinForms.Guna2TextBox textBox_moznost4;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_predmety;
        private System.Windows.Forms.Label label_predmet;
        private Guna.UI2.WinForms.Guna2GradientButton button_ulozit;
        private Guna.UI2.WinForms.Guna2GradientButton button_upravit;
        private Guna.UI2.WinForms.Guna2GradientButton button_reset;
        private Guna.UI2.WinForms.Guna2DataGridView OtazkyDGV;
        private System.Windows.Forms.Label label_zoznam_otazok;
        private System.Windows.Forms.Label label_predmety1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_predmet;
        private System.Windows.Forms.Label label_student;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_student;
        private System.Windows.Forms.Label label_odhlasenie;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_odhlasenie;
        private System.Windows.Forms.Label label_o_programe;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_o_programe;
    }
}

