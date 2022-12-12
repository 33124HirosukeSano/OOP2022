using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class KantoRegion : Form {
        string dStringWeather;

        public KantoRegion() {
            InitializeComponent();
        }

        private void KantoRegion_Load(object sender, EventArgs e) {

            DateTime dtToday = DateTime.Today;
            DateTime dtTomorrow = dtToday.AddDays(1);
            DateTime dtITD = dtToday.AddDays(2);
            DateTime dtIFoD = dtToday.AddDays(3);
            DateTime dtIFiD = dtToday.AddDays(4);
            DateTime dtISiD = dtToday.AddDays(5);
            DateTime dtISeD = dtToday.AddDays(6);

            string resultToday = dtToday.ToString("MM/dd");
            lbToday.Text = resultToday;

            string resultTomorrow = dtTomorrow.ToString("MM/dd");
            lbTomorrow.Text = resultTomorrow;
            string resultITD = dtITD.ToString("MM/dd");
            lbITD.Text = resultITD;
            string resultIFoD = dtIFoD.ToString("MM/dd");
            lbIFoD.Text = resultIFoD;
            string resultIFiD = dtIFiD.ToString("MM/dd");
            lbIFiD.Text = resultIFiD;
            string resultISiD = dtISiD.ToString("MM/dd");
            lbISiD.Text = resultISiD;
            string resultISeD = dtISeD.ToString("MM/dd");
            lbISeD.Text = resultISeD;

            pbKanto.ImageLocation = "https://japan-map.com/wp-content/uploads/kanto.png";


            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "東京都の天気予報";

            WeatherAndTemperture();

        }

        public static Image resizeImage(Image imgToResize, Size size) {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void WeatherAndTemperture() {

            var jsonCode = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);
            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[0]) {
                case "100":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[1]) {
                case "100":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[2]) {
                case "100":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbITD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[3]) {
                case "100":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbIFoD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[4]) {
                case "100":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbIFiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[5]) {
                case "100":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbISiD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[6]) {
                case "100":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbISeD.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            switch (jsonCode[1].timeSeries[0].areas[0].weatherCodes[0]) {
                case "100":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "101":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "102":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "103":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "104":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "105":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "106":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "107":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "108":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "110":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "111":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/110.png";
                    break;
                case "112":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "113":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "114":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "115":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "116":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "117":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "118":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "119":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "120":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "121":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "122":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "123":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "124":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "125":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "126":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "127":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "128":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/112.png";
                    break;
                case "130":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "131":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/100.png";
                    break;
                case "132":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";
                    break;
                case "140":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/102.png";
                    break;
                case "160":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "170":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/104.png";
                    break;
                case "181":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/115.png";
                    break;
                case "200":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "201":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "202":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "203":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "204":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "205":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "206":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "207":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "208":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "209":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "210":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "211":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/210.png";
                    break;
                case "212":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "213":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "214":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "215":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "216":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "217":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "218":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "219":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "220":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "221":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "222":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "223":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/201.png";
                    break;
                case "224":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "225":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "226":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/212.png";
                    break;
                case "228":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "229":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "230":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "231":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/200.png";
                    break;
                case "240":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/202.png";
                    break;
                case "250":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "260":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "270":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/204.png";
                    break;
                case "281":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/215.png";
                    break;
                case "300":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "301":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/301.png";
                    break;
                case "302":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/302.png";
                    break;
                case "303":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "304":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "306":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "308":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/308.png";
                    break;
                case "309":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "311":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "313":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "314":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "315":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "316":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "317":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "320":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "321":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/313.png";
                    break;
                case "322":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/303.png";
                    break;
                case "323":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/323.png";
                    break;
                case "324":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "325":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/311.png";
                    break;
                case "326":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "327":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/314.png";
                    break;
                case "328":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "329":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "340":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "350":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/300.png";
                    break;
                case "361":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "371":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "400":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "401":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/401.png";
                    break;
                case "402":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/402.png";
                    break;
                case "403":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "405":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "406":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "407":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/406.png";
                    break;
                case "409":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/403.png";
                    break;
                case "411":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "413":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "414":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "420":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/411.png";
                    break;
                case "421":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/413.png";
                    break;
                case "422":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "423":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/414.png";
                    break;
                case "425":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "426":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "427":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                case "450":
                    pbTodayBig.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/400.png";
                    break;
                default:
                    break;
            }

            if (jsonCode[0].timeSeries[2].areas[0].temps[0] == " ") {
                lbTodayT.Text = " ";
                lbTodayTBig.Text = "更新中";
            } else {

                lbTodayT.Text = jsonCode[0].timeSeries[2].areas[0].temps[0] + "℃";
                lbTodayTBig.Text = jsonCode[0].timeSeries[2].areas[0].temps[0] + "℃";

            }

            lbTomorrowT.Text = jsonCode[1].timeSeries[1].areas[0].tempsMax[1] + "℃";
            lbITDT.Text = jsonCode[1].timeSeries[1].areas[0].tempsMax[2] + "℃";
            lbIFoDT.Text = jsonCode[1].timeSeries[1].areas[0].tempsMax[3] + "℃";
            lbIFiDT.Text = jsonCode[1].timeSeries[1].areas[0].tempsMax[4] + "℃";
            lbISiDT.Text = jsonCode[1].timeSeries[1].areas[0].tempsMax[5] + "℃";
            lbISeDT.Text = jsonCode[1].timeSeries[1].areas[0].tempsMax[6] + "℃";


        }

        private void btReturn_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void btIbaraki_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "福島県の天気予報";

            WeatherAndTemperture();
        }

        private void btTotigi_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "栃木県の天気予報";

            WeatherAndTemperture();
        }

        private void btGunma_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "群馬県の天気予報";

            WeatherAndTemperture();
        }

        private void btSaitama_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "埼玉県の天気予報";

            WeatherAndTemperture();
        }

        private void btChiba_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "千葉県の天気予報";

            WeatherAndTemperture();
        }

        private void btTokyo_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "東京都の天気予報";

            WeatherAndTemperture();
        }

        private void btKanagawa_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);

            lbKantoRegion.Text = "神奈川県の天気予報";

            WeatherAndTemperture();
        }
    }
}
