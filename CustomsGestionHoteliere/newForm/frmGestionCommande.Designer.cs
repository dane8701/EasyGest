namespace CustomsGestionHoteliere.newForm
{
    partial class FrmGestionCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionCommande));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.AjouterUtilisateur = new System.Windows.Forms.TabPage();
            this.txtprg = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbDatefCommande = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtQuantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrixUnitaire = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdCommande = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtmenueID = new Guna.UI2.WinForms.Guna2TextBox();
            this.ListeCommande = new System.Windows.Forms.TabPage();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomDataGrid4 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idComandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateComandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantUnitaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantGlobalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuidMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMANDESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.easyGestDataSet5 = new CustomsGestionHoteliere.EasyGestDataSet5();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cOMMANDESTableAdapter = new CustomsGestionHoteliere.EasyGestDataSet5TableAdapters.COMMANDESTableAdapter();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.materialTabControl1.SuspendLayout();
            this.AjouterUtilisateur.SuspendLayout();
            this.ListeCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyGestDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.AjouterUtilisateur);
            this.materialTabControl1.Controls.Add(this.ListeCommande);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(1, 49);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(858, 516);
            this.materialTabControl1.TabIndex = 11;
            // 
            // AjouterUtilisateur
            // 
            this.AjouterUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.AjouterUtilisateur.Controls.Add(this.txtprg);
            this.AjouterUtilisateur.Controls.Add(this.cbDatefCommande);
            this.AjouterUtilisateur.Controls.Add(this.txtQuantite);
            this.AjouterUtilisateur.Controls.Add(this.btnEnregistrer);
            this.AjouterUtilisateur.Controls.Add(this.txtPrixUnitaire);
            this.AjouterUtilisateur.Controls.Add(this.txtIdCommande);
            this.AjouterUtilisateur.Controls.Add(this.bunifuCustomLabel5);
            this.AjouterUtilisateur.Controls.Add(this.txtmenueID);
            this.AjouterUtilisateur.Location = new System.Drawing.Point(4, 22);
            this.AjouterUtilisateur.Name = "AjouterUtilisateur";
            this.AjouterUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.AjouterUtilisateur.Size = new System.Drawing.Size(850, 490);
            this.AjouterUtilisateur.TabIndex = 0;
            this.AjouterUtilisateur.Text = "AjouterCommande";
            this.AjouterUtilisateur.Click += new System.EventHandler(this.addUtilisateur_Click);
            // 
            // txtprg
            // 
            this.txtprg.BorderColor = System.Drawing.Color.Indigo;
            this.txtprg.BorderRadius = 16;
            this.txtprg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprg.DefaultText = "PrixGlobal";
            this.txtprg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprg.DisabledState.Parent = this.txtprg;
            this.txtprg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprg.FocusedState.Parent = this.txtprg;
            this.txtprg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprg.HoverState.Parent = this.txtprg;
            this.txtprg.Location = new System.Drawing.Point(467, 187);
            this.txtprg.Margin = new System.Windows.Forms.Padding(4);
            this.txtprg.Name = "txtprg";
            this.txtprg.PasswordChar = '\0';
            this.txtprg.PlaceholderText = "";
            this.txtprg.SelectedText = "";
            this.txtprg.SelectionStart = 10;
            this.txtprg.ShadowDecoration.Parent = this.txtprg;
            this.txtprg.Size = new System.Drawing.Size(177, 36);
            this.txtprg.TabIndex = 66;
            // 
            // cbDatefCommande
            // 
            this.cbDatefCommande.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbDatefCommande.BorderRadius = 16;
            this.cbDatefCommande.BorderThickness = 1;
            this.cbDatefCommande.CheckedState.Parent = this.cbDatefCommande;
            this.cbDatefCommande.FillColor = System.Drawing.Color.White;
            this.cbDatefCommande.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbDatefCommande.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cbDatefCommande.HoverState.Parent = this.cbDatefCommande;
            this.cbDatefCommande.Location = new System.Drawing.Point(444, 74);
            this.cbDatefCommande.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbDatefCommande.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbDatefCommande.Name = "cbDatefCommande";
            this.cbDatefCommande.ShadowDecoration.Parent = this.cbDatefCommande;
            this.cbDatefCommande.Size = new System.Drawing.Size(200, 36);
            this.cbDatefCommande.TabIndex = 1;
            this.cbDatefCommande.Value = new System.DateTime(2020, 8, 29, 0, 0, 0, 0);
            // 
            // txtQuantite
            // 
            this.txtQuantite.BorderColor = System.Drawing.Color.Indigo;
            this.txtQuantite.BorderRadius = 16;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantite.DefaultText = "Quantite";
            this.txtQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.DisabledState.Parent = this.txtQuantite;
            this.txtQuantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantite.FocusedState.Parent = this.txtQuantite;
            this.txtQuantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantite.HoverState.Parent = this.txtQuantite;
            this.txtQuantite.Location = new System.Drawing.Point(161, 131);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.PasswordChar = '\0';
            this.txtQuantite.PlaceholderText = "";
            this.txtQuantite.SelectedText = "";
            this.txtQuantite.SelectionStart = 8;
            this.txtQuantite.ShadowDecoration.Parent = this.txtQuantite;
            this.txtQuantite.Size = new System.Drawing.Size(483, 36);
            this.txtQuantite.TabIndex = 2;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.BorderRadius = 19;
            this.btnEnregistrer.BorderThickness = 2;
            this.btnEnregistrer.CheckedState.Parent = this.btnEnregistrer;
            this.btnEnregistrer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.CustomImages.Parent = this.btnEnregistrer;
            this.btnEnregistrer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.HoverState.Parent = this.btnEnregistrer;
            this.btnEnregistrer.Location = new System.Drawing.Point(316, 375);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.ShadowDecoration.Parent = this.btnEnregistrer;
            this.btnEnregistrer.Size = new System.Drawing.Size(188, 45);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.BorderColor = System.Drawing.Color.Indigo;
            this.txtPrixUnitaire.BorderRadius = 16;
            this.txtPrixUnitaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixUnitaire.DefaultText = "PrixUnitaire";
            this.txtPrixUnitaire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrixUnitaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrixUnitaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrixUnitaire.DisabledState.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrixUnitaire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrixUnitaire.FocusedState.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrixUnitaire.HoverState.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.Location = new System.Drawing.Point(161, 187);
            this.txtPrixUnitaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.PasswordChar = '\0';
            this.txtPrixUnitaire.PlaceholderText = "";
            this.txtPrixUnitaire.SelectedText = "";
            this.txtPrixUnitaire.SelectionStart = 12;
            this.txtPrixUnitaire.ShadowDecoration.Parent = this.txtPrixUnitaire;
            this.txtPrixUnitaire.Size = new System.Drawing.Size(200, 36);
            this.txtPrixUnitaire.TabIndex = 3;
            // 
            // txtIdCommande
            // 
            this.txtIdCommande.BorderColor = System.Drawing.Color.Indigo;
            this.txtIdCommande.BorderRadius = 16;
            this.txtIdCommande.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCommande.DefaultText = "id Commande";
            this.txtIdCommande.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCommande.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCommande.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCommande.DisabledState.Parent = this.txtIdCommande;
            this.txtIdCommande.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCommande.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCommande.FocusedState.Parent = this.txtIdCommande;
            this.txtIdCommande.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCommande.HoverState.Parent = this.txtIdCommande;
            this.txtIdCommande.Location = new System.Drawing.Point(161, 74);
            this.txtIdCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCommande.Name = "txtIdCommande";
            this.txtIdCommande.PasswordChar = '\0';
            this.txtIdCommande.PlaceholderText = "";
            this.txtIdCommande.SelectedText = "";
            this.txtIdCommande.SelectionStart = 11;
            this.txtIdCommande.ShadowDecoration.Parent = this.txtIdCommande;
            this.txtIdCommande.Size = new System.Drawing.Size(200, 36);
            this.txtIdCommande.TabIndex = 0;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(347, 303);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(0, 20);
            this.bunifuCustomLabel5.TabIndex = 65;
            // 
            // txtmenueID
            // 
            this.txtmenueID.BorderColor = System.Drawing.Color.Indigo;
            this.txtmenueID.BorderRadius = 16;
            this.txtmenueID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmenueID.DefaultText = "Menu id";
            this.txtmenueID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmenueID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmenueID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmenueID.DisabledState.Parent = this.txtmenueID;
            this.txtmenueID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmenueID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmenueID.FocusedState.Parent = this.txtmenueID;
            this.txtmenueID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmenueID.HoverState.Parent = this.txtmenueID;
            this.txtmenueID.Location = new System.Drawing.Point(161, 248);
            this.txtmenueID.Margin = new System.Windows.Forms.Padding(4);
            this.txtmenueID.Name = "txtmenueID";
            this.txtmenueID.PasswordChar = '\0';
            this.txtmenueID.PlaceholderText = "";
            this.txtmenueID.SelectedText = "";
            this.txtmenueID.SelectionStart = 7;
            this.txtmenueID.ShadowDecoration.Parent = this.txtmenueID;
            this.txtmenueID.Size = new System.Drawing.Size(483, 36);
            this.txtmenueID.TabIndex = 4;
            this.txtmenueID.TextChanged += new System.EventHandler(this.txtPrixGlobal_TextChanged);
            // 
            // ListeCommande
            // 
            this.ListeCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ListeCommande.Controls.Add(this.guna2GradientButton2);
            this.ListeCommande.Controls.Add(this.guna2GradientButton1);
            this.ListeCommande.Controls.Add(this.guna2GradientButton4);
            this.ListeCommande.Controls.Add(this.guna2TextBox4);
            this.ListeCommande.Controls.Add(this.bunifuCustomDataGrid4);
            this.ListeCommande.Location = new System.Drawing.Point(4, 22);
            this.ListeCommande.Name = "ListeCommande";
            this.ListeCommande.Padding = new System.Windows.Forms.Padding(3);
            this.ListeCommande.Size = new System.Drawing.Size(850, 490);
            this.ListeCommande.TabIndex = 1;
            this.ListeCommande.Text = "ListeCommande";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 16;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(141, 61);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton2.TabIndex = 18;
            this.guna2GradientButton2.Text = "Refresh";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 16;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(7, 61);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton1.TabIndex = 17;
            this.guna2GradientButton1.Text = "Update";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 16;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(725, 33);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton4.TabIndex = 16;
            this.guna2GradientButton4.Text = "Rechercher";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2TextBox4.BorderRadius = 16;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = " Recherche";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox4.IconLeft")));
            this.guna2TextBox4.Location = new System.Drawing.Point(452, 33);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.SelectionStart = 10;
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(257, 45);
            this.guna2TextBox4.TabIndex = 15;
            // 
            // bunifuCustomDataGrid4
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid4.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComandeDataGridViewTextBoxColumn,
            this.dateComandeDataGridViewTextBoxColumn,
            this.quantiterDataGridViewTextBoxColumn,
            this.montantUnitaireDataGridViewTextBoxColumn,
            this.montantGlobalDataGridViewTextBoxColumn,
            this.menuidMenuDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid4.DataSource = this.cOMMANDESBindingSource;
            this.bunifuCustomDataGrid4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid4.DoubleBuffered = true;
            this.bunifuCustomDataGrid4.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.bunifuCustomDataGrid4.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.bunifuCustomDataGrid4.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.Location = new System.Drawing.Point(3, 112);
            this.bunifuCustomDataGrid4.Name = "bunifuCustomDataGrid4";
            this.bunifuCustomDataGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid4.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid4.Size = new System.Drawing.Size(844, 375);
            this.bunifuCustomDataGrid4.TabIndex = 13;
            // 
            // idComandeDataGridViewTextBoxColumn
            // 
            this.idComandeDataGridViewTextBoxColumn.DataPropertyName = "idComande";
            this.idComandeDataGridViewTextBoxColumn.HeaderText = "idComande";
            this.idComandeDataGridViewTextBoxColumn.Name = "idComandeDataGridViewTextBoxColumn";
            // 
            // dateComandeDataGridViewTextBoxColumn
            // 
            this.dateComandeDataGridViewTextBoxColumn.DataPropertyName = "dateComande";
            this.dateComandeDataGridViewTextBoxColumn.HeaderText = "dateComande";
            this.dateComandeDataGridViewTextBoxColumn.Name = "dateComandeDataGridViewTextBoxColumn";
            // 
            // quantiterDataGridViewTextBoxColumn
            // 
            this.quantiterDataGridViewTextBoxColumn.DataPropertyName = "quantiter";
            this.quantiterDataGridViewTextBoxColumn.HeaderText = "quantiter";
            this.quantiterDataGridViewTextBoxColumn.Name = "quantiterDataGridViewTextBoxColumn";
            // 
            // montantUnitaireDataGridViewTextBoxColumn
            // 
            this.montantUnitaireDataGridViewTextBoxColumn.DataPropertyName = "montantUnitaire";
            this.montantUnitaireDataGridViewTextBoxColumn.HeaderText = "montantUnitaire";
            this.montantUnitaireDataGridViewTextBoxColumn.Name = "montantUnitaireDataGridViewTextBoxColumn";
            // 
            // montantGlobalDataGridViewTextBoxColumn
            // 
            this.montantGlobalDataGridViewTextBoxColumn.DataPropertyName = "montantGlobal";
            this.montantGlobalDataGridViewTextBoxColumn.HeaderText = "montantGlobal";
            this.montantGlobalDataGridViewTextBoxColumn.Name = "montantGlobalDataGridViewTextBoxColumn";
            // 
            // menuidMenuDataGridViewTextBoxColumn
            // 
            this.menuidMenuDataGridViewTextBoxColumn.DataPropertyName = "MenuidMenu";
            this.menuidMenuDataGridViewTextBoxColumn.HeaderText = "IdMenu";
            this.menuidMenuDataGridViewTextBoxColumn.Name = "menuidMenuDataGridViewTextBoxColumn";
            // 
            // cOMMANDESBindingSource
            // 
            this.cOMMANDESBindingSource.DataMember = "COMMANDES";
            this.cOMMANDESBindingSource.DataSource = this.easyGestDataSet5;
            // 
            // easyGestDataSet5
            // 
            this.easyGestDataSet5.DataSetName = "EasyGestDataSet5";
            this.easyGestDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Liste Commande";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(209, 12);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(166, 35);
            this.bunifuFlatButton2.TabIndex = 15;
            this.bunifuFlatButton2.Text = "Liste Commande";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(167)))), ((int)(((byte)(201)))));
            this.slider.Location = new System.Drawing.Point(5, 44);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(153, 10);
            this.slider.TabIndex = 14;
            this.slider.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ajouter Commande";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(5, 12);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(198, 30);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Ajouter Commande";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cOMMANDESTableAdapter
            // 
            this.cOMMANDESTableAdapter.ClearBeforeFill = true;
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
            this.gunaImageButton1.TabIndex = 16;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // FrmGestionCommande
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.materialTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionCommande";
            this.Load += new System.EventHandler(this.FrmGestionCommande_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.AjouterUtilisateur.ResumeLayout(false);
            this.AjouterUtilisateur.PerformLayout();
            this.ListeCommande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyGestDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage ListeCommande;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid4;
        private System.Windows.Forms.TabPage AjouterUtilisateur;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantite;
        private Guna.UI2.WinForms.Guna2Button btnEnregistrer;
        private Guna.UI2.WinForms.Guna2TextBox txtPrixUnitaire;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCommande;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtmenueID;
        private Guna.UI2.WinForms.Guna2DateTimePicker cbDatefCommande;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private EasyGestDataSet5 easyGestDataSet5;
        private System.Windows.Forms.BindingSource cOMMANDESBindingSource;
        private EasyGestDataSet5TableAdapters.COMMANDESTableAdapter cOMMANDESTableAdapter;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateComandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantUnitaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantGlobalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidMenuDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox txtprg;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}