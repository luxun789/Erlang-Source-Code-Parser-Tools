using System;
using System.Windows.Forms;
using ErlangParserLib.Elements;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;

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

        private void btnParser_Click(object sender, EventArgs e)
        {
            op.Load(lblFilepath.Text);
            op.Parser();

            ShowDom();
            ShowMatch();
        }

        private void ShowDom()
        {
            txtDomTree.Text = JsonConvert.SerializeObject(op.Efile, Formatting.Indented);
        }

        private void ShowMatch()
        {
            if (op.Efile == null) return;

            int i = 0;

            txtResult.Text = op.Context;
            txtResult.SelectionTabs = new int[] { 24 };
            this.Refresh();

            foreach (ErlangElement elem in op.Efile.Elements)
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

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtRegexStr.Text = FsmCheck.strLexParser;
        }
    }

}
