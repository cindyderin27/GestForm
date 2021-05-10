
namespace GestForm
{
    partial class Session
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Session));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblEmail = new Guna.UI.WinForms.GunaLabel();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.btnConnect = new Guna.UI.WinForms.GunaButton();
            this.txtmotpasse = new Guna.UI.WinForms.GunaTextBox();
            this.lblmotpasse = new Guna.UI.WinForms.GunaLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.Pbclose = new Guna.UI.WinForms.GunaPictureBox();
            this.pbback = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(186, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(326, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Connection a une Session";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(157, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(292, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 10;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(259, 42);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Entrez votre email";
            // 
            // btnConnect
            // 
            this.btnConnect.AnimationHoverSpeed = 0.07F;
            this.btnConnect.AnimationSpeed = 0.03F;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BaseColor = System.Drawing.Color.Green;
            this.btnConnect.BorderColor = System.Drawing.Color.White;
            this.btnConnect.BorderSize = 1;
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConnect.FocusedColor = System.Drawing.Color.Empty;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Image = null;
            this.btnConnect.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnect.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConnect.Location = new System.Drawing.Point(117, 300);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConnect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConnect.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConnect.OnHoverImage = null;
            this.btnConnect.OnPressedColor = System.Drawing.Color.Black;
            this.btnConnect.Radius = 15;
            this.btnConnect.Size = new System.Drawing.Size(256, 46);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connecter";
            this.btnConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnect.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // txtmotpasse
            // 
            this.txtmotpasse.BackColor = System.Drawing.Color.Transparent;
            this.txtmotpasse.BaseColor = System.Drawing.Color.White;
            this.txtmotpasse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtmotpasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmotpasse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmotpasse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmotpasse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmotpasse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmotpasse.Location = new System.Drawing.Point(292, 215);
            this.txtmotpasse.Name = "txtmotpasse";
            this.txtmotpasse.PasswordChar = '\0';
            this.txtmotpasse.Radius = 10;
            this.txtmotpasse.SelectedText = "";
            this.txtmotpasse.Size = new System.Drawing.Size(259, 42);
            this.txtmotpasse.TabIndex = 5;
            this.txtmotpasse.Text = "Entrez votre mot de passe";
            // 
            // lblmotpasse
            // 
            this.lblmotpasse.AutoSize = true;
            this.lblmotpasse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmotpasse.ForeColor = System.Drawing.Color.White;
            this.lblmotpasse.Location = new System.Drawing.Point(157, 232);
            this.lblmotpasse.Name = "lblmotpasse";
            this.lblmotpasse.Size = new System.Drawing.Size(124, 25);
            this.lblmotpasse.TabIndex = 4;
            this.lblmotpasse.Text = "Mot de passe";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(356, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 6;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(439, 367);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(97, 15);
            this.gunaLinkLabel1.TabIndex = 8;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Creez un compte";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(198, 364);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(244, 20);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Vous n\'avez pas encore de compte?";
            // 
            // Pbclose
            // 
            this.Pbclose.BaseColor = System.Drawing.Color.White;
            this.Pbclose.Image = ((System.Drawing.Image)(resources.GetObject("Pbclose.Image")));
            this.Pbclose.Location = new System.Drawing.Point(688, 12);
            this.Pbclose.Name = "Pbclose";
            this.Pbclose.Size = new System.Drawing.Size(29, 28);
            this.Pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pbclose.TabIndex = 10;
            this.Pbclose.TabStop = false;
            // 
            // pbback
            // 
            this.pbback.BaseColor = System.Drawing.Color.White;
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(12, 12);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(29, 28);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbback.TabIndex = 12;
            this.pbback.TabStop = false;
            // 
            // Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.Pbclose);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtmotpasse);
            this.Controls.Add(this.lblmotpasse);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Session";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Session";
            this.Load += new System.EventHandler(this.Session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblEmail;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaButton btnConnect;
        private Guna.UI.WinForms.GunaTextBox txtmotpasse;
        private Guna.UI.WinForms.GunaLabel lblmotpasse;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox Pbclose;
        private Guna.UI.WinForms.GunaPictureBox pbback;
    }
}