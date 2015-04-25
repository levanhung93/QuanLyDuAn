namespace QuanLySinhVien.Common
{
    partial class DialogContent_YESNO
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
            this._btnYes = new System.Windows.Forms.Button();
            this._btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnYes
            // 
            this._btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnYes.Location = new System.Drawing.Point(171, 6);
            this._btnYes.Name = "_btnYes";
            this._btnYes.Size = new System.Drawing.Size(75, 28);
            this._btnYes.TabIndex = 0;
            this._btnYes.Text = "Yes";
            this._btnYes.UseVisualStyleBackColor = true;
            this._btnYes.Click += new System.EventHandler(this.OnBtnYesClick);
            // 
            // _btnNo
            // 
            this._btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnNo.Location = new System.Drawing.Point(268, 6);
            this._btnNo.Name = "_btnNo";
            this._btnNo.Size = new System.Drawing.Size(75, 28);
            this._btnNo.TabIndex = 1;
            this._btnNo.Text = "No";
            this._btnNo.UseVisualStyleBackColor = true;
            this._btnNo.Click += new System.EventHandler(this.OnBtnNoClick);
            // 
            // DialogContent_YESNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this._btnNo);
            this.Controls.Add(this._btnYes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DialogContent_YESNO";
            this.Size = new System.Drawing.Size(368, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnYes;
        private System.Windows.Forms.Button _btnNo;
    }
}
