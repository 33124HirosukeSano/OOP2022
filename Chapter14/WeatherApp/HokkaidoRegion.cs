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
    public partial class HokkaidoRegion : Form {
        string dStringWeather;

        public HokkaidoRegion() {
            InitializeComponent();
        }

        private void HokkaidoRegion_Load(object sender, EventArgs e) {

            String hokkaidoUrl = "https://japan-map.com/wp-content/uploads/hokkaido.png";
            WebClient hokkaidoClient = new WebClient();
            Stream hokkaidoStream = hokkaidoClient.OpenRead(hokkaidoUrl);

            Bitmap hokkaido = new Bitmap(hokkaidoStream);
            hokkaidoStream.Close();

            Image resizedImage = resizeImage(hokkaido, new Size(712, 585));

            pbHokkaido.Image = resizedImage;

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);
            tbHokkaidoToday.Text = json[0].timeSeries[0].areas[0].weathers[0];
            tbTomorrow.Text = json[0].timeSeries[0].areas[0].weathers[1];
            try {

                tbDAT.Text = json[0].timeSeries[0].areas[0].weathers[2];

            }
            catch (IndexOutOfRangeException) {

                tbDAT.Text = "時間をおいてから再度ご確認ください";

            }

            lbHokkaidoRegion.Text = "宗谷の天気予報";

            InitializePrefectureComboBox();

        }

        public static Image resizeImage(Image imgToResize, Size size) {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void btSoya_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            dStringWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
            var json = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);
            tbHokkaidoToday.Text = json[0].timeSeries[0].areas[0].weathers[0];
            tbTomorrow.Text = json[0].timeSeries[0].areas[0].weathers[1];
            try {

                tbDAT.Text = json[0].timeSeries[0].areas[0].weathers[2];

            }
            catch (IndexOutOfRangeException) {

                tbDAT.Text = "時間をおいてから再度ご確認ください";

            }
            
            lbHokkaidoRegion.Text = "宗谷の天気予報";

            InitializePrefectureComboBox();

        }

        private void InitializePrefectureComboBox() {

            var jsonCode = JsonConvert.DeserializeObject<Class1[]>(dStringWeather);
            switch (jsonCode[0].timeSeries[0].areas[0].weatherCodes[0]) {
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
                default:
                    break;
            }

        }

        private void btReturn_Click(object sender, EventArgs e) {

            this.Close();

        }
    }
}
