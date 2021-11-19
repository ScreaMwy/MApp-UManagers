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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*UserManagerForm userManagerForm = new UserManagerForm();
            userManagerForm.MdiParent = this;
            userManagerForm.Parent = scMainForm.Panel2;
            userManagerForm.Show();*/
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NodeReset();
            // 获取节点的方法：1、((TreeView)sender)；2、TreeView treeView对象；3、TreeViewEventArgs e对象。
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;


            UserManagerForm userManagerForm = new UserManagerForm();
            userManagerForm.MdiParent = this;
            userManagerForm.Parent = scMainForm.Panel2;
            userManagerForm.Show();
        }

        private void NodeReset()
        {
            foreach (TreeNode node in tvMenu.Nodes)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
        }
    }
}
