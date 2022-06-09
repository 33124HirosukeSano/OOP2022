using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {

        private Random rand = new Random();
        private int randomNumber;


        public Form1() {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e) {


            randomNumber = rand.Next(49) + 1;


        }

        private void btAns_Click_1(object sender, EventArgs e) {


            if (nudNum.Value == randomNumber) {

                celebrate.Text = "当たり";

            } else {

                celebrate.Text = "はずれ";

            }

        }
    }
}
