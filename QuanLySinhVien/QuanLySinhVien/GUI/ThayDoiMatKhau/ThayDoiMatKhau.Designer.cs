namespace QuanLySinhVien.GUI
{
    partial class _frmThayDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmThayDoiMatKhau));
            this._lblClose = new System.Windows.Forms.Label();
            this._pnlThayDoiMatKhau = new System.Windows.Forms.Panel();
            this._txtMatKhauCu = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnThayDoi = new System.Windows.Forms.Button();
            this._pnlThayDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblClose
            // 
            this._lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lblClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClose.Location = new System.Drawing.Point(506, 4);
            this._lblClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._lblClose.Name = "_lblClose";
            this._lblClose.Size = new System.Drawing.Size(52, 28);
            this._lblClose.TabIndex = 1;
            this._lblClose.Text = "X";
            this._lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblClose.Click += new System.EventHandler(this.OnLblThayDoiMKClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCloseMouseMove);
            // 
            // _pnlThayDoiMatKhau
            // 
            this._pnlThayDoiMatKhau.BackgroundImage = global::QuanLySinhVien.Properties.Resources._11033350_412625648862521_279522555_o;
            this._pnlThayDoiMatKhau.Controls.Add(this._lblClose);
            this._pnlThayDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlThayDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this._pnlThayDoiMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this._pnlThayDoiMatKhau.Name = "_pnlThayDoiMatKhau";
            this._pnlThayDoiMatKhau.Size = new System.Drawing.Size(561, 36);
            this._pnlThayDoiMatKhau.TabIndex = 7;
            // 
            // _txtMatKhauCu
            // 
            this._txtMatKhauCu.Location = new System.Drawing.Point(231, 107);
            this._txtMatKhauCu.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhauCu.Name = "_txtMatKhauCu";
            this._txtMatKhauCu.PasswordChar = '*';
            this._txtMatKhauCu.Size = new System.Drawing.Size(273, 22);
            this._txtMatKhauCu.TabIndex = 17;
            this._txtMatKhauCu.Text = "mật khẩu cũ";
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.Enabled = false;
            this._txtTenDangNhap.Location = new System.Drawing.Point(231, 75);
            this._txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(273, 22);
            this._txtTenDangNhap.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên đăng nhập";
            // 
            // _txtMatKhauMoi
            // 
            this._txtMatKhauMoi.Location = new System.Drawing.Point(231, 139);
            this._txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhauMoi.Name = "_txtMatKhauMoi";
            this._txtMatKhauMoi.PasswordChar = '*';
            this._txtMatKhauMoi.Size = new System.Drawing.Size(273, 22);
            this._txtMatKhauMoi.TabIndex = 20;
            this._txtMatKhauMoi.Text = "mật khẩu  mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu mới";
            // 
            // _txtNhapLaiMatKhauMoi
            // 
            this._txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(231, 175);
            this._txtNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this._txtNhapLaiMatKhauMoi.Name = "_txtNhapLaiMatKhauMoi";
            this._txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this._txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(273, 22);
            this._txtNhapLaiMatKhauMoi.TabIndex = 24;
            this._txtNhapLaiMatKhauMoi.Text = "nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nhập lại  mật khẩu mới";
            // 
            // _btnThayDoi
            // 
            this._btnThayDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThayDoi.Location = new System.Drawing.Point(231, 218);
            this._btnThayDoi.Name = "_btnThayDoi";
            this._btnThayDoi.Size = new System.Drawing.Size(125, 39);
            this._btnThayDoi.TabIndex = 25;
            this._btnThayDoi.Text = "Thay đổi";
            this._btnThayDoi.UseVisualStyleBackColor = true;
            this._btnThayDoi.Click += new System.EventHandler(this.OnBtnThayDoiClick);
            // 
            // _frmThayDoiMatKhau
            // 
            this.AcceptButton = this._btnThayDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 291);
            this.Controls.Add(this._btnThayDoi);
            this.Controls.Add(this._txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtMatKhauCu);
            this.Controls.Add(this._txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._pnlThayDoiMatKhau);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_frmThayDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThayDoiMatKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnThayDoiMatKhauFormClosing);
            this.Load += new System.EventHandler(this.OnThayDoiMatKhauLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnThayDoiMatKhauKeyDown);
            this._pnlThayDoiMatKhau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.Panel _pnlThayDoiMatKhau;
        private System.Windows.Forms.TextBox _txtMatKhauCu;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnThayDoi;
    }
}