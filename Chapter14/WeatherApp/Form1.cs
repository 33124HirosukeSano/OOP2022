﻿using Newtonsoft.Json;
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
    public partial class mainForm : Form {
        string dString;
        string dStringToday;
        private DataTable dataTable;


        public mainForm() {
            InitializeComponent();
        }

        private void cbPrefecture_Changed(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            try {
                switch (cbPrefecture.Text) {
                    case "宗谷":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                        break;
                    case "上川・留萌":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                        break;
                    case "網走・北見・紋別":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                        break;
                    case "釧路・根室":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                        break;
                    case "胆振・日高":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                        break;
                    case "石狩・空知・後志":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                        break;
                    case "渡島・檜山":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                        break;
                    case "青森県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                        break;
                    case "岩手県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                        break;
                    case "宮城県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                        break;
                    case "秋田県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                        break;
                    case "山形県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                        break;
                    case "福島県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                        break;
                    case "茨城県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                        break;
                    case "栃木県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                        break;
                    case "群馬県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                        break;
                    case "埼玉県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                        break;
                    case "千葉県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                        break;
                    case "東京都":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                        break;
                    case "神奈川県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                        break;
                    case "新潟県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                        break;
                    case "富山県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                        break;
                    case "石川県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                        break;
                    case "福井県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                        break;
                    case "山梨県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                        break;
                    case "長野県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                        break;
                    case "岐阜県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                        break;
                    case "静岡県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                        break;
                    case "愛知県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                        break;
                    case "三重県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                        break;
                    case "滋賀県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                        break;
                    case "京都府":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                        break;
                    case "大阪府":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                        break;
                    case "兵庫県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                        break;
                    case "奈良県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                        break;
                    case "和歌山県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                        break;
                    case "鳥取県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                        break;
                    case "島根県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                        break;
                    case "岡山県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                        break;
                    case "広島県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                        break;
                    case "山口県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                        break;
                    case "徳島県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
                        break;
                    case "香川県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                        break;
                    case "愛媛県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                        break;
                    case "高知県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                        break;
                    case "福岡県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                        break;
                    case "佐賀県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                        break;
                    case "長崎県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                        break;
                    case "熊本県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                        break;
                    case "大分県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                        break;
                    case "宮崎県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                        break;
                    case "鹿児島県":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
                        break;
                    case "沖縄本島":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                        break;
                    case "大東島":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                        break;
                    case "宮古島":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                        break;
                    case "八重山列島":
                        dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                        dStringToday = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                        break;
                    default:
                        break;


                }

                var dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");

                var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                var json2 = JsonConvert.DeserializeObject<Class1[]>(dStringToday);
                tbToday.Text = json2[0].timeSeries[0].areas[0].weathers[0];
                tbWeatherInfoThreedays.Text = json.text;
            }
            catch (WebException) {

             
            }
            

        }

        private void Form1_Load(object sender, EventArgs e) {

            cbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrefecture.DropDownStyle = ComboBoxStyle.DropDownList;

            dataTable = new DataTable("Region");

            dataTable.Columns.Add("region", typeof(string));
            dataTable.Columns.Add("prefecture", typeof(string));

            dataTable.Rows.Add("北海道", "宗谷");
            dataTable.Rows.Add("北海道", "上川・留萌");
            dataTable.Rows.Add("北海道", "網走・北見・紋別");
            dataTable.Rows.Add("北海道", "釧路・根室");
            dataTable.Rows.Add("北海道", "胆振・日高");
            dataTable.Rows.Add("北海道", "石狩・空知・後志");
            dataTable.Rows.Add("北海道", "渡島・檜山");
            dataTable.Rows.Add("東北地方", "青森県");
            dataTable.Rows.Add("東北地方", "岩手県");
            dataTable.Rows.Add("東北地方", "宮城県");
            dataTable.Rows.Add("東北地方", "秋田県");
            dataTable.Rows.Add("東北地方", "山形県");
            dataTable.Rows.Add("東北地方", "福島県");
            dataTable.Rows.Add("関東地方", "茨城県");
            dataTable.Rows.Add("関東地方", "栃木県");
            dataTable.Rows.Add("関東地方", "群馬県");
            dataTable.Rows.Add("関東地方", "埼玉県");
            dataTable.Rows.Add("関東地方", "千葉県");
            dataTable.Rows.Add("関東地方", "東京都");
            dataTable.Rows.Add("関東地方", "神奈川県");
            dataTable.Rows.Add("中部地方", "新潟県");
            dataTable.Rows.Add("中部地方", "富山県");
            dataTable.Rows.Add("中部地方", "石川県");
            dataTable.Rows.Add("中部地方", "福井県");
            dataTable.Rows.Add("中部地方", "山梨県");
            dataTable.Rows.Add("中部地方", "長野県");
            dataTable.Rows.Add("中部地方", "岐阜県");
            dataTable.Rows.Add("中部地方", "静岡県");
            dataTable.Rows.Add("中部地方", "愛知県");
            dataTable.Rows.Add("近畿地方", "三重県");
            dataTable.Rows.Add("近畿地方", "滋賀県");
            dataTable.Rows.Add("近畿地方", "京都府");
            dataTable.Rows.Add("近畿地方", "大阪府");
            dataTable.Rows.Add("近畿地方", "兵庫県");
            dataTable.Rows.Add("近畿地方", "奈良県");
            dataTable.Rows.Add("近畿地方", "和歌山県");
            dataTable.Rows.Add("中国地方", "鳥取県");
            dataTable.Rows.Add("中国地方", "島根県");
            dataTable.Rows.Add("中国地方", "岡山県");
            dataTable.Rows.Add("中国地方", "広島県");
            dataTable.Rows.Add("中国地方", "山口県");
            dataTable.Rows.Add("四国地方", "徳島県");
            dataTable.Rows.Add("四国地方", "香川県");
            dataTable.Rows.Add("四国地方", "愛媛県");
            dataTable.Rows.Add("四国地方", "高知県");
            dataTable.Rows.Add("九州地方", "福岡県");
            dataTable.Rows.Add("九州地方", "佐賀県");
            dataTable.Rows.Add("九州地方", "長崎県");
            dataTable.Rows.Add("九州地方", "熊本県");
            dataTable.Rows.Add("九州地方", "大分県");
            dataTable.Rows.Add("九州地方", "宮崎県");
            dataTable.Rows.Add("九州地方", "鹿児島県");
            dataTable.Rows.Add("沖縄県", "沖縄本島");
            dataTable.Rows.Add("沖縄県", "大東島");
            dataTable.Rows.Add("沖縄県", "宮古島");
            dataTable.Rows.Add("沖縄県", "八重山列島");

            var resultDataTableForArea = dataTable.DefaultView.ToTable(true, new string[] { "region" });
            this.cbRegion.DisplayMember = "region";
            this.cbRegion.ValueMember = "region";
            this.cbRegion.DataSource = resultDataTableForArea;
            this.cbRegion.SelectedIndex = 0;

            this.InitializePrefectureComboBox();


            String japanUrl = "https://japan-map.com/wp-content/uploads/nihonchizu-color-768x768.png";
            WebClient japanClient = new WebClient();
            try {
                Stream japanStream = japanClient.OpenRead(japanUrl);
                Bitmap japan = new Bitmap(japanStream);
                japanStream.Close();
                Image resizedImage = resizeImage(japan, new Size(712, 585));
                pbJapan.Image = resizedImage;
                var wc = new WebClient() {

                    Encoding = Encoding.UTF8

                };

                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
            }
            catch (Exception) {

                
            }

            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {
                DialogResult result = MessageBox.Show("インターネットに接続されていません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK) {
                    this.Close();
                }
            }

        }

        public static Image resizeImage(Image imgToResize, Size size) {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void InitializePrefectureComboBox() {
            var resultDataTableForPrefecture = dataTable.AsEnumerable().Where(
              row => row.Field<string>("region") == this.cbRegion.SelectedValue.ToString())
              .AsDataView().ToTable(true, new string[] { "region", "prefecture" });
            this.cbPrefecture.DisplayMember = "prefecture";
            this.cbPrefecture.ValueMember = "prefecture";
            this.cbPrefecture.DataSource = resultDataTableForPrefecture;
            this.cbPrefecture.SelectedIndex = 0;
        }


        private void cbRegion_TextChanged(object sender, EventArgs e) {

            this.InitializePrefectureComboBox();

        }

        private void btHokkaido_Click(object sender, EventArgs e) {

            var form2 = new HokkaidoRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btTohoku_Click(object sender, EventArgs e) {

            var form2 = new TohokuRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btKanto_Click(object sender, EventArgs e) {

            var form2 = new KantoRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btChubu_Click(object sender, EventArgs e) {

            var form2 = new ChubuRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btKinki_Click(object sender, EventArgs e) {

            var form2 = new KinkiRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btChugoku_Click(object sender, EventArgs e) {

            var form2 = new ChugokuRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btSikoku_Click(object sender, EventArgs e) {

            var form2 = new SikokuRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }

        private void btKyusyu_Click(object sender, EventArgs e) {

            var form2 = new KyusyuRegion();

            this.Hide();
            if (form2.ShowDialog() == DialogResult.Cancel) {
                this.Show();
            }
        }
    }
    
}
