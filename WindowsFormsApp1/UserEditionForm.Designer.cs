using System.Windows.Forms;

namespace WinForm
{
    partial class UserEditionForm
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
            this.gbxUserInfo = new GroupBox();
            this.chkbOn = new CheckBox();
            this.cbxGender = new ComboBox();
            this.lblGender = new Label();
            this.cbxSFEdition = new ComboBox();
            this.lblShengFen = new Label();
            this.txtUserName = new TextBox();
            this.lblUserName = new Label();
            this.gbxEdition = new GroupBox();
            this.btnClose = new Button();
            this.btnSave = new Button();
            this.btnErrMsg = new Button();
            this.gbxUserInfo.SuspendLayout();
            this.gbxEdition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxUserInfo.Controls.Add(this.chkbOn);
            this.gbxUserInfo.Controls.Add(this.cbxGender);
            this.gbxUserInfo.Controls.Add(this.lblGender);
            this.gbxUserInfo.Controls.Add(this.cbxSFEdition);
            this.gbxUserInfo.Controls.Add(this.lblShengFen);
            this.gbxUserInfo.Controls.Add(this.txtUserName);
            this.gbxUserInfo.Controls.Add(this.lblUserName);
            this.gbxUserInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbxUserInfo.Location = new System.Drawing.Point(13, 13);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Size = new System.Drawing.Size(665, 176);
            this.gbxUserInfo.TabIndex = 0;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "用户信息";
            // 
            // chkbOn
            // 
            this.chkbOn.AutoSize = true;
            this.chkbOn.Location = new System.Drawing.Point(298, 112);
            this.chkbOn.Name = "chkbOn";
            this.chkbOn.Size = new System.Drawing.Size(75, 21);
            this.chkbOn.TabIndex = 6;
            this.chkbOn.Text = "是否停用";
            this.chkbOn.UseVisualStyleBackColor = true;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxGender.Location = new System.Drawing.Point(87, 110);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(176, 25);
            this.cbxGender.TabIndex = 5;
            this.cbxGender.Text = "-- 请选择合适的性别 --";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(41, 113);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "性  别：";
            // 
            // cbxSFEdition
            // 
            this.cbxSFEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSFEdition.FormattingEnabled = true;
            this.cbxSFEdition.Location = new System.Drawing.Point(353, 42);
            this.cbxSFEdition.Name = "cbxSFEdition";
            this.cbxSFEdition.Size = new System.Drawing.Size(176, 25);
            this.cbxSFEdition.TabIndex = 3;
            this.cbxSFEdition.Text = "-- 请选择相应的身份 --";
            // 
            // lblShengFen
            // 
            this.lblShengFen.AutoSize = true;
            this.lblShengFen.Location = new System.Drawing.Point(295, 45);
            this.lblShengFen.Name = "lblShengFen";
            this.lblShengFen.Size = new System.Drawing.Size(52, 17);
            this.lblShengFen.TabIndex = 2;
            this.lblShengFen.Text = "身  份：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(87, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Enabled = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(38, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名：";
            // 
            // gbxEdition
            // 
            this.gbxEdition.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.gbxEdition.Controls.Add(this.btnErrMsg);
            this.gbxEdition.Controls.Add(this.btnClose);
            this.gbxEdition.Controls.Add(this.btnSave);
            this.gbxEdition.Location = new System.Drawing.Point(13, 195);
            this.gbxEdition.Name = "gbxEdition";
            this.gbxEdition.Size = new System.Drawing.Size(665, 65);
            this.gbxEdition.TabIndex = 1;
            this.gbxEdition.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(584, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(503, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnErrMsg
            // 
            this.btnErrMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErrMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnErrMsg.Location = new System.Drawing.Point(404, 20);
            this.btnErrMsg.Name = "btnErrMsg";
            this.btnErrMsg.Size = new System.Drawing.Size(93, 31);
            this.btnErrMsg.TabIndex = 2;
            this.btnErrMsg.Text = "查看错误日志";
            this.btnErrMsg.UseVisualStyleBackColor = true;
            // this.btnErrMsg.Click += new System.EventHandler(this.btnErrMsg_Click);
            // 
            // UserEditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 272);
            this.Controls.Add(this.gbxEdition);
            this.Controls.Add(this.gbxUserInfo);
            this.Name = "UserEditionForm";
            this.Text = "用户编辑";
            this.Load += new System.EventHandler(this.EditionUserForm_Load);
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxUserInfo.PerformLayout();
            this.gbxEdition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxUserInfo;
        private GroupBox gbxEdition;
        private Button btnSave;
        private CheckBox chkbOn;
        private ComboBox cbxGender;
        private Label lblGender;
        private ComboBox cbxSFEdition;
        private Label lblShengFen;
        private TextBox txtUserName;
        private Label lblUserName;
        private Button btnClose;
        private Button btnErrMsg;
    }
}