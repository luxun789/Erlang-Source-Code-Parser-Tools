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
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnParser = new System.Windows.Forms.Button();
            this.txtRegexStr = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.NumericUpDown();
            this.txtDomTree = new System.Windows.Forms.TextBox();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tpJsonTree = new System.Windows.Forms.TabPage();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.tpSource = new System.Windows.Forms.TabPage();
            this.txtSource = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).BeginInit();
            this.tcInfo.SuspendLayout();
            this.tpJsonTree.SuspendLayout();
            this.tpMatches.SuspendLayout();
            this.tpSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(396, 12);
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
            this.lblFilepath.Size = new System.Drawing.Size(378, 23);
            this.lblFilepath.TabIndex = 1;
            this.lblFilepath.Text = "test4.txt";
            this.lblFilepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(346, 140);
            this.txtResult.TabIndex = 2;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            // 
            // btnParser
            // 
            this.btnParser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParser.Location = new System.Drawing.Point(477, 12);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(75, 23);
            this.btnParser.TabIndex = 0;
            this.btnParser.Text = "解  析";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtRegexStr
            // 
            this.txtRegexStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexStr.Location = new System.Drawing.Point(12, 51);
            this.txtRegexStr.Name = "txtRegexStr";
            this.txtRegexStr.Size = new System.Drawing.Size(447, 21);
            this.txtRegexStr.TabIndex = 3;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.Location = new System.Drawing.Point(465, 51);
            this.txtCount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(87, 21);
            this.txtCount.TabIndex = 4;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCount.ThousandsSeparator = true;
            this.txtCount.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // txtDomTree
            // 
            this.txtDomTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDomTree.Location = new System.Drawing.Point(3, 3);
            this.txtDomTree.Multiline = true;
            this.txtDomTree.Name = "txtDomTree";
            this.txtDomTree.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDomTree.Size = new System.Drawing.Size(346, 140);
            this.txtDomTree.TabIndex = 5;
            // 
            // tcInfo
            // 
            this.tcInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcInfo.Controls.Add(this.tpJsonTree);
            this.tcInfo.Controls.Add(this.tpMatches);
            this.tcInfo.Controls.Add(this.tpSource);
            this.tcInfo.Location = new System.Drawing.Point(12, 78);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(540, 370);
            this.tcInfo.TabIndex = 6;
            // 
            // tpJsonTree
            // 
            this.tpJsonTree.Controls.Add(this.txtDomTree);
            this.tpJsonTree.Location = new System.Drawing.Point(4, 22);
            this.tpJsonTree.Name = "tpJsonTree";
            this.tpJsonTree.Padding = new System.Windows.Forms.Padding(3);
            this.tpJsonTree.Size = new System.Drawing.Size(352, 146);
            this.tpJsonTree.TabIndex = 0;
            this.tpJsonTree.Text = "分析树";
            this.tpJsonTree.UseVisualStyleBackColor = true;
            // 
            // tpMatches
            // 
            this.tpMatches.Controls.Add(this.txtResult);
            this.tpMatches.Location = new System.Drawing.Point(4, 22);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatches.Size = new System.Drawing.Size(352, 146);
            this.tpMatches.TabIndex = 1;
            this.tpMatches.Text = "着色匹配";
            this.tpMatches.UseVisualStyleBackColor = true;
            // 
            // tpSource
            // 
            this.tpSource.Controls.Add(this.txtSource);
            this.tpSource.Location = new System.Drawing.Point(4, 22);
            this.tpSource.Name = "tpSource";
            this.tpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tpSource.Size = new System.Drawing.Size(532, 344);
            this.tpSource.TabIndex = 2;
            this.tpSource.Text = "源文本";
            this.tpSource.UseVisualStyleBackColor = true;
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(3, 3);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(526, 338);
            this.txtSource.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 460);
            this.Controls.Add(this.tcInfo);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtRegexStr);
            this.Controls.Add(this.lblFilepath);
            this.Controls.Add(this.btnParser);
            this.Controls.Add(this.btnOpen);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erlang分析器";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).EndInit();
            this.tcInfo.ResumeLayout(false);
            this.tpJsonTree.ResumeLayout(false);
            this.tpJsonTree.PerformLayout();
            this.tpMatches.ResumeLayout(false);
            this.tpSource.ResumeLayout(false);
            this.tpSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFilepath;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnParser;
        private System.Windows.Forms.TextBox txtRegexStr;
        private System.Windows.Forms.NumericUpDown txtCount;
        private System.Windows.Forms.TextBox txtDomTree;
        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage tpJsonTree;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.TabPage tpSource;
        private System.Windows.Forms.TextBox txtSource;
    }
}

