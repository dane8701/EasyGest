namespace CustomsGestionHoteliere
{
    partial class gestfacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestfacture));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbdure = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbmttotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel25 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbidreserv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbidclient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbidagent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbmodepaiement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbdatefact = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbidfactu = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.gset_hotelDataSet = new CustomsGestionHoteliere.gset_hotelDataSet();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factureTableAdapter = new CustomsGestionHoteliere.gset_hotelDataSetTableAdapters.factureTableAdapter();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(514, 49);
            this.panel1.TabIndex = 2;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 21);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Enregistrement facture";
            // 
            // cbdure
            // 
            this.cbdure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbdure.BorderRadius = 16;
            this.cbdure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbdure.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "dure du sejour ", true));
            this.cbdure.DefaultText = "   dure du sejour";
            this.cbdure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbdure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbdure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbdure.DisabledState.Parent = this.cbdure;
            this.cbdure.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbdure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdure.FocusedState.Parent = this.cbdure;
            this.cbdure.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdure.HoverState.Parent = this.cbdure;
            this.cbdure.Location = new System.Drawing.Point(257, 266);
            this.cbdure.Name = "cbdure";
            this.cbdure.PasswordChar = '\0';
            this.cbdure.PlaceholderText = "";
            this.cbdure.SelectedText = "";
            this.cbdure.SelectionStart = 17;
            this.cbdure.ShadowDecoration.Parent = this.cbdure;
            this.cbdure.Size = new System.Drawing.Size(178, 36);
            this.cbdure.TabIndex = 56;
            this.cbdure.TextChanged += new System.EventHandler(this.guna2TextBox12_TextChanged);
            // 
            // cbmttotal
            // 
            this.cbmttotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbmttotal.BorderRadius = 16;
            this.cbmttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbmttotal.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "montant total ", true));
            this.cbmttotal.DefaultText = "Montant total";
            this.cbmttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbmttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbmttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbmttotal.DisabledState.Parent = this.cbmttotal;
            this.cbmttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbmttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmttotal.FocusedState.Parent = this.cbmttotal;
            this.cbmttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmttotal.HoverState.Parent = this.cbmttotal;
            this.cbmttotal.Location = new System.Drawing.Point(69, 344);
            this.cbmttotal.Name = "cbmttotal";
            this.cbmttotal.PasswordChar = '\0';
            this.cbmttotal.PlaceholderText = "";
            this.cbmttotal.SelectedText = "";
            this.cbmttotal.SelectionStart = 13;
            this.cbmttotal.ShadowDecoration.Parent = this.cbmttotal;
            this.cbmttotal.Size = new System.Drawing.Size(178, 36);
            this.cbmttotal.TabIndex = 55;
            // 
            // bunifuCustomLabel25
            // 
            this.bunifuCustomLabel25.AutoSize = true;
            this.bunifuCustomLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel25.Location = new System.Drawing.Point(293, 162);
            this.bunifuCustomLabel25.Name = "bunifuCustomLabel25";
            this.bunifuCustomLabel25.Size = new System.Drawing.Size(117, 20);
            this.bunifuCustomLabel25.TabIndex = 54;
            this.bunifuCustomLabel25.Text = "id reservation";
            // 
            // cbidreserv
            // 
            this.cbidreserv.BackColor = System.Drawing.Color.Transparent;
            this.cbidreserv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbidreserv.BorderRadius = 15;
            this.cbidreserv.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "Id_reservation", true));
            this.cbidreserv.DisplayMember = "Id_reservation";
            this.cbidreserv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidreserv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidreserv.FocusedColor = System.Drawing.Color.Empty;
            this.cbidreserv.FocusedState.Parent = this.cbidreserv;
            this.cbidreserv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbidreserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbidreserv.FormattingEnabled = true;
            this.cbidreserv.HoverState.Parent = this.cbidreserv;
            this.cbidreserv.ItemHeight = 30;
            this.cbidreserv.ItemsAppearance.Parent = this.cbidreserv;
            this.cbidreserv.Location = new System.Drawing.Point(289, 197);
            this.cbidreserv.Name = "cbidreserv";
            this.cbidreserv.ShadowDecoration.Parent = this.cbidreserv;
            this.cbidreserv.Size = new System.Drawing.Size(200, 36);
            this.cbidreserv.TabIndex = 53;
            this.cbidreserv.ValueMember = "Id_reservation";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(35, 176);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(74, 20);
            this.bunifuCustomLabel15.TabIndex = 52;
            this.bunifuCustomLabel15.Text = "id agent";
            // 
            // cbidclient
            // 
            this.cbidclient.BackColor = System.Drawing.Color.Transparent;
            this.cbidclient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbidclient.BorderRadius = 15;
            this.cbidclient.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "Id_client", true));
            this.cbidclient.DisplayMember = "Id_client";
            this.cbidclient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidclient.FocusedColor = System.Drawing.Color.Empty;
            this.cbidclient.FocusedState.Parent = this.cbidclient;
            this.cbidclient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbidclient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbidclient.FormattingEnabled = true;
            this.cbidclient.HoverState.Parent = this.cbidclient;
            this.cbidclient.ItemHeight = 30;
            this.cbidclient.ItemsAppearance.Parent = this.cbidclient;
            this.cbidclient.Location = new System.Drawing.Point(7, 127);
            this.cbidclient.Name = "cbidclient";
            this.cbidclient.ShadowDecoration.Parent = this.cbidclient;
            this.cbidclient.Size = new System.Drawing.Size(200, 36);
            this.cbidclient.TabIndex = 51;
            this.cbidclient.ValueMember = "Id_client";
            // 
            // cbidagent
            // 
            this.cbidagent.BackColor = System.Drawing.Color.Transparent;
            this.cbidagent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbidagent.BorderRadius = 15;
            this.cbidagent.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "Id_agt", true));
            this.cbidagent.DisplayMember = "Id_agt";
            this.cbidagent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidagent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidagent.FocusedColor = System.Drawing.Color.Empty;
            this.cbidagent.FocusedState.Parent = this.cbidagent;
            this.cbidagent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbidagent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbidagent.FormattingEnabled = true;
            this.cbidagent.HoverState.Parent = this.cbidagent;
            this.cbidagent.ItemHeight = 30;
            this.cbidagent.ItemsAppearance.Parent = this.cbidagent;
            this.cbidagent.Location = new System.Drawing.Point(7, 199);
            this.cbidagent.Name = "cbidagent";
            this.cbidagent.ShadowDecoration.Parent = this.cbidagent;
            this.cbidagent.Size = new System.Drawing.Size(200, 36);
            this.cbidagent.TabIndex = 50;
            this.cbidagent.ValueMember = "Id_agt";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(231, 321);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(157, 20);
            this.bunifuCustomLabel18.TabIndex = 49;
            this.bunifuCustomLabel18.Text = "mode de paiement";
            // 
            // cbmodepaiement
            // 
            this.cbmodepaiement.BackColor = System.Drawing.Color.Transparent;
            this.cbmodepaiement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbmodepaiement.BorderRadius = 15;
            this.cbmodepaiement.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "mode paiement", true));
            this.cbmodepaiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmodepaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmodepaiement.FocusedColor = System.Drawing.Color.Empty;
            this.cbmodepaiement.FocusedState.Parent = this.cbmodepaiement;
            this.cbmodepaiement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmodepaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmodepaiement.FormattingEnabled = true;
            this.cbmodepaiement.HoverState.Parent = this.cbmodepaiement;
            this.cbmodepaiement.ItemHeight = 30;
            this.cbmodepaiement.Items.AddRange(new object[] {
            "par carte ",
            "espece",
            "cheque"});
            this.cbmodepaiement.ItemsAppearance.Parent = this.cbmodepaiement;
            this.cbmodepaiement.Location = new System.Drawing.Point(253, 344);
            this.cbmodepaiement.Name = "cbmodepaiement";
            this.cbmodepaiement.ShadowDecoration.Parent = this.cbmodepaiement;
            this.cbmodepaiement.Size = new System.Drawing.Size(157, 36);
            this.cbmodepaiement.TabIndex = 48;
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(47, 243);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(132, 20);
            this.bunifuCustomLabel22.TabIndex = 47;
            this.bunifuCustomLabel22.Text = "date de facture";
            // 
            // cbdatefact
            // 
            this.cbdatefact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbdatefact.BorderRadius = 16;
            this.cbdatefact.BorderThickness = 1;
            this.cbdatefact.CheckedState.Parent = this.cbdatefact;
            this.cbdatefact.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "date facture ", true));
            this.cbdatefact.FillColor = System.Drawing.Color.White;
            this.cbdatefact.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbdatefact.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cbdatefact.HoverState.Parent = this.cbdatefact;
            this.cbdatefact.Location = new System.Drawing.Point(51, 266);
            this.cbdatefact.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbdatefact.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbdatefact.Name = "cbdatefact";
            this.cbdatefact.ShadowDecoration.Parent = this.cbdatefact;
            this.cbdatefact.Size = new System.Drawing.Size(200, 36);
            this.cbdatefact.TabIndex = 46;
            this.cbdatefact.Value = new System.DateTime(2020, 8, 29, 0, 0, 0, 0);
            // 
            // cbidfactu
            // 
            this.cbidfactu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbidfactu.BorderRadius = 16;
            this.cbidfactu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbidfactu.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.factureBindingSource, "Id_facture", true));
            this.cbidfactu.DefaultText = "  Id facture";
            this.cbidfactu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cbidfactu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cbidfactu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbidfactu.DisabledState.Parent = this.cbidfactu;
            this.cbidfactu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbidfactu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidfactu.FocusedState.Parent = this.cbidfactu;
            this.cbidfactu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidfactu.HoverState.Parent = this.cbidfactu;
            this.cbidfactu.Location = new System.Drawing.Point(275, 123);
            this.cbidfactu.Name = "cbidfactu";
            this.cbidfactu.PasswordChar = '\0';
            this.cbidfactu.PlaceholderText = "";
            this.cbidfactu.SelectedText = "";
            this.cbidfactu.SelectionStart = 12;
            this.cbidfactu.ShadowDecoration.Parent = this.cbidfactu;
            this.cbidfactu.Size = new System.Drawing.Size(227, 36);
            this.cbidfactu.TabIndex = 44;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 104);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 20);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "id client";
            // 
            // guna2Button16
            // 
            this.guna2Button16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button16.BorderRadius = 19;
            this.guna2Button16.BorderThickness = 2;
            this.guna2Button16.CheckedState.Parent = this.guna2Button16;
            this.guna2Button16.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button16.CustomImages.Parent = this.guna2Button16;
            this.guna2Button16.FillColor = System.Drawing.Color.Indigo;
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.HoverState.Parent = this.guna2Button16;
            this.guna2Button16.Location = new System.Drawing.Point(144, 477);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.ShadowDecoration.Parent = this.guna2Button16;
            this.guna2Button16.Size = new System.Drawing.Size(188, 45);
            this.guna2Button16.TabIndex = 58;
            this.guna2Button16.Text = "enregistrer";
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // gset_hotelDataSet
            // 
            this.gset_hotelDataSet.DataSetName = "gset_hotelDataSet";
            this.gset_hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "facture";
            this.factureBindingSource.DataSource = this.gset_hotelDataSet;
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
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
            this.guna2TileButton2.Location = new System.Drawing.Point(469, 9);
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
            // gestfacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 579);
            this.Controls.Add(this.guna2Button16);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cbdure);
            this.Controls.Add(this.cbmttotal);
            this.Controls.Add(this.bunifuCustomLabel25);
            this.Controls.Add(this.cbidreserv);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.cbidclient);
            this.Controls.Add(this.cbidagent);
            this.Controls.Add(this.bunifuCustomLabel18);
            this.Controls.Add(this.cbmodepaiement);
            this.Controls.Add(this.bunifuCustomLabel22);
            this.Controls.Add(this.cbdatefact);
            this.Controls.Add(this.cbidfactu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestfacture";
            this.Text = "gestReglement";
            this.Load += new System.EventHandler(this.gestfacture_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2TextBox cbdure;
        private Guna.UI2.WinForms.Guna2TextBox cbmttotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel25;
        private Guna.UI2.WinForms.Guna2ComboBox cbidreserv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Guna.UI2.WinForms.Guna2ComboBox cbidclient;
        private Guna.UI2.WinForms.Guna2ComboBox cbidagent;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Guna.UI2.WinForms.Guna2ComboBox cbmodepaiement;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private Guna.UI2.WinForms.Guna2DateTimePicker cbdatefact;
        private Guna.UI2.WinForms.Guna2TextBox cbidfactu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private gset_hotelDataSet gset_hotelDataSet;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private gset_hotelDataSetTableAdapters.factureTableAdapter factureTableAdapter;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}