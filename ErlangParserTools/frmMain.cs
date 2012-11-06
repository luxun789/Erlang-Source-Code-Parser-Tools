using System;
using System.Drawing;
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
            txtResult.Text = string.Empty;
            txtRegexStr.Text = FsmCheck.strLexParser;
            this.Refresh();

            ErlangFsmParser o = ErlangFsmParser.Instance;
            o.Load(lblFilepath.Text);
            o.Parser();

            wl("Count:" + o.words.Count + "\r\n");
            //wl(string.Join("|", o.words));

            btnParser.Enabled = false;
            int i = 0;
            int cnt = (int)txtCount.Value;
            foreach (string s in o.words)
            {
                if(i++ > cnt) break;
                wi(s);
            }
            btnParser.Enabled = true;
        }

        private bool isColor = false;
        private void wi(string str)
        {
            if (str.Length <= 0) return;

            int s = txtResult.TextLength;
            txtResult.AppendText(str);

            txtResult.SelectionStart = s;
            txtResult.SelectionLength = str.Length;
            if (isColor)
            {
                txtResult.SelectionColor = Color.LightGoldenrodYellow;
                txtResult.SelectionBackColor = Color.Green;
            }
            else
            {
                txtResult.SelectionColor = Color.Blue;
                txtResult.SelectionBackColor = Color.BlanchedAlmond;
            }
            isColor = !isColor;
        }

        private void wl(string str)
        {
            txtResult.AppendText(str + "\r\n");
        }
    }
}
