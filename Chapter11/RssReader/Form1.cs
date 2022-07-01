using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RssReader {
    public partial class Form1 : Form {

        IEnumerable<string> xTitle;

        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (String)x.Element("title"));
                var lNew = xdoc.Root.Descendants("item").Select(x => (String)x.Element("link"));
                List<string> linklist = new List<string>();

                foreach (var data in lNew) {

                    linklist.Add(data);

                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {            
            
            int index = lbRssTitle.SelectedIndex;

        }
    }
}
