﻿namespace GUI
{
    partial class fEditTheLoai
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
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.controlPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.miniControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.closeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.butOK = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.labelMaTheLoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.controlPanel.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.controlPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.controlPanel.Controls.Add(this.miniControlBox);
            this.controlPanel.Controls.Add(this.closeControlBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(640, 54);
            this.controlPanel.TabIndex = 5;
            // 
            // miniControlBox
            // 
            this.miniControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.miniControlBox.FillColor = System.Drawing.Color.Transparent;
            this.miniControlBox.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.miniControlBox.Location = new System.Drawing.Point(517, 0);
            this.miniControlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniControlBox.Name = "miniControlBox";
            this.miniControlBox.Size = new System.Drawing.Size(60, 54);
            this.miniControlBox.TabIndex = 0;
            // 
            // closeControlBox
            // 
            this.closeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.closeControlBox.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.closeControlBox.Location = new System.Drawing.Point(579, 0);
            this.closeControlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeControlBox.Name = "closeControlBox";
            this.closeControlBox.Size = new System.Drawing.Size(61, 54);
            this.closeControlBox.TabIndex = 0;
            // 
            // butOK
            // 
            this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butOK.BorderRadius = 2;
            this.butOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOK.FillColor = System.Drawing.Color.SlateBlue;
            this.butOK.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOK.ForeColor = System.Drawing.Color.White;
            this.butOK.Location = new System.Drawing.Point(151, 305);
            this.butOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(100, 48);
            this.butOK.TabIndex = 6;
            this.butOK.Text = "Lưu";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // labelMaTheLoai
            // 
            this.labelMaTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaTheLoai.AutoSize = true;
            this.labelMaTheLoai.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaTheLoai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMaTheLoai.Location = new System.Drawing.Point(58, 116);
            this.labelMaTheLoai.Name = "labelMaTheLoai";
            this.labelMaTheLoai.Size = new System.Drawing.Size(122, 27);
            this.labelMaTheLoai.TabIndex = 5;
            this.labelMaTheLoai.Text = "Mã Thể loại: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(58, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Thể loại: ";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(63, 199);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(269, 36);
            this.txtTen.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelTitle.Location = new System.Drawing.Point(82, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(239, 44);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "SỬA THỂ LOẠI";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.siticonePanel1.BorderRadius = 4;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.butOK);
            this.siticonePanel1.Controls.Add(this.labelMaTheLoai);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.txtTen);
            this.siticonePanel1.Controls.Add(this.labelTitle);
            this.siticonePanel1.Location = new System.Drawing.Point(125, 98);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(402, 437);
            this.siticonePanel1.TabIndex = 6;
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // fEditTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 585);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEditTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEditTheLoai";
            this.controlPanel.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox miniControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox closeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butOK;
        private System.Windows.Forms.Label labelMaTheLoai;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTen;
        private System.Windows.Forms.Label labelTitle;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    }
}