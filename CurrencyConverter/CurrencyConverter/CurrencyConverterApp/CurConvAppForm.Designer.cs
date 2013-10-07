namespace CurrencyConverterApp
{
    partial class Currency_Converter
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Currency_Converter));
            this.currency_textBox = new System.Windows.Forms.TextBox();
            this.getData_button = new System.Windows.Forms.Button();
            this.startDate_textBox = new System.Windows.Forms.TextBox();
            this.rate_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDate_label = new System.Windows.Forms.Label();
            this.endDate_textBox = new System.Windows.Forms.TextBox();
            this.endDate_label = new System.Windows.Forms.Label();
            this.currencyA_textBox = new System.Windows.Forms.TextBox();
            this.currencyB_textBox = new System.Windows.Forms.TextBox();
            this.date_textBox = new System.Windows.Forms.TextBox();
            this.currencyA_label = new System.Windows.Forms.Label();
            this.currencyB_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.sumXinA_textBox = new System.Windows.Forms.TextBox();
            this.sumX_label = new System.Windows.Forms.Label();
            this.convert_button = new System.Windows.Forms.Button();
            this.resultIs_label = new System.Windows.Forms.Label();
            this.res_label = new System.Windows.Forms.Label();
            this.rateA_label = new System.Windows.Forms.Label();
            this.rateA_res_label = new System.Windows.Forms.Label();
            this.rateB_label = new System.Windows.Forms.Label();
            this.rateB_res_label = new System.Windows.Forms.Label();
            this.export_button = new System.Windows.Forms.Button();
            this.task1_label = new System.Windows.Forms.Label();
            this.task2_label = new System.Windows.Forms.Label();
            this.task3_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.required_label2 = new System.Windows.Forms.Label();
            this.required_label = new System.Windows.Forms.Label();
            this.required_label5 = new System.Windows.Forms.Label();
            this.required_label4 = new System.Windows.Forms.Label();
            this.required_label3 = new System.Windows.Forms.Label();
            this.required_label6 = new System.Windows.Forms.Label();
            this.required = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currency_textBox
            // 
            this.currency_textBox.Location = new System.Drawing.Point(12, 65);
            this.currency_textBox.Name = "currency_textBox";
            this.currency_textBox.Size = new System.Drawing.Size(368, 20);
            this.currency_textBox.TabIndex = 2;
            this.currency_textBox.Click += new System.EventHandler(this.currency_textbox_Click);
            // 
            // getData_button
            // 
            this.getData_button.Location = new System.Drawing.Point(12, 202);
            this.getData_button.Name = "getData_button";
            this.getData_button.Size = new System.Drawing.Size(368, 23);
            this.getData_button.TabIndex = 0;
            this.getData_button.Text = "Get data!";
            this.getData_button.UseVisualStyleBackColor = true;
            this.getData_button.Click += new System.EventHandler(this.getData_Click);
            // 
            // startDate_textBox
            // 
            this.startDate_textBox.Location = new System.Drawing.Point(12, 113);
            this.startDate_textBox.Name = "startDate_textBox";
            this.startDate_textBox.Size = new System.Drawing.Size(368, 20);
            this.startDate_textBox.TabIndex = 3;
            this.startDate_textBox.Click += new System.EventHandler(this.startDate_textBox_Click);
            // 
            // rate_label
            // 
            this.rate_label.AutoSize = true;
            this.rate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rate_label.Location = new System.Drawing.Point(15, 228);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(62, 18);
            this.rate_label.TabIndex = 4;
            this.rate_label.Text = "Rate is: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currency:";
            // 
            // StartDate_label
            // 
            this.StartDate_label.AutoSize = true;
            this.StartDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate_label.Location = new System.Drawing.Point(15, 93);
            this.StartDate_label.Name = "StartDate_label";
            this.StartDate_label.Size = new System.Drawing.Size(75, 18);
            this.StartDate_label.TabIndex = 6;
            this.StartDate_label.Text = "Start time:";
            // 
            // endDate_textBox
            // 
            this.endDate_textBox.Location = new System.Drawing.Point(12, 162);
            this.endDate_textBox.Name = "endDate_textBox";
            this.endDate_textBox.Size = new System.Drawing.Size(368, 20);
            this.endDate_textBox.TabIndex = 7;
            this.endDate_textBox.Click += new System.EventHandler(this.endDate_textBox_Click);
            // 
            // endDate_label
            // 
            this.endDate_label.AutoSize = true;
            this.endDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate_label.Location = new System.Drawing.Point(15, 142);
            this.endDate_label.Name = "endDate_label";
            this.endDate_label.Size = new System.Drawing.Size(75, 18);
            this.endDate_label.TabIndex = 8;
            this.endDate_label.Text = "End Time:";
            // 
            // currencyA_textBox
            // 
            this.currencyA_textBox.Location = new System.Drawing.Point(386, 65);
            this.currencyA_textBox.Name = "currencyA_textBox";
            this.currencyA_textBox.Size = new System.Drawing.Size(368, 20);
            this.currencyA_textBox.TabIndex = 12;
            this.currencyA_textBox.Click += new System.EventHandler(this.currencyA_textBox_Click);
            // 
            // currencyB_textBox
            // 
            this.currencyB_textBox.Location = new System.Drawing.Point(387, 112);
            this.currencyB_textBox.Name = "currencyB_textBox";
            this.currencyB_textBox.Size = new System.Drawing.Size(367, 20);
            this.currencyB_textBox.TabIndex = 13;
            this.currencyB_textBox.Click += new System.EventHandler(this.currencyB_textBox_Click);
            // 
            // date_textBox
            // 
            this.date_textBox.Location = new System.Drawing.Point(387, 161);
            this.date_textBox.Name = "date_textBox";
            this.date_textBox.Size = new System.Drawing.Size(367, 20);
            this.date_textBox.TabIndex = 14;
            this.date_textBox.Click += new System.EventHandler(this.date_textBox_Click);
            // 
            // currencyA_label
            // 
            this.currencyA_label.AutoSize = true;
            this.currencyA_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyA_label.Location = new System.Drawing.Point(389, 45);
            this.currencyA_label.Name = "currencyA_label";
            this.currencyA_label.Size = new System.Drawing.Size(95, 18);
            this.currencyA_label.TabIndex = 15;
            this.currencyA_label.Text = "Currency \"A\":";
            // 
            // currencyB_label
            // 
            this.currencyB_label.AutoSize = true;
            this.currencyB_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyB_label.Location = new System.Drawing.Point(390, 92);
            this.currencyB_label.Name = "currencyB_label";
            this.currencyB_label.Size = new System.Drawing.Size(96, 18);
            this.currencyB_label.TabIndex = 16;
            this.currencyB_label.Text = "Currency \"B\":";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_label.Location = new System.Drawing.Point(390, 141);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(43, 18);
            this.date_label.TabIndex = 17;
            this.date_label.Text = "Date:";
            // 
            // sumXinA_textBox
            // 
            this.sumXinA_textBox.Location = new System.Drawing.Point(386, 211);
            this.sumXinA_textBox.Name = "sumXinA_textBox";
            this.sumXinA_textBox.Size = new System.Drawing.Size(368, 20);
            this.sumXinA_textBox.TabIndex = 18;
            this.sumXinA_textBox.Click += new System.EventHandler(this.sumXinA_textBox_Click);
            // 
            // sumX_label
            // 
            this.sumX_label.AutoSize = true;
            this.sumX_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumX_label.Location = new System.Drawing.Point(389, 191);
            this.sumX_label.Name = "sumX_label";
            this.sumX_label.Size = new System.Drawing.Size(182, 18);
            this.sumX_label.TabIndex = 19;
            this.sumX_label.Text = "Sum «Х»  in currency «А»:";
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(387, 249);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(367, 23);
            this.convert_button.TabIndex = 20;
            this.convert_button.Text = "Convert!";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // resultIs_label
            // 
            this.resultIs_label.AutoSize = true;
            this.resultIs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultIs_label.Location = new System.Drawing.Point(389, 338);
            this.resultIs_label.Name = "resultIs_label";
            this.resultIs_label.Size = new System.Drawing.Size(166, 18);
            this.resultIs_label.TabIndex = 21;
            this.resultIs_label.Text = "Sum \"Y\" in currency \"B\":";
            // 
            // res_label
            // 
            this.res_label.AutoSize = true;
            this.res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_label.Location = new System.Drawing.Point(566, 338);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(0, 18);
            this.res_label.TabIndex = 22;
            // 
            // rateA_label
            // 
            this.rateA_label.AutoSize = true;
            this.rateA_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateA_label.Location = new System.Drawing.Point(391, 283);
            this.rateA_label.Name = "rateA_label";
            this.rateA_label.Size = new System.Drawing.Size(144, 18);
            this.rateA_label.TabIndex = 23;
            this.rateA_label.Text = "Rate of currency \"A\":";
            // 
            // rateA_res_label
            // 
            this.rateA_res_label.AutoSize = true;
            this.rateA_res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateA_res_label.Location = new System.Drawing.Point(541, 283);
            this.rateA_res_label.Name = "rateA_res_label";
            this.rateA_res_label.Size = new System.Drawing.Size(0, 18);
            this.rateA_res_label.TabIndex = 24;
            // 
            // rateB_label
            // 
            this.rateB_label.AutoSize = true;
            this.rateB_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateB_label.Location = new System.Drawing.Point(390, 301);
            this.rateB_label.Name = "rateB_label";
            this.rateB_label.Size = new System.Drawing.Size(145, 18);
            this.rateB_label.TabIndex = 25;
            this.rateB_label.Text = "Rate of currency \"B\":";
            // 
            // rateB_res_label
            // 
            this.rateB_res_label.AutoSize = true;
            this.rateB_res_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateB_res_label.Location = new System.Drawing.Point(541, 301);
            this.rateB_res_label.Name = "rateB_res_label";
            this.rateB_res_label.Size = new System.Drawing.Size(0, 18);
            this.rateB_res_label.TabIndex = 26;
            // 
            // export_button
            // 
            this.export_button.Enabled = false;
            this.export_button.Location = new System.Drawing.Point(12, 531);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(368, 23);
            this.export_button.TabIndex = 27;
            this.export_button.Text = "Export results to .csv file!";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // task1_label
            // 
            this.task1_label.AutoSize = true;
            this.task1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1_label.Location = new System.Drawing.Point(164, 9);
            this.task1_label.Name = "task1_label";
            this.task1_label.Size = new System.Drawing.Size(62, 20);
            this.task1_label.TabIndex = 28;
            this.task1_label.Text = "Task 1";
            // 
            // task2_label
            // 
            this.task2_label.AutoSize = true;
            this.task2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2_label.Location = new System.Drawing.Point(540, 9);
            this.task2_label.Name = "task2_label";
            this.task2_label.Size = new System.Drawing.Size(62, 20);
            this.task2_label.TabIndex = 29;
            this.task2_label.Text = "Task 2";
            // 
            // task3_label
            // 
            this.task3_label.AutoSize = true;
            this.task3_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task3_label.Location = new System.Drawing.Point(153, 502);
            this.task3_label.Name = "task3_label";
            this.task3_label.Size = new System.Drawing.Size(62, 20);
            this.task3_label.TabIndex = 30;
            this.task3_label.Text = "Task 3";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.Location = new System.Drawing.Point(12, 249);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(368, 250);
            this.dataGridView.TabIndex = 32;
            // 
            // required_label2
            // 
            this.required_label2.AutoSize = true;
            this.required_label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required_label2.ForeColor = System.Drawing.Color.Red;
            this.required_label2.Location = new System.Drawing.Point(87, 137);
            this.required_label2.Name = "required_label2";
            this.required_label2.Size = new System.Drawing.Size(21, 24);
            this.required_label2.TabIndex = 33;
            this.required_label2.Text = "*";
            // 
            // required_label
            // 
            this.required_label.AutoSize = true;
            this.required_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required_label.ForeColor = System.Drawing.Color.Red;
            this.required_label.Location = new System.Drawing.Point(86, 88);
            this.required_label.Name = "required_label";
            this.required_label.Size = new System.Drawing.Size(21, 24);
            this.required_label.TabIndex = 34;
            this.required_label.Text = "*";
            // 
            // required_label5
            // 
            this.required_label5.AutoSize = true;
            this.required_label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required_label5.ForeColor = System.Drawing.Color.Red;
            this.required_label5.Location = new System.Drawing.Point(428, 135);
            this.required_label5.Name = "required_label5";
            this.required_label5.Size = new System.Drawing.Size(21, 24);
            this.required_label5.TabIndex = 35;
            this.required_label5.Text = "*";
            // 
            // required_label4
            // 
            this.required_label4.AutoSize = true;
            this.required_label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required_label4.ForeColor = System.Drawing.Color.Red;
            this.required_label4.Location = new System.Drawing.Point(483, 86);
            this.required_label4.Name = "required_label4";
            this.required_label4.Size = new System.Drawing.Size(21, 24);
            this.required_label4.TabIndex = 36;
            this.required_label4.Text = "*";
            // 
            // required_label3
            // 
            this.required_label3.AutoSize = true;
            this.required_label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required_label3.ForeColor = System.Drawing.Color.Red;
            this.required_label3.Location = new System.Drawing.Point(481, 41);
            this.required_label3.Name = "required_label3";
            this.required_label3.Size = new System.Drawing.Size(21, 24);
            this.required_label3.TabIndex = 37;
            this.required_label3.Text = "*";
            // 
            // required_label6
            // 
            this.required_label6.AutoSize = true;
            this.required_label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required_label6.ForeColor = System.Drawing.Color.Red;
            this.required_label6.Location = new System.Drawing.Point(567, 184);
            this.required_label6.Name = "required_label6";
            this.required_label6.Size = new System.Drawing.Size(21, 24);
            this.required_label6.TabIndex = 38;
            this.required_label6.Text = "*";
            // 
            // required
            // 
            this.required.AutoSize = true;
            this.required.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.required.ForeColor = System.Drawing.Color.Red;
            this.required.Location = new System.Drawing.Point(628, 531);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(126, 19);
            this.required.TabIndex = 39;
            this.required.Text = "* - required fields";
            // 
            // Currency_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(767, 566);
            this.Controls.Add(this.required);
            this.Controls.Add(this.required_label6);
            this.Controls.Add(this.required_label3);
            this.Controls.Add(this.required_label4);
            this.Controls.Add(this.required_label5);
            this.Controls.Add(this.required_label);
            this.Controls.Add(this.required_label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.task3_label);
            this.Controls.Add(this.task2_label);
            this.Controls.Add(this.task1_label);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.rateB_res_label);
            this.Controls.Add(this.rateB_label);
            this.Controls.Add(this.rateA_res_label);
            this.Controls.Add(this.rateA_label);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.resultIs_label);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.sumX_label);
            this.Controls.Add(this.sumXinA_textBox);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.currencyB_label);
            this.Controls.Add(this.currencyA_label);
            this.Controls.Add(this.date_textBox);
            this.Controls.Add(this.currencyB_textBox);
            this.Controls.Add(this.currencyA_textBox);
            this.Controls.Add(this.endDate_label);
            this.Controls.Add(this.endDate_textBox);
            this.Controls.Add(this.StartDate_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rate_label);
            this.Controls.Add(this.startDate_textBox);
            this.Controls.Add(this.getData_button);
            this.Controls.Add(this.currency_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(775, 600);
            this.MinimumSize = new System.Drawing.Size(775, 600);
            this.Name = "Currency_Converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currency_textBox;
        private System.Windows.Forms.Button getData_button;
        private System.Windows.Forms.TextBox startDate_textBox;
        private System.Windows.Forms.Label rate_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartDate_label;
        private System.Windows.Forms.TextBox endDate_textBox;
        private System.Windows.Forms.Label endDate_label;
        private System.Windows.Forms.TextBox currencyA_textBox;
        private System.Windows.Forms.TextBox currencyB_textBox;
        private System.Windows.Forms.TextBox date_textBox;
        private System.Windows.Forms.Label currencyA_label;
        private System.Windows.Forms.Label currencyB_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox sumXinA_textBox;
        private System.Windows.Forms.Label sumX_label;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Label resultIs_label;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.Label rateA_label;
        private System.Windows.Forms.Label rateA_res_label;
        private System.Windows.Forms.Label rateB_label;
        private System.Windows.Forms.Label rateB_res_label;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Label task1_label;
        private System.Windows.Forms.Label task2_label;
        private System.Windows.Forms.Label task3_label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label required_label2;
        private System.Windows.Forms.Label required_label;
        private System.Windows.Forms.Label required_label5;
        private System.Windows.Forms.Label required_label4;
        private System.Windows.Forms.Label required_label3;
        private System.Windows.Forms.Label required_label6;
        private System.Windows.Forms.Label required;
    }
}

