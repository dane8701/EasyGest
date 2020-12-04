namespace CustomsGestionHoteliere
{
    partial class gestutilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestutilisateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsex = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbsatut = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtpsw = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtadress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpost = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.txtnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.gset_hotelDataSet = new CustomsGestionHoteliere.gset_hotelDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new CustomsGestionHoteliere.gset_hotelDataSetTableAdapters.agentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(596, 49);
            this.panel1.TabIndex = 2;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(209, 21);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Enregistrement utilisateur";
            // 
            // txtusername
            // 
            this.txtusername.BorderColor = System.Drawing.Color.Indigo;
            this.txtusername.BorderRadius = 16;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "username", true));
            this.txtusername.DefaultText = "Username";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(363, 150);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionStart = 8;
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(211, 36);
            this.txtusername.TabIndex = 31;
            // 
            // txttel
            // 
            this.txttel.BorderColor = System.Drawing.Color.Indigo;
            this.txttel.BorderRadius = 16;
            this.txttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "telephone", true));
            this.txttel.DefaultText = "  Telephone";
            this.txttel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttel.DisabledState.Parent = this.txttel;
            this.txttel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttel.FocusedState.Parent = this.txttel;
            this.txttel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttel.HoverState.Parent = this.txttel;
            this.txttel.Location = new System.Drawing.Point(321, 210);
            this.txttel.Name = "txttel";
            this.txttel.PasswordChar = '\0';
            this.txttel.PlaceholderText = "";
            this.txttel.SelectedText = "";
            this.txttel.SelectionStart = 11;
            this.txttel.ShadowDecoration.Parent = this.txttel;
            this.txttel.Size = new System.Drawing.Size(211, 36);
            this.txttel.TabIndex = 30;
            // 
            // txtsex
            // 
            this.txtsex.BorderColor = System.Drawing.Color.Indigo;
            this.txtsex.BorderRadius = 16;
            this.txtsex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsex.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "sex ", true));
            this.txtsex.DefaultText = "   Sex";
            this.txtsex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsex.DisabledState.Parent = this.txtsex;
            this.txtsex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.FocusedState.Parent = this.txtsex;
            this.txtsex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsex.HoverState.Parent = this.txtsex;
            this.txtsex.Location = new System.Drawing.Point(49, 210);
            this.txtsex.Name = "txtsex";
            this.txtsex.PasswordChar = '\0';
            this.txtsex.PlaceholderText = "";
            this.txtsex.SelectedText = "";
            this.txtsex.SelectionStart = 6;
            this.txtsex.ShadowDecoration.Parent = this.txtsex;
            this.txtsex.Size = new System.Drawing.Size(200, 36);
            this.txtsex.TabIndex = 29;
            // 
            // txtid
            // 
            this.txtid.BorderColor = System.Drawing.Color.Indigo;
            this.txtid.BorderRadius = 16;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "Id_agt", true));
            this.txtid.DefaultText = "Id utilisateur";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.Parent = this.txtid;
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.FocusedState.Parent = this.txtid;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.HoverState.Parent = this.txtid;
            this.txtid.Location = new System.Drawing.Point(12, 101);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.SelectionStart = 14;
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(200, 36);
            this.txtid.TabIndex = 28;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(105, 335);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(61, 20);
            this.bunifuCustomLabel5.TabIndex = 27;
            this.bunifuCustomLabel5.Text = "statut ";
            // 
            // cbsatut
            // 
            this.cbsatut.BackColor = System.Drawing.SystemColors.Control;
            this.cbsatut.BorderColor = System.Drawing.Color.Indigo;
            this.cbsatut.BorderRadius = 15;
            this.cbsatut.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "statut de l agent", true));
            this.cbsatut.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsatut.FocusedColor = System.Drawing.Color.Empty;
            this.cbsatut.FocusedState.Parent = this.cbsatut;
            this.cbsatut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbsatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbsatut.FormattingEnabled = true;
            this.cbsatut.HoverState.Parent = this.cbsatut;
            this.cbsatut.ItemHeight = 30;
            this.cbsatut.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbsatut.ItemsAppearance.Parent = this.cbsatut;
            this.cbsatut.Location = new System.Drawing.Point(109, 358);
            this.cbsatut.Name = "cbsatut";
            this.cbsatut.ShadowDecoration.Parent = this.cbsatut;
            this.cbsatut.Size = new System.Drawing.Size(140, 36);
            this.cbsatut.TabIndex = 26;
            // 
            // txtpsw
            // 
            this.txtpsw.BorderColor = System.Drawing.Color.Indigo;
            this.txtpsw.BorderRadius = 16;
            this.txtpsw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpsw.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "mot de passe ", true));
            this.txtpsw.DefaultText = "Mot de passe";
            this.txtpsw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpsw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpsw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpsw.DisabledState.Parent = this.txtpsw;
            this.txtpsw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpsw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpsw.FocusedState.Parent = this.txtpsw;
            this.txtpsw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpsw.HoverState.Parent = this.txtpsw;
            this.txtpsw.Location = new System.Drawing.Point(270, 358);
            this.txtpsw.Name = "txtpsw";
            this.txtpsw.PasswordChar = '\0';
            this.txtpsw.PlaceholderText = "";
            this.txtpsw.SelectedText = "";
            this.txtpsw.SelectionStart = 12;
            this.txtpsw.ShadowDecoration.Parent = this.txtpsw;
            this.txtpsw.Size = new System.Drawing.Size(177, 36);
            this.txtpsw.TabIndex = 25;
            // 
            // txtadress
            // 
            this.txtadress.BorderColor = System.Drawing.Color.Indigo;
            this.txtadress.BorderRadius = 16;
            this.txtadress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "adress", true));
            this.txtadress.DefaultText = "  adress";
            this.txtadress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadress.DisabledState.Parent = this.txtadress;
            this.txtadress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadress.FocusedState.Parent = this.txtadress;
            this.txtadress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadress.HoverState.Parent = this.txtadress;
            this.txtadress.Location = new System.Drawing.Point(85, 279);
            this.txtadress.Name = "txtadress";
            this.txtadress.PasswordChar = '\0';
            this.txtadress.PlaceholderText = "";
            this.txtadress.SelectedText = "";
            this.txtadress.SelectionStart = 8;
            this.txtadress.ShadowDecoration.Parent = this.txtadress;
            this.txtadress.Size = new System.Drawing.Size(187, 36);
            this.txtadress.TabIndex = 23;
            // 
            // txtpost
            // 
            this.txtpost.BorderColor = System.Drawing.Color.Indigo;
            this.txtpost.BorderRadius = 16;
            this.txtpost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpost.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "fonction de l agent ", true));
            this.txtpost.DefaultText = "poste";
            this.txtpost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpost.DisabledState.Parent = this.txtpost;
            this.txtpost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpost.FocusedState.Parent = this.txtpost;
            this.txtpost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpost.HoverState.Parent = this.txtpost;
            this.txtpost.Location = new System.Drawing.Point(293, 279);
            this.txtpost.Name = "txtpost";
            this.txtpost.PasswordChar = '\0';
            this.txtpost.PlaceholderText = "";
            this.txtpost.SelectedText = "";
            this.txtpost.SelectionStart = 5;
            this.txtpost.ShadowDecoration.Parent = this.txtpost;
            this.txtpost.Size = new System.Drawing.Size(211, 36);
            this.txtpost.TabIndex = 22;
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
            this.guna2Button16.Location = new System.Drawing.Point(176, 483);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.ShadowDecoration.Parent = this.guna2Button16;
            this.guna2Button16.Size = new System.Drawing.Size(188, 45);
            this.guna2Button16.TabIndex = 59;
            this.guna2Button16.Text = "enregistrer";
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // txtnom
            // 
            this.txtnom.BorderColor = System.Drawing.Color.Indigo;
            this.txtnom.BorderRadius = 16;
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "nom complet", true));
            this.txtnom.DefaultText = "nom";
            this.txtnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.DisabledState.Parent = this.txtnom;
            this.txtnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.FocusedState.Parent = this.txtnom;
            this.txtnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.HoverState.Parent = this.txtnom;
            this.txtnom.Location = new System.Drawing.Point(17, 150);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderText = "";
            this.txtnom.SelectedText = "";
            this.txtnom.SelectionStart = 3;
            this.txtnom.ShadowDecoration.Parent = this.txtnom;
            this.txtnom.Size = new System.Drawing.Size(329, 36);
            this.txtnom.TabIndex = 60;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
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
            this.guna2TileButton2.Location = new System.Drawing.Point(551, 9);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(33, 30);
            this.guna2TileButton2.TabIndex = 35;
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // gset_hotelDataSet
            // 
            this.gset_hotelDataSet.DataSetName = "gset_hotelDataSet";
            this.gset_hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "agent";
            this.bindingSource1.DataSource = this.gset_hotelDataSet;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // gestutilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 572);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.guna2Button16);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.cbsatut);
            this.Controls.Add(this.txtpsw);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.txtpost);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestutilisateur";
            this.Text = "utilisateur";
            this.Load += new System.EventHandler(this.utilisateur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txttel;
        private Guna.UI2.WinForms.Guna2TextBox txtsex;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbsatut;
        private Guna.UI2.WinForms.Guna2TextBox txtpsw;
        private Guna.UI2.WinForms.Guna2TextBox txtadress;
        private Guna.UI2.WinForms.Guna2TextBox txtpost;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
       
        private System.Windows.Forms.BindingSource agentBindingSource;
      
        private Guna.UI2.WinForms.Guna2TextBox txtnom;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private gset_hotelDataSet gset_hotelDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private gset_hotelDataSetTableAdapters.agentTableAdapter agentTableAdapter;
    }
}