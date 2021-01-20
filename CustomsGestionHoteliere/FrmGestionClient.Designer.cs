
namespace CustomsGestionHoteliere.newForm
{
    partial class FrmGestionClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionClient));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.addUtilisateur = new System.Windows.Forms.TabPage();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbIdTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrenomClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtNomClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new System.Windows.Forms.PictureBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.addUtilisateur.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.addUtilisateur);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 52);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(847, 513);
            this.materialTabControl1.TabIndex = 13;
            // 
            // addUtilisateur
            // 
            this.addUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.addUtilisateur.Controls.Add(this.txtEmail);
            this.addUtilisateur.Controls.Add(this.gunaLabel1);
            this.addUtilisateur.Controls.Add(this.cbIdTable);
            this.addUtilisateur.Controls.Add(this.txtPrenomClient);
            this.addUtilisateur.Controls.Add(this.btnSave);
            this.addUtilisateur.Controls.Add(this.txtNomClient);
            this.addUtilisateur.Controls.Add(this.txtTelephone);
            this.addUtilisateur.Controls.Add(this.txtAdresse);
            this.addUtilisateur.Location = new System.Drawing.Point(4, 22);
            this.addUtilisateur.Name = "addUtilisateur";
            this.addUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.addUtilisateur.Size = new System.Drawing.Size(839, 487);
            this.addUtilisateur.TabIndex = 0;
            this.addUtilisateur.Text = "Ajouter Client";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.txtEmail.BorderRadius = 16;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(184, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(200, 36);
            this.txtEmail.TabIndex = 75;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(410, 207);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel1.TabIndex = 74;
            this.gunaLabel1.Text = "N° Table";
            // 
            // cbIdTable
            // 
            this.cbIdTable.BackColor = System.Drawing.SystemColors.Control;
            this.cbIdTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.cbIdTable.BorderRadius = 15;
            this.cbIdTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIdTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdTable.FocusedColor = System.Drawing.Color.Empty;
            this.cbIdTable.FocusedState.Parent = this.cbIdTable;
            this.cbIdTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIdTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIdTable.FormattingEnabled = true;
            this.cbIdTable.HoverState.Parent = this.cbIdTable;
            this.cbIdTable.ItemHeight = 30;
            this.cbIdTable.Items.AddRange(new object[] {
            "1"});
            this.cbIdTable.ItemsAppearance.Parent = this.cbIdTable;
            this.cbIdTable.Location = new System.Drawing.Point(413, 225);
            this.cbIdTable.Name = "cbIdTable";
            this.cbIdTable.ShadowDecoration.Parent = this.cbIdTable;
            this.cbIdTable.Size = new System.Drawing.Size(200, 36);
            this.cbIdTable.TabIndex = 5;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.txtPrenomClient.BorderRadius = 16;
            this.txtPrenomClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenomClient.DefaultText = "";
            this.txtPrenomClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrenomClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrenomClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenomClient.DisabledState.Parent = this.txtPrenomClient;
            this.txtPrenomClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenomClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenomClient.FocusedState.Parent = this.txtPrenomClient;
            this.txtPrenomClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenomClient.HoverState.Parent = this.txtPrenomClient;
            this.txtPrenomClient.Location = new System.Drawing.Point(413, 79);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.PasswordChar = '\0';
            this.txtPrenomClient.PlaceholderText = "Prenom Client";
            this.txtPrenomClient.SelectedText = "";
            this.txtPrenomClient.ShadowDecoration.Parent = this.txtPrenomClient;
            this.txtPrenomClient.Size = new System.Drawing.Size(200, 36);
            this.txtPrenomClient.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.BorderRadius = 19;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(297, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(211, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNomClient
            // 
            this.txtNomClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.txtNomClient.BorderRadius = 16;
            this.txtNomClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomClient.DefaultText = "";
            this.txtNomClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomClient.DisabledState.Parent = this.txtNomClient;
            this.txtNomClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomClient.FocusedState.Parent = this.txtNomClient;
            this.txtNomClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomClient.HoverState.Parent = this.txtNomClient;
            this.txtNomClient.Location = new System.Drawing.Point(184, 79);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.PasswordChar = '\0';
            this.txtNomClient.PlaceholderText = "Nom Client";
            this.txtNomClient.SelectedText = "";
            this.txtNomClient.ShadowDecoration.Parent = this.txtNomClient;
            this.txtNomClient.Size = new System.Drawing.Size(200, 36);
            this.txtNomClient.TabIndex = 1;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.txtTelephone.BorderRadius = 16;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.DefaultText = "";
            this.txtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.DisabledState.Parent = this.txtTelephone;
            this.txtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.FocusedState.Parent = this.txtTelephone;
            this.txtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.HoverState.Parent = this.txtTelephone;
            this.txtTelephone.Location = new System.Drawing.Point(184, 149);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PlaceholderText = "Telephone";
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.ShadowDecoration.Parent = this.txtTelephone;
            this.txtTelephone.Size = new System.Drawing.Size(200, 36);
            this.txtTelephone.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.txtAdresse.BorderRadius = 16;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.DefaultText = "";
            this.txtAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.DisabledState.Parent = this.txtAdresse;
            this.txtAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.FocusedState.Parent = this.txtAdresse;
            this.txtAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.HoverState.Parent = this.txtAdresse;
            this.txtAdresse.Location = new System.Drawing.Point(413, 149);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.PlaceholderText = "Adresse";
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.ShadowDecoration.Parent = this.txtAdresse;
            this.txtAdresse.Size = new System.Drawing.Size(200, 36);
            this.txtAdresse.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste Client";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 16;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(3, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(108, 45);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 16;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.btnRefresh.FillColor2 = System.Drawing.Color.Green;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(117, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(108, 45);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 16;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(231, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(108, 45);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 16;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(721, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(108, 45);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Rechercher";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.txtSearch.BorderRadius = 16;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(458, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Recherche";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(257, 45);
            this.txtSearch.TabIndex = 16;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Liste Client";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(171, 12);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(166, 35);
            this.bunifuFlatButton2.TabIndex = 12;
            this.bunifuFlatButton2.Text = "Liste Client";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ajouter Client";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(153, 30);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "Ajouter Client";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.slider.Location = new System.Drawing.Point(12, 44);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(153, 10);
            this.slider.TabIndex = 11;
            this.slider.TabStop = false;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.White;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::CustomsGestionHoteliere.Properties.Resources.delete_96px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(823, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(36, 26);
            this.gunaImageButton1.TabIndex = 14;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(839, 369);
            this.dataGridView1.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 92.978F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Nom";
            this.Column6.FillWeight = 92.978F;
            this.Column6.HeaderText = "Nom";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Prenom";
            this.Column7.FillWeight = 92.978F;
            this.Column7.HeaderText = "Prénom";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Contact";
            this.Column8.FillWeight = 92.978F;
            this.Column8.HeaderText = "Contact";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Email";
            this.Column9.FillWeight = 142.132F;
            this.Column9.HeaderText = "Email";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Adresse";
            this.Column10.FillWeight = 92.978F;
            this.Column10.HeaderText = "Adresse";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "IdTable";
            this.Column11.FillWeight = 92.978F;
            this.Column11.HeaderText = "IdTable";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // FrmGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.bunifuFlatButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionClient";
            this.Load += new System.EventHandler(this.FrmGestionClient_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.addUtilisateur.ResumeLayout(false);
            this.addUtilisateur.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage addUtilisateur;
        private Guna.UI2.WinForms.Guna2TextBox txtPrenomClient;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtNomClient;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephone;
        private Guna.UI2.WinForms.Guna2TextBox txtAdresse;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbIdTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tABLESidTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMANDESidComandeDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}