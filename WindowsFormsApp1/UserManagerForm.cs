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
    public partial class UserManagerForm : Form
    {
        public UserManagerForm()
        {
            InitializeComponent();
        }

        private void gbShaiXuan_Enter(object sender, EventArgs e)
        {

        }

        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            BindCbx();
            BindDgv();
            _bindDgvDelegate = new BindDgvDelegate(BindDgv);
        }

        // 筛选中的按需查询
        private void BindDgv()
        {
            string userName = txtUserName.Text.Trim();
            int baseTypeId = (int)cbxShengFen.SelectedValue;
            bool isStop = chkNonJob.Checked;
            dgvUserAppraisalBase.AutoGenerateColumns = false;
            List<UsersAppraisalBases> usersAppraisalBases = UsersAppraisalBases.GetListJoinAppraisal();
            if (baseTypeId == 0)
            {
                dgvUserAppraisalBase.DataSource = usersAppraisalBases.FindAll(m =>
                m.Name.Contains(userName) && m.IsDel == (NonJob)(Convert.ToInt32(isStop)));
            }
            else
            {
                dgvUserAppraisalBase.DataSource = usersAppraisalBases.FindAll(m =>
                m.Name.Contains(userName) && m.BaseTypeId == baseTypeId && m.IsDel == (NonJob)(Convert.ToInt32(isStop)));
            }
        }

        // 查询所有
        private void BindCbx()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            /*appraisalBases.Add(new AppraisalBases()
            {
                Id = 0,
                BaseType ="-- 查询所有 --",
                AppraisalBase = 0,
                IsDel = false
            });
            IEnumerable<AppraisalBases> appraisalBases1 = AppraisalBases.ListAll();
            appraisalBases.AddRange(appraisalBases1);*/
            appraisalBases = AppraisalBases.ListAll();
            appraisalBases.Insert(0, new AppraisalBases()
            {
                Id = 0,
                BaseType = "-- 查询所有 --",
                AppraisalBase = 0,
            });
            cbxShengFen.DataSource = appraisalBases;
            cbxShengFen.DisplayMember = "BaseType";
            cbxShengFen.ValueMember = "Id";
            /*cbxShengFen.Text = "—查询所有—";
            cbxShengFen.Items.Add("—查询所有—");
            foreach (var appraisalBase in appraisalBases)
            {
                cbxShengFen.Items.Add(appraisalBase.BaseType);
            }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        // 鼠标右键的执行先是MouseDown -> CellMouseDown
        // 添加判断右键的条件
        private void dgvUserAppraisalBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tsmNewItem.Visible = true;
                tsmEdit.Visible = false;
                tsmStart.Visible = false;
                tsmStop.Visible = false;
            }
        }

        private void dgvUserAppraisalBase_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1)
                {
                    dgvUserAppraisalBase.Rows[e.RowIndex].Selected = true;
                    tsmNewItem.Visible = true;
                    tsmEdit.Visible = true;
                    bool isDel = Convert.ToBoolean(dgvUserAppraisalBase.SelectedRows[0].Cells["IsDel"].Value);
                    if (isDel)
                    {
                        tsmStart.Visible = true;
                    }
                    else
                    {
                        tsmStop.Visible = false;
                    }
                }
            }
        }

        private void tsmNewItem_Click(object sender, EventArgs e)
        {
            UserEditionForm userEditionForm = new UserEditionForm(_bindDgvDelegate);
            userEditionForm.ShowDialog();
            BindDgv();
        }

        private void tsmStart_Click(object sender, EventArgs e)
        {

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int id = (int)dgvUserAppraisalBase.SelectedRows[0].Cells["Id"].Value;
            UserEditionForm userEditionForm = new UserEditionForm(_bindDgvDelegate, id);
            userEditionForm.ShowDialog();
        }

        private void tsmStop_Click(object sender, EventArgs e)
        {

        }

        private void dgvUserAppraisalBase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Double Click");
        }

        private BindDgvDelegate _bindDgvDelegate;
    }
}
