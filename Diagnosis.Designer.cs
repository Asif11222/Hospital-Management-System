namespace HospitalManagementSystem
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMedicines = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDiagnosis = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDoctors = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDocName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbDocId = new System.Windows.Forms.ComboBox();
            this.CbPatientId = new System.Windows.Forms.ComboBox();
            this.txtMedicine = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiagnosis = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSymptoms = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPName1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiagnosisId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnReload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVDiagnosis = new Guna.UI.WinForms.GunaDataGridView();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMedicines);
            this.panel1.Controls.Add(this.btnDiagnosis);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 668);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HospitalManagementSystem.Properties.Resources.hospital_building;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(12, 625);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Radius = 20;
            this.btnLogout.Size = new System.Drawing.Size(179, 31);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "LogOut ";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.AnimationHoverSpeed = 0.07F;
            this.btnMedicines.AnimationSpeed = 0.03F;
            this.btnMedicines.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicines.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnMedicines.BorderColor = System.Drawing.Color.Black;
            this.btnMedicines.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMedicines.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMedicines.CheckedForeColor = System.Drawing.Color.White;
            this.btnMedicines.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMedicines.CheckedImage")));
            this.btnMedicines.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMedicines.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicines.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicines.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicines.ForeColor = System.Drawing.Color.White;
            this.btnMedicines.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicines.Image")));
            this.btnMedicines.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMedicines.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicines.Location = new System.Drawing.Point(12, 367);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnMedicines.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicines.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicines.OnHoverImage = null;
            this.btnMedicines.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnMedicines.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicines.Radius = 20;
            this.btnMedicines.Size = new System.Drawing.Size(179, 59);
            this.btnMedicines.TabIndex = 26;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.AnimationHoverSpeed = 0.07F;
            this.btnDiagnosis.AnimationSpeed = 0.03F;
            this.btnDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.btnDiagnosis.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnDiagnosis.BorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDiagnosis.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.CheckedImage")));
            this.btnDiagnosis.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDiagnosis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDiagnosis.FocusedColor = System.Drawing.Color.Empty;
            this.btnDiagnosis.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.Image")));
            this.btnDiagnosis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDiagnosis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.Location = new System.Drawing.Point(12, 285);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnDiagnosis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.OnHoverImage = null;
            this.btnDiagnosis.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnDiagnosis.OnPressedColor = System.Drawing.Color.Black;
            this.btnDiagnosis.Radius = 20;
            this.btnDiagnosis.Size = new System.Drawing.Size(179, 61);
            this.btnDiagnosis.TabIndex = 25;
            this.btnDiagnosis.Text = "Diagnosis";
            // 
            // btnPatient
            // 
            this.btnPatient.AnimationHoverSpeed = 0.07F;
            this.btnPatient.AnimationSpeed = 0.03F;
            this.btnPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnPatient.BaseColor = System.Drawing.Color.SkyBlue;
            this.btnPatient.BorderColor = System.Drawing.Color.Black;
            this.btnPatient.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPatient.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPatient.CheckedForeColor = System.Drawing.Color.White;
            this.btnPatient.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPatient.CheckedImage")));
            this.btnPatient.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatient.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatient.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnPatient.Image")));
            this.btnPatient.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPatient.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatient.Location = new System.Drawing.Point(12, 209);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnPatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPatient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPatient.OnHoverImage = null;
            this.btnPatient.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnPatient.OnPressedColor = System.Drawing.Color.Black;
            this.btnPatient.Radius = 20;
            this.btnPatient.Size = new System.Drawing.Size(179, 56);
            this.btnPatient.TabIndex = 24;
            this.btnPatient.Text = "Patient ";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.AnimationHoverSpeed = 0.07F;
            this.btnDoctors.AnimationSpeed = 0.03F;
            this.btnDoctors.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctors.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btnDoctors.BorderColor = System.Drawing.Color.Black;
            this.btnDoctors.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDoctors.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDoctors.CheckedForeColor = System.Drawing.Color.White;
            this.btnDoctors.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDoctors.CheckedImage")));
            this.btnDoctors.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDoctors.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoctors.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoctors.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
            this.btnDoctors.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDoctors.LineColor = System.Drawing.Color.Cyan;
            this.btnDoctors.Location = new System.Drawing.Point(12, 129);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoctors.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoctors.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoctors.OnHoverImage = null;
            this.btnDoctors.OnHoverLineColor = System.Drawing.Color.Cyan;
            this.btnDoctors.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoctors.Radius = 20;
            this.btnDoctors.Size = new System.Drawing.Size(179, 52);
            this.btnDoctors.TabIndex = 23;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hospital Management System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Controls.Add(this.txtDocName);
            this.panel2.Controls.Add(this.cmbDocId);
            this.panel2.Controls.Add(this.CbPatientId);
            this.panel2.Controls.Add(this.txtMedicine);
            this.panel2.Controls.Add(this.txtDiagnosis);
            this.panel2.Controls.Add(this.txtSymptoms);
            this.panel2.Controls.Add(this.txtPName1);
            this.panel2.Controls.Add(this.txtDiagnosisId);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(218, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 253);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(491, 94);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 20);
            this.gunaLabel2.TabIndex = 46;
            this.gunaLabel2.Text = "Select Doctor Id";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(217, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(115, 20);
            this.gunaLabel1.TabIndex = 45;
            this.gunaLabel1.Text = "Select Patient Id";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // txtDocName
            // 
            this.txtDocName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocName.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDocName.HintText = "Doctor Name";
            this.txtDocName.isPassword = false;
            this.txtDocName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDocName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDocName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDocName.LineThickness = 3;
            this.txtDocName.Location = new System.Drawing.Point(751, 116);
            this.txtDocName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(205, 42);
            this.txtDocName.TabIndex = 44;
            this.txtDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocName.OnValueChanged += new System.EventHandler(this.txtDocName_OnValueChanged);
            // 
            // cmbDocId
            // 
            this.cmbDocId.FormattingEnabled = true;
            this.cmbDocId.Location = new System.Drawing.Point(495, 126);
            this.cmbDocId.Name = "cmbDocId";
            this.cmbDocId.Size = new System.Drawing.Size(237, 32);
            this.cmbDocId.TabIndex = 43;
            this.cmbDocId.Text = "Assign to Doctor ";
            this.cmbDocId.SelectedIndexChanged += new System.EventHandler(this.cmbDocId_SelectedIndexChanged);
            // 
            // CbPatientId
            // 
            this.CbPatientId.FormattingEnabled = true;
            this.CbPatientId.Location = new System.Drawing.Point(221, 36);
            this.CbPatientId.Name = "CbPatientId";
            this.CbPatientId.Size = new System.Drawing.Size(237, 32);
            this.CbPatientId.TabIndex = 42;
            this.CbPatientId.Text = "Patient ID";
            this.CbPatientId.SelectedIndexChanged += new System.EventHandler(this.CbPatientId_SelectedIndexChanged);
            // 
            // txtMedicine
            // 
            this.txtMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicine.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicine.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicine.HintText = "Medicine ";
            this.txtMedicine.isPassword = false;
            this.txtMedicine.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicine.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicine.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicine.LineThickness = 3;
            this.txtMedicine.Location = new System.Drawing.Point(285, 116);
            this.txtMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(186, 42);
            this.txtMedicine.TabIndex = 41;
            this.txtMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnosis.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosis.HintText = "Diagnosis";
            this.txtDiagnosis.isPassword = false;
            this.txtDiagnosis.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiagnosis.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiagnosis.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiagnosis.LineThickness = 3;
            this.txtDiagnosis.Location = new System.Drawing.Point(7, 109);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(270, 42);
            this.txtDiagnosis.TabIndex = 40;
            this.txtDiagnosis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSymptoms.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymptoms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSymptoms.HintForeColor = System.Drawing.Color.Empty;
            this.txtSymptoms.HintText = "Symptoms";
            this.txtSymptoms.isPassword = false;
            this.txtSymptoms.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSymptoms.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSymptoms.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSymptoms.LineThickness = 3;
            this.txtSymptoms.Location = new System.Drawing.Point(733, 23);
            this.txtSymptoms.Margin = new System.Windows.Forms.Padding(4);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(213, 42);
            this.txtSymptoms.TabIndex = 39;
            this.txtSymptoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPName1
            // 
            this.txtPName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPName1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPName1.HintForeColor = System.Drawing.Color.Empty;
            this.txtPName1.HintText = "Patient Name";
            this.txtPName1.isPassword = false;
            this.txtPName1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPName1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPName1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPName1.LineThickness = 3;
            this.txtPName1.Location = new System.Drawing.Point(495, 28);
            this.txtPName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName1.Name = "txtPName1";
            this.txtPName1.Size = new System.Drawing.Size(213, 42);
            this.txtPName1.TabIndex = 38;
            this.txtPName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPName1.OnValueChanged += new System.EventHandler(this.txtPName1_OnValueChanged);
            // 
            // txtDiagnosisId
            // 
            this.txtDiagnosisId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosisId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosisId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiagnosisId.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiagnosisId.HintText = "Diagnosis Id";
            this.txtDiagnosisId.isPassword = false;
            this.txtDiagnosisId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiagnosisId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiagnosisId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiagnosisId.LineThickness = 3;
            this.txtDiagnosisId.Location = new System.Drawing.Point(0, 28);
            this.txtDiagnosisId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosisId.Name = "txtDiagnosisId";
            this.txtDiagnosisId.Size = new System.Drawing.Size(213, 42);
            this.txtDiagnosisId.TabIndex = 36;
            this.txtDiagnosisId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnReload.Location = new System.Drawing.Point(687, 203);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Radius = 20;
            this.btnReload.Size = new System.Drawing.Size(158, 47);
            this.btnReload.TabIndex = 31;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(495, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 20;
            this.btnDelete.Size = new System.Drawing.Size(158, 47);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(312, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 20;
            this.btnUpdate.Size = new System.Drawing.Size(158, 47);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(95, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(158, 47);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diagnosis Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Diagnosis List ";
            // 
            // DGVDiagnosis
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVDiagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDiagnosis.BackgroundColor = System.Drawing.Color.White;
            this.DGVDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDiagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDiagnosis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDiagnosis.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDiagnosis.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDiagnosis.EnableHeadersVisualStyles = false;
            this.DGVDiagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDiagnosis.Location = new System.Drawing.Point(218, 396);
            this.DGVDiagnosis.Name = "DGVDiagnosis";
            this.DGVDiagnosis.RowHeadersVisible = false;
            this.DGVDiagnosis.RowHeadersWidth = 51;
            this.DGVDiagnosis.RowTemplate.Height = 24;
            this.DGVDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDiagnosis.Size = new System.Drawing.Size(931, 238);
            this.DGVDiagnosis.TabIndex = 28;
            this.DGVDiagnosis.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVDiagnosis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDiagnosis.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDiagnosis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDiagnosis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDiagnosis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDiagnosis.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVDiagnosis.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDiagnosis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVDiagnosis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDiagnosis.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDiagnosis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVDiagnosis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVDiagnosis.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVDiagnosis.ThemeStyle.ReadOnly = false;
            this.DGVDiagnosis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDiagnosis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDiagnosis.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDiagnosis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDiagnosis.ThemeStyle.RowsStyle.Height = 24;
            this.DGVDiagnosis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDiagnosis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDiagnosis_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1097, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.pharmacy;
            this.pictureBox1.Location = new System.Drawing.Point(236, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(960, 14);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(103, 38);
            this.gunaAdvenceButton1.TabIndex = 43;
            this.gunaAdvenceButton1.Text = "Back";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 668);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.DGVDiagnosis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton btnMedicines;
        private Guna.UI.WinForms.GunaAdvenceButton btnDiagnosis;
        private Guna.UI.WinForms.GunaAdvenceButton btnPatient;
        private Guna.UI.WinForms.GunaAdvenceButton btnDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnReload;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicine;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiagnosis;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSymptoms;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPName1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiagnosisId;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView DGVDiagnosis;
        private System.Windows.Forms.ComboBox CbPatientId;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDocName;
        private System.Windows.Forms.ComboBox cmbDocId;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}