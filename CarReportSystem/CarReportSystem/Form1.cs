﻿using System;
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
        Settings SetColor = Settings.getInstance();
        OpenFileDialog ofdFileOpenDialog = new OpenFileDialog();
        SaveFileDialog sfdSaveDialog = new SaveFileDialog();
        int mode = 0;
        ColorDialog cd = new ColorDialog();

        public Form1() {
            InitializeComponent();
            dgvCar.DataSource = listCarReport;
        }

        private void btOpenPicture_Click(object sender, EventArgs e) {

            ofdFileOpenDialog.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                pbCarPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
                btPictureClear.Enabled = true;

            }
        }

        private void btAddReport_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202230DataSet.AddressTable.NewRow();
            newRow[2] = cbAuther.Text;
            newRow[4] = cbCarName.Text;
            //データセットへ新しいレコードを追加
            infosys202230DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202230DataSet.CarReportDB);

            EnabledCheck();

            if (String.IsNullOrWhiteSpace(tbReport.Text)) {

                MessageBox.Show("空欄があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            } else {

                
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

            btCorrectReport.Enabled = btDeletionReport.Enabled = btSaveArticle.Enabled = btUpdate.Enabled = listCarReport.Count() > 0 ? true : false;

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

        //private void btOpenArticle_Click(object sender, EventArgs e) {

        //    if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

        //        try {

        //            //バイナリ形式で逆シリアル化
        //            var bf = new BinaryFormatter();

        //            using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {

        //                //逆シリアル化して読み込む
        //                listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
        //                dgvCar.DataSource = null;
        //                dgvCar.DataSource = listCarReport;

        //            }
        //        }
        //        catch (Exception ex) {

        //            MessageBox.Show(ex.Message);

        //        }

        //        cbAuther.Items.Clear();
        //        cbCarName.Items.Clear();

        //        EnabledCheck();

        //        foreach (var item in listCarReport.Select(p => p.Auther)) {

        //            //すでに存在する記録者を登録
        //            setCbAuther(item);

        //        }
        //        foreach (var item in listCarReport.Select(p => p.CarName)) {

        //            //すでに存在する車名を登録
        //            setCarName(item);

        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202230DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            

            try {
            //設定ファイルを逆シリアル化
                using (var reader = XmlReader.Create("setting.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    var settinng = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settinng.MainFormColor);//ARGBからColorオブジェクトへ

                }
            }
            catch (Exception) {

            }
            finally {

                EnabledCheck();

            }

        }

        private void btExit_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
                                    
            cd.Color = this.BackColor;
            
            cd.AllowFullOpen = true;
            cd.SolidColorOnly = false;
            //[作成した色]に指定した色（RGB値）を表示する
            cd.CustomColors = new int[] {
                
            };
            
            if (cd.ShowDialog() == DialogResult.OK) {

                this.BackColor = cd.Color;

            }

        }

        private void btChangeDisplaySettings_Click(object sender, EventArgs e) {

            pbCarPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            
            cd.Color = this.BackColor;
            SetColor.MainFormColor = cd.Color.ToArgb();

            //設定ファイルをシリアル化
            using (var color = XmlWriter.Create("setting.xml")) {
                var serializer = new XmlSerializer(SetColor.GetType());
                serializer.Serialize(color, SetColor);

            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202230DataSet);

        }

        private void btConnect_Click(object sender, EventArgs e) {

            // TODO: このコード行はデータを 'infosys202230DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202230DataSet.CarReportDB);

        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {

            if (carReportDBDataGridView.RowCount == null) {

                return;

            }
            
            cbAuther.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull)) {

                pbCarPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);

            } else {

                pbCarPicture.Image = null;

            }

        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void btUpdate_Click(object sender, EventArgs e) {

            //carReportDBDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonKind();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbCarPicture.Image);

            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202230DataSet);

        }
    }
}
