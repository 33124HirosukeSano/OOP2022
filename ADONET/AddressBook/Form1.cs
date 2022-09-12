using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202230DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {

            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void bcConect_Click(object sender, EventArgs e) {

            // TODO: このコード行はデータを 'infosys202230DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.addressTableTableAdapter.Fill(this.infosys202230DataSet.AddressTable);

        }

        private void btAdd_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202230DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            //データセットへ新しいレコードを追加
            infosys202230DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202230DataSet.AddressTable);

        }
        
        private void addressTableDataGridView_Click(object sender, EventArgs e) {

            if (addressTableDataGridView.RowCount == null) {

                return;

            }


            //データグリットビューの選択レコードをテキストボックスへ
            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTell.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {

                pbPicture.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);

            } else {

                pbPicture.Image = null;

            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリットビュー
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTell.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202230DataSet);

        }

        private void btImageOpen_Click(object sender, EventArgs e) {

            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(ofdImage.FileName);
                btImageClear.Enabled = true;                

            }
        }

        private void btImageClear_Click(object sender, EventArgs e) {

            pbPicture.Image = null;
            btImageClear.Enabled = false;            

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

        private void addressTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btNameSearcher_Click(object sender, EventArgs e) {

            this.addressTableTableAdapter.FillByName(this.infosys202230DataSet.AddressTable, tbNameSearcher.Text);
            

        }

        private void btClear_Click(object sender, EventArgs e) {



        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {

            this.addressTableTableAdapter.Fill(this.infosys202230DataSet.AddressTable);

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btSearchClear_Click(object sender, EventArgs e) {

            tbNameSearcher.Text = null;
            this.addressTableTableAdapter.Fill(this.infosys202230DataSet.AddressTable);
            btSearchClear.Enabled = false;

        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {

            new Version().ShowDialog();

        }
    }
}
