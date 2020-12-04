using CustomsGestionHoteliere.encientTravail;

namespace CustomsGestionHoteliere
{
    partial class enregistreClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enregistreClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.adress = new Guna.UI2.WinForms.Guna2TextBox();
            this.id_client = new Guna.UI2.WinForms.Guna2TextBox();
            this.nationalit = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtSaveClt = new Guna.UI2.WinForms.Guna2Button();
            this.cbsex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gset_hotelDataSet2 = new CustomsGestionHoteliere.encientTravail.gset_hotelDataSet2();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new CustomsGestionHoteliere.encientTravail.gset_hotelDataSet2TableAdapters.clientTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.guna2TileButton2);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 49);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(174, 21);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Enregistrement client";
            // 
            // email
            // 
            this.email.BorderColor = System.Drawing.Color.Indigo;
            this.email.BorderRadius = 16;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientBindingSource, "email", true));
            this.email.DefaultText = "email";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(72, 275);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.SelectionStart = 5;
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(200, 36);
            this.email.TabIndex = 31;
            // 
            // txttelephone
            // 
            this.txttelephone.BorderColor = System.Drawing.Color.Indigo;
            this.txttelephone.BorderRadius = 16;
            this.txttelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelephone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientBindingSource, "numero de telephone", true));
            this.txttelephone.DefaultText = "Numero de telephone";
            this.txttelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelephone.DisabledState.Parent = this.txttelephone;
            this.txttelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelephone.FocusedState.Parent = this.txttelephone;
            this.txttelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelephone.HoverState.Parent = this.txttelephone;
            this.txttelephone.Location = new System.Drawing.Point(321, 214);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.PasswordChar = '\0';
            this.txttelephone.PlaceholderText = "";
            this.txttelephone.SelectedText = "";
            this.txttelephone.SelectionStart = 19;
            this.txttelephone.ShadowDecoration.Parent = this.txttelephone;
            this.txttelephone.Size = new System.Drawing.Size(200, 36);
            this.txttelephone.TabIndex = 30;
            // 
            // adress
            // 
            this.adress.BorderColor = System.Drawing.Color.Indigo;
            this.adress.BorderRadius = 16;
            this.adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientBindingSource, "adress", true));
            this.adress.DefaultText = "Adresse";
            this.adress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress.DisabledState.Parent = this.adress;
            this.adress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress.FocusedState.Parent = this.adress;
            this.adress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress.HoverState.Parent = this.adress;
            this.adress.Location = new System.Drawing.Point(30, 214);
            this.adress.Name = "adress";
            this.adress.PasswordChar = '\0';
            this.adress.PlaceholderText = "";
            this.adress.SelectedText = "";
            this.adress.SelectionStart = 7;
            this.adress.ShadowDecoration.Parent = this.adress;
            this.adress.Size = new System.Drawing.Size(269, 36);
            this.adress.TabIndex = 27;
            // 
            // id_client
            // 
            this.id_client.BackColor = System.Drawing.Color.Transparent;
            this.id_client.BorderColor = System.Drawing.Color.Indigo;
            this.id_client.BorderRadius = 16;
            this.id_client.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_client.DefaultText = "   id client";
            this.id_client.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_client.DisabledState.Parent = this.id_client;
            this.id_client.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_client.FocusedState.Parent = this.id_client;
            this.id_client.ForeColor = System.Drawing.Color.DarkGray;
            this.id_client.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_client.HoverState.Parent = this.id_client;
            this.id_client.Location = new System.Drawing.Point(0, 99);
            this.id_client.Name = "id_client";
            this.id_client.PasswordChar = '\0';
            this.id_client.PlaceholderText = "";
            this.id_client.SelectedText = "";
            this.id_client.SelectionStart = 12;
            this.id_client.ShadowDecoration.Parent = this.id_client;
            this.id_client.Size = new System.Drawing.Size(176, 36);
            this.id_client.TabIndex = 25;
            // 
            // nationalit
            // 
            this.nationalit.BorderColor = System.Drawing.Color.Indigo;
            this.nationalit.BorderRadius = 16;
            this.nationalit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nationalit.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientBindingSource, "nationaliter", true));
            this.nationalit.DefaultText = "Nationaliter";
            this.nationalit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nationalit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nationalit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalit.DisabledState.Parent = this.nationalit;
            this.nationalit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalit.FocusedState.Parent = this.nationalit;
            this.nationalit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalit.HoverState.Parent = this.nationalit;
            this.nationalit.Location = new System.Drawing.Point(321, 275);
            this.nationalit.Name = "nationalit";
            this.nationalit.PasswordChar = '\0';
            this.nationalit.PlaceholderText = "";
            this.nationalit.SelectedText = "";
            this.nationalit.SelectionStart = 12;
            this.nationalit.ShadowDecoration.Parent = this.nationalit;
            this.nationalit.Size = new System.Drawing.Size(177, 36);
            this.nationalit.TabIndex = 24;
            // 
            // nom
            // 
            this.nom.BorderColor = System.Drawing.Color.Indigo;
            this.nom.BorderRadius = 16;
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientBindingSource, "nom complet ", true));
            this.nom.DefaultText = " Nom complete";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.Location = new System.Drawing.Point(0, 156);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.SelectionStart = 13;
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(422, 36);
            this.nom.TabIndex = 23;
            // 
            // BtSaveClt
            // 
            this.BtSaveClt.BackColor = System.Drawing.Color.Transparent;
            this.BtSaveClt.BorderRadius = 16;
            this.BtSaveClt.CheckedState.Parent = this.BtSaveClt;
            this.BtSaveClt.CustomImages.Parent = this.BtSaveClt;
            this.BtSaveClt.FillColor = System.Drawing.Color.Indigo;
            this.BtSaveClt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtSaveClt.ForeColor = System.Drawing.Color.White;
            this.BtSaveClt.HoverState.Parent = this.BtSaveClt;
            this.BtSaveClt.Location = new System.Drawing.Point(173, 475);
            this.BtSaveClt.Name = "BtSaveClt";
            this.BtSaveClt.ShadowDecoration.Parent = this.BtSaveClt;
            this.BtSaveClt.Size = new System.Drawing.Size(116, 45);
            this.BtSaveClt.TabIndex = 35;
            this.BtSaveClt.Text = "enregistre";
            this.BtSaveClt.Click += new System.EventHandler(this.BtSaveClt_Click);
            // 
            // cbsex
            // 
            this.cbsex.BackColor = System.Drawing.SystemColors.Control;
            this.cbsex.BorderColor = System.Drawing.Color.Indigo;
            this.cbsex.BorderRadius = 15;
            this.cbsex.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clientBindingSource, "sex", true));
            this.cbsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsex.FocusedColor = System.Drawing.Color.Empty;
            this.cbsex.FocusedState.Parent = this.cbsex;
            this.cbsex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbsex.ForeColor = System.Drawing.Color.DarkGray;
            this.cbsex.FormattingEnabled = true;
            this.cbsex.HoverState.Parent = this.cbsex;
            this.cbsex.ItemHeight = 30;
            this.cbsex.Items.AddRange(new object[] {
            "homme",
            "femme"});
            this.cbsex.ItemsAppearance.Parent = this.cbsex;
            this.cbsex.Location = new System.Drawing.Point(173, 349);
            this.cbsex.Name = "cbsex";
            this.cbsex.ShadowDecoration.Parent = this.cbsex;
            this.cbsex.Size = new System.Drawing.Size(140, 36);
            this.cbsex.TabIndex = 36;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(169, 326);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(36, 20);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "sex";
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2TileButton2.Image")));
            this.guna2TileButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2TileButton2.Location = new System.Drawing.Point(506, 9);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(33, 30);
            this.guna2TileButton2.TabIndex = 35;
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // gset_hotelDataSet2
            // 
            this.gset_hotelDataSet2.DataSetName = "gset_hotelDataSet2";
            this.gset_hotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.gset_hotelDataSet2;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // enregistreClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 532);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cbsex);
            this.Controls.Add(this.BtSaveClt);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.id_client);
            this.Controls.Add(this.nationalit);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "enregistreClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "enregistreClient";
            this.Load += new System.EventHandler(this.enregistreClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox txttelephone;
        private Guna.UI2.WinForms.Guna2TextBox adress;
        private Guna.UI2.WinForms.Guna2TextBox id_client;
        private Guna.UI2.WinForms.Guna2TextBox nationalit;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2Button BtSaveClt;
        private Guna.UI2.WinForms.Guna2ComboBox cbsex;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private gset_hotelDataSet2 gset_hotelDataSet2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private encientTravail.gset_hotelDataSet2TableAdapters.clientTableAdapter clientTableAdapter;
    }
}