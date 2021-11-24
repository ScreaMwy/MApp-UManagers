using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Model;

namespace WinForm
{
    internal partial class BaseManagerForm : Form
    {
        public BaseManagerForm()
        {
            InitializeComponent();
        }

        private void BaseManagerForm_Load(object sender, EventArgs e)
        {
            dgvBaseData.DataSource = AppraisalBases.ListAll();
        }

        private void dgvBaseData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    dgvBaseData.Rows[e.RowIndex].Selected = true;
                    MessageBox.Show($"Right Cell Click Successed");
                }    
            }
        }

        private void dgvBaseData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            }
        }

        private void dgvBaseData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"DoubleClick Successed");
            
        }

        // private void BaseManagerForm_Load(object sender, EventArgs e)
        // {
        //     tmrBase.Start();
        // }
        //
        // private void tmrBase_Tick(object sender, EventArgs e)
        // {
        //     lblBaseTimer.Text = DateTime.Now.ToString($"yyyy年MM月dd日 hh:mm:ss");
        // }
    } 
}
