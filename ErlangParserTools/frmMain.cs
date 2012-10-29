using System;
using System.Windows.Forms;
using ErlangParserLib.Fsm;

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
            //ErlangFile efile = ErlangRegexParser.Parser(lblFilepath.Text);
            //txtResult.Text = JsonConvert.SerializeObject(efile, Formatting.Indented);

            txtRegexStr.Text = FsmCheck.strWorkParser;
            ErlangFsmParser o = ErlangFsmParser.Instance;
            o.Load(lblFilepath.Text);
            o.Parser();
            txtResult.Text = string.Join("\r\nmatch=", o.words);
        }
    }
}
