using System;
using System.Collections.Generic;
using System.Drawing;
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
            txtResult.Text = string.Empty;
            txtRegexStr.Text = FsmCheck.strLexParser;
            
            txtDomTree.Clear();
            this.Refresh();

            ErlangFsmParser o = ErlangFsmParser.Instance;
            o.Load(lblFilepath.Text);
            o.Parser();
            txtDomTree.AppendText(JsonConvert.SerializeObject(o.Efile, Formatting.Indented));

            wl("Count:" + o.Efile.Elements.Count + "\r\n");
            //wl(string.Join("|", o.words));

            btnParser.Enabled = false;
            int i = 0;
            int cnt = (int)txtCount.Value;
            txtResult.Text = o.Context;
            txtResult.SelectionTabs = new int[] { 24 };
            foreach (ErlangElement elem in o.Efile.Elements)
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
            btnParser.Enabled = true;
        }

        private void wl(string str)
        {
            txtResult.AppendText(str + "\r\n");
        }
    }
}
