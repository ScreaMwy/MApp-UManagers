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

        private void UserManagerForm_LoadAndOpen()
        {
            
            _userManagerForm = new UserManagerForm();
            _userManagerForm.MdiParent = this;
            _userManagerForm.Parent = scMainForm.Panel2;
            _userManagerForm.Show();
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
            switch (e.Node.Name)
            {
                case "tnUserManager":
                    // MessageBox.Show("tnUserManager");
                    // FormReset();
                    if (_mainLogForm != null)
                    {
                        _mainLogForm.Close();
                    }
                    if (_baseManagerForm != null)
                    {
                        _baseManagerForm.Close();
                    }
                    if (
                        _coefficientManagerForm != null)
                    {
                        _coefficientManagerForm.Close();
                    }
                    if (_userAppraisalForm != null)
                    {
                        _userAppraisalForm.Close();
                    }

                    UserManagerForm_LoadAndOpen();
                    break;
                case "tnBaseManager":
                    // MessageBox.Show("tnBaseManager");
                    // FormReset();
                    if (_mainLogForm != null)
                    {
                        _mainLogForm.Close();
                    }
                    if (_userManagerForm != null)
                    {
                        _userManagerForm.Close();
                    }
                    if (
                        _coefficientManagerForm != null)
                    {
                        _coefficientManagerForm.Close();
                    }
                    if (_userAppraisalForm != null)
                    {
                        _userAppraisalForm.Close();
                    }

                    _baseManagerForm = new BaseManagerForm();
                    _baseManagerForm.MdiParent = this;
                    _baseManagerForm.Parent = scMainForm.Panel2;
                    _baseManagerForm.Show();

                    /*
                    if (_userManagerForm != null ||
                        _coefficientManagerForm != null ||
                        _userAppraisalForm != null)
                    {
                        _userManagerForm.Close();
                        _coefficientManagerForm.Close();
                        _userAppraisalForm.Close();
                    }*/

                    
                    break;
                case "tnCoefficientManager":
                    // MessageBox.Show("tnCoefficientManager");
                    // FormReset();
                    /*if (_userManagerForm != null ||
                        _baseManagerForm != null ||
                        _userAppraisalForm != null)
                    {
                        _userManagerForm.Close();
                        _baseManagerForm.Close();
                        _userAppraisalForm.Close();
                    }*/

                    _coefficientManagerForm = new CoefficientManagerForm();
                    _coefficientManagerForm.MdiParent = this;
                    _coefficientManagerForm.Parent = scMainForm.Parent;
                    _coefficientManagerForm.Show();
                    break;
                case "tnUserAppraisal":
                    // MessageBox.Show("tnUserAppraisal");
                    // FormReset();
                    /*if (_userManagerForm != null ||
                        _baseManagerForm != null ||
                        _userAppraisalForm != null)
                    {
                        _userManagerForm.Close();
                        _baseManagerForm.Close();
                        _coefficientManagerForm.Close();
                    }*/

                    _userAppraisalForm = new UserAppraisalForm();
                    _userAppraisalForm.MdiParent = this;
                    _userAppraisalForm.Parent = scMainForm.Panel2;
                    _userAppraisalForm.Show();
                    break;
                default:
                    MessageBox.Show($"{new Exception("不存在相应的节点！").Message}");
                    break;
            }
        }

        private UserManagerForm _userManagerForm;
        private BaseManagerForm _baseManagerForm;
        private CoefficientManagerForm _coefficientManagerForm;
        private UserAppraisalForm _userAppraisalForm;
        private MainLogForm _mainLogForm;
    }
}
