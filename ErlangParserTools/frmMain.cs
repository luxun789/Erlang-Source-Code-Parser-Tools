using System;
using System.Windows.Forms;
using ErlangParserLib;
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
            ErlangFile efile = ErlangParser.ParserFile(lblFilepath.Text);
            txtResult.Text = JsonConvert.SerializeObject(efile, Formatting.Indented);
        }
    }
}
