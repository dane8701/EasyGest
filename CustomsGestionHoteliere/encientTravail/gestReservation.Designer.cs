using CustomsGestionHoteliere.encientTravail;

namespace CustomsGestionHoteliere
{
    partial class gestReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestReservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idagt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gset_hotelDataSet = new CustomsGestionHoteliere.encientTravail.gset_hotelDataSet();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idclt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datedeb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nbrchambre = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.formule = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.typechambre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datersvt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.idreserve = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.reservationTableAdapter = new CustomsGestionHoteliere.encientTravail.gset_hotelDataSetTableAdapters.reservationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrchambre)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(627, 49);
            this.panel1.TabIndex = 1;
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
            this.guna2TileButton2.Location = new System.Drawing.Point(582, 9);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(33, 30);
            this.guna2TileButton2.TabIndex = 35;
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(218, 21);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Enregistrement reservation";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(349, 98);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(74, 20);
            this.bunifuCustomLabel13.TabIndex = 59;
            this.bunifuCustomLabel13.Text = "id agent";
            // 
            // idagt
            // 
            this.idagt.BackColor = System.Drawing.SystemColors.Control;
            this.idagt.BorderColor = System.Drawing.Color.Indigo;
            this.idagt.BorderRadius = 15;
            this.idagt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationBindingSource, "Id_agt", true));
            this.idagt.DisplayMember = "Id_agt";
            this.idagt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idagt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idagt.FocusedColor = System.Drawing.Color.Empty;
            this.idagt.FocusedState.Parent = this.idagt;
            this.idagt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idagt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.idagt.FormattingEnabled = true;
            this.idagt.HoverState.Parent = this.idagt;
            this.idagt.ItemHeight = 30;
            this.idagt.ItemsAppearance.Parent = this.idagt;
            this.idagt.Location = new System.Drawing.Point(353, 127);
            this.idagt.Name = "idagt";
            this.idagt.ShadowDecoration.Parent = this.idagt;
            this.idagt.Size = new System.Drawing.Size(157, 36);
            this.idagt.TabIndex = 58;
            this.idagt.ValueMember = "Id_agt";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "reservation";
            this.reservationBindingSource.DataSource = this.gset_hotelDataSet;
            // 
            // gset_hotelDataSet
            // 
            this.gset_hotelDataSet.DataSetName = "gset_hotelDataSet";
            this.gset_hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(114, 98);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(71, 20);
            this.bunifuCustomLabel14.TabIndex = 57;
            this.bunifuCustomLabel14.Text = "id client";
            // 
            // idclt
            // 
            this.idclt.BackColor = System.Drawing.SystemColors.Control;
            this.idclt.BorderColor = System.Drawing.Color.Indigo;
            this.idclt.BorderRadius = 15;
            this.idclt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationBindingSource, "Id_client", true));
            this.idclt.DisplayMember = "Id_client";
            this.idclt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idclt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idclt.FocusedColor = System.Drawing.Color.Empty;
            this.idclt.FocusedState.Parent = this.idclt;
            this.idclt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idclt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.idclt.FormattingEnabled = true;
            this.idclt.HoverState.Parent = this.idclt;
            this.idclt.ItemHeight = 30;
            this.idclt.ItemsAppearance.Parent = this.idclt;
            this.idclt.Location = new System.Drawing.Point(118, 127);
            this.idclt.Name = "idclt";
            this.idclt.ShadowDecoration.Parent = this.idclt;
            this.idclt.Size = new System.Drawing.Size(200, 36);
            this.idclt.TabIndex = 56;
            this.idclt.ValueMember = "Id_client";
            // 
            // datedeb
            // 
            this.datedeb.BorderColor = System.Drawing.Color.Indigo;
            this.datedeb.BorderRadius = 16;
            this.datedeb.BorderThickness = 1;
            this.datedeb.CheckedState.Parent = this.datedeb;
            this.datedeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "date de debut du sejour", true));
            this.datedeb.FillColor = System.Drawing.Color.White;
            this.datedeb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datedeb.HoverState.Parent = this.datedeb;
            this.datedeb.Location = new System.Drawing.Point(209, 204);
            this.datedeb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datedeb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datedeb.Name = "datedeb";
            this.datedeb.ShadowDecoration.Parent = this.datedeb;
            this.datedeb.Size = new System.Drawing.Size(195, 36);
            this.datedeb.TabIndex = 55;
            this.datedeb.Value = new System.DateTime(2020, 8, 29, 10, 49, 48, 737);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.Indigo;
            this.guna2DateTimePicker2.BorderRadius = 16;
            this.guna2DateTimePicker2.BorderThickness = 1;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "date de fin de sejour", true));
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(427, 204);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(188, 36);
            this.guna2DateTimePicker2.TabIndex = 54;
            this.guna2DateTimePicker2.Value = new System.DateTime(2020, 8, 29, 10, 49, 48, 737);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(202, 357);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(168, 20);
            this.bunifuCustomLabel12.TabIndex = 53;
            this.bunifuCustomLabel12.Text = "nombre de chambre";
            // 
            // nbrchambre
            // 
            this.nbrchambre.BackColor = System.Drawing.SystemColors.Control;
            this.nbrchambre.BorderColor = System.Drawing.Color.Indigo;
            this.nbrchambre.BorderRadius = 13;
            this.nbrchambre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrchambre.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationBindingSource, "nombre de chambre", true));
            this.nbrchambre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nbrchambre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nbrchambre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nbrchambre.DisabledState.Parent = this.nbrchambre;
            this.nbrchambre.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nbrchambre.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nbrchambre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nbrchambre.FocusedState.Parent = this.nbrchambre;
            this.nbrchambre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrchambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nbrchambre.Location = new System.Drawing.Point(220, 380);
            this.nbrchambre.Name = "nbrchambre";
            this.nbrchambre.ShadowDecoration.Parent = this.nbrchambre;
            this.nbrchambre.Size = new System.Drawing.Size(100, 36);
            this.nbrchambre.TabIndex = 52;
            this.nbrchambre.UpDownButtonFillColor = System.Drawing.Color.Purple;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(335, 270);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(69, 20);
            this.bunifuCustomLabel11.TabIndex = 51;
            this.bunifuCustomLabel11.Text = "formule";
            // 
            // formule
            // 
            this.formule.BackColor = System.Drawing.SystemColors.Control;
            this.formule.BorderColor = System.Drawing.Color.Indigo;
            this.formule.BorderRadius = 15;
            this.formule.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationBindingSource, "formule", true));
            this.formule.DisplayMember = "formule chambre";
            this.formule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.formule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formule.FocusedColor = System.Drawing.Color.Empty;
            this.formule.FocusedState.Parent = this.formule;
            this.formule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.formule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.formule.FormattingEnabled = true;
            this.formule.HoverState.Parent = this.formule;
            this.formule.ItemHeight = 30;
            this.formule.ItemsAppearance.Parent = this.formule;
            this.formule.Location = new System.Drawing.Point(328, 293);
            this.formule.Name = "formule";
            this.formule.ShadowDecoration.Parent = this.formule;
            this.formule.Size = new System.Drawing.Size(157, 36);
            this.formule.TabIndex = 50;
            this.formule.ValueMember = "formule chambre";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(103, 270);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(142, 20);
            this.bunifuCustomLabel10.TabIndex = 49;
            this.bunifuCustomLabel10.Text = "type de chambre";
            // 
            // typechambre
            // 
            this.typechambre.BackColor = System.Drawing.SystemColors.Control;
            this.typechambre.BorderColor = System.Drawing.Color.Indigo;
            this.typechambre.BorderRadius = 15;
            this.typechambre.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationBindingSource, "type de chambre", true));
            this.typechambre.DisplayMember = "type de chambre";
            this.typechambre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typechambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typechambre.FocusedColor = System.Drawing.Color.Empty;
            this.typechambre.FocusedState.Parent = this.typechambre;
            this.typechambre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typechambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typechambre.FormattingEnabled = true;
            this.typechambre.HoverState.Parent = this.typechambre;
            this.typechambre.ItemHeight = 30;
            this.typechambre.ItemsAppearance.Parent = this.typechambre;
            this.typechambre.Location = new System.Drawing.Point(104, 293);
            this.typechambre.Name = "typechambre";
            this.typechambre.ShadowDecoration.Parent = this.typechambre;
            this.typechambre.Size = new System.Drawing.Size(200, 36);
            this.typechambre.TabIndex = 48;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(411, 181);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(108, 20);
            this.bunifuCustomLabel9.TabIndex = 47;
            this.bunifuCustomLabel9.Text = "fin du sejour";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(205, 181);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(134, 20);
            this.bunifuCustomLabel8.TabIndex = 46;
            this.bunifuCustomLabel8.Text = "debut du sejour";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(6, 181);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(164, 20);
            this.bunifuCustomLabel7.TabIndex = 45;
            this.bunifuCustomLabel7.Text = "date de reservation";
            // 
            // datersvt
            // 
            this.datersvt.BorderColor = System.Drawing.Color.Indigo;
            this.datersvt.BorderRadius = 16;
            this.datersvt.BorderThickness = 1;
            this.datersvt.CheckedState.Parent = this.datersvt;
            this.datersvt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationBindingSource, "date de reservation", true));
            this.datersvt.FillColor = System.Drawing.Color.White;
            this.datersvt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datersvt.HoverState.Parent = this.datersvt;
            this.datersvt.Location = new System.Drawing.Point(3, 204);
            this.datersvt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datersvt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datersvt.Name = "datersvt";
            this.datersvt.ShadowDecoration.Parent = this.datersvt;
            this.datersvt.Size = new System.Drawing.Size(182, 36);
            this.datersvt.TabIndex = 44;
            this.datersvt.Value = new System.DateTime(2020, 8, 29, 10, 49, 48, 737);
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
            this.guna2Button16.Location = new System.Drawing.Point(196, 455);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.ShadowDecoration.Parent = this.guna2Button16;
            this.guna2Button16.Size = new System.Drawing.Size(188, 45);
            this.guna2Button16.TabIndex = 41;
            this.guna2Button16.Text = "enregistrer";
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // idreserve
            // 
            this.idreserve.BorderColor = System.Drawing.Color.Indigo;
            this.idreserve.BorderRadius = 16;
            this.idreserve.BorderThickness = 2;
            this.idreserve.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idreserve.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationBindingSource, "Id_reservation", true));
            this.idreserve.DefaultText = "id reservation";
            this.idreserve.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idreserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idreserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idreserve.DisabledState.Parent = this.idreserve;
            this.idreserve.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idreserve.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idreserve.FocusedState.Parent = this.idreserve;
            this.idreserve.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idreserve.HoverState.Parent = this.idreserve;
            this.idreserve.Location = new System.Drawing.Point(206, 55);
            this.idreserve.Name = "idreserve";
            this.idreserve.PasswordChar = '\0';
            this.idreserve.PlaceholderText = "";
            this.idreserve.SelectedText = "";
            this.idreserve.SelectionStart = 14;
            this.idreserve.ShadowDecoration.Parent = this.idreserve;
            this.idreserve.Size = new System.Drawing.Size(178, 36);
            this.idreserve.TabIndex = 40;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // gestReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 532);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.idagt);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.idclt);
            this.Controls.Add(this.datedeb);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.nbrchambre);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.formule);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.typechambre);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.datersvt);
            this.Controls.Add(this.guna2Button16);
            this.Controls.Add(this.idreserve);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestReservation";
            this.Text = "clientConfig";
            this.Load += new System.EventHandler(this.gestReservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gset_hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrchambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Guna.UI2.WinForms.Guna2ComboBox idagt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Guna.UI2.WinForms.Guna2ComboBox idclt;
        private Guna.UI2.WinForms.Guna2DateTimePicker datedeb;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbrchambre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Guna.UI2.WinForms.Guna2ComboBox formule;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Guna.UI2.WinForms.Guna2ComboBox typechambre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Guna.UI2.WinForms.Guna2DateTimePicker datersvt;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2TextBox idreserve;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private gset_hotelDataSet gset_hotelDataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private encientTravail.gset_hotelDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
    }
}