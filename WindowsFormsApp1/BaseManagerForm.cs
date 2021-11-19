using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class BaseManagerForm : Form
    {
        public BaseManagerForm()
        {
            InitializeComponent();
        }

        private void BaseManagerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrBase_Tick(object sender, EventArgs e)
        {
            this.lblBaseTimer.Text += DateTime.Now.ToString($"yyyy年MM月dd日 hh:mm:ss");
        }
    }
}
