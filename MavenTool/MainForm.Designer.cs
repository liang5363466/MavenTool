namespace MavenTool
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJarsConfig = new System.Windows.Forms.TextBox();
            this.btnJarsConfig = new System.Windows.Forms.Button();
            this.lblJarsConfig = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.fbdRepository = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdJarConfig = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJarsConfig
            // 
            this.txtJarsConfig.Enabled = false;
            this.txtJarsConfig.Location = new System.Drawing.Point(134, 24);
            this.txtJarsConfig.Name = "txtJarsConfig";
            this.txtJarsConfig.Size = new System.Drawing.Size(339, 21);
            this.txtJarsConfig.TabIndex = 0;
            // 
            // btnJarsConfig
            // 
            this.btnJarsConfig.Location = new System.Drawing.Point(489, 23);
            this.btnJarsConfig.Name = "btnJarsConfig";
            this.btnJarsConfig.Size = new System.Drawing.Size(75, 23);
            this.btnJarsConfig.TabIndex = 1;
            this.btnJarsConfig.Text = "浏览";
            this.btnJarsConfig.UseVisualStyleBackColor = true;
            this.btnJarsConfig.Click += new System.EventHandler(this.btnJarsConfig_Click);
            // 
            // lblJarsConfig
            // 
            this.lblJarsConfig.AutoSize = true;
            this.lblJarsConfig.Location = new System.Drawing.Point(22, 27);
            this.lblJarsConfig.Name = "lblJarsConfig";
            this.lblJarsConfig.Size = new System.Drawing.Size(95, 12);
            this.lblJarsConfig.TabIndex = 2;
            this.lblJarsConfig.Text = "JAR包配置文件：";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(24, 64);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(540, 303);
            this.txtConsole.TabIndex = 3;
            // 
            // ofdJarConfig
            // 
            this.ofdJarConfig.FileName = "openFileDialog1";
            this.ofdJarConfig.Filter = "xml文件(*.xml)|*.xml";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(489, 381);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(398, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 426);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblJarsConfig);
            this.Controls.Add(this.btnJarsConfig);
            this.Controls.Add(this.txtJarsConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maven 辅助工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJarsConfig;
        private System.Windows.Forms.Button btnJarsConfig;
        private System.Windows.Forms.Label lblJarsConfig;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.FolderBrowserDialog fbdRepository;
        private System.Windows.Forms.OpenFileDialog ofdJarConfig;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
    }
}

