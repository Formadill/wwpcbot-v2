using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wwpcbot_v2
{
    public partial class AddFunc : Form
    {
        public AddFunc()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Functionality.CmdBool = checkBoxCmds.Checked;
            Functionality.CustomCmdBool = checkBoxCustomCmds.Checked;
            Functionality.CapBool = checkBoxTwitchCap.Checked;
            Functionality.MemBool = checkBoxMember.Checked;
            Functionality.TagBool = checkBoxTags.Checked;
            this.Close();
        }

        private void checkBoxCmds_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCmds.Checked)
            {
                checkBoxCustomCmds.Visible = true;
            }
        }

        private void checkBoxTwitchCap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTwitchCap.Checked)
            {
                checkBoxMember.Visible = true;
                checkBoxTags.Visible = true;
            }
        }
    }
}
