using System;
using System.Windows.Forms;
using QuanLySinhVien.GUI;

namespace QuanLySinhVien.Common
{
    public partial class MessageDialog : Form
    {
        public enum DialogType
        {
            Ok,
            YesNo
        }
        public enum DialogResultType
        {
            Ok,
            Yes,
            No
        }
        public DialogType Type = DialogType.Ok;

        public delegate void Dlg(DialogResultType result);
        public Dlg SendValueDelegate;
        public MessageDialog(string message, DialogType type)
        {
            InitializeComponent();

            this.ShowInTaskbar = false;


            _txtMessage.Text = message;
            switch (type)
            {
                case DialogType.Ok:
                    DialogContent_OK dialogContentOK = new DialogContent_OK();
                    _panelContent.Controls.Add(dialogContentOK);
                    dialogContentOK.Dock = DockStyle.Bottom;
                    dialogContentOK.SendValueDelegate = delegate(bool ok)
                    {
                        this.Close();
                        if (null != SendValueDelegate)
                        {
                            SendValueDelegate(DialogResultType.Ok);
                        }
                    };
                    break;
                case DialogType.YesNo:
                    DialogContent_YESNO dialogContentYesno = new DialogContent_YESNO();
                    _panelContent.Controls.Add(dialogContentYesno);
                    dialogContentYesno.Dock = DockStyle.Bottom;
                    dialogContentYesno.SendValueDelegate = delegate(bool yes)
                    {
                        this.Close();
                        if (null != SendValueDelegate)
                        {
                            if (yes)
                            {
                                SendValueDelegate(DialogResultType.Yes);
                            }
                            else
                            {
                                SendValueDelegate(DialogResultType.No);
                            }
                        }
                    };
                    break;
            }
        }
    }
}
