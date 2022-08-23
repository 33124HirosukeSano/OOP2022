using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        Settings SetColor = new Settings();
        OpenFileDialog ofdFileOpenDialog = new OpenFileDialog();
        SaveFileDialog sfdSaveDialog = new SaveFileDialog();
        int mode = 0;        

        public Form1() {
            InitializeComponent();
            dgvCar.DataSource = listCarReport;
        }

        private void btOpenPicture_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                pbCarPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
                btPictureClear.Enabled = true;
                btChangeDisplaySettings.Enabled = true;

            }
        }

        private void btAddReport_Click(object sender, EventArgs e) {

            CarReport newCarReport = new CarReport {

                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = GetRadioButtonKind(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbCarPicture.Image,
                
            };

            EnabledCheck();

            if (String.IsNullOrWhiteSpace(tbReport.Text)) {

                MessageBox.Show("空欄があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            } else {

                listCarReport.Add(newCarReport);
                EnabledCheck();

            }

            setCbAuther(cbAuther.Text);
            setCarName(cbCarName.Text);

        }

        //コンボボックスに記録者名を登録する(重複なし)
        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {

                //まだ登録されていなければ登録処理
                cbAuther.Items.Add(auther);

            }
        }
        //コンボボックスに車名を登録する(重複なし)
        private void setCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {

                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(carName);

            }
        }

        //ラジオボタンにセットされている値を取り出す
        private CarReport.MakerGroup GetRadioButtonKind() {

            CarReport.MakerGroup selectedMaker = CarReport.MakerGroup.その他;

            if (rbTOYOTA.Checked) {//トヨタにチェック

                selectedMaker = CarReport.MakerGroup.トヨタ;

            }
            if (rbNISSAN.Checked) {//日産にチェック

                selectedMaker = CarReport.MakerGroup.日産;

            }
            if (rbHONDA.Checked) {//ホンダにチェック

                selectedMaker = CarReport.MakerGroup.ホンダ;

            }
            if (rbSUBARU.Checked) {//スバルにチェック

                selectedMaker = CarReport.MakerGroup.スバル;

            }
            if (rbForeignCar.Checked) {//外国車にチェック

                selectedMaker = CarReport.MakerGroup.外国車;

            }
            return selectedMaker;

        }

        private void btPictureClear_Click(object sender, EventArgs e) {

            pbCarPicture.Image = null;
            btPictureClear.Enabled = false;
            btChangeDisplaySettings.Enabled = false;

        }

        //データグリットビューをクリックした時のイベントハンドラ
        private void dgvCar_Click(object sender, EventArgs e) {

            if (dgvCar.CurrentRow == null) {

                return;

            }

            int index = dgvCar.CurrentRow.Index;
            cbAuther.Text = (String)dgvCar.CurrentRow.Cells[1].Value;
            cbCarName.Text = (String)dgvCar.CurrentRow.Cells[3].Value;
            tbReport.Text = (String)dgvCar.CurrentRow.Cells[4].Value;
            pbCarPicture.Image = (Image)dgvCar.CurrentRow.Cells[5].Value;

            setMakerGroup(index);//メーカーチェック処理

        }

        private void setMakerGroup(int index) {
            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbTOYOTA.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNISSAN.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHONDA.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSUBARU.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbForeignCar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
            }
        }

        //データが更新された時の処理
        private void btCorrectReport_Click(object sender, EventArgs e) {

            listCarReport[dgvCar.CurrentRow.Index].Date = dtpDate.Value;
            listCarReport[dgvCar.CurrentRow.Index].Auther = cbAuther.Text;
            listCarReport[dgvCar.CurrentRow.Index].Maker = GetRadioButtonKind();
            listCarReport[dgvCar.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReport[dgvCar.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvCar.CurrentRow.Index].Picture = pbCarPicture.Image;

            dgvCar.Refresh();

            setCbAuther(cbAuther.Text);
            setCarName(cbCarName.Text);

        }

        private void btDeletionReport_Click(object sender, EventArgs e) {

            listCarReport.RemoveAt(dgvCar.CurrentRow.Index);

            //マスク処理呼び出し
            EnabledCheck();

        }

        //更新・削除ボタンのマスク処理を行う(マスク判定を含む)
        private void EnabledCheck() {

            btCorrectReport.Enabled = btDeletionReport.Enabled = btSaveArticle.Enabled = listCarReport.Count() > 0 ? true : false;

        }

        private void btSaveArticle_Click(object sender, EventArgs e) {

            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {

                try {

                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listCarReport);

                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btOpenArticle_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                try {

                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCar.DataSource = null;
                        dgvCar.DataSource = listCarReport;

                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);

                }

                cbAuther.Items.Clear();
                cbCarName.Items.Clear();

                EnabledCheck();

                foreach (var item in listCarReport.Select(p => p.Auther)) {

                    //すでに存在する記録者を登録
                    setCbAuther(item);

                }
                foreach (var item in listCarReport.Select(p => p.CarName)) {

                    //すでに存在する車名を登録
                    setCarName(item);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

            //マスク処理
            EnabledCheck();

            ColorDialog cd = new ColorDialog();
            cd.Color = this.BackColor;
            this.BackColor = cd.Color;
            SetColor.MainFormColor = cd.Color.ToArgb();

            //設定ファイルを逆シリアル化
            using (var reader = XmlReader.Create("setting.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                var settinng = serializer.Deserialize(reader) as Settings;
                this.BackColor = Color.FromArgb(settinng.MainFormColor);//ARGBからColorオブジェクトへ

            }



        }

        private void btExit_Click(object sender, EventArgs e) {

            this.Close();


        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            
            ColorDialog cd = new ColorDialog();
            
            cd.Color = this.BackColor;
            
            cd.AllowFullOpen = true;
            cd.SolidColorOnly = false;
            //[作成した色]に指定した色（RGB値）を表示する
            cd.CustomColors = new int[] {
                
            };
            
            if (cd.ShowDialog() == DialogResult.OK) {

                this.BackColor = cd.Color;
                SetColor.MainFormColor = cd.Color.ToArgb();

            }            

        }

        private void btChangeDisplaySettings_Click(object sender, EventArgs e) {

            pbCarPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;


        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルをシリアル化
            using (var color = XmlWriter.Create("setting.xml")) {
                var serializer = new XmlSerializer(SetColor.GetType());
                serializer.Serialize(color, SetColor);

            }            

        }
    }
}
