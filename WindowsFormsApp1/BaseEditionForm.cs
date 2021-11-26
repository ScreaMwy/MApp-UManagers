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
    internal partial class BaseEditionForm : Form
    {
        public BaseEditionForm(BindDgvDelegate bindDgvDelegate, int id)
        {
            InitializeComponent();
            _bindDgvDelegate = bindDgvDelegate;
            _appraisalBases = AppraisalBases.ListAll().Find(m => m.Id == id);
        }

        private void BaseEditionForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            // 从文本框中获取
            _appraisalBases.AppraisalBase = Convert.ToInt32(txtBase.Text.Trim());

            // AppraisalBase的数据更新
            AppraisalBases.Update(_appraisalBases);

            DialogResult result = MessageBox.Show($"数据已成功修改为{txtBase.Text.Trim()}！", "提示", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                _bindDgvDelegate.Invoke();
            }
            Close();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtBase_KeyDown(object sender, KeyEventArgs e)
        {
            // 当输入的Key为Enter（回车）时触发
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private BindDgvDelegate _bindDgvDelegate;
        private AppraisalBases _appraisalBases;

    }
}
