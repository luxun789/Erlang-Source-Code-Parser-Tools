namespace ErlangParserTools
{
    partial class frmMain
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFilepath = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnParser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(566, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开文件";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFilepath
            // 
            this.lblFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilepath.Location = new System.Drawing.Point(12, 12);
            this.lblFilepath.Name = "lblFilepath";
            this.lblFilepath.Size = new System.Drawing.Size(548, 23);
            this.lblFilepath.TabIndex = 1;
            this.lblFilepath.Text = "D:\\workspace\\server\\src\\pp\\pp_fst.erl";
            this.lblFilepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 49);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(710, 451);
            this.txtResult.TabIndex = 2;
            // 
            // btnParser
            // 
            this.btnParser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParser.Location = new System.Drawing.Point(647, 12);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(75, 23);
            this.btnParser.TabIndex = 0;
            this.btnParser.Text = "解  析";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblFilepath);
            this.Controls.Add(this.btnParser);
            this.Controls.Add(this.btnOpen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erlang分析器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFilepath;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnParser;
    }
}

