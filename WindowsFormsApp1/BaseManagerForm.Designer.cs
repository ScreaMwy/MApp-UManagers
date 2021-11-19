namespace WinForm
{
    partial class BaseManagerForm
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
            this.tmrBase = new System.Windows.Forms.Timer(this.components);
            this.lblBaseTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrBase
            // 
            this.tmrBase.Interval = 1000;
            this.tmrBase.Tick += new System.EventHandler(this.tmrBase_Tick);
            // 
            // lblBaseTimer
            // 
            this.lblBaseTimer.AutoSize = true;
            this.lblBaseTimer.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBaseTimer.Location = new System.Drawing.Point(102, 178);
            this.lblBaseTimer.Name = "lblBaseTimer";
            this.lblBaseTimer.Size = new System.Drawing.Size(242, 48);
            this.lblBaseTimer.TabIndex = 0;
            this.lblBaseTimer.Text = "服务器时间：";
            // 
            // BaseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBaseTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseManagerForm";
            this.Text = "BaseManagerForm";
            this.Load += new System.EventHandler(this.BaseManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrBase;
        private System.Windows.Forms.Label lblBaseTimer;
    }
}