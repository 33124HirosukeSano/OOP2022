using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
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

    }
}
