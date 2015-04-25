using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.Common
{
    public partial class DialogContent_OK : UserControl
    {
        public delegate void Dlg(bool isOK);
        public Dlg SendValueDelegate;
        public DialogContent_OK()
        {
            InitializeComponent();
        }

        private void OnBtnOkClick(object sender, EventArgs e)
        {
            if (null!=SendValueDelegate)
            {
                SendValueDelegate(true);
            }
        }
    }
}
