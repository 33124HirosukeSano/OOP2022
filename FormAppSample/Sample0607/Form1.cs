﻿using System;
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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {            

            /*if (int.Parse(tbNum2.Text) != 0) {
                tbAns.Text = Math.DivRem(int.Parse(tbNum1.Text), int.Parse(tbNum2.Text), out var rem).ToString();
                tbMod.Text = rem.ToString();
            } else {

                MessageBox.Show("0以外を入力してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }*/

            if (nudNum2.Value != 0) {
                nudAns.Value = nudNum1.Value / nudNum2.Value;
                nudMod.Value = nudNum1.Value % nudNum2.Value;
            } else {

                MessageBox.Show("0で割り算できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }            

        }
    }
}