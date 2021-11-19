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
using WinForm.Utility;

namespace WinForm
{
    public partial class UserEditionForm : Form
    {
        public UserEditionForm(BindDgvDelegate bindDgvDelegate)
        {
            InitializeComponent();
            _bindDgvDelegate = bindDgvDelegate;
        }

        public UserEditionForm(BindDgvDelegate bindDgvDelegate, int userId) : this(bindDgvDelegate)
        {
            _user = Users.ListAll().Find(m => m.Id == userId);
            
        }

        private void EditionUserForm_Load(object sender, EventArgs e)
        {
            BindCbxShengFen();
            // 显示已选人员的原始信息
            if (_user != null)
            {
                this.txtUserName.Enabled = false;
                cbxSFEdition.SelectedValue = _user?.BaseTypeId;
                cbxGender.Text = _user?.Sex.ToString();
                txtUserName.Text = _user?.Name;
                chkbOn.Checked = Convert.ToBoolean(_user?.IsDel);
            }
        }

        private void BindCbxShengFen()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases = AppraisalBases.ListAll();
            appraisalBases.Insert(0, new AppraisalBases()
            {
                Id = 0,
                BaseType = "-- 请选择相应的身份 --",
                AppraisalBase = 0
            });
            cbxSFEdition.DataSource = appraisalBases;
            cbxSFEdition.DisplayMember = "BaseType";
            cbxSFEdition.ValueMember = "Id";
        }
        
        // 关闭用户编辑窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // 用户编辑的保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            int shengFen = (int)cbxSFEdition.SelectedValue;
            string sex = cbxGender.Text;
            Gender gender = default(Gender);
            if (sex == "男")
            {
                gender = Gender.男;
            }
            else
            {
                gender = Gender.女;
            }

            bool isDel = chkbOn.Checked;
            Users user = new Users()
            {
                Name = userName,
                BaseTypeId = shengFen,
                Sex = gender,
                IsDel = (NonJob)Convert.ToInt32(isDel)
            };

            if (_user == null)
            {
                Users.Insert(user);
                MessageBox.Show($"用户[{user.Name}]的信息已添加成功！");
            }
            else
            {
                user.Id = _user.Id;
                Users.Update(user);
                MessageBox.Show($"用户[{_user.Name}]的信息已修改成功！");
            }

            _bindDgvDelegate.Invoke();
            this.Close();
        }

        /*private void btnErrMsg_Click(object sender, EventArgs e)
        {
            ErrorMsgForm errorMsgForm = new ErrorMsgForm();
            errorMsgForm.ShowDialog();
        }*/

        private BindDgvDelegate _bindDgvDelegate;
        private Users _user;
    }
}
    