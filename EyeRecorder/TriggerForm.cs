using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeRecorder
{
    public partial class TriggerForm : Form
    {
        public bool triggerFlag = false;

        public TriggerForm()
        {
            triggerFlag = false;
            InitializeComponent();
        }

        private void triggerSwitchButton_Click(object sender, EventArgs e)
        {
            if (this.triggerFlag)
            {
                this.triggerFlag = false;
                this.triggerLabel.Text = "Trigger off";
                this.triggerLabel.ForeColor = Color.Black;
            }
            else
            {
                this.triggerFlag = true;
                this.triggerLabel.Text = "Trigger on";
                this.triggerLabel.ForeColor = Color.Red;
            }
        }
    }
}
