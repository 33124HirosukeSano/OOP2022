
namespace WeatherApp {
    partial class mainForm {
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
            this.tbWeatherInfoThreedays = new System.Windows.Forms.TextBox();
            this.cbPrefecture = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbJapan = new System.Windows.Forms.PictureBox();
            this.btHokkaido = new System.Windows.Forms.Button();
            this.btTohoku = new System.Windows.Forms.Button();
            this.btKanto = new System.Windows.Forms.Button();
            this.btChubu = new System.Windows.Forms.Button();
            this.btKinki = new System.Windows.Forms.Button();
            this.btChugoku = new System.Windows.Forms.Button();
            this.btSikoku = new System.Windows.Forms.Button();
            this.btKyusyu = new System.Windows.Forms.Button();
            this.btOkinawa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbToday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbJapan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfoThreedays
            // 
            this.tbWeatherInfoThreedays.BackColor = System.Drawing.SystemColors.Window;
            this.tbWeatherInfoThreedays.Enabled = false;
            this.tbWeatherInfoThreedays.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfoThreedays.Location = new System.Drawing.Point(28, 307);
            this.tbWeatherInfoThreedays.Multiline = true;
            this.tbWeatherInfoThreedays.Name = "tbWeatherInfoThreedays";
            this.tbWeatherInfoThreedays.ReadOnly = true;
            this.tbWeatherInfoThreedays.Size = new System.Drawing.Size(346, 287);
            this.tbWeatherInfoThreedays.TabIndex = 0;
            // 
            // cbPrefecture
            // 
            this.cbPrefecture.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbPrefecture.FormattingEnabled = true;
            this.cbPrefecture.Items.AddRange(new object[] {
            "宗谷地方",
            "上川・留萌地方",
            "網走・北見・紋別地方",
            "十勝地方",
            "釧路・根室地方",
            "胆振・日高地方",
            "石狩・空知・後志地方",
            "渡島・檜山地方"});
            this.cbPrefecture.Location = new System.Drawing.Point(28, 110);
            this.cbPrefecture.Name = "cbPrefecture";
            this.cbPrefecture.Size = new System.Drawing.Size(347, 35);
            this.cbPrefecture.TabIndex = 2;
            this.cbPrefecture.SelectedIndexChanged += new System.EventHandler(this.cbPrefecture_Changed);
            // 
            // cbRegion
            // 
            this.cbRegion.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(28, 38);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(347, 35);
            this.cbRegion.TabIndex = 3;
            this.cbRegion.TextChanged += new System.EventHandler(this.cbRegion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "地方";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "都道府県・地域";
            // 
            // pbJapan
            // 
            this.pbJapan.BackColor = System.Drawing.SystemColors.Window;
            this.pbJapan.Location = new System.Drawing.Point(454, 9);
            this.pbJapan.Name = "pbJapan";
            this.pbJapan.Size = new System.Drawing.Size(712, 585);
            this.pbJapan.TabIndex = 5;
            this.pbJapan.TabStop = false;
            // 
            // btHokkaido
            // 
            this.btHokkaido.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btHokkaido.Location = new System.Drawing.Point(931, 101);
            this.btHokkaido.Name = "btHokkaido";
            this.btHokkaido.Size = new System.Drawing.Size(75, 23);
            this.btHokkaido.TabIndex = 6;
            this.btHokkaido.Text = "北海道";
            this.btHokkaido.UseVisualStyleBackColor = true;
            this.btHokkaido.Click += new System.EventHandler(this.btHokkaido_Click);
            // 
            // btTohoku
            // 
            this.btTohoku.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btTohoku.Location = new System.Drawing.Point(878, 235);
            this.btTohoku.Name = "btTohoku";
            this.btTohoku.Size = new System.Drawing.Size(75, 23);
            this.btTohoku.TabIndex = 7;
            this.btTohoku.Text = "東北地方";
            this.btTohoku.UseVisualStyleBackColor = true;
            this.btTohoku.Click += new System.EventHandler(this.btTohoku_Click);
            // 
            // btKanto
            // 
            this.btKanto.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btKanto.Location = new System.Drawing.Point(842, 362);
            this.btKanto.Name = "btKanto";
            this.btKanto.Size = new System.Drawing.Size(75, 23);
            this.btKanto.TabIndex = 8;
            this.btKanto.Text = "関東地方";
            this.btKanto.UseVisualStyleBackColor = true;
            this.btKanto.Click += new System.EventHandler(this.btKanto_Click);
            // 
            // btChubu
            // 
            this.btChubu.Location = new System.Drawing.Point(761, 371);
            this.btChubu.Name = "btChubu";
            this.btChubu.Size = new System.Drawing.Size(75, 23);
            this.btChubu.TabIndex = 9;
            this.btChubu.Text = "中部地方";
            this.btChubu.UseVisualStyleBackColor = true;
            this.btChubu.Click += new System.EventHandler(this.btChubu_Click);
            // 
            // btKinki
            // 
            this.btKinki.Location = new System.Drawing.Point(689, 413);
            this.btKinki.Name = "btKinki";
            this.btKinki.Size = new System.Drawing.Size(75, 23);
            this.btKinki.TabIndex = 10;
            this.btKinki.Text = "近畿地方";
            this.btKinki.UseVisualStyleBackColor = true;
            this.btKinki.Click += new System.EventHandler(this.btKinki_Click);
            // 
            // btChugoku
            // 
            this.btChugoku.Location = new System.Drawing.Point(595, 403);
            this.btChugoku.Name = "btChugoku";
            this.btChugoku.Size = new System.Drawing.Size(75, 23);
            this.btChugoku.TabIndex = 11;
            this.btChugoku.Text = "中国地方";
            this.btChugoku.UseVisualStyleBackColor = true;
            this.btChugoku.Click += new System.EventHandler(this.btChugoku_Click);
            // 
            // btSikoku
            // 
            this.btSikoku.Location = new System.Drawing.Point(612, 449);
            this.btSikoku.Name = "btSikoku";
            this.btSikoku.Size = new System.Drawing.Size(75, 23);
            this.btSikoku.TabIndex = 12;
            this.btSikoku.Text = "四国地方";
            this.btSikoku.UseVisualStyleBackColor = true;
            this.btSikoku.Click += new System.EventHandler(this.btSikoku_Click);
            // 
            // btKyusyu
            // 
            this.btKyusyu.Location = new System.Drawing.Point(510, 479);
            this.btKyusyu.Name = "btKyusyu";
            this.btKyusyu.Size = new System.Drawing.Size(75, 23);
            this.btKyusyu.TabIndex = 13;
            this.btKyusyu.Text = "九州地方";
            this.btKyusyu.UseVisualStyleBackColor = true;
            this.btKyusyu.Click += new System.EventHandler(this.btKyusyu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(466, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "詳細";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(24, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "概況（三日間）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "今日の天気";
            // 
            // tbToday
            // 
            this.tbToday.BackColor = System.Drawing.SystemColors.Window;
            this.tbToday.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbToday.Location = new System.Drawing.Point(28, 182);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.ReadOnly = true;
            this.tbToday.Size = new System.Drawing.Size(343, 88);
            this.tbToday.TabIndex = 17;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 606);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btOkinawa);
            this.Controls.Add(this.btKyusyu);
            this.Controls.Add(this.btSikoku);
            this.Controls.Add(this.btChugoku);
            this.Controls.Add(this.btKinki);
            this.Controls.Add(this.btChubu);
            this.Controls.Add(this.btKanto);
            this.Controls.Add(this.btTohoku);
            this.Controls.Add(this.btHokkaido);
            this.Controls.Add(this.pbJapan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbPrefecture);
            this.Controls.Add(this.tbWeatherInfoThreedays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJapan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfoThreedays;
        private System.Windows.Forms.ComboBox cbPrefecture;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbJapan;
        private System.Windows.Forms.Button btHokkaido;
        private System.Windows.Forms.Button btTohoku;
        private System.Windows.Forms.Button btKanto;
        private System.Windows.Forms.Button btChubu;
        private System.Windows.Forms.Button btKinki;
        private System.Windows.Forms.Button btChugoku;
        private System.Windows.Forms.Button btSikoku;
        private System.Windows.Forms.Button btKyusyu;
        private System.Windows.Forms.Button btOkinawa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbToday;
    }
}

