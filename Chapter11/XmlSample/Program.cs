using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace XmlSample {
    class Program {
        static void Main(string[] args) {

            using (var wc = new WebClient()) {

                var stream = new WebClient().OpenRead("https://news.yahoo.co.jp/rss/media/tspkeiba/all.xml");

                var xdoc = XDocument.Load(stream);
                var xNew = xdoc.Root.Descendants("item").Select(x => x.Element("title"));

                foreach (var data in xNew) {

                    Console.WriteLine(data);

                }
            }                        
        }
    }
}
