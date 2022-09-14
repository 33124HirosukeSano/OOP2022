
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
            this.components = new System.ComponentModel.Container();
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
            this.btConnect = new System.Windows.Forms.Button();
            this.btSaveArticle = new System.Windows.Forms.Button();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btCorrectReport = new System.Windows.Forms.Button();
            this.btDeletionReport = new System.Windows.Forms.Button();
            this.btOpenPicture = new System.Windows.Forms.Button();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCarPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btChangeDisplaySettings = new System.Windows.Forms.Button();
            this.infosys202230DataSet = new CarReportSystem.infosys202230DataSet();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReportDBTableAdapter = new CarReportSystem.infosys202230DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202230DataSetTableAdapters.TableAdapterManager();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.btUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202230DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(104, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // tbReport
            // 
            this.tbReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbReport.Location = new System.Drawing.Point(104, 207);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(525, 154);
            this.tbReport.TabIndex = 2;
            // 
            // cbAuther
            // 
            this.cbAuther.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAuther.FormattingEnabled = true;
            this.cbAuther.Location = new System.Drawing.Point(104, 83);
            this.cbAuther.Name = "cbAuther";
            this.cbAuther.Size = new System.Drawing.Size(263, 23);
            this.cbAuther.TabIndex = 3;
            // 
            // cbCarName
            // 
            this.cbCarName.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(104, 164);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(263, 23);
            this.cbCarName.TabIndex = 3;
            // 
            // rbTOYOTA
            // 
            this.rbTOYOTA.AutoSize = true;
            this.rbTOYOTA.Location = new System.Drawing.Point(104, 127);
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
            this.rbNISSAN.Location = new System.Drawing.Point(183, 127);
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
            this.rbHONDA.Location = new System.Drawing.Point(262, 127);
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
            this.rbSUBARU.Location = new System.Drawing.Point(345, 127);
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
            this.rbForeignCar.Location = new System.Drawing.Point(429, 127);
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
            this.rbOther.Location = new System.Drawing.Point(520, 127);
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
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "日付：";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btExit.Location = new System.Drawing.Point(936, 595);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(28, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(17, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "記事一覧：";
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(20, 410);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(63, 44);
            this.btConnect.TabIndex = 7;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSaveArticle
            // 
            this.btSaveArticle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSaveArticle.Location = new System.Drawing.Point(20, 470);
            this.btSaveArticle.Name = "btSaveArticle";
            this.btSaveArticle.Size = new System.Drawing.Size(63, 44);
            this.btSaveArticle.TabIndex = 7;
            this.btSaveArticle.Text = "保存";
            this.btSaveArticle.UseVisualStyleBackColor = true;
            this.btSaveArticle.Click += new System.EventHandler(this.btSaveArticle_Click);
            // 
            // btAddReport
            // 
            this.btAddReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddReport.Location = new System.Drawing.Point(705, 339);
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
            this.btCorrectReport.Location = new System.Drawing.Point(805, 339);
            this.btCorrectReport.Name = "btCorrectReport";
            this.btCorrectReport.Size = new System.Drawing.Size(70, 31);
            this.btCorrectReport.TabIndex = 8;
            this.btCorrectReport.Text = "修正";
            this.btCorrectReport.UseVisualStyleBackColor = true;
            // 
            // btDeletionReport
            // 
            this.btDeletionReport.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeletionReport.Location = new System.Drawing.Point(907, 339);
            this.btDeletionReport.Name = "btDeletionReport";
            this.btDeletionReport.Size = new System.Drawing.Size(70, 31);
            this.btDeletionReport.TabIndex = 8;
            this.btDeletionReport.Text = "削除";
            this.btDeletionReport.UseVisualStyleBackColor = true;
            this.btDeletionReport.Click += new System.EventHandler(this.btDeletionReport_Click);
            // 
            // btOpenPicture
            // 
            this.btOpenPicture.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpenPicture.Location = new System.Drawing.Point(748, 83);
            this.btOpenPicture.Name = "btOpenPicture";
            this.btOpenPicture.Size = new System.Drawing.Size(65, 23);
            this.btOpenPicture.TabIndex = 8;
            this.btOpenPicture.Text = "開く...";
            this.btOpenPicture.UseVisualStyleBackColor = true;
            this.btOpenPicture.Click += new System.EventHandler(this.btOpenPicture_Click);
            // 
            // btPictureClear
            // 
            this.btPictureClear.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPictureClear.Location = new System.Drawing.Point(827, 83);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(65, 23);
            this.btPictureClear.TabIndex = 8;
            this.btPictureClear.Text = "削除";
            this.btPictureClear.UseVisualStyleBackColor = true;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(702, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "画像：";
            // 
            // pbCarPicture
            // 
            this.pbCarPicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbCarPicture.Location = new System.Drawing.Point(715, 113);
            this.pbCarPicture.Name = "pbCarPicture";
            this.pbCarPicture.Size = new System.Drawing.Size(237, 216);
            this.pbCarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarPicture.TabIndex = 9;
            this.pbCarPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.開くToolStripMenuItem.Text = "開く(O)...";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.保存ToolStripMenuItem.Text = "保存(S)...";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btSaveArticle_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.設定ToolStripMenuItem.Text = "色設定...";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.終了ToolStripMenuItem.Text = "終了(X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btChangeDisplaySettings
            // 
            this.btChangeDisplaySettings.Enabled = false;
            this.btChangeDisplaySettings.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btChangeDisplaySettings.Location = new System.Drawing.Point(906, 83);
            this.btChangeDisplaySettings.Name = "btChangeDisplaySettings";
            this.btChangeDisplaySettings.Size = new System.Drawing.Size(71, 23);
            this.btChangeDisplaySettings.TabIndex = 8;
            this.btChangeDisplaySettings.Text = "表示変更";
            this.btChangeDisplaySettings.UseVisualStyleBackColor = true;
            this.btChangeDisplaySettings.Click += new System.EventHandler(this.btChangeDisplaySettings_Click);
            // 
            // infosys202230DataSet
            // 
            this.infosys202230DataSet.DataSetName = "infosys202230DataSet";
            this.infosys202230DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202230DataSet;
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202230DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.社員TableAdapter = null;
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AllowUserToAddRows = false;
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(104, 381);
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.ReadOnly = true;
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(742, 210);
            this.carReportDBDataGridView.TabIndex = 30;
            this.carReportDBDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDBDataGridView_DataError);
            this.carReportDBDataGridView.Click += new System.EventHandler(this.carReportDBDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dgvCar
            // 
            this.dgvCar.AllowUserToAddRows = false;
            this.dgvCar.AllowUserToDeleteRows = false;
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(869, 381);
            this.dgvCar.MultiSelect = false;
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RowTemplate.Height = 21;
            this.dgvCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCar.Size = new System.Drawing.Size(142, 193);
            this.dgvCar.TabIndex = 0;
            this.dgvCar.Click += new System.EventHandler(this.dgvCar_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(20, 530);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(63, 44);
            this.btUpdate.TabIndex = 31;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 630);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.pbCarPicture);
            this.Controls.Add(this.btChangeDisplaySettings);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.btDeletionReport);
            this.Controls.Add(this.btCorrectReport);
            this.Controls.Add(this.btOpenPicture);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.btSaveArticle);
            this.Controls.Add(this.btConnect);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202230DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSaveArticle;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btCorrectReport;
        private System.Windows.Forms.Button btDeletionReport;
        private System.Windows.Forms.Button btOpenPicture;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbCarPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.Button btChangeDisplaySettings;
        private infosys202230DataSet infosys202230DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202230DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202230DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.Button btUpdate;
    }
}

