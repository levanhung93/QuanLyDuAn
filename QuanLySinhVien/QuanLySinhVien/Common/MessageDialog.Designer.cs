namespace QuanLySinhVien.Common
{
    partial class MessageDialog
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
            this._panelContent = new System.Windows.Forms.Panel();
            this._txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelContent
            // 
            this._panelContent.Controls.Add(this._txtMessage);
            this._panelContent.Controls.Add(this.panel1);
            this._panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelContent.Location = new System.Drawing.Point(0, 0);
            this._panelContent.Name = "_panelContent";
            this._panelContent.Size = new System.Drawing.Size(368, 210);
            this._panelContent.TabIndex = 0;
            // 
            // _txtMessage
            // 
            this._txtMessage.BackColor = System.Drawing.Color.SkyBlue;
            this._txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this._txtMessage.Location = new System.Drawing.Point(0, 30);
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.Size = new System.Drawing.Size(368, 140);
            this._txtMessage.TabIndex = 1;
            this._txtMessage.Text = "Message";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLySinhVien.Properties.Resources.header;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 30);
            this.panel1.TabIndex = 0;
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 210);
            this.Controls.Add(this._panelContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageDialog";
            this._panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _txtMessage;
    }
}