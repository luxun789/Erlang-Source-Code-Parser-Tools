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
            this.lblFilepath = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnParser = new System.Windows.Forms.Button();
            this.txtRegexStr = new System.Windows.Forms.TextBox();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslPostion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpJsonTree = new System.Windows.Forms.TabPage();
            this.tvwDom = new System.Windows.Forms.TreeView();
            this.tpRegex = new System.Windows.Forms.TabPage();
            this.tcInfo.SuspendLayout();
            this.tpMatches.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.tpJsonTree.SuspendLayout();
            this.tpRegex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(520, 12);
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
            this.lblFilepath.ReadOnly = true;
            this.lblFilepath.Size = new System.Drawing.Size(502, 21);
            this.lblFilepath.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.AcceptsTab = true;
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txtResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.ShowSelectionMargin = true;
            this.txtResult.Size = new System.Drawing.Size(650, 437);
            this.txtResult.TabIndex = 2;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            // 
            // btnParser
            // 
            this.btnParser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParser.Location = new System.Drawing.Point(601, 12);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(75, 23);
            this.btnParser.TabIndex = 0;
            this.btnParser.Text = "解  析";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnParser_Click);
            // 
            // txtRegexStr
            // 
            this.txtRegexStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegexStr.Location = new System.Drawing.Point(3, 3);
            this.txtRegexStr.Multiline = true;
            this.txtRegexStr.Name = "txtRegexStr";
            this.txtRegexStr.ReadOnly = true;
            this.txtRegexStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegexStr.Size = new System.Drawing.Size(650, 437);
            this.txtRegexStr.TabIndex = 3;
            // 
            // tcInfo
            // 
            this.tcInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcInfo.Controls.Add(this.tpRegex);
            this.tcInfo.Controls.Add(this.tpJsonTree);
            this.tcInfo.Controls.Add(this.tpMatches);
            this.tcInfo.Location = new System.Drawing.Point(12, 41);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(664, 469);
            this.tcInfo.TabIndex = 6;
            // 
            // tpMatches
            // 
            this.tpMatches.Controls.Add(this.txtResult);
            this.tpMatches.Location = new System.Drawing.Point(4, 22);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatches.Size = new System.Drawing.Size(656, 443);
            this.tpMatches.TabIndex = 1;
            this.tpMatches.Text = "着色匹配";
            this.tpMatches.UseVisualStyleBackColor = true;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslPostion});
            this.StatusBar.Location = new System.Drawing.Point(0, 513);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(688, 22);
            this.StatusBar.TabIndex = 7;
            this.StatusBar.Text = "statusStrip1";
            // 
            // tsslPostion
            // 
            this.tsslPostion.Name = "tsslPostion";
            this.tsslPostion.Size = new System.Drawing.Size(102, 17);
            this.tsslPostion.Text = "Line:0, Column:0";
            // 
            // tpJsonTree
            // 
            this.tpJsonTree.Controls.Add(this.tvwDom);
            this.tpJsonTree.Location = new System.Drawing.Point(4, 22);
            this.tpJsonTree.Name = "tpJsonTree";
            this.tpJsonTree.Padding = new System.Windows.Forms.Padding(3);
            this.tpJsonTree.Size = new System.Drawing.Size(656, 443);
            this.tpJsonTree.TabIndex = 0;
            this.tpJsonTree.Text = "分析树";
            this.tpJsonTree.UseVisualStyleBackColor = true;
            // 
            // tvwDom
            // 
            this.tvwDom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDom.Location = new System.Drawing.Point(3, 3);
            this.tvwDom.Name = "tvwDom";
            this.tvwDom.Size = new System.Drawing.Size(650, 437);
            this.tvwDom.TabIndex = 0;
            // 
            // tpRegex
            // 
            this.tpRegex.Controls.Add(this.txtRegexStr);
            this.tpRegex.Location = new System.Drawing.Point(4, 22);
            this.tpRegex.Name = "tpRegex";
            this.tpRegex.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegex.Size = new System.Drawing.Size(656, 443);
            this.tpRegex.TabIndex = 2;
            this.tpRegex.Text = "正则式";
            this.tpRegex.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 535);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.tcInfo);
            this.Controls.Add(this.lblFilepath);
            this.Controls.Add(this.btnParser);
            this.Controls.Add(this.btnOpen);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erlang分析器";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcInfo.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.tpJsonTree.ResumeLayout(false);
            this.tpRegex.ResumeLayout(false);
            this.tpRegex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox lblFilepath;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnParser;
        private System.Windows.Forms.TextBox txtRegexStr;
        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslPostion;
        private System.Windows.Forms.TabPage tpJsonTree;
        private System.Windows.Forms.TreeView tvwDom;
        private System.Windows.Forms.TabPage tpRegex;
    }
}

