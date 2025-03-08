namespace HospitalManagementSystem
{
    partial class DoctorDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdoctorsId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDictorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtYearsOfExperience = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGVDoctors = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchMedicine = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtMedicineId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DgvSearchMEdicine = new Guna.UI.WinForms.GunaDataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchMEdicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 35);
            this.label1.TabIndex = 46;
            this.label1.Text = "Doctor Profile";
            // 
            // txtdoctorsId
            // 
            this.txtdoctorsId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdoctorsId.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoctorsId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdoctorsId.HintForeColor = System.Drawing.Color.Empty;
            this.txtdoctorsId.HintText = "Doctor Id";
            this.txtdoctorsId.isPassword = false;
            this.txtdoctorsId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdoctorsId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdoctorsId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdoctorsId.LineThickness = 3;
            this.txtdoctorsId.Location = new System.Drawing.Point(41, 92);
            this.txtdoctorsId.Margin = new System.Windows.Forms.Padding(4);
            this.txtdoctorsId.Name = "txtdoctorsId";
            this.txtdoctorsId.Size = new System.Drawing.Size(213, 42);
            this.txtdoctorsId.TabIndex = 47;
            this.txtdoctorsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdoctorsId.OnValueChanged += new System.EventHandler(this.txtdoctorsId_OnValueChanged);
            // 
            // txtDictorName
            // 
            this.txtDictorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDictorName.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDictorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDictorName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDictorName.HintText = "Doctor Name";
            this.txtDictorName.isPassword = false;
            this.txtDictorName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDictorName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDictorName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDictorName.LineThickness = 3;
            this.txtDictorName.Location = new System.Drawing.Point(355, 92);
            this.txtDictorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDictorName.Name = "txtDictorName";
            this.txtDictorName.Size = new System.Drawing.Size(213, 42);
            this.txtDictorName.TabIndex = 48;
            this.txtDictorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDictorName.OnValueChanged += new System.EventHandler(this.txtDictorName_OnValueChanged);
            // 
            // txtYearsOfExperience
            // 
            this.txtYearsOfExperience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYearsOfExperience.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearsOfExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYearsOfExperience.HintForeColor = System.Drawing.Color.Empty;
            this.txtYearsOfExperience.HintText = "Years Of Experience";
            this.txtYearsOfExperience.isPassword = false;
            this.txtYearsOfExperience.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtYearsOfExperience.LineIdleColor = System.Drawing.Color.Gray;
            this.txtYearsOfExperience.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtYearsOfExperience.LineThickness = 3;
            this.txtYearsOfExperience.Location = new System.Drawing.Point(664, 92);
            this.txtYearsOfExperience.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearsOfExperience.Name = "txtYearsOfExperience";
            this.txtYearsOfExperience.Size = new System.Drawing.Size(213, 42);
            this.txtYearsOfExperience.TabIndex = 49;
            this.txtYearsOfExperience.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYearsOfExperience.OnValueChanged += new System.EventHandler(this.txtYearsOfExperience_OnValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(957, 92);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 42);
            this.txtPassword.TabIndex = 50;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // DGVDoctors
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDoctors.BackgroundColor = System.Drawing.Color.White;
            this.DGVDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDoctors.ColumnHeadersHeight = 30;
            this.DGVDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDoctors.EnableHeadersVisualStyles = false;
            this.DGVDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDoctors.Location = new System.Drawing.Point(12, 291);
            this.DGVDoctors.Name = "DGVDoctors";
            this.DGVDoctors.RowHeadersVisible = false;
            this.DGVDoctors.RowHeadersWidth = 51;
            this.DGVDoctors.RowTemplate.Height = 24;
            this.DGVDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDoctors.Size = new System.Drawing.Size(1170, 163);
            this.DGVDoctors.TabIndex = 54;
            this.DGVDoctors.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDoctors.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVDoctors.ThemeStyle.ReadOnly = false;
            this.DGVDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDoctors.ThemeStyle.RowsStyle.Height = 24;
            this.DGVDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDoctors_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 37);
            this.label3.TabIndex = 55;
            this.label3.Text = "Diagnosis List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Doctor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Years Of Experience";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(954, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Password";
            // 
            // SearchMedicine
            // 
            this.SearchMedicine.AnimationHoverSpeed = 0.07F;
            this.SearchMedicine.AnimationSpeed = 0.03F;
            this.SearchMedicine.BackColor = System.Drawing.Color.Transparent;
            this.SearchMedicine.BaseColor = System.Drawing.Color.SteelBlue;
            this.SearchMedicine.BorderColor = System.Drawing.Color.Black;
            this.SearchMedicine.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SearchMedicine.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchMedicine.CheckedForeColor = System.Drawing.Color.White;
            this.SearchMedicine.CheckedImage = ((System.Drawing.Image)(resources.GetObject("SearchMedicine.CheckedImage")));
            this.SearchMedicine.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.SearchMedicine.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMedicine.ForeColor = System.Drawing.Color.White;
            this.SearchMedicine.Image = ((System.Drawing.Image)(resources.GetObject("SearchMedicine.Image")));
            this.SearchMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchMedicine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SearchMedicine.Location = new System.Drawing.Point(929, 179);
            this.SearchMedicine.Name = "SearchMedicine";
            this.SearchMedicine.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.SearchMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchMedicine.OnHoverImage = null;
            this.SearchMedicine.OnHoverLineColor = System.Drawing.Color.Navy;
            this.SearchMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.SearchMedicine.Radius = 20;
            this.SearchMedicine.Size = new System.Drawing.Size(231, 47);
            this.SearchMedicine.TabIndex = 61;
            this.SearchMedicine.Text = "Search Medicine";
            this.SearchMedicine.Click += new System.EventHandler(this.SearchMedicine_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1142, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 56;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBack.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBack.CheckedForeColor = System.Drawing.Color.White;
            this.btnBack.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBack.CheckedImage")));
            this.btnBack.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBack.Location = new System.Drawing.Point(518, 179);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 20;
            this.btnBack.Size = new System.Drawing.Size(158, 47);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Logout";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReload
            // 
            this.btnReload.AnimationHoverSpeed = 0.07F;
            this.btnReload.AnimationSpeed = 0.03F;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnReload.BorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReload.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedForeColor = System.Drawing.Color.White;
            this.btnReload.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReload.CheckedImage")));
            this.btnReload.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.FocusedColor = System.Drawing.Color.Empty;
            this.btnReload.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReload.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReload.Location = new System.Drawing.Point(321, 179);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Radius = 20;
            this.btnReload.Size = new System.Drawing.Size(158, 47);
            this.btnReload.TabIndex = 52;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.CheckedImage")));
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.Location = new System.Drawing.Point(50, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 20;
            this.btnUpdate.Size = new System.Drawing.Size(231, 47);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineId.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineId.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicineId.HintText = "Medicine ID";
            this.txtMedicineId.isPassword = false;
            this.txtMedicineId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicineId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineId.LineThickness = 3;
            this.txtMedicineId.Location = new System.Drawing.Point(709, 184);
            this.txtMedicineId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(213, 42);
            this.txtMedicineId.TabIndex = 62;
            this.txtMedicineId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMedicineId.OnValueChanged += new System.EventHandler(this.txtMedicineId_OnValueChanged);
            // 
            // DgvSearchMEdicine
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvSearchMEdicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSearchMEdicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearchMEdicine.BackgroundColor = System.Drawing.Color.White;
            this.DgvSearchMEdicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSearchMEdicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvSearchMEdicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSearchMEdicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvSearchMEdicine.ColumnHeadersHeight = 30;
            this.DgvSearchMEdicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSearchMEdicine.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvSearchMEdicine.EnableHeadersVisualStyles = false;
            this.DgvSearchMEdicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvSearchMEdicine.Location = new System.Drawing.Point(23, 522);
            this.DgvSearchMEdicine.Name = "DgvSearchMEdicine";
            this.DgvSearchMEdicine.RowHeadersVisible = false;
            this.DgvSearchMEdicine.RowHeadersWidth = 51;
            this.DgvSearchMEdicine.RowTemplate.Height = 24;
            this.DgvSearchMEdicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSearchMEdicine.Size = new System.Drawing.Size(1170, 81);
            this.DgvSearchMEdicine.TabIndex = 63;
            this.DgvSearchMEdicine.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DgvSearchMEdicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvSearchMEdicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvSearchMEdicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvSearchMEdicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvSearchMEdicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvSearchMEdicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvSearchMEdicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvSearchMEdicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvSearchMEdicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvSearchMEdicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvSearchMEdicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvSearchMEdicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSearchMEdicine.ThemeStyle.HeaderStyle.Height = 30;
            this.DgvSearchMEdicine.ThemeStyle.ReadOnly = false;
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.Height = 24;
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvSearchMEdicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 37);
            this.label7.TabIndex = 64;
            this.label7.Text = "Medicine List";
            // 
            // DoctorDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvSearchMEdicine);
            this.Controls.Add(this.txtMedicineId);
            this.Controls.Add(this.SearchMedicine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVDoctors);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtYearsOfExperience);
            this.Controls.Add(this.txtDictorName);
            this.Controls.Add(this.txtdoctorsId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDashBoard";
            this.Load += new System.EventHandler(this.DoctorDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchMEdicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdoctorsId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDictorName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtYearsOfExperience;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnReload;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI.WinForms.GunaDataGridView DGVDoctors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaAdvenceButton SearchMedicine;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineId;
        private Guna.UI.WinForms.GunaDataGridView DgvSearchMEdicine;
        private System.Windows.Forms.Label label7;
    }
}