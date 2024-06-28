namespace 程式化語法存取資料庫
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.btn資料新增 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn資料測試 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.txt點數 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbox進階搜尋結果 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio婚姻已婚 = new System.Windows.Forms.RadioButton();
            this.radio婚姻單身 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radio婚姻全部 = new System.Windows.Forms.RadioButton();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txt搜尋關鍵字 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn資料刪除);
            this.groupBox1.Controls.Add(this.btn資料新增);
            this.groupBox1.Controls.Add(this.btn資料修改);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Controls.Add(this.btn資料測試);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 662);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(16, 489);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(169, 58);
            this.btn清空欄位.TabIndex = 5;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn資料刪除
            // 
            this.btn資料刪除.Location = new System.Drawing.Point(16, 402);
            this.btn資料刪除.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn資料刪除.Name = "btn資料刪除";
            this.btn資料刪除.Size = new System.Drawing.Size(169, 58);
            this.btn資料刪除.TabIndex = 4;
            this.btn資料刪除.Text = "資料刪除";
            this.btn資料刪除.UseVisualStyleBackColor = true;
            this.btn資料刪除.Click += new System.EventHandler(this.btn資料刪除_Click);
            // 
            // btn資料新增
            // 
            this.btn資料新增.Location = new System.Drawing.Point(16, 315);
            this.btn資料新增.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn資料新增.Name = "btn資料新增";
            this.btn資料新增.Size = new System.Drawing.Size(169, 58);
            this.btn資料新增.TabIndex = 3;
            this.btn資料新增.Text = "資料新增";
            this.btn資料新增.UseVisualStyleBackColor = true;
            this.btn資料新增.Click += new System.EventHandler(this.btn資料新增_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.Location = new System.Drawing.Point(16, 228);
            this.btn資料修改.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(169, 58);
            this.btn資料修改.TabIndex = 2;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = true;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Location = new System.Drawing.Point(16, 142);
            this.btn資料搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(169, 58);
            this.btn資料搜尋.TabIndex = 1;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // btn資料測試
            // 
            this.btn資料測試.Location = new System.Drawing.Point(16, 60);
            this.btn資料測試.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn資料測試.Name = "btn資料測試";
            this.btn資料測試.Size = new System.Drawing.Size(169, 58);
            this.btn資料測試.TabIndex = 0;
            this.btn資料測試.Text = "資料測試";
            this.btn資料測試.UseVisualStyleBackColor = true;
            this.btn資料測試.Click += new System.EventHandler(this.btn資料測試_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chk婚姻狀態);
            this.groupBox2.Controls.Add(this.dtp生日);
            this.groupBox2.Controls.Add(this.txt點數);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txt地址);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(219, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(357, 662);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料欄位";
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk婚姻狀態.Location = new System.Drawing.Point(148, 344);
            this.chk婚姻狀態.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(81, 33);
            this.chk婚姻狀態.TabIndex = 33;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(71, 288);
            this.dtp生日.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(281, 38);
            this.dtp生日.TabIndex = 32;
            // 
            // txt點數
            // 
            this.txt點數.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt點數.Location = new System.Drawing.Point(71, 398);
            this.txt點數.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt點數.Name = "txt點數";
            this.txt點數.Size = new System.Drawing.Size(249, 38);
            this.txt點數.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(71, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 38);
            this.txtEmail.TabIndex = 30;
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(71, 192);
            this.txt地址.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(281, 38);
            this.txt地址.TabIndex = 29;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(71, 148);
            this.txt電話.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(281, 38);
            this.txt電話.TabIndex = 28;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(71, 100);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(281, 38);
            this.txt姓名.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(71, 52);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(249, 38);
            this.txtID.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(5, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "點數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(5, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "婚姻狀態";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(5, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "電話";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(5, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(5, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(5, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(5, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.lbox進階搜尋結果);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.dtp結束時間);
            this.groupBox3.Controls.Add(this.dtp開始時間);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn搜尋);
            this.groupBox3.Controls.Add(this.cbox欄位名稱);
            this.groupBox3.Controls.Add(this.txt搜尋關鍵字);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(595, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(335, 662);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "進階搜尋";
            // 
            // lbox進階搜尋結果
            // 
            this.lbox進階搜尋結果.FormattingEnabled = true;
            this.lbox進階搜尋結果.ItemHeight = 34;
            this.lbox進階搜尋結果.Location = new System.Drawing.Point(12, 472);
            this.lbox進階搜尋結果.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox進階搜尋結果.Name = "lbox進階搜尋結果";
            this.lbox進階搜尋結果.Size = new System.Drawing.Size(317, 106);
            this.lbox進階搜尋結果.TabIndex = 12;
            this.lbox進階搜尋結果.SelectedIndexChanged += new System.EventHandler(this.lbox進階搜尋結果_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.radio婚姻已婚);
            this.groupBox5.Controls.Add(this.radio婚姻單身);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radio婚姻全部);
            this.groupBox5.Location = new System.Drawing.Point(11, 342);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(317, 92);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // radio婚姻已婚
            // 
            this.radio婚姻已婚.AutoSize = true;
            this.radio婚姻已婚.Location = new System.Drawing.Point(211, 32);
            this.radio婚姻已婚.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio婚姻已婚.Name = "radio婚姻已婚";
            this.radio婚姻已婚.Size = new System.Drawing.Size(92, 39);
            this.radio婚姻已婚.TabIndex = 3;
            this.radio婚姻已婚.TabStop = true;
            this.radio婚姻已婚.Text = "已婚";
            this.radio婚姻已婚.UseVisualStyleBackColor = true;
            this.radio婚姻已婚.CheckedChanged += new System.EventHandler(this.radio婚姻已婚_CheckedChanged);
            // 
            // radio婚姻單身
            // 
            this.radio婚姻單身.AutoSize = true;
            this.radio婚姻單身.Location = new System.Drawing.Point(113, 32);
            this.radio婚姻單身.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio婚姻單身.Name = "radio婚姻單身";
            this.radio婚姻單身.Size = new System.Drawing.Size(92, 39);
            this.radio婚姻單身.TabIndex = 2;
            this.radio婚姻單身.TabStop = true;
            this.radio婚姻單身.Text = "單身";
            this.radio婚姻單身.UseVisualStyleBackColor = true;
            this.radio婚姻單身.CheckedChanged += new System.EventHandler(this.radio婚姻單身_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 32);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 39);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "全部";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radio婚姻全部
            // 
            this.radio婚姻全部.AutoSize = true;
            this.radio婚姻全部.Location = new System.Drawing.Point(5, 32);
            this.radio婚姻全部.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio婚姻全部.Name = "radio婚姻全部";
            this.radio婚姻全部.Size = new System.Drawing.Size(92, 39);
            this.radio婚姻全部.TabIndex = 0;
            this.radio婚姻全部.TabStop = true;
            this.radio婚姻全部.Text = "全部";
            this.radio婚姻全部.UseVisualStyleBackColor = true;
            this.radio婚姻全部.CheckedChanged += new System.EventHandler(this.radio婚姻全部_CheckedChanged);
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Location = new System.Drawing.Point(44, 258);
            this.dtp結束時間.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(284, 43);
            this.dtp結束時間.TabIndex = 10;
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.Location = new System.Drawing.Point(45, 205);
            this.dtp開始時間.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(284, 43);
            this.dtp開始時間.TabIndex = 9;
            this.dtp開始時間.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(5, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "到";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(5, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "從";
            // 
            // btn搜尋
            // 
            this.btn搜尋.Location = new System.Drawing.Point(195, 128);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(135, 50);
            this.btn搜尋.TabIndex = 6;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox欄位名稱
            // 
            this.cbox欄位名稱.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox欄位名稱.FormattingEnabled = true;
            this.cbox欄位名稱.Location = new System.Drawing.Point(195, 80);
            this.cbox欄位名稱.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox欄位名稱.Name = "cbox欄位名稱";
            this.cbox欄位名稱.Size = new System.Drawing.Size(135, 42);
            this.cbox欄位名稱.TabIndex = 5;
            // 
            // txt搜尋關鍵字
            // 
            this.txt搜尋關鍵字.Location = new System.Drawing.Point(5, 80);
            this.txt搜尋關鍵字.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt搜尋關鍵字.Name = "txt搜尋關鍵字";
            this.txt搜尋關鍵字.Size = new System.Drawing.Size(181, 43);
            this.txt搜尋關鍵字.TabIndex = 4;
            this.txt搜尋關鍵字.TextChanged += new System.EventHandler(this.txt搜尋關鍵字_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(5, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "搜尋結果";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(5, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "婚姻狀態選擇";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(5, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "生日區間指定";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(0, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "欄位關鍵字搜尋";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(935, 21);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1009, 662);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "所有會員資料";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(984, 604);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1936, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn資料刪除;
        private System.Windows.Forms.Button btn資料新增;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.Button btn資料測試;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.TextBox txt點數;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbox進階搜尋結果;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio婚姻已婚;
        private System.Windows.Forms.RadioButton radio婚姻單身;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radio婚姻全部;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox欄位名稱;
        private System.Windows.Forms.TextBox txt搜尋關鍵字;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

