using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        string dString;
        private DataTable dataTable;


        public Form1() {
            InitializeComponent();
        }



        private void btWeatherGet_Click(object sender, EventArgs e) {

            var wc = new WebClient() {

                Encoding = Encoding.UTF8

            };

            switch (cbPrefecture.Text) {
                case "宗谷":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                    break;
                case "上川・留萌":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                    break;
                case "網走・北見・紋別":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                    break;
                case "十勝":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014030.json");
                    break;
                case "釧路・根室":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                    break;
                case "胆振・日高":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                    break;
                case "石狩・空知・後志":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                    break;
                case "渡島・檜山":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                    break;
                case "青森県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                    break;
                case "岩手県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                    break;
                case "宮城県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                    break;
                case "秋田県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                    break;
                case "山形県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                    break;
                case "福島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                    break;
                case "茨城県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                    break;
                case "栃木県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                    break;
                case "群馬県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                    break;
                case "埼玉県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                    break;
                case "千葉県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                    break;
                case "東京都":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                    break;
                case "神奈川県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                    break;
                case "新潟県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                    break;
                case "富山県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                    break;
                case "石川県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                    break;
                case "福井県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                    break;
                case "山梨県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                    break;
                case "長野県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                    break;
                case "岐阜県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                    break;
                case "静岡県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                    break;
                case "愛知県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                    break;
                case "三重県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                    break;
                case "滋賀県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                    break;
                case "京都府":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                    break;
                case "大阪府":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                    break;
                case "兵庫県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                    break;
                case "奈良県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                    break;
                case "和歌山県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                    break;
                case "鳥取県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                    break;
                case "島根県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                    break;
                case "岡山県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                    break;
                case "広島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                    break;
                case "山口県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                    break;
                case "徳島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                    break;
                case "香川県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                    break;
                case "愛媛県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                    break;
                case "高知県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                    break;
                case "福岡県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                    break;
                case "佐賀県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                    break;
                case "長崎県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                    break;
                case "熊本県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                    break;
                case "大分県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                    break;
                case "宮崎県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                    break;
                case "鹿児島県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                    break;
                case "沖縄県":
                    dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                    break;
                default:
                    break;
            }

            var dString2 = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            var json2 = JsonConvert.DeserializeObject<Class1[]>(dString2);
            tbWeatherInfo.Text = json2[0].timeSeries[0].areas[0].weathers[1];
            //tbWeatherInfo.Text = json.text;

        }

        private void Form1_Load(object sender, EventArgs e) {

            dataTable = new DataTable("Region");

            dataTable.Columns.Add("region", typeof(string));
            dataTable.Columns.Add("prefecture", typeof(string));

            dataTable.Rows.Add("北海道地方", "宗谷");
            dataTable.Rows.Add("北海道地方", "上川・留萌");
            dataTable.Rows.Add("北海道地方", "網走・北見・紋別");
            dataTable.Rows.Add("北海道地方", "十勝");
            dataTable.Rows.Add("北海道地方", "釧路・根室");
            dataTable.Rows.Add("北海道地方", "胆振・日高");
            dataTable.Rows.Add("北海道地方", "石狩・空知・後志");
            dataTable.Rows.Add("北海道地方", "渡島・檜山");
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
            dataTable.Rows.Add("九州地方", "沖縄県");

            var resultDataTableForArea = dataTable.DefaultView.ToTable(true, new string[] { "region" });
            this.cbRegion.DisplayMember = "region";
            this.cbRegion.ValueMember = "region";
            this.cbRegion.DataSource = resultDataTableForArea;
            this.cbRegion.SelectedIndex = 0;

            this.InitializePrefectureComboBox();

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
 
    }
}
