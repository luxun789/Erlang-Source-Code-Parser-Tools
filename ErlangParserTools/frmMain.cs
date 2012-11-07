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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtRegexStr.Text = FsmCheck.strLexParser;
            txtDomTree.Clear();
            this.Refresh();

            ErlangFsmParser o = ErlangFsmParser.Instance;
            o.Load(lblFilepath.Text);
            o.Parser();
            txtDomTree.AppendText(JsonConvert.SerializeObject(o.Efile, Formatting.Indented));

            btnParser.Enabled = false;

            int i = 0;
            int cnt = (int)txtCount.Value;
            txtSource.Text = o.Context;
            foreach (ErlangElement elem in o.Efile.Elements)
            {
                txtResult.SelectionStart = txtResult.TextLength;
                txtResult.AppendText(elem.Context);
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
            txtResult.SelectionTabs = new int[] { 24 };
            btnParser.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
