using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace CarReportSystem {

    
    //設定情報
    [Serializable]
    public class Settings {

        private static Settings singleton;
        private Settings() {

        }

        public static Settings getInstance() {

            if (singleton == null) {

                singleton = new Settings();

            }
            return singleton;

        }

        public int MainFormColor { get; set; } 

    }
}
