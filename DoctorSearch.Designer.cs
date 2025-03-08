namespace HospitalManagementSystem
{
    partial class DoctorSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSearch));
            this.txtdoctorsId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGVDoctors = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDocSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.txtdoctorsId.Location = new System.Drawing.Point(38, 25);
            this.txtdoctorsId.Margin = new System.Windows.Forms.Padding(4);
            this.txtdoctorsId.Name = "txtdoctorsId";
            this.txtdoctorsId.Size = new System.Drawing.Size(213, 42);
            this.txtdoctorsId.TabIndex = 33;
            this.txtdoctorsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdoctorsId.OnValueChanged += new System.EventHandler(this.txtdoctorsId_OnValueChanged);
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
            this.DGVDoctors.Location = new System.Drawing.Point(5, 150);
            this.DGVDoctors.Name = "DGVDoctors";
            this.DGVDoctors.RowHeadersVisible = false;
            this.DGVDoctors.RowHeadersWidth = 51;
            this.DGVDoctors.RowTemplate.Height = 24;
            this.DGVDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDoctors.Size = new System.Drawing.Size(1193, 342);
            this.DGVDoctors.TabIndex = 40;
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
            this.label3.Location = new System.Drawing.Point(496, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 41;
            this.label3.Text = "Doctors List";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1147, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 43;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.SteelBlue;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(938, 25);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Navy;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 20;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(158, 47);
            this.gunaAdvenceButton1.TabIndex = 42;
            this.gunaAdvenceButton1.Text = "Back";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btnDocSearch
            // 
            this.btnDocSearch.AnimationHoverSpeed = 0.07F;
            this.btnDocSearch.AnimationSpeed = 0.03F;
            this.btnDocSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnDocSearch.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnDocSearch.BorderColor = System.Drawing.Color.Black;
            this.btnDocSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDocSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDocSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnDocSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDocSearch.CheckedImage")));
            this.btnDocSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDocSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDocSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnDocSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocSearch.ForeColor = System.Drawing.Color.White;
            this.btnDocSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnDocSearch.Image")));
            this.btnDocSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDocSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDocSearch.Location = new System.Drawing.Point(308, 25);
            this.btnDocSearch.Name = "btnDocSearch";
            this.btnDocSearch.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnDocSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDocSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDocSearch.OnHoverImage = null;
            this.btnDocSearch.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnDocSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnDocSearch.Radius = 20;
            this.btnDocSearch.Size = new System.Drawing.Size(158, 47);
            this.btnDocSearch.TabIndex = 34;
            this.btnDocSearch.Text = "Search";
            this.btnDocSearch.Click += new System.EventHandler(this.btnDocSearch_Click);
            // 
            // DoctorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 601);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVDoctors);
            this.Controls.Add(this.btnDocSearch);
            this.Controls.Add(this.txtdoctorsId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorSearch";
            this.Load += new System.EventHandler(this.DoctorSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdoctorsId;
        private Guna.UI.WinForms.GunaAdvenceButton btnDocSearch;
        private Guna.UI.WinForms.GunaDataGridView DGVDoctors;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.PictureBox btnClose;
    }
}