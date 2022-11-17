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

    }
}
