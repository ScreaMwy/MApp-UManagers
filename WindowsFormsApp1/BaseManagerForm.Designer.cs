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
            this.dgvBaseData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBaseData)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrBase
            // 
            this.tmrBase.Interval = 1000;
            // 
            // dgvBaseData
            // 
            this.dgvBaseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaseData.Location = new System.Drawing.Point(0, 0);
            this.dgvBaseData.Name = "dgvBaseData";
            this.dgvBaseData.RowTemplate.Height = 23;
            this.dgvBaseData.Size = new System.Drawing.Size(800, 450);
            this.dgvBaseData.TabIndex = 0;
            // 
            // BaseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBaseData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseManagerForm";
            this.Text = "BaseManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvBaseData)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvBaseData;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion

        private System.Windows.Forms.Timer tmrBase;
    }
}