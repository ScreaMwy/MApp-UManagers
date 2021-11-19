namespace WinForm
{
    partial class MainLogForm
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
            this.tmrMainLog = new System.Windows.Forms.Timer(this.components);
            this.lblMainMsg = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainMsg
            // 
            this.lblMainMsg.AutoSize = true;
            this.lblMainMsg.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMainMsg.ForeColor = System.Drawing.Color.Salmon;
            this.lblMainMsg.Location = new System.Drawing.Point(207, 145);
            this.lblMainMsg.Name = "lblMainMsg";
            this.lblMainMsg.Size = new System.Drawing.Size(411, 62);
            this.lblMainMsg.TabIndex = 0;
            this.lblMainMsg.Text = "欢迎使用管理系统";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.ForeColor = System.Drawing.Color.Salmon;
            this.lblTimer.Location = new System.Drawing.Point(12, 408);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(230, 46);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "服务器时间：";
            // 
            // MainLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(858, 463);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMainMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLogForm";
            this.Text = "MainLogForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMainLog;
        private System.Windows.Forms.Label lblMainMsg;
        private System.Windows.Forms.Label lblTimer;
    }
}