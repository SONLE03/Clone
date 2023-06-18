namespace GUI.UserControls
{
    partial class ucPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuNhap));
            this.PhieuNhapgrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.SoPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUNHAPSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtNam = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtThang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtNgay = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butFind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtFind = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPSACHBindingSource)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhieuNhapgrid
            // 
            this.PhieuNhapgrid.AllowUserToAddRows = false;
            this.PhieuNhapgrid.AllowUserToDeleteRows = false;
            this.PhieuNhapgrid.AllowUserToResizeColumns = false;
            this.PhieuNhapgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuNhapgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PhieuNhapgrid.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhieuNhapgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PhieuNhapgrid.ColumnHeadersHeight = 35;
            this.PhieuNhapgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuNhapgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuNhap,
            this.TongTien,
            this.NgayNhap});
            this.PhieuNhapgrid.DataSource = this.pHIEUNHAPSACHBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhieuNhapgrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.PhieuNhapgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhieuNhapgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.Location = new System.Drawing.Point(0, 100);
            this.PhieuNhapgrid.Name = "PhieuNhapgrid";
            this.PhieuNhapgrid.ReadOnly = true;
            this.PhieuNhapgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuNhapgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PhieuNhapgrid.RowHeadersVisible = false;
            this.PhieuNhapgrid.RowHeadersWidth = 51;
            this.PhieuNhapgrid.RowTemplate.Height = 30;
            this.PhieuNhapgrid.Size = new System.Drawing.Size(932, 562);
            this.PhieuNhapgrid.TabIndex = 3;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhieuNhapgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhieuNhapgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuNhapgrid.ThemeStyle.HeaderStyle.Height = 35;
            this.PhieuNhapgrid.ThemeStyle.ReadOnly = true;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.Height = 30;
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuNhapgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuNhapgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhieuNhapgrid_CellClick);
            // 
            // SoPhieuNhap
            // 
            this.SoPhieuNhap.DataPropertyName = "SoPhieuNhap";
            this.SoPhieuNhap.HeaderText = "Số phiếu nhập ";
            this.SoPhieuNhap.MinimumWidth = 6;
            this.SoPhieuNhap.Name = "SoPhieuNhap";
            this.SoPhieuNhap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập ";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // pHIEUNHAPSACHBindingSource
            // 
            this.pHIEUNHAPSACHBindingSource.DataSource = typeof(DTO.PHIEUNHAPSACH);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.siticoneButton1);
            this.topPanel.Controls.Add(this.txtNam);
            this.topPanel.Controls.Add(this.txtThang);
            this.topPanel.Controls.Add(this.txtNgay);
            this.topPanel.Controls.Add(this.butFind);
            this.topPanel.Controls.Add(this.txtFind);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(932, 100);
            this.topPanel.TabIndex = 2;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderRadius = 13;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.SlateBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(3, 0);
            this.siticoneButton1.Location = new System.Drawing.Point(698, 57);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(151, 28);
            this.siticoneButton1.TabIndex = 29;
            this.siticoneButton1.Text = "Lọc ngày nhập";
            this.siticoneButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.TextOffset = new System.Drawing.Point(3, 0);
            this.siticoneButton1.Click += new System.EventHandler(this.butFindDay_Click);
            // 
            // txtNam
            // 
            this.txtNam.AutoRoundedCorners = true;
            this.txtNam.BorderRadius = 14;
            this.txtNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNam.DefaultText = "";
            this.txtNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Location = new System.Drawing.Point(599, 57);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNam.PlaceholderText = "Năm";
            this.txtNam.SelectedText = "";
            this.txtNam.Size = new System.Drawing.Size(83, 30);
            this.txtNam.TabIndex = 28;
            // 
            // txtThang
            // 
            this.txtThang.AutoRoundedCorners = true;
            this.txtThang.BorderRadius = 14;
            this.txtThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThang.DefaultText = "";
            this.txtThang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Location = new System.Drawing.Point(520, 57);
            this.txtThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThang.Name = "txtThang";
            this.txtThang.PasswordChar = '\0';
            this.txtThang.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtThang.PlaceholderText = "Tháng";
            this.txtThang.SelectedText = "";
            this.txtThang.Size = new System.Drawing.Size(73, 30);
            this.txtThang.TabIndex = 27;
            // 
            // txtNgay
            // 
            this.txtNgay.AutoRoundedCorners = true;
            this.txtNgay.BorderRadius = 14;
            this.txtNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgay.DefaultText = "";
            this.txtNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Location = new System.Drawing.Point(446, 57);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.PasswordChar = '\0';
            this.txtNgay.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNgay.PlaceholderText = "Ngày";
            this.txtNgay.SelectedText = "";
            this.txtNgay.Size = new System.Drawing.Size(68, 30);
            this.txtNgay.TabIndex = 26;
            // 
            // butFind
            // 
            this.butFind.AutoRoundedCorners = true;
            this.butFind.BorderRadius = 13;
            this.butFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFind.FillColor = System.Drawing.Color.SlateBlue;
            this.butFind.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.White;
            this.butFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFind.Location = new System.Drawing.Point(698, 23);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(151, 28);
            this.butFind.TabIndex = 16;
            this.butFind.Text = "Tìm kiếm";
            this.butFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.TextOffset = new System.Drawing.Point(3, 0);
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderRadius = 12;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(446, 25);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFind.PlaceholderText = "Số phiếu";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(236, 26);
            this.txtFind.TabIndex = 17;
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = ((System.Drawing.Image)(resources.GetObject("butRefresh.Image")));
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(0, 31);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(82, 66);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // ucPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhieuNhapgrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucPhieuNhap";
            this.Size = new System.Drawing.Size(932, 662);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPSACHBindingSource)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView PhieuNhapgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.BindingSource pHIEUNHAPSACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNam;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtThang;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNgay;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFind;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtFind;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
    }
}
