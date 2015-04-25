namespace QuanLySinhVien.GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this._txtMatKhau = new System.Windows.Forms.TextBox();
            this._txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._panelDangNhap = new System.Windows.Forms.Panel();
            this._lblClose = new System.Windows.Forms.Label();
            this._btnDangNhap = new System.Windows.Forms.Button();
            this._panelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtMatKhau
            // 
            this._txtMatKhau.Location = new System.Drawing.Point(236, 123);
            this._txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhau.Name = "_txtMatKhau";
            this._txtMatKhau.PasswordChar = '*';
            this._txtMatKhau.Size = new System.Drawing.Size(273, 22);
            this._txtMatKhau.TabIndex = 11;
            this._txtMatKhau.Text = "mật khẩu";
            // 
            // _txtTenDangNhap
            // 
            this._txtTenDangNhap.Location = new System.Drawing.Point(236, 79);
            this._txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this._txtTenDangNhap.Name = "_txtTenDangNhap";
            this._txtTenDangNhap.Size = new System.Drawing.Size(273, 22);
            this._txtTenDangNhap.TabIndex = 10;
            this._txtTenDangNhap.Text = "Nhập tên đăng nhập....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // _panelDangNhap
            // 
            this._panelDangNhap.BackgroundImage = global::QuanLySinhVien.Properties.Resources.login;
            this._panelDangNhap.Controls.Add(this._lblClose);
            this._panelDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelDangNhap.Location = new System.Drawing.Point(0, 0);
            this._panelDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this._panelDangNhap.Name = "_panelDangNhap";
            this._panelDangNhap.Size = new System.Drawing.Size(561, 36);
            this._panelDangNhap.TabIndex = 6;
            this._panelDangNhap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelDangNhapMouseDown);
            this._panelDangNhap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelDangNhapMouseMove);
            this._panelDangNhap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelDangNhapMouseUp);
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
            this._lblClose.Click += new System.EventHandler(this.OnCloseClick);
            this._lblClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            this._lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCloseMouseMove);
            // 
            // _btnDangNhap
            // 
            this._btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDangNhap.Location = new System.Drawing.Point(236, 189);
            this._btnDangNhap.Name = "_btnDangNhap";
            this._btnDangNhap.Size = new System.Drawing.Size(125, 39);
            this._btnDangNhap.TabIndex = 12;
            this._btnDangNhap.Text = "Đăng nhập";
            this._btnDangNhap.UseVisualStyleBackColor = true;
            this._btnDangNhap.Click += new System.EventHandler(this.OnBtnDangNhapClick);
            // 
            // DangNhap
            // 
            this.AcceptButton = this._btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 291);
            this.Controls.Add(this._btnDangNhap);
            this.Controls.Add(this._panelDangNhap);
            this.Controls.Add(this._txtMatKhau);
            this.Controls.Add(this._txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnDangNhapFormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnDangNhapKeyDown);
            this._panelDangNhap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelDangNhap;
        private System.Windows.Forms.Label _lblClose;
        private System.Windows.Forms.TextBox _txtMatKhau;
        private System.Windows.Forms.TextBox _txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnDangNhap;
    }
}