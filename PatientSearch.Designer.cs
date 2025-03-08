namespace HospitalManagementSystem
{
    partial class PatientSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSearch));
            this.txtPId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DGVPatient = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPatientSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPId
            // 
            this.txtPId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPId.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPId.HintForeColor = System.Drawing.Color.Empty;
            this.txtPId.HintText = "Patient ID";
            this.txtPId.isPassword = false;
            this.txtPId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPId.LineThickness = 3;
            this.txtPId.Location = new System.Drawing.Point(59, 17);
            this.txtPId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(213, 42);
            this.txtPId.TabIndex = 39;
            this.txtPId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DGVPatient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPatient.BackgroundColor = System.Drawing.Color.White;
            this.DGVPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPatient.ColumnHeadersHeight = 30;
            this.DGVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPatient.EnableHeadersVisualStyles = false;
            this.DGVPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVPatient.Location = new System.Drawing.Point(1, 156);
            this.DGVPatient.Name = "DGVPatient";
            this.DGVPatient.RowHeadersVisible = false;
            this.DGVPatient.RowHeadersWidth = 51;
            this.DGVPatient.RowTemplate.Height = 24;
            this.DGVPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPatient.Size = new System.Drawing.Size(1156, 384);
            this.DGVPatient.TabIndex = 40;
            this.DGVPatient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVPatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVPatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVPatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVPatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVPatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVPatient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVPatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVPatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVPatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVPatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVPatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVPatient.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVPatient.ThemeStyle.ReadOnly = false;
            this.DGVPatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVPatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVPatient.ThemeStyle.RowsStyle.Height = 24;
            this.DGVPatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVPatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPatient_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 41;
            this.label3.Text = "Patient List";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1104, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 44;
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(906, 10);
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
            // btnPatientSearch
            // 
            this.btnPatientSearch.AnimationHoverSpeed = 0.07F;
            this.btnPatientSearch.AnimationSpeed = 0.03F;
            this.btnPatientSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientSearch.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnPatientSearch.BorderColor = System.Drawing.Color.Black;
            this.btnPatientSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPatientSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPatientSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPatientSearch.CheckedImage")));
            this.btnPatientSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPatientSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatientSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatientSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientSearch.Image")));
            this.btnPatientSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPatientSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatientSearch.Location = new System.Drawing.Point(353, 12);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.OnHoverBaseColor = System.Drawing.Color.Navy;
            this.btnPatientSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPatientSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.OnHoverImage = null;
            this.btnPatientSearch.OnHoverLineColor = System.Drawing.Color.Navy;
            this.btnPatientSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnPatientSearch.Radius = 20;
            this.btnPatientSearch.Size = new System.Drawing.Size(158, 47);
            this.btnPatientSearch.TabIndex = 35;
            this.btnPatientSearch.Text = "Search";
            this.btnPatientSearch.Click += new System.EventHandler(this.btnDocSearch_Click);
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 607);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVPatient);
            this.Controls.Add(this.txtPId);
            this.Controls.Add(this.btnPatientSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientSearch";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnPatientSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPId;
        private Guna.UI.WinForms.GunaDataGridView DGVPatient;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.PictureBox btnClose;
    }
}