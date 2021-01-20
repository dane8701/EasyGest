namespace CustomsGestionHoteliere.newForm
{
    partial class FrmLogin
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
            this.btnConnexion = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.BorderRadius = 20;
            this.btnConnexion.CheckedState.Parent = this.btnConnexion;
            this.btnConnexion.CustomImages.Parent = this.btnConnexion;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.HoverState.Parent = this.btnConnexion;
            this.btnConnexion.Location = new System.Drawing.Point(80, 337);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.ShadowDecoration.Parent = this.btnConnexion;
            this.btnConnexion.Size = new System.Drawing.Size(180, 45);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 16;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "admin",
            "simpleUser"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(95, 295);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(128, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(107, 56);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Login";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.White;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::CustomsGestionHoteliere.Properties.Resources.delete_96px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(2, 3);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(36, 26);
            this.gunaImageButton1.TabIndex = 0;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::CustomsGestionHoteliere.Properties.Resources.pexels_narda_yescas_1566837;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Location = new System.Drawing.Point(387, -6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(414, 459);
            this.guna2Panel1.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderRadius = 16;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "Mot de passe";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.SystemColors.Control;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = global::CustomsGestionHoteliere.Properties.Resources.key_24px;
            this.txtPassword.Location = new System.Drawing.Point(25, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionStart = 12;
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(294, 47);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.BorderRadius = 16;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.DefaultText = "Nom d utilisateur";
            this.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.DisabledState.Parent = this.txtLogin;
            this.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogin.FillColor = System.Drawing.SystemColors.Control;
            this.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.FocusedState.Parent = this.txtLogin;
            this.txtLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogin.HoverState.Parent = this.txtLogin;
            this.txtLogin.IconLeft = global::CustomsGestionHoteliere.Properties.Resources.male_user_50px;
            this.txtLogin.Location = new System.Drawing.Point(25, 140);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceholderText = "";
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionStart = 17;
            this.txtLogin.ShadowDecoration.Parent = this.txtLogin;
            this.txtLogin.Size = new System.Drawing.Size(294, 47);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLogin_MouseClick);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnConnexion;
        private Guna.UI2.WinForms.Guna2TextBox txtLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}