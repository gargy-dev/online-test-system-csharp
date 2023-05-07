namespace p65_72_Korabsky_Pavol
{
    partial class Form_Uvod
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
            this.label_uvod = new System.Windows.Forms.Label();
            this.progressBar_uvod = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pictureBox_uvod = new Guna.UI2.WinForms.Guna2PictureBox();
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.label_podnadpis = new System.Windows.Forms.Label();
            this.label_nacitavanie_percenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uvod)).BeginInit();
            this.SuspendLayout();
            // 
            // label_uvod
            // 
            this.label_uvod.AutoSize = true;
            this.label_uvod.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_uvod.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_uvod.Location = new System.Drawing.Point(152, 29);
            this.label_uvod.Name = "label_uvod";
            this.label_uvod.Size = new System.Drawing.Size(237, 36);
            this.label_uvod.TabIndex = 25;
            this.label_uvod.Text = "Online Test Systém";
            // 
            // progressBar_uvod
            // 
            this.progressBar_uvod.BorderRadius = 5;
            this.progressBar_uvod.Location = new System.Drawing.Point(32, 208);
            this.progressBar_uvod.Name = "progressBar_uvod";
            this.progressBar_uvod.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar_uvod.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.progressBar_uvod.Size = new System.Drawing.Size(422, 11);
            this.progressBar_uvod.TabIndex = 27;
            this.progressBar_uvod.Text = "guna2ProgressBar1";
            this.progressBar_uvod.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pictureBox_uvod
            // 
            this.pictureBox_uvod.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_uvod.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_uvod.Image = global::p65_72_Korabsky_Pavol.Properties.Resources.uvod;
            this.pictureBox_uvod.ImageRotate = 0F;
            this.pictureBox_uvod.Location = new System.Drawing.Point(183, 68);
            this.pictureBox_uvod.Name = "pictureBox_uvod";
            this.pictureBox_uvod.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_uvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_uvod.TabIndex = 26;
            this.pictureBox_uvod.TabStop = false;
            this.pictureBox_uvod.UseTransparentBackground = true;
            // 
            // casovac
            // 
            this.casovac.Enabled = true;
            this.casovac.Tick += new System.EventHandler(this.casovac_Tick);
            // 
            // label_podnadpis
            // 
            this.label_podnadpis.AutoSize = true;
            this.label_podnadpis.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Italic);
            this.label_podnadpis.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_podnadpis.Location = new System.Drawing.Point(28, 182);
            this.label_podnadpis.Name = "label_podnadpis";
            this.label_podnadpis.Size = new System.Drawing.Size(194, 23);
            this.label_podnadpis.TabIndex = 28;
            this.label_podnadpis.Text = "Online Systém Testovania";
            // 
            // label_nacitavanie_percenta
            // 
            this.label_nacitavanie_percenta.AutoSize = true;
            this.label_nacitavanie_percenta.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Italic);
            this.label_nacitavanie_percenta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_nacitavanie_percenta.Location = new System.Drawing.Point(430, 182);
            this.label_nacitavanie_percenta.Name = "label_nacitavanie_percenta";
            this.label_nacitavanie_percenta.Size = new System.Drawing.Size(24, 23);
            this.label_nacitavanie_percenta.TabIndex = 29;
            this.label_nacitavanie_percenta.Text = "%";
            // 
            // Form_Uvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(489, 246);
            this.Controls.Add(this.label_nacitavanie_percenta);
            this.Controls.Add(this.label_podnadpis);
            this.Controls.Add(this.progressBar_uvod);
            this.Controls.Add(this.pictureBox_uvod);
            this.Controls.Add(this.label_uvod);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Uvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Uvod";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_uvod;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_uvod;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar_uvod;
        private System.Windows.Forms.Timer casovac;
        private System.Windows.Forms.Label label_podnadpis;
        private System.Windows.Forms.Label label_nacitavanie_percenta;
    }
}