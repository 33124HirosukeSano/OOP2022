using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine("--------------");
            Exercise1_2(file);
            Console.WriteLine("--------------");
            Exercise1_3(file);
            Console.WriteLine("--------------");

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load(file);
            var sprots = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    TeamMenbers = (string)x.Element("teammembers"),
                                });

            foreach (var sport in sprots) {

                Console.WriteLine("{0} {1}人", sport.Name, sport.TeamMenbers);
            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load(file);
            var sprots = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name").Attribute("kanji"),
                                    FirstPlayed = (string)x.Element("firstplayed"),
                                }).OrderBy(x => (string)(x.FirstPlayed));

            foreach (var sport in sprots) {

                Console.WriteLine("{0} ({1})", sport.Name, sport.FirstPlayed);
            }
        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load(file);
            var sprots = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    TeamMenbers = (string)x.Element("teammembers"),
                                }).OrderByDescending(x => (string)(x.TeamMenbers)).FirstOrDefault();
           
            Console.WriteLine(sprots.Name);            

        }

        private static void Exercise1_4(string file, string newfile) {

            var xdoc = XDocument.Load(file);

            var element = new XElement("ballsport",
                            new XElement("name", "サッカー",new XAttribute("kanji","蹴球")),
                            new XElement("teammembers","11"),
                            new XElement("firstplayed","1863"));            
            
            xdoc.Root.Add(element);
            xdoc.Save(newfile);

            var sprots = xdoc.Root.Elements()
                               .Select(x => new {
                                   Name = (string)x.Element("name"),
                                   TeamMenbers = (string)x.Element("teammembers"),
                                   FirstPlayed = (string)x.Element("firstplayed"),
                               });

            foreach (var sport in sprots) {

                Console.WriteLine("{0} {1} {2}", sport.Name, sport.TeamMenbers, sport.FirstPlayed);

            }            
        }
    }
}
