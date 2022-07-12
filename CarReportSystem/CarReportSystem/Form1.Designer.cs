
namespace CarReportSystem {
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
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.cbAuther = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.rbTOYOTA = new System.Windows.Forms.RadioButton();
            this.rbNISSAN = new System.Windows.Forms.RadioButton();
            this.rbHONDA = new System.Windows.Forms.RadioButton();
            this.rbSUBARU = new System.Windows.Forms.RadioButton();
            this.rbForeignCar = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpenArticle = new System.Windows.Forms.Button();
            this.btSaveArticle = new System.Windows.Forms.Button();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btCorrectReport = new System.Windows.Forms.Button();
            this.btDeletionReport = new System.Windows.Forms.Button();
            this.btOpenPicture = new System.Windows.Forms.Button();
            this.btDeletionPicture = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCarPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCar
            // 
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(108, 357);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowTemplate.Height = 21;
            this.dgvCar.Size = new System.Drawing.Size(907, 194);
            this.dgvCar.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(108, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // tbReport
            // 
            this.tbReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbReport.Location = new System.Drawing.Point(108, 184);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(525, 154);
            this.tbReport.TabIndex = 2;
            // 
            // cbAuther
            // 
            this.cbAuther.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAuther.FormattingEnabled = true;
            this.cbAuther.Location = new System.Drawing.Point(108, 60);
            this.cbAuther.Name = "cbAuther";
            this.cbAuther.Size = new System.Drawing.Size(263, 23);
            this.cbAuther.TabIndex = 3;
            // 
            // cbCarName
            // 
            this.cbCarName.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(108, 141);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(263, 23);
            this.cbCarName.TabIndex = 3;
            // 
            // rbTOYOTA
            // 
            this.rbTOYOTA.AutoSize = true;
            this.rbTOYOTA.Location = new System.Drawing.Point(108, 104);
            this.rbTOYOTA.Name = "rbTOYOTA";
            this.rbTOYOTA.Size = new System.Drawing.Size(47, 16);
            this.rbTOYOTA.TabIndex = 4;
            this.rbTOYOTA.TabStop = true;
            this.rbTOYOTA.Text = "トヨタ";
            this.rbTOYOTA.UseVisualStyleBackColor = true;
            // 
            // rbNISSAN
            // 
            this.rbNISSAN.AutoSize = true;
            this.rbNISSAN.Location = new System.Drawing.Point(187, 104);
            this.rbNISSAN.Name = "rbNISSAN";
            this.rbNISSAN.Size = new System.Drawing.Size(47, 16);
            this.rbNISSAN.TabIndex = 4;
            this.rbNISSAN.TabStop = true;
            this.rbNISSAN.Text = "日産";
            this.rbNISSAN.UseVisualStyleBackColor = true;
            // 
            // rbHONDA
            // 
            this.rbHONDA.AutoSize = true;
            this.rbHONDA.Location = new System.Drawing.Point(266, 104);
            this.rbHONDA.Name = "rbHONDA";
            this.rbHONDA.Size = new System.Drawing.Size(51, 16);
            this.rbHONDA.TabIndex = 4;
            this.rbHONDA.TabStop = true;
            this.rbHONDA.Text = "ホンダ";
            this.rbHONDA.UseVisualStyleBackColor = true;
            // 
            // rbSUBARU
            // 
            this.rbSUBARU.AutoSize = true;
            this.rbSUBARU.Location = new System.Drawing.Point(349, 104);
            this.rbSUBARU.Name = "rbSUBARU";
            this.rbSUBARU.Size = new System.Drawing.Size(52, 16);
            this.rbSUBARU.TabIndex = 4;
            this.rbSUBARU.TabStop = true;
            this.rbSUBARU.Text = "スバル";
            this.rbSUBARU.UseVisualStyleBackColor = true;
            // 
            // rbForeignCar
            // 
            this.rbForeignCar.AutoSize = true;
            this.rbForeignCar.Location = new System.Drawing.Point(433, 104);
            this.rbForeignCar.Name = "rbForeignCar";
            this.rbForeignCar.Size = new System.Drawing.Size(59, 16);
            this.rbForeignCar.TabIndex = 4;
            this.rbForeignCar.TabStop = true;
            this.rbForeignCar.Text = "外国車";
            this.rbForeignCar.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(524, 104);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 4;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "日付：";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btExit.Location = new System.Drawing.Point(940, 572);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(47, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(32, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(21, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "記事一覧：";
            // 
            // btOpenArticle
            // 
            this.btOpenArticle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpenArticle.Location = new System.Drawing.Point(24, 387);
            this.btOpenArticle.Name = "btOpenArticle";
            this.btOpenArticle.Size = new System.Drawing.Size(63, 44);
            this.btOpenArticle.TabIndex = 7;
            this.btOpenArticle.Text = "開く...";
            this.btOpenArticle.UseVisualStyleBackColor = true;
            // 
            // btSaveArticle
            // 
            this.btSaveArticle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSaveArticle.Location = new System.Drawing.Point(24, 448);
            this.btSaveArticle.Name = "btSaveArticle";
            this.btSaveArticle.Size = new System.Drawing.Size(63, 44);
            this.btSaveArticle.TabIndex = 7;
            this.btSaveArticle.Text = "保存";
            this.btSaveArticle.UseVisualStyleBackColor = true;
            // 
            // btAddReport
            // 
            this.btAddReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddReport.Location = new System.Drawing.Point(709, 316);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(70, 31);
            this.btAddReport.TabIndex = 8;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = true;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // btCorrectReport
            // 
            this.btCorrectReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCorrectReport.Location = new System.Drawing.Point(809, 316);
            this.btCorrectReport.Name = "btCorrectReport";
            this.btCorrectReport.Size = new System.Drawing.Size(70, 31);
            this.btCorrectReport.TabIndex = 8;
            this.btCorrectReport.Text = "修正";
            this.btCorrectReport.UseVisualStyleBackColor = true;
            // 
            // btDeletionReport
            // 
            this.btDeletionReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeletionReport.Location = new System.Drawing.Point(911, 316);
            this.btDeletionReport.Name = "btDeletionReport";
            this.btDeletionReport.Size = new System.Drawing.Size(70, 31);
            this.btDeletionReport.TabIndex = 8;
            this.btDeletionReport.Text = "削除";
            this.btDeletionReport.UseVisualStyleBackColor = true;
            // 
            // btOpenPicture
            // 
            this.btOpenPicture.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpenPicture.Location = new System.Drawing.Point(787, 61);
            this.btOpenPicture.Name = "btOpenPicture";
            this.btOpenPicture.Size = new System.Drawing.Size(88, 23);
            this.btOpenPicture.TabIndex = 8;
            this.btOpenPicture.Text = "開く...";
            this.btOpenPicture.UseVisualStyleBackColor = true;
            // 
            // btDeletionPicture
            // 
            this.btDeletionPicture.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeletionPicture.Location = new System.Drawing.Point(881, 61);
            this.btDeletionPicture.Name = "btDeletionPicture";
            this.btDeletionPicture.Size = new System.Drawing.Size(88, 23);
            this.btDeletionPicture.TabIndex = 8;
            this.btDeletionPicture.Text = "削除";
            this.btDeletionPicture.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(706, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "画像：";
            // 
            // pbCarPicture
            // 
            this.pbCarPicture.Location = new System.Drawing.Point(719, 90);
            this.pbCarPicture.Name = "pbCarPicture";
            this.pbCarPicture.Size = new System.Drawing.Size(237, 216);
            this.pbCarPicture.TabIndex = 9;
            this.pbCarPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.pbCarPicture);
            this.Controls.Add(this.btDeletionPicture);
            this.Controls.Add(this.btDeletionReport);
            this.Controls.Add(this.btCorrectReport);
            this.Controls.Add(this.btOpenPicture);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.btSaveArticle);
            this.Controls.Add(this.btOpenArticle);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbForeignCar);
            this.Controls.Add(this.rbSUBARU);
            this.Controls.Add(this.rbHONDA);
            this.Controls.Add(this.rbNISSAN);
            this.Controls.Add(this.rbTOYOTA);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuther);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvCar);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.ComboBox cbAuther;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.RadioButton rbTOYOTA;
        private System.Windows.Forms.RadioButton rbNISSAN;
        private System.Windows.Forms.RadioButton rbHONDA;
        private System.Windows.Forms.RadioButton rbSUBARU;
        private System.Windows.Forms.RadioButton rbForeignCar;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpenArticle;
        private System.Windows.Forms.Button btSaveArticle;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btCorrectReport;
        private System.Windows.Forms.Button btDeletionReport;
        private System.Windows.Forms.Button btOpenPicture;
        private System.Windows.Forms.Button btDeletionPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbCarPicture;
    }
}

