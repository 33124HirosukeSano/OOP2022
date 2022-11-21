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
            tbDAT.Text = json[0].timeSeries[0].areas[0].weathers[2];
            tbHokkaidoRegion.Text = "宗谷";

        }
    }
}
