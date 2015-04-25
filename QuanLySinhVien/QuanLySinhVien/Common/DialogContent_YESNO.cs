using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien.Common
{
    public partial class DialogContent_YESNO : UserControl
    {
        #region Field
        public delegate void Dlg(bool isYes);
        public Dlg SendValueDelegate;
        #endregion Field

        #region Method
        public DialogContent_YESNO()
        {
            InitializeComponent();
        }
        #endregion Method

        #region Event
        private void OnBtnYesClick(object sender, EventArgs e)
        {
            if (null != SendValueDelegate)
            {
                SendValueDelegate(true);
            }
        }

        private void OnBtnNoClick(object sender, EventArgs e)
        {
            if (null != SendValueDelegate)
            {
                SendValueDelegate(false);
            }
        }
        #endregion Event
    }
}
