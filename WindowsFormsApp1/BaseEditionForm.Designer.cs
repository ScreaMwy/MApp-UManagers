namespace WinForm
{
    partial class BaseEditionForm
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
            this.gbxBaseEdition = new System.Windows.Forms.GroupBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.gbxBaseEdition.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBaseEdition
            // 
            this.gbxBaseEdition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBaseEdition.Controls.Add(this.txtBase);
            this.gbxBaseEdition.Controls.Add(this.lblBase);
            this.gbxBaseEdition.Location = new System.Drawing.Point(13, 13);
            this.gbxBaseEdition.Name = "gbxBaseEdition";
            this.gbxBaseEdition.Size = new System.Drawing.Size(309, 89);
            this.gbxBaseEdition.TabIndex = 0;
            this.gbxBaseEdition.TabStop = false;
            this.gbxBaseEdition.Text = "基数修改";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBase.Location = new System.Drawing.Point(61, 38);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(39, 20);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "基数";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(250, 108);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(72, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(169, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBase.Location = new System.Drawing.Point(106, 38);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(125, 23);
            this.txtBase.TabIndex = 1;
            // 
            // BaseEditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbxBaseEdition);
            this.Name = "BaseEditionForm";
            this.Text = "基数修改页面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxBaseEdition.ResumeLayout(false);
            this.gbxBaseEdition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBaseEdition;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
    }
}