using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ErlangParserLib.Elements;
using ErlangParserLib.Fsm;

namespace ErlangParserTools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        ErlangFsmParser op = ErlangFsmParser.Instance;

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lblFilepath.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// 语法解析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParser_Click(object sender, EventArgs e)
        {
            op.Load(lblFilepath.Text);
            op.Parser();

            tvwDom.Nodes.Clear();
            TreeNode root = tvwDom.Nodes.Add("[Type: LineNumber, Index]:Context");

            foreach (ErlangElement elem in op.Efile.Elements)
            {
                ShowDom(elem, root);
            }
            tvwDom.ExpandAll();
            ShowMatch();
        }

        /// <summary>
        /// 语法树
        /// </summary>
        private void ShowDom(ErlangElement root, TreeNode rnode)
        {
            TreeNode c = rnode.Nodes.Add("[" + root.GroupName + ":" + root.Line + ", " + root.Index + "]:" + root.Context);
            c.Tag = root;
            if (FsmCheck.RegexGroups.ContainsKey(root.GroupName))
            {
                if ("Blank".IndexOf(root.GroupName) <= 0)
                {
                    c.ForeColor = FsmCheck.RegexGroups[root.GroupName];
                }
            }
            if (root.Elements != null)
            {
                foreach (ErlangElement ch in root.Elements)
                {
                    ShowDom(ch, c);
                }
            }
        }

        /// <summary>
        /// 语法匹配
        /// </summary>
        private void ShowMatch()
        {
            if (op.Efile == null) return;

            txtResult.HideSelection = true;

            txtResult.Text = op.Context;
            txtResult.SelectionTabs = new int[] { 24 };
            this.Refresh();

            IErlangElement elem = op.Efile;
            while (elem != null)
            {
                if (elem.GroupName.Length > 0)
                {
                    txtResult.SelectionStart = elem.Index;
                    txtResult.SelectionLength = elem.Context.Length;
                    if (FsmCheck.RegexGroups.ContainsKey(elem.GroupName))
                    {
                        txtResult.SelectionColor = FsmCheck.RegexGroups[elem.GroupName];
                    }
                    else
                    {
                        txtResult.SelectionColor = txtResult.ForeColor;
                    }
                }
                elem = elem.Next;
            }

            txtResult.HideSelection = false;

        }

        private void btnViewRegex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FsmCheck.strLexParser.Replace("(?", "\r\n(?"));
        }

        private void tvwDom_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode ndcur = e.Node;
            IErlangElement elem = e.Node.Tag as IErlangElement;
            if (elem == null)
            {
                return;
            }

            txtResult.SelectionStart = elem.Index - 200 > 0 ? elem.Index - 200 : 0;
            txtResult.ScrollToCaret();

            txtResult.SelectionStart = elem.Index;
            txtResult.SelectionLength = elem.Context.Length;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }

}
