using MultiHyperLink.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MultiHyperLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> textToLink = new Dictionary<string, string>()
            {
                { "テスト", @"C:\Users\shutnull\Pictures\ホロライブ" },
                { "テストおおおおおおおおおおおおお", @"C:\Users\shutnull\Pictures" },
                { "llllllllllllllllllllllllllllllllllllllllllllllllllllll", @"C:\Users\shutnull" },
                { "A", @"C:\Users" },
            };

            HyperLinkMultiLabel hyperLinkMultiLabel = new HyperLinkMultiLabel(textToLink);

            ElementHost elementHost = new ElementHost();
            elementHost.Child = hyperLinkMultiLabel;
            this.Controls.Add(elementHost);
        }
    }
}
