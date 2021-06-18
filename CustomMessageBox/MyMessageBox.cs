using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMessageBox
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string mess, string cap, System.Windows.Forms.MessageBoxButtons btn, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dr = System.Windows.Forms.DialogResult.None;
            switch (btn)
            {
                case System.Windows.Forms.MessageBoxButtons.OK :
                    using(MessageOK msOK = new MessageOK())
                    {
                        msOK.Text = cap;
                        msOK.Message = mess;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msOK.MessageIcon = CustomMessageBox.Properties.Resources.tick;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msOK.MessageIcon = CustomMessageBox.Properties.Resources.error;
                                break;
                        }
                        msOK.ShowDialog();
                        dr = msOK._btnResult;
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (MessageYesNo msYN = new MessageYesNo())
                    {
                        msYN.Text = cap;
                        msYN.Message = mess;
                        msYN.MessageIcon = CustomMessageBox.Properties.Resources.question;
                        msYN.ShowDialog();
                        dr = msYN._btnResult;
                    }
                    break;
            }
            return dr;
        }
    }
}
