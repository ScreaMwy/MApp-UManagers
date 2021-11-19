using System.Windows.Forms;

namespace WinForm
{
    public partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            treeNode1 = new TreeNode("用户管理");
            treeNode2 = new TreeNode("基数管理");
            treeNode3 = new TreeNode("系数管理");
            treeNode4 = new TreeNode("人员绩效");
            this.scMainForm = new System.Windows.Forms.SplitContainer();
            this.tvMenu = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.scMainForm)).BeginInit();
            this.scMainForm.Panel1.SuspendLayout();
            this.scMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMainForm
            // 
            this.scMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainForm.Location = new System.Drawing.Point(0, 0);
            this.scMainForm.Name = "scMainForm";
            // 
            // scMainForm.Panel1
            // 
            this.scMainForm.Panel1.Controls.Add(this.tvMenu);
            // 
            // scMainForm.Panel2
            // 
            this.scMainForm.Panel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scMainForm.Size = new System.Drawing.Size(1084, 591);
            this.scMainForm.SplitterDistance = 242;
            this.scMainForm.TabIndex = 0;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.ItemHeight = 40;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Name = "tnUserManager";
            treeNode1.Text = "用户管理";
            treeNode2.Name = "tnBaseManager";
            treeNode2.Text = "基数管理";
            treeNode3.Name = "tnCoefficientManager";
            treeNode3.Text = "系数管理";
            treeNode4.Name = "tnUserAppraisal";
            treeNode4.Text = "人员绩效";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(242, 591);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 591);
            this.Controls.Add(this.scMainForm);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scMainForm.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainForm)).EndInit();
            this.scMainForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.MaximizeBox = false;
        }

        #endregion

        private SplitContainer scMainForm;
        private TreeView tvMenu;
        private TreeNode treeNode1;
        private TreeNode treeNode2;
        private TreeNode treeNode3;
        private TreeNode treeNode4;
    }
}

