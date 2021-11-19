using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class UserManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbShaiXuan = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblShengFen = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxShengFen = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkNonJob = new System.Windows.Forms.CheckBox();
            this.dgvUserAppraisalBase = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsUserManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStop = new System.Windows.Forms.ToolStripMenuItem();
            this.gbShaiXuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisalBase)).BeginInit();
            this.cmsUserManager.SuspendLayout();
            this.SuspendLayout();



            // 
            // gbShaiXuan
            // 
            this.gbShaiXuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbShaiXuan.Controls.Add(this.lblUserName);
            this.gbShaiXuan.Controls.Add(this.lblShengFen);
            this.gbShaiXuan.Controls.Add(this.btnSearch);
            this.gbShaiXuan.Controls.Add(this.cbxShengFen);
            this.gbShaiXuan.Controls.Add(this.txtUserName);
            this.gbShaiXuan.Controls.Add(this.chkNonJob);
            this.gbShaiXuan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbShaiXuan.Location = new System.Drawing.Point(14, 17);
            this.gbShaiXuan.Margin = new System.Windows.Forms.Padding(4);
            this.gbShaiXuan.Name = "gbShaiXuan";
            this.gbShaiXuan.Padding = new System.Windows.Forms.Padding(4);
            this.gbShaiXuan.Size = new System.Drawing.Size(959, 116);
            this.gbShaiXuan.TabIndex = 0;
            this.gbShaiXuan.TabStop = false;
            this.gbShaiXuan.Text = "筛选";
            this.gbShaiXuan.Enter += new System.EventHandler(this.gbShaiXuan_Enter);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(7, 51);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 17);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "用户名：";
            // 
            // lblShengFen
            // 
            this.lblShengFen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblShengFen.AutoSize = true;
            this.lblShengFen.Location = new System.Drawing.Point(311, 51);
            this.lblShengFen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShengFen.Name = "lblShengFen";
            this.lblShengFen.Size = new System.Drawing.Size(44, 17);
            this.lblShengFen.TabIndex = 2;
            this.lblShengFen.Text = "身份：";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(850, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxShengFen
            // 
            this.cbxShengFen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxShengFen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxShengFen.FormattingEnabled = true;
            this.cbxShengFen.Location = new System.Drawing.Point(362, 48);
            this.cbxShengFen.Name = "cbxShengFen";
            this.cbxShengFen.Size = new System.Drawing.Size(210, 25);
            this.cbxShengFen.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserName.Location = new System.Drawing.Point(70, 48);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(188, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // chkNonJob
            // 
            this.chkNonJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkNonJob.AutoSize = true;
            this.chkNonJob.Location = new System.Drawing.Point(602, 50);
            this.chkNonJob.Name = "chkNonJob";
            this.chkNonJob.Size = new System.Drawing.Size(63, 21);
            this.chkNonJob.TabIndex = 4;
            this.chkNonJob.Text = "已停职";
            this.chkNonJob.UseVisualStyleBackColor = true;
            // 
            // dgvUserAppraisalBase
            // 
            this.dgvUserAppraisalBase.AllowUserToAddRows = false;
            this.dgvUserAppraisalBase.AllowUserToDeleteRows = false;
            this.dgvUserAppraisalBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAppraisalBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAppraisalBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Gender,
            this.BaseType,
            this.AppraisalBase,
            this.IsDel});
            this.dgvUserAppraisalBase.ContextMenuStrip = this.cmsUserManager;
            this.dgvUserAppraisalBase.Location = new System.Drawing.Point(13, 141);
            this.dgvUserAppraisalBase.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserAppraisalBase.MultiSelect = false;
            this.dgvUserAppraisalBase.Name = "dgvUserAppraisalBase";
            this.dgvUserAppraisalBase.ReadOnly = true;
            this.dgvUserAppraisalBase.RowTemplate.Height = 23;
            this.dgvUserAppraisalBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisalBase.Size = new System.Drawing.Size(960, 427);
            this.dgvUserAppraisalBase.TabIndex = 1;
            this.dgvUserAppraisalBase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAppraisalBase_CellDoubleClick);
            this.dgvUserAppraisalBase.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserAppraisalBase_CellMouseDown);
            this.dgvUserAppraisalBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUserAppraisalBase_MouseDown);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Sex";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // BaseType
            // 
            this.BaseType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BaseType.DataPropertyName = "BaseType";
            this.BaseType.HeaderText = "基数类型";
            this.BaseType.Name = "BaseType";
            this.BaseType.ReadOnly = true;
            // 
            // AppraisalBase
            // 
            this.AppraisalBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppraisalBase.DataPropertyName = "AppraisalBase";
            this.AppraisalBase.HeaderText = "基数";
            this.AppraisalBase.Name = "AppraisalBase";
            this.AppraisalBase.ReadOnly = true;
            // 
            // IsDel
            // 
            this.IsDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否停职";
            this.IsDel.Name = "IsDel";
            this.IsDel.ReadOnly = true;
            this.IsDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmsUserManager
            // 
            this.cmsUserManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewItem,
            this.tsmEdit,
            this.tsmStart,
            this.tsmStop});
            this.cmsUserManager.Name = "cmsClickMenu";
            this.cmsUserManager.Size = new System.Drawing.Size(101, 92);
            // 
            // tsmNewItem
            // 
            this.tsmNewItem.Name = "tsmNewItem";
            this.tsmNewItem.Size = new System.Drawing.Size(100, 22);
            this.tsmNewItem.Text = "新建";
            this.tsmNewItem.Click += new System.EventHandler(this.tsmNewItem_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(100, 22);
            this.tsmEdit.Text = "编辑";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(100, 22);
            this.tsmStart.Text = "启用";
            this.tsmStart.Click += new System.EventHandler(this.tsmStart_Click);
            // 
            // tsmStop
            // 
            this.tsmStop.Name = "tsmStop";
            this.tsmStop.Size = new System.Drawing.Size(100, 22);
            this.tsmStop.Text = "停用";
            this.tsmStop.Click += new System.EventHandler(this.tsmStop_Click);
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 581);
            this.Controls.Add(this.dgvUserAppraisalBase);
            this.Controls.Add(this.gbShaiXuan);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagerForm";
            this.Text = "UserManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserManagerForm_Load);
            this.gbShaiXuan.ResumeLayout(false);
            this.gbShaiXuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisalBase)).EndInit();
            this.cmsUserManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.WindowState = FormWindowState.Maximized;

        }

        #endregion

        private GroupBox gbShaiXuan;
        private DataGridView dgvUserAppraisalBase;
        private TextBox txtUserName;
        private Button btnSearch;
        private CheckBox chkNonJob;
        private ComboBox cbxShengFen;
        private Label lblShengFen;
        private Label lblUserName;
        private ContextMenuStrip cmsUserManager;
        private ToolStripMenuItem tsmNewItem;
        private ToolStripMenuItem tsmEdit;
        private ToolStripMenuItem tsmStart;
        private ToolStripMenuItem tsmStop;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn BaseType;
        private DataGridViewTextBoxColumn AppraisalBase;
        private DataGridViewCheckBoxColumn IsDel;
    }
}