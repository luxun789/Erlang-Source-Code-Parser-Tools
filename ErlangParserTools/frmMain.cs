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
            lblResult.Text = string.Empty;
            txtRegexStr.Text = FsmCheck.strWorkParser;
            this.Refresh();

            ErlangFsmParser o = ErlangFsmParser.Instance;
            o.Load(lblFilepath.Text);
            o.Parser();

            wl("Count:" + o.words.Length + "\r\n");
            wl(string.Join("|", o.words));
            //foreach(string s in o.words)
            //{
            //    wl("match=【" + s + "】\r\n");
            //}
        }

        private void wl(string str)
        {
            lblResult.Text += (str + "\r\n");
        }
    }
}
