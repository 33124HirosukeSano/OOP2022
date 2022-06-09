
namespace Sample0607 {
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
            this.btAns = new System.Windows.Forms.Button();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.celebrate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "1～50の中から入力";
            // 
            // btAns
            // 
            this.btAns.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAns.Location = new System.Drawing.Point(496, 143);
            this.btAns.Name = "btAns";
            this.btAns.Size = new System.Drawing.Size(75, 59);
            this.btAns.TabIndex = 1;
            this.btAns.Text = "入力";
            this.btAns.UseVisualStyleBackColor = true;
            this.btAns.Click += new System.EventHandler(this.btAns_Click_1);
            // 
            // nudNum
            // 
            this.nudNum.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudNum.Location = new System.Drawing.Point(126, 143);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(120, 55);
            this.nudNum.TabIndex = 3;
            // 
            // celebrate
            // 
            this.celebrate.AutoSize = true;
            this.celebrate.BackColor = System.Drawing.Color.White;
            this.celebrate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.celebrate.Location = new System.Drawing.Point(336, 156);
            this.celebrate.Name = "celebrate";
            this.celebrate.Size = new System.Drawing.Size(0, 35);
            this.celebrate.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(718, 307);
            this.Controls.Add(this.celebrate);
            this.Controls.Add(this.nudNum);
            this.Controls.Add(this.btAns);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAns;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Label celebrate;
    }
}

