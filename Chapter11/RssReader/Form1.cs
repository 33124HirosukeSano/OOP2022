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

        IEnumerable<string> xTitle, xLink;

        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (String)x.Element("title"));
                                
                foreach (var data in xTitle) {

                    lbRssTitle.Items.Add(data);

                }

                xLink = xdoc.Root.Descendants("item").Select(x => (String)x.Element("link"));

            }
        }

        private void btback_Click(object sender, EventArgs e) {

            wvBrowser.GoBack();

        }

        private void btForward_Click(object sender, EventArgs e) {

            wvBrowser.GoForward();

        }

        private void Form1_Load(object sender, EventArgs e) {

            EnabledCheck();

        }

        private void EnabledCheck() {

            btBack.Enabled = wvBrowser.CanGoBack;
            btForward.Enabled = wvBrowser.CanGoForward;
        }        
        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {

            EnabledCheck();

        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            
            int index = lbRssTitle.SelectedIndex;

            if (index == -1) return;
            var url = xLink.ElementAt(index);
            //wbBrowser.Navigate(url);
            //wbBrowser.Url = new Uri(url);
            wvBrowser.Source = new Uri(url);
            

        }
        
    }
}
