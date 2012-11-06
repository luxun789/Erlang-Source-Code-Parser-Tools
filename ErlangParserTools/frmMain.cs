using System;
using System.Drawing;
using System.Windows.Forms;
using ErlangParserLib.Fsm;
using Newtonsoft.Json;
using ErlangParserLib.Elements;
using System.Collections;
using System.Collections.Generic;

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
            Dictionary<string, Color> colors = new Dictionary<string, Color>{
                {"Var", Color.FromArgb(100, 100, 220)},
                {"String", Color.FromArgb(250, 250, 70)},
                {"Number", Color.FromArgb(175, 130, 255)},
                {"Atom", Color.FromArgb(250, 250, 250)},
                {"p", Color.FromArgb(220, 220, 220)},
                {"Blank", Color.FromArgb(0, 0, 0)},
                {"Other", Color.Red},
                {"Comment", Color.FromArgb(100, 250, 100)}
            };
            foreach (ErlangElement elem in o.Efile.Elements)
            {
                i = txtResult.Text.Length;
                txtResult.AppendText(elem.Context);
                txtResult.SelectionStart = i;
                txtResult.SelectionLength = elem.Context.Length;
                if (colors.ContainsKey(elem.GroupName))
                {
                    txtResult.SelectionColor = colors[elem.GroupName];
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
