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
            _mainLogForm = new MainLogForm();
            _mainLogForm.MdiParent = this;
            _mainLogForm.Parent = scMainForm.Panel2;
            _mainLogForm.Show();
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NodeReset();
            // 获取节点的方法：1、((TreeView)sender)；2、TreeView treeView对象；3、TreeViewEventArgs e对象。
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;
        }

        private void NodeReset()
        {
            foreach (TreeNode node in tvMenu.Nodes)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
        }

        /*
         *  UserManagerForm userManagerForm = new UserManagerForm();
         *  userManagerForm.MdiParent = this;
         *  userManagerForm.Parent = scMainForm.Panel2;
         *  userManagerForm.Show();
         */

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form form = FormFactory.CreateFactory(e.Node.Index);
            form.MdiParent = this;
            form.Parent = scMainForm.Panel2;
            form.Show();
        }
        
        private MainLogForm _mainLogForm;
    }
}
