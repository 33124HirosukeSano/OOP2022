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

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {

            InitializeComponent();
            dgvPersons.DataSource = listPerson;
            

        }       

        private void btPictureOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
                btPictureClear.Enabled = true;

            }
            
        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            Person newPerson = new Person {

                Name = tbName.Text,
                MailAddress = tbMeilAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                KindNumber = GetRadioButtonKind(),
                Registration = dtpRegistDate.Value,
                listGroup = GetCheckBoxGroup(),
                TellNumber = tbTellNumber.Text,


            };

            //listPerson.Add(newPerson);
            EnabledCheck();


            if (String.IsNullOrWhiteSpace(tbName.Text)) {

                MessageBox.Show("空欄があります。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            } else {

                listPerson.Add(newPerson);
                EnabledCheck();

            }

            setCbCompany(cbCompany.Text);

        }

        //コンボボックスに会社名を登録する(重複なし)
        private void setCbCompany(string company) {
            if (!cbCompany.Items.Contains(company)) {

                //まだ登録されていなければ登録処理
                cbCompany.Items.Add(company);

            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {

            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked) {

                listGroup.Add(Person.GroupType.家族);

            }
            if (cbFriend.Checked) {

                listGroup.Add(Person.GroupType.友人);

            }
            if (cbWork.Checked) {

                listGroup.Add(Person.GroupType.仕事);

            }
            if (cbOther.Checked) {

                listGroup.Add(Person.GroupType.その他);

            }


            return listGroup;

        }

        //ラジオボタンにセットされている値を取り出す
        private Person.KindNmberType GetRadioButtonKind() {

            Person.KindNmberType selectedKindNumber = Person.KindNmberType.その他;

            if (rbHome.Checked) {//自宅にチェック

                selectedKindNumber = Person.KindNmberType.自宅;

            }
            if (rbMobile.Checked) {//携帯にチェック

                selectedKindNumber = Person.KindNmberType.携帯;

            }
            return selectedKindNumber;

        }

        private void btPictureClear_Click(object sender, EventArgs e) {

            pbPicture.Image = null;
            btPictureClear.Enabled = false;

        }

        //データグリットビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvPersons.CurrentRow == null) {

                return;

            }

            int index = dgvPersons.CurrentRow.Index;
            //tbName.Text = listPerson[index].Name;
            //tbMeilAddress.Text = listPerson[index].MailAddress;
            //tbAddress.Text = listPerson[index].Address;
            //cbCompany.Text = listPerson[index].Company;
            //pbPicture.Image = listPerson[index].Picture;
            //dtpRegistDate.Value = listPerson[index].Registration.Year > 1900 ?

            tbName.Text = (String)dgvPersons.CurrentRow.Cells[0].Value;
            tbMeilAddress.Text = (String)dgvPersons.CurrentRow.Cells[1].Value;
            tbAddress.Text = (String)dgvPersons.CurrentRow.Cells[2].Value;
            cbCompany.Text = (String)dgvPersons.CurrentRow.Cells[3].Value;
            tbTellNumber.Text = (String)dgvPersons.CurrentRow.Cells[6].Value;
            dtpRegistDate.Value = (DateTime)dgvPersons.CurrentRow.Cells[7].Value;
            pbPicture.Image = (Image)dgvPersons.CurrentRow.Cells[8].Value;

            groupCheckBoxAllClear();

            setGroupType(index);//グループチェック            
            setKindNumberType(index);//番号チェック処理
        }

        private void setKindNumberType(int index) {
            switch (listPerson[index].KindNumber) {
                case Person.KindNmberType.自宅:
                    rbHome.Checked = true;
                    break;
                case Person.KindNmberType.携帯:
                    rbMobile.Checked = true;
                    break;
                case Person.KindNmberType.その他:
                    break;
                default:
                    break;
            }
        }

        private void setGroupType(int index) {
            foreach (var group in listPerson[index].listGroup) {

                switch (group) {

                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;

                }
            }
        }

        private void groupCheckBoxAllClear() {

            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;

        }

        //データが更新された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMeilAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].KindNumber = GetRadioButtonKind();
            listPerson[dgvPersons.CurrentRow.Index].TellNumber = tbTellNumber.Text;
            listPerson[dgvPersons.CurrentRow.Index].Registration = dtpRegistDate.Value;
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;

            dgvPersons.Refresh();
            
        }

        private void btDeletion_Click(object sender, EventArgs e) {
            
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
           
            EnabledCheck();//マスク処理呼び出し
            
        }
        //更新・削除ボタンのマスク処理を行う(マスク判定を含む)
        private void EnabledCheck() {

            btUpdate.Enabled = btDeletion.Enabled = btSave.Enabled = listPerson.Count() > 0 ? true : false;

        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {

            if (sfdSaveDialog.ShowDialog() == DialogResult.OK){

                try {

                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {

                        bf.Serialize(fs, listPerson);

                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                try {

                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;

                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);

                }

                cbCompany.Items.Clear();

                EnabledCheck();

                foreach (var item in listPerson.Select(p => p.Company)) {

                    //すでに存在する会社を登録
                    setCbCompany(item);

                }

            }

        }        

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

            EnabledCheck();
        }

    }
}
