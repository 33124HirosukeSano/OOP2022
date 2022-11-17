
namespace WeatherApp {
    partial class HokkaidoRegion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pbHokkaido = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHokkaido)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHokkaido
            // 
            this.pbHokkaido.BackColor = System.Drawing.SystemColors.Window;
            this.pbHokkaido.Location = new System.Drawing.Point(454, 9);
            this.pbHokkaido.Name = "pbHokkaido";
            this.pbHokkaido.Size = new System.Drawing.Size(712, 585);
            this.pbHokkaido.TabIndex = 0;
            this.pbHokkaido.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "宗谷";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "上川・留萌";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(800, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "網走・北見・紋別";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HokkaidoRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbHokkaido);
            this.Name = "HokkaidoRegion";
            this.Text = "HokkaidoRegion";
            this.Load += new System.EventHandler(this.HokkaidoRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHokkaido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHokkaido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}