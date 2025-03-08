namespace HospitalManagementSystem
{
    partial class Appoinment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appoinment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.CbPatientId = new System.Windows.Forms.ComboBox();
            this.cmbDocId = new System.Windows.Forms.ComboBox();
            this.txtPName1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDocName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVAppointment = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSlNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 37);
            this.label3.TabIndex = 42;
            this.label3.Text = "Appoinment For Patient";
            // 
            // CbPatientId
            // 
            this.CbPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPatientId.FormattingEnabled = true;
            this.CbPatientId.Location = new System.Drawing.Point(326, 109);
            this.CbPatientId.Name = "CbPatientId";
            this.CbPatientId.Size = new System.Drawing.Size(162, 33);
            this.CbPatientId.TabIndex = 43;
            this.CbPatientId.Text = "Patient ID";
            this.CbPatientId.SelectedIndexChanged += new System.EventHandler(this.CbPatientId_SelectedIndexChanged);
            // 
            // cmbDocId
            // 
            this.cmbDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocId.FormattingEnabled = true;
            this.cmbDocId.Location = new System.Drawing.Point(544, 109);
            this.cmbDocId.Name = "cmbDocId";
            this.cmbDocId.Size = new System.Drawing.Size(162, 33);
            this.cmbDocId.TabIndex = 44;
            this.cmbDocId.Text = " Doctor  Id";
            this.cmbDocId.SelectedIndexChanged += new System.EventHandler(this.cmbDocId_SelectedIndexChanged);
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
            this.txtPName1.Location = new System.Drawing.Point(289, 161);
            this.txtPName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName1.Name = "txtPName1";
            this.txtPName1.Size = new System.Drawing.Size(213, 42);
            this.txtPName1.TabIndex = 45;
            this.txtPName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPName1.OnValueChanged += new System.EventHandler(this.txtPName1_OnValueChanged);
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
            this.txtDocName.Location = new System.Drawing.Point(533, 161);
            this.txtDocName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(205, 42);
            this.txtDocName.TabIndex = 46;
            this.txtDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocName.OnValueChanged += new System.EventHandler(this.txtDocName_OnValueChanged);
            // 
            // txtDate
            // 
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.HintForeColor = System.Drawing.Color.Empty;
            this.txtDate.HintText = "Date";
            this.txtDate.isPassword = false;
            this.txtDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDate.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDate.LineThickness = 3;
            this.txtDate.Location = new System.Drawing.Point(795, 100);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(205, 42);
            this.txtDate.TabIndex = 48;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDate.OnValueChanged += new System.EventHandler(this.txtDate_OnValueChanged);
            // 
            // txtTime
            // 
            this.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTime.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTime.HintForeColor = System.Drawing.Color.Empty;
            this.txtTime.HintText = "Time";
            this.txtTime.isPassword = false;
            this.txtTime.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTime.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTime.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTime.LineThickness = 3;
            this.txtTime.Location = new System.Drawing.Point(795, 161);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(205, 42);
            this.txtTime.TabIndex = 49;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTime.OnValueChanged += new System.EventHandler(this.txtTime_OnValueChanged);
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
            this.btnAdd.Location = new System.Drawing.Point(567, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 20;
            this.btnAdd.Size = new System.Drawing.Size(158, 47);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.SteelBlue;
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
            this.btnBack.Location = new System.Drawing.Point(755, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 20;
            this.btnBack.Size = new System.Drawing.Size(158, 47);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1106, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 53;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Apponnment List ";
            // 
            // DGVAppointment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAppointment.BackgroundColor = System.Drawing.Color.White;
            this.DGVAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAppointment.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAppointment.EnableHeadersVisualStyles = false;
            this.DGVAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVAppointment.Location = new System.Drawing.Point(12, 249);
            this.DGVAppointment.Name = "DGVAppointment";
            this.DGVAppointment.RowHeadersVisible = false;
            this.DGVAppointment.RowHeadersWidth = 51;
            this.DGVAppointment.RowTemplate.Height = 24;
            this.DGVAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAppointment.Size = new System.Drawing.Size(1134, 318);
            this.DGVAppointment.TabIndex = 55;
            this.DGVAppointment.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVAppointment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVAppointment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVAppointment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVAppointment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVAppointment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVAppointment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVAppointment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVAppointment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVAppointment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAppointment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVAppointment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVAppointment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVAppointment.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVAppointment.ThemeStyle.ReadOnly = false;
            this.DGVAppointment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVAppointment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVAppointment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVAppointment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVAppointment.ThemeStyle.RowsStyle.Height = 24;
            this.DGVAppointment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVAppointment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAppointment_CellContentClick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(331, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(115, 20);
            this.gunaLabel1.TabIndex = 56;
            this.gunaLabel1.Text = "Select Patient Id";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(540, 71);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 20);
            this.gunaLabel2.TabIndex = 57;
            this.gunaLabel2.Text = "Select Doctor Id";
            // 
            // BtnDelete
            // 
            this.BtnDelete.AnimationHoverSpeed = 0.07F;
            this.BtnDelete.AnimationSpeed = 0.03F;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.BtnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.CheckedImage")));
            this.BtnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDelete.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnDelete.Location = new System.Drawing.Point(919, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.BtnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDelete.OnHoverImage = null;
            this.BtnDelete.OnHoverLineColor = System.Drawing.Color.Navy;
            this.BtnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDelete.Radius = 20;
            this.BtnDelete.Size = new System.Drawing.Size(158, 47);
            this.BtnDelete.TabIndex = 58;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // txtSlNo
            // 
            this.txtSlNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlNo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSlNo.HintForeColor = System.Drawing.Color.Empty;
            this.txtSlNo.HintText = "SL No";
            this.txtSlNo.isPassword = false;
            this.txtSlNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSlNo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSlNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSlNo.LineThickness = 3;
            this.txtSlNo.Location = new System.Drawing.Point(40, 109);
            this.txtSlNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlNo.Name = "txtSlNo";
            this.txtSlNo.Size = new System.Drawing.Size(213, 42);
            this.txtSlNo.TabIndex = 47;
            this.txtSlNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSlNo.OnValueChanged += new System.EventHandler(this.txtSlNo_OnValueChanged);
            // 
            // Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 593);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DGVAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtSlNo);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.txtPName1);
            this.Controls.Add(this.cmbDocId);
            this.Controls.Add(this.CbPatientId);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appoinment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appoinment";
            this.Load += new System.EventHandler(this.Appoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbPatientId;
        private System.Windows.Forms.ComboBox cmbDocId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPName1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDocName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTime;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView DGVAppointment;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton BtnDelete;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSlNo;
    }
}