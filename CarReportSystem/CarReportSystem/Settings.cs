﻿using System;
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
        
        public int MainFormColor { get; set; } 

    }
}
