
namespace AddressBook {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMeilAddress = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbFamily = new System.Windows.Forms.CheckBox();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.cbFriend = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDeletion = new System.Windows.Forms.Button();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRegistDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gbKindNumber = new System.Windows.Forms.GroupBox();
            this.rbMobile = new System.Windows.Forms.RadioButton();
            this.rbHome = new System.Windows.Forms.RadioButton();
            this.tbTellNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.gbKindNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(138, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "メールアドレス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(138, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(138, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(210, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(461, 31);
            this.tbName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(107, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "グループ";
            // 
            // tbMeilAddress
            // 
            this.tbMeilAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMeilAddress.Location = new System.Drawing.Point(210, 65);
            this.tbMeilAddress.Name = "tbMeilAddress";
            this.tbMeilAddress.Size = new System.Drawing.Size(461, 31);
            this.tbMeilAddress.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(210, 108);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(461, 67);
            this.tbAddress.TabIndex = 1;
            // 
            // cbFamily
            // 
            this.cbFamily.AutoSize = true;
            this.cbFamily.Location = new System.Drawing.Point(222, 262);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(48, 16);
            this.cbFamily.TabIndex = 2;
            this.cbFamily.Text = "家族";
            this.cbFamily.UseVisualStyleBackColor = true;
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(459, 262);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(48, 16);
            this.cbWork.TabIndex = 2;
            this.cbWork.Text = "仕事";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // cbFriend
            // 
            this.cbFriend.AutoSize = true;
            this.cbFriend.Location = new System.Drawing.Point(338, 262);
            this.cbFriend.Name = "cbFriend";
            this.cbFriend.Size = new System.Drawing.Size(48, 16);
            this.cbFriend.TabIndex = 2;
            this.cbFriend.Text = "友人";
            this.cbFriend.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(576, 262);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(55, 16);
            this.cbOther.TabIndex = 2;
            this.cbOther.Text = "その他";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddPerson.Location = new System.Drawing.Point(691, 234);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(55, 44);
            this.btAddPerson.TabIndex = 3;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbPicture.Location = new System.Drawing.Point(701, 25);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(156, 150);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(701, 192);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 5;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(95, 366);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowTemplate.Height = 21;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(797, 162);
            this.dgvPersons.TabIndex = 6;
            this.dgvPersons.Click += new System.EventHandler(this.dgvPersons_Click);
            // 
            // btPictureClear
            // 
            this.btPictureClear.Enabled = false;
            this.btPictureClear.Location = new System.Drawing.Point(782, 192);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(75, 23);
            this.btPictureClear.TabIndex = 5;
            this.btPictureClear.Text = "クリア";
            this.btPictureClear.UseVisualStyleBackColor = true;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // btUpdate
            // 
            this.btUpdate.Enabled = false;
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(752, 234);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(55, 44);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDeletion
            // 
            this.btDeletion.Enabled = false;
            this.btDeletion.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeletion.Location = new System.Drawing.Point(813, 234);
            this.btDeletion.Name = "btDeletion";
            this.btDeletion.Size = new System.Drawing.Size(55, 44);
            this.btDeletion.TabIndex = 3;
            this.btDeletion.Text = "削除";
            this.btDeletion.UseVisualStyleBackColor = true;
            this.btDeletion.Click += new System.EventHandler(this.btDeletion_Click);
            // 
            // cbCompany
            // 
            this.cbCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(210, 191);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(461, 32);
            this.cbCompany.TabIndex = 7;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpen.Location = new System.Drawing.Point(12, 412);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(66, 50);
            this.btOpen.TabIndex = 3;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(12, 478);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(66, 50);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(651, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "登録日";
            // 
            // dtpRegistDate
            // 
            this.dtpRegistDate.Location = new System.Drawing.Point(709, 545);
            this.dtpRegistDate.Name = "dtpRegistDate";
            this.dtpRegistDate.Size = new System.Drawing.Size(159, 19);
            this.dtpRegistDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(84, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "電話番号";
            // 
            // gbKindNumber
            // 
            this.gbKindNumber.Controls.Add(this.rbMobile);
            this.gbKindNumber.Controls.Add(this.rbHome);
            this.gbKindNumber.Location = new System.Drawing.Point(210, 284);
            this.gbKindNumber.Name = "gbKindNumber";
            this.gbKindNumber.Size = new System.Drawing.Size(116, 38);
            this.gbKindNumber.TabIndex = 10;
            this.gbKindNumber.TabStop = false;
            this.gbKindNumber.Text = "種別";
            // 
            // rbMobile
            // 
            this.rbMobile.AutoSize = true;
            this.rbMobile.Location = new System.Drawing.Point(63, 16);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(47, 16);
            this.rbMobile.TabIndex = 1;
            this.rbMobile.Text = "携帯";
            this.rbMobile.UseVisualStyleBackColor = true;
            // 
            // rbHome
            // 
            this.rbHome.AutoSize = true;
            this.rbHome.Checked = true;
            this.rbHome.Location = new System.Drawing.Point(12, 16);
            this.rbHome.Name = "rbHome";
            this.rbHome.Size = new System.Drawing.Size(47, 16);
            this.rbHome.TabIndex = 0;
            this.rbHome.TabStop = true;
            this.rbHome.Text = "自宅";
            this.rbHome.UseVisualStyleBackColor = true;
            // 
            // tbTellNumber
            // 
            this.tbTellNumber.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTellNumber.Location = new System.Drawing.Point(210, 322);
            this.tbTellNumber.Name = "tbTellNumber";
            this.tbTellNumber.Size = new System.Drawing.Size(461, 31);
            this.tbTellNumber.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 576);
            this.Controls.Add(this.gbKindNumber);
            this.Controls.Add(this.dtpRegistDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btDeletion);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.cbFriend);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbTellNumber);
            this.Controls.Add(this.tbMeilAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "住所録ソフト";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.gbKindNumber.ResumeLayout(false);
            this.gbKindNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMeilAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.CheckBox cbFamily;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.CheckBox cbFriend;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDeletion;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRegistDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbKindNumber;
        private System.Windows.Forms.RadioButton rbMobile;
        private System.Windows.Forms.RadioButton rbHome;
        private System.Windows.Forms.TextBox tbTellNumber;
    }
}

