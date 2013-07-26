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
            this.tvwDom = new System.Windows.Forms.TreeView();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslPostion = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnViewRegex = new System.Windows.Forms.Button();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(442, 10);
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
            this.lblFilepath.Size = new System.Drawing.Size(424, 21);
            this.lblFilepath.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.AcceptsTab = true;
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtResult.HideSelection = false;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.ShowSelectionMargin = true;
            this.txtResult.Size = new System.Drawing.Size(417, 466);
            this.txtResult.TabIndex = 2;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            // 
            // btnParser
            // 
            this.btnParser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParser.Location = new System.Drawing.Point(523, 9);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(75, 23);
            this.btnParser.TabIndex = 0;
            this.btnParser.Text = "解  析";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnParser_Click);
            // 
            // tvwDom
            // 
            this.tvwDom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.tvwDom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tvwDom.LineColor = System.Drawing.Color.WhiteSmoke;
            this.tvwDom.Location = new System.Drawing.Point(0, 0);
            this.tvwDom.Name = "tvwDom";
            this.tvwDom.Size = new System.Drawing.Size(243, 466);
            this.tvwDom.TabIndex = 0;
            this.tvwDom.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDom_NodeMouseClick);
            // 
            // StatusBar
            // 
            this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslPostion});
            this.StatusBar.Location = new System.Drawing.Point(0, 513);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(118, 22);
            this.StatusBar.TabIndex = 7;
            this.StatusBar.Text = "statusStrip1";
            // 
            // tsslPostion
            // 
            this.tsslPostion.Name = "tsslPostion";
            this.tsslPostion.Size = new System.Drawing.Size(101, 17);
            this.tsslPostion.Text = "Line:0, Column:0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvwDom);
            this.splitContainer1.Size = new System.Drawing.Size(664, 466);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnViewRegex
            // 
            this.btnViewRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRegex.Location = new System.Drawing.Point(604, 9);
            this.btnViewRegex.Name = "btnViewRegex";
            this.btnViewRegex.Size = new System.Drawing.Size(75, 23);
            this.btnViewRegex.TabIndex = 0;
            this.btnViewRegex.Text = "查看正则";
            this.btnViewRegex.UseVisualStyleBackColor = true;
            this.btnViewRegex.Click += new System.EventHandler(this.btnViewRegex_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 535);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.lblFilepath);
            this.Controls.Add(this.btnViewRegex);
            this.Controls.Add(this.btnParser);
            this.Controls.Add(this.btnOpen);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erlang语法树DOM分析器";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox lblFilepath;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnParser;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslPostion;
        private System.Windows.Forms.TreeView tvwDom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnViewRegex;
    }
}

