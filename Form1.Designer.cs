namespace p65_72_Korabsky_Pavol
{
    partial class Form_HO_PK
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
            this.label_nadpis = new System.Windows.Forms.Label();
            this.label_typ_uzivatela = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox_typy_uzivatelov = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel_prihlasenie_ucitel = new System.Windows.Forms.Panel();
            this.checkBox_zobrazit_heslo_ucitel = new System.Windows.Forms.CheckBox();
            this.button_prihlasitSa_ucitel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.textBox_heslo_ucitel = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_PM_ucitel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_nespravne_prihlasenie_ucitel = new System.Windows.Forms.Label();
            this.label_heslo_ucitel = new System.Windows.Forms.Label();
            this.label_PM_ucitel = new System.Windows.Forms.Label();
            this.label_prihlasenie_ucitel = new System.Windows.Forms.Label();
            this.panel_prihlasenie_student = new System.Windows.Forms.Panel();
            this.button_registrovatSa_student = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.button_prihlasitSa_student = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.textBox_id_student = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id_student = new System.Windows.Forms.Label();
            this.label_prihlasenie_student = new System.Windows.Forms.Label();
            this.pictureBox_pozadie = new System.Windows.Forms.PictureBox();
            this.pictureBox_koniec = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_prihlasenie_ucitel.SuspendLayout();
            this.panel_prihlasenie_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pozadie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_koniec)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nadpis
            // 
            this.label_nadpis.AutoSize = true;
            this.label_nadpis.BackColor = System.Drawing.Color.Transparent;
            this.label_nadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nadpis.Location = new System.Drawing.Point(510, 74);
            this.label_nadpis.Name = "label_nadpis";
            this.label_nadpis.Size = new System.Drawing.Size(446, 32);
            this.label_nadpis.TabIndex = 0;
            this.label_nadpis.Text = "Systém preverovania vedomostí";
            // 
            // label_typ_uzivatela
            // 
            this.label_typ_uzivatela.AutoSize = true;
            this.label_typ_uzivatela.BackColor = System.Drawing.Color.Transparent;
            this.label_typ_uzivatela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_typ_uzivatela.Location = new System.Drawing.Point(633, 136);
            this.label_typ_uzivatela.Name = "label_typ_uzivatela";
            this.label_typ_uzivatela.Size = new System.Drawing.Size(136, 25);
            this.label_typ_uzivatela.TabIndex = 1;
            this.label_typ_uzivatela.Text = "Typ užívateľa:";
            // 
            // comboBox_typy_uzivatelov
            // 
            this.comboBox_typy_uzivatelov.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_typy_uzivatelov.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_typy_uzivatelov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typy_uzivatelov.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_typy_uzivatelov.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_typy_uzivatelov.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_typy_uzivatelov.ForeColor = System.Drawing.Color.Black;
            this.comboBox_typy_uzivatelov.ItemHeight = 30;
            this.comboBox_typy_uzivatelov.Items.AddRange(new object[] {
            "Učiteľ",
            "Študent"});
            this.comboBox_typy_uzivatelov.Location = new System.Drawing.Point(619, 174);
            this.comboBox_typy_uzivatelov.Name = "comboBox_typy_uzivatelov";
            this.comboBox_typy_uzivatelov.Size = new System.Drawing.Size(135, 36);
            this.comboBox_typy_uzivatelov.TabIndex = 2;
            this.comboBox_typy_uzivatelov.SelectedIndexChanged += new System.EventHandler(this.comboBox_typy_uzivatelov_SelectedIndexChanged);
            // 
            // panel_prihlasenie_ucitel
            // 
            this.panel_prihlasenie_ucitel.Controls.Add(this.checkBox_zobrazit_heslo_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.button_prihlasitSa_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.textBox_heslo_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.textBox_PM_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.label_nespravne_prihlasenie_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.label_heslo_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.label_PM_ucitel);
            this.panel_prihlasenie_ucitel.Controls.Add(this.label_prihlasenie_ucitel);
            this.panel_prihlasenie_ucitel.Location = new System.Drawing.Point(491, 228);
            this.panel_prihlasenie_ucitel.Name = "panel_prihlasenie_ucitel";
            this.panel_prihlasenie_ucitel.Size = new System.Drawing.Size(390, 364);
            this.panel_prihlasenie_ucitel.TabIndex = 5;
            // 
            // checkBox_zobrazit_heslo_ucitel
            // 
            this.checkBox_zobrazit_heslo_ucitel.AutoSize = true;
            this.checkBox_zobrazit_heslo_ucitel.Location = new System.Drawing.Point(135, 210);
            this.checkBox_zobrazit_heslo_ucitel.Name = "checkBox_zobrazit_heslo_ucitel";
            this.checkBox_zobrazit_heslo_ucitel.Size = new System.Drawing.Size(140, 25);
            this.checkBox_zobrazit_heslo_ucitel.TabIndex = 7;
            this.checkBox_zobrazit_heslo_ucitel.Text = "Zobraziť heslo";
            this.checkBox_zobrazit_heslo_ucitel.UseVisualStyleBackColor = true;
            this.checkBox_zobrazit_heslo_ucitel.CheckedChanged += new System.EventHandler(this.checkBox_zobrazit_heslo_ucitel_CheckedChanged);
            // 
            // button_prihlasitSa_ucitel
            // 
            this.button_prihlasitSa_ucitel.BackColor = System.Drawing.Color.Transparent;
            this.button_prihlasitSa_ucitel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasitSa_ucitel.BorderRadius = 8;
            this.button_prihlasitSa_ucitel.BorderThickness = 2;
            this.button_prihlasitSa_ucitel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_prihlasitSa_ucitel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_prihlasitSa_ucitel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_prihlasitSa_ucitel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_prihlasitSa_ucitel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_prihlasitSa_ucitel.FillColor = System.Drawing.Color.Green;
            this.button_prihlasitSa_ucitel.FillColor2 = System.Drawing.Color.LimeGreen;
            this.button_prihlasitSa_ucitel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_prihlasitSa_ucitel.ForeColor = System.Drawing.Color.White;
            this.button_prihlasitSa_ucitel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_prihlasitSa_ucitel.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasitSa_ucitel.HoverState.FillColor2 = System.Drawing.Color.LightGreen;
            this.button_prihlasitSa_ucitel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_prihlasitSa_ucitel.Location = new System.Drawing.Point(109, 259);
            this.button_prihlasitSa_ucitel.Name = "button_prihlasitSa_ucitel";
            this.button_prihlasitSa_ucitel.Size = new System.Drawing.Size(170, 34);
            this.button_prihlasitSa_ucitel.TabIndex = 6;
            this.button_prihlasitSa_ucitel.Text = "Prihlásiť Sa";
            // 
            // textBox_heslo_ucitel
            // 
            this.textBox_heslo_ucitel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_heslo_ucitel.DefaultText = "";
            this.textBox_heslo_ucitel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_heslo_ucitel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_heslo_ucitel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_heslo_ucitel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_heslo_ucitel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_heslo_ucitel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_heslo_ucitel.ForeColor = System.Drawing.Color.Black;
            this.textBox_heslo_ucitel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_heslo_ucitel.Location = new System.Drawing.Point(75, 176);
            this.textBox_heslo_ucitel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_heslo_ucitel.Name = "textBox_heslo_ucitel";
            this.textBox_heslo_ucitel.PasswordChar = '*';
            this.textBox_heslo_ucitel.PlaceholderText = "";
            this.textBox_heslo_ucitel.SelectedText = "";
            this.textBox_heslo_ucitel.Size = new System.Drawing.Size(238, 27);
            this.textBox_heslo_ucitel.TabIndex = 5;
            this.textBox_heslo_ucitel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PM_ucitel
            // 
            this.textBox_PM_ucitel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PM_ucitel.DefaultText = "";
            this.textBox_PM_ucitel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_PM_ucitel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_PM_ucitel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PM_ucitel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_PM_ucitel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PM_ucitel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_PM_ucitel.ForeColor = System.Drawing.Color.Black;
            this.textBox_PM_ucitel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_PM_ucitel.Location = new System.Drawing.Point(75, 100);
            this.textBox_PM_ucitel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_PM_ucitel.Name = "textBox_PM_ucitel";
            this.textBox_PM_ucitel.PasswordChar = '\0';
            this.textBox_PM_ucitel.PlaceholderText = "";
            this.textBox_PM_ucitel.SelectedText = "";
            this.textBox_PM_ucitel.Size = new System.Drawing.Size(238, 27);
            this.textBox_PM_ucitel.TabIndex = 4;
            this.textBox_PM_ucitel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_nespravne_prihlasenie_ucitel
            // 
            this.label_nespravne_prihlasenie_ucitel.AutoSize = true;
            this.label_nespravne_prihlasenie_ucitel.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nespravne_prihlasenie_ucitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_nespravne_prihlasenie_ucitel.Location = new System.Drawing.Point(33, 316);
            this.label_nespravne_prihlasenie_ucitel.Name = "label_nespravne_prihlasenie_ucitel";
            this.label_nespravne_prihlasenie_ucitel.Size = new System.Drawing.Size(322, 23);
            this.label_nespravne_prihlasenie_ucitel.TabIndex = 3;
            this.label_nespravne_prihlasenie_ucitel.Text = "Nesprávne Heslo alebo Prihlasovacie Meno!";
            // 
            // label_heslo_ucitel
            // 
            this.label_heslo_ucitel.AutoSize = true;
            this.label_heslo_ucitel.Location = new System.Drawing.Point(172, 151);
            this.label_heslo_ucitel.Name = "label_heslo_ucitel";
            this.label_heslo_ucitel.Size = new System.Drawing.Size(54, 21);
            this.label_heslo_ucitel.TabIndex = 2;
            this.label_heslo_ucitel.Text = "Heslo";
            // 
            // label_PM_ucitel
            // 
            this.label_PM_ucitel.AutoSize = true;
            this.label_PM_ucitel.Location = new System.Drawing.Point(128, 75);
            this.label_PM_ucitel.Name = "label_PM_ucitel";
            this.label_PM_ucitel.Size = new System.Drawing.Size(157, 21);
            this.label_PM_ucitel.TabIndex = 1;
            this.label_PM_ucitel.Text = "Prihlasovacie Meno";
            // 
            // label_prihlasenie_ucitel
            // 
            this.label_prihlasenie_ucitel.AutoSize = true;
            this.label_prihlasenie_ucitel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_prihlasenie_ucitel.Location = new System.Drawing.Point(125, 18);
            this.label_prihlasenie_ucitel.Name = "label_prihlasenie_ucitel";
            this.label_prihlasenie_ucitel.Size = new System.Drawing.Size(170, 24);
            this.label_prihlasenie_ucitel.TabIndex = 0;
            this.label_prihlasenie_ucitel.Text = "Učiteľ Prihlásenie";
            // 
            // panel_prihlasenie_student
            // 
            this.panel_prihlasenie_student.Controls.Add(this.button_registrovatSa_student);
            this.panel_prihlasenie_student.Controls.Add(this.button_prihlasitSa_student);
            this.panel_prihlasenie_student.Controls.Add(this.textBox_id_student);
            this.panel_prihlasenie_student.Controls.Add(this.label_id_student);
            this.panel_prihlasenie_student.Controls.Add(this.label_prihlasenie_student);
            this.panel_prihlasenie_student.Location = new System.Drawing.Point(492, 229);
            this.panel_prihlasenie_student.Name = "panel_prihlasenie_student";
            this.panel_prihlasenie_student.Size = new System.Drawing.Size(390, 364);
            this.panel_prihlasenie_student.TabIndex = 8;
            // 
            // button_registrovatSa_student
            // 
            this.button_registrovatSa_student.BackColor = System.Drawing.Color.Transparent;
            this.button_registrovatSa_student.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_registrovatSa_student.BorderRadius = 8;
            this.button_registrovatSa_student.BorderThickness = 2;
            this.button_registrovatSa_student.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_registrovatSa_student.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_registrovatSa_student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_registrovatSa_student.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_registrovatSa_student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_registrovatSa_student.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_registrovatSa_student.FillColor2 = System.Drawing.Color.Gold;
            this.button_registrovatSa_student.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_registrovatSa_student.ForeColor = System.Drawing.Color.White;
            this.button_registrovatSa_student.HoverState.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_registrovatSa_student.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_registrovatSa_student.HoverState.FillColor2 = System.Drawing.Color.SandyBrown;
            this.button_registrovatSa_student.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_registrovatSa_student.Location = new System.Drawing.Point(110, 179);
            this.button_registrovatSa_student.Name = "button_registrovatSa_student";
            this.button_registrovatSa_student.Size = new System.Drawing.Size(170, 34);
            this.button_registrovatSa_student.TabIndex = 7;
            this.button_registrovatSa_student.Text = "Zaregistrovať Sa";
            // 
            // button_prihlasitSa_student
            // 
            this.button_prihlasitSa_student.BackColor = System.Drawing.Color.Transparent;
            this.button_prihlasitSa_student.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasitSa_student.BorderRadius = 8;
            this.button_prihlasitSa_student.BorderThickness = 2;
            this.button_prihlasitSa_student.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_prihlasitSa_student.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_prihlasitSa_student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_prihlasitSa_student.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_prihlasitSa_student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_prihlasitSa_student.FillColor = System.Drawing.Color.Green;
            this.button_prihlasitSa_student.FillColor2 = System.Drawing.Color.LimeGreen;
            this.button_prihlasitSa_student.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_prihlasitSa_student.ForeColor = System.Drawing.Color.White;
            this.button_prihlasitSa_student.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_prihlasitSa_student.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.button_prihlasitSa_student.HoverState.FillColor2 = System.Drawing.Color.LightGreen;
            this.button_prihlasitSa_student.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_prihlasitSa_student.Location = new System.Drawing.Point(109, 231);
            this.button_prihlasitSa_student.Name = "button_prihlasitSa_student";
            this.button_prihlasitSa_student.Size = new System.Drawing.Size(170, 34);
            this.button_prihlasitSa_student.TabIndex = 6;
            this.button_prihlasitSa_student.Text = "Prihlásiť Sa";
            // 
            // textBox_id_student
            // 
            this.textBox_id_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_id_student.DefaultText = "";
            this.textBox_id_student.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_id_student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_id_student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_id_student.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_id_student.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_id_student.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_id_student.ForeColor = System.Drawing.Color.Black;
            this.textBox_id_student.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_id_student.Location = new System.Drawing.Point(75, 120);
            this.textBox_id_student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_id_student.Name = "textBox_id_student";
            this.textBox_id_student.PasswordChar = '\0';
            this.textBox_id_student.PlaceholderText = "";
            this.textBox_id_student.SelectedText = "";
            this.textBox_id_student.Size = new System.Drawing.Size(238, 27);
            this.textBox_id_student.TabIndex = 4;
            this.textBox_id_student.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_id_student
            // 
            this.label_id_student.AutoSize = true;
            this.label_id_student.Location = new System.Drawing.Point(155, 99);
            this.label_id_student.Name = "label_id_student";
            this.label_id_student.Size = new System.Drawing.Size(98, 21);
            this.label_id_student.TabIndex = 1;
            this.label_id_student.Text = "ID Študenta";
            // 
            // label_prihlasenie_student
            // 
            this.label_prihlasenie_student.AutoSize = true;
            this.label_prihlasenie_student.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_prihlasenie_student.Location = new System.Drawing.Point(125, 18);
            this.label_prihlasenie_student.Name = "label_prihlasenie_student";
            this.label_prihlasenie_student.Size = new System.Drawing.Size(187, 24);
            this.label_prihlasenie_student.TabIndex = 0;
            this.label_prihlasenie_student.Text = "Študent Prihlásenie";
            // 
            // pictureBox_pozadie
            // 
            this.pictureBox_pozadie.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pozadie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_pozadie.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.pozadie_uvod;
            this.pictureBox_pozadie.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_pozadie.Name = "pictureBox_pozadie";
            this.pictureBox_pozadie.Size = new System.Drawing.Size(1300, 700);
            this.pictureBox_pozadie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pozadie.TabIndex = 4;
            this.pictureBox_pozadie.TabStop = false;
            // 
            // pictureBox_koniec
            // 
            this.pictureBox_koniec.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_koniec.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox_koniec.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.koniec_programu;
            this.pictureBox_koniec.ImageRotate = 0F;
            this.pictureBox_koniec.Location = new System.Drawing.Point(1243, 12);
            this.pictureBox_koniec.Name = "pictureBox_koniec";
            this.pictureBox_koniec.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_koniec.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_koniec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_koniec.TabIndex = 9;
            this.pictureBox_koniec.TabStop = false;
            this.pictureBox_koniec.UseTransparentBackground = true;
            this.pictureBox_koniec.Click += new System.EventHandler(this.pictureBox_koniec_Click);
            // 
            // Form_HO_PK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pictureBox_koniec);
            this.Controls.Add(this.panel_prihlasenie_student);
            this.Controls.Add(this.panel_prihlasenie_ucitel);
            this.Controls.Add(this.comboBox_typy_uzivatelov);
            this.Controls.Add(this.label_typ_uzivatela);
            this.Controls.Add(this.label_nadpis);
            this.Controls.Add(this.pictureBox_pozadie);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_HO_PK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Systém preverovania vedomostí";
            this.Load += new System.EventHandler(this.Form_HO_PK_Load);
            this.panel_prihlasenie_ucitel.ResumeLayout(false);
            this.panel_prihlasenie_ucitel.PerformLayout();
            this.panel_prihlasenie_student.ResumeLayout(false);
            this.panel_prihlasenie_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pozadie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_koniec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nadpis;
        private System.Windows.Forms.Label label_typ_uzivatela;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_typy_uzivatelov;
        private System.Windows.Forms.PictureBox pictureBox_pozadie;
        private System.Windows.Forms.Panel panel_prihlasenie_ucitel;
        private System.Windows.Forms.Label label_prihlasenie_ucitel;
        private System.Windows.Forms.Label label_heslo_ucitel;
        private System.Windows.Forms.Label label_PM_ucitel;
        private System.Windows.Forms.Label label_nespravne_prihlasenie_ucitel;
        private Guna.UI2.WinForms.Guna2TextBox textBox_heslo_ucitel;
        private Guna.UI2.WinForms.Guna2TextBox textBox_PM_ucitel;
        private Guna.UI2.WinForms.Guna2GradientTileButton button_prihlasitSa_ucitel;
        private System.Windows.Forms.CheckBox checkBox_zobrazit_heslo_ucitel;
        private System.Windows.Forms.Panel panel_prihlasenie_student;
        private Guna.UI2.WinForms.Guna2GradientTileButton button_prihlasitSa_student;
        private Guna.UI2.WinForms.Guna2TextBox textBox_id_student;
        private System.Windows.Forms.Label label_id_student;
        private System.Windows.Forms.Label label_prihlasenie_student;
        private Guna.UI2.WinForms.Guna2GradientTileButton button_registrovatSa_student;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_koniec;
    }
}

