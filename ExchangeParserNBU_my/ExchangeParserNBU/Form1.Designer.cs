
namespace ExchangeParserNBU
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ExitButton = new System.Windows.Forms.Button();
            this.comboBox_First = new System.Windows.Forms.ComboBox();
            this.comboBox_Second = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.labelDate3 = new System.Windows.Forms.Label();
            this.labelDate4 = new System.Windows.Forms.Label();
            this.labelDate7 = new System.Windows.Forms.Label();
            this.labelDate6 = new System.Windows.Forms.Label();
            this.labelDate5 = new System.Windows.Forms.Label();
            this.labelCurrency1_7 = new System.Windows.Forms.Label();
            this.labelCurrency1_6 = new System.Windows.Forms.Label();
            this.labelCurrency1_5 = new System.Windows.Forms.Label();
            this.labelCurrency1_4 = new System.Windows.Forms.Label();
            this.labelCurrency1_3 = new System.Windows.Forms.Label();
            this.labelCurrency1_2 = new System.Windows.Forms.Label();
            this.labelCurrency1_1 = new System.Windows.Forms.Label();
            this.labelCurrency2_7 = new System.Windows.Forms.Label();
            this.labelCurrency2_6 = new System.Windows.Forms.Label();
            this.labelCurrency2_5 = new System.Windows.Forms.Label();
            this.labelCurrency2_4 = new System.Windows.Forms.Label();
            this.labelCurrency2_3 = new System.Windows.Forms.Label();
            this.labelCurrency2_2 = new System.Windows.Forms.Label();
            this.labelCurrency2_1 = new System.Windows.Forms.Label();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.labelMinimum = new System.Windows.Forms.Label();
            this.labelCurrency1 = new System.Windows.Forms.Label();
            this.labelCurrency2 = new System.Windows.Forms.Label();
            this.labelMaxCur1 = new System.Windows.Forms.Label();
            this.labelMinCur1 = new System.Windows.Forms.Label();
            this.labelMaxCur2 = new System.Windows.Forms.Label();
            this.labelMinCur2 = new System.Windows.Forms.Label();
            this.Graph1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Graph2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1321, 15);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 87);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = " X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // comboBox_First
            // 
            this.comboBox_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_First.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_First.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox_First.FormattingEnabled = true;
            this.comboBox_First.Items.AddRange(new object[] {
            "AUD",
            "BYN",
            "BGN",
            "KRW",
            "HKD",
            "DKK",
            "USD",
            "EUR",
            "EGP",
            "JPY",
            "PLN",
            "INR",
            "CAD",
            "HRK",
            "MXN",
            "MDL",
            "ILS",
            "NZD",
            "NOK",
            "ZAR",
            "RUB",
            "RON",
            "IDR",
            "SAR",
            "SGD",
            "XDR",
            "KZT",
            "TRY",
            "HUF",
            "GBP",
            "CZK",
            "SEK",
            "CHF",
            "CNY",
            "AZN",
            "DZD",
            "THB",
            "BRL",
            "AMD",
            "AED",
            "VND",
            "IQD",
            "IRR",
            "GEL",
            "LBP",
            "LYD",
            "MYR",
            "MAD",
            "PKR",
            "RSD",
            "KGS",
            "TJS",
            "BDT",
            "TND",
            "TMT",
            "UZS",
            "XAU",
            "XAG",
            "XPT",
            "XPD"});
            this.comboBox_First.Location = new System.Drawing.Point(235, 151);
            this.comboBox_First.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox_First.Name = "comboBox_First";
            this.comboBox_First.Size = new System.Drawing.Size(186, 37);
            this.comboBox_First.TabIndex = 1;
            // 
            // comboBox_Second
            // 
            this.comboBox_Second.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Second.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Second.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox_Second.FormattingEnabled = true;
            this.comboBox_Second.Items.AddRange(new object[] {
            "AUD",
            "BYN",
            "BGN",
            "KRW",
            "HKD",
            "DKK",
            "USD",
            "EUR",
            "EGP",
            "JPY",
            "PLN",
            "INR",
            "CAD",
            "HRK",
            "MXN",
            "MDL",
            "ILS",
            "NZD",
            "NOK",
            "ZAR",
            "RUB",
            "RON",
            "IDR",
            "SAR",
            "SGD",
            "XDR",
            "KZT",
            "TRY",
            "HUF",
            "GBP",
            "CZK",
            "SEK",
            "CHF",
            "CNY",
            "AZN",
            "DZD",
            "THB",
            "BRL",
            "AMD",
            "AED",
            "VND",
            "IQD",
            "IRR",
            "GEL",
            "LBP",
            "LYD",
            "MYR",
            "MAD",
            "PKR",
            "RSD",
            "KGS",
            "TJS",
            "BDT",
            "TND",
            "TMT",
            "UZS",
            "XAU",
            "XAG",
            "XPT",
            "XPD"});
            this.comboBox_Second.Location = new System.Drawing.Point(465, 150);
            this.comboBox_Second.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox_Second.Name = "comboBox_Second";
            this.comboBox_Second.Size = new System.Drawing.Size(186, 37);
            this.comboBox_Second.TabIndex = 2;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePicker.CalendarForeColor = System.Drawing.Color.SlateBlue;
            this.DateTimePicker.CalendarMonthBackground = System.Drawing.Color.OrangeRed;
            this.DateTimePicker.CalendarTitleBackColor = System.Drawing.Color.SlateBlue;
            this.DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SlateBlue;
            this.DateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.SlateBlue;
            this.DateTimePicker.Checked = false;
            this.DateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(222, 46);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTimePicker.Size = new System.Drawing.Size(509, 37);
            this.DateTimePicker.TabIndex = 3;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.ChangeDaysByCalendar);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ConfirmButton.Location = new System.Drawing.Point(465, 684);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(308, 138);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "CHECK";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate1.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate1.Location = new System.Drawing.Point(28, 244);
            this.labelDate1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(81, 45);
            this.labelDate1.TabIndex = 5;
            this.labelDate1.Text = "Day 1";
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate2.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate2.Location = new System.Drawing.Point(28, 291);
            this.labelDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(86, 45);
            this.labelDate2.TabIndex = 6;
            this.labelDate2.Text = "Day 2";
            // 
            // labelDate3
            // 
            this.labelDate3.AutoSize = true;
            this.labelDate3.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate3.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate3.Location = new System.Drawing.Point(28, 339);
            this.labelDate3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate3.Name = "labelDate3";
            this.labelDate3.Size = new System.Drawing.Size(86, 45);
            this.labelDate3.TabIndex = 7;
            this.labelDate3.Text = "Day 3";
            // 
            // labelDate4
            // 
            this.labelDate4.AutoSize = true;
            this.labelDate4.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate4.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate4.Location = new System.Drawing.Point(28, 381);
            this.labelDate4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate4.Name = "labelDate4";
            this.labelDate4.Size = new System.Drawing.Size(87, 45);
            this.labelDate4.TabIndex = 8;
            this.labelDate4.Text = "Day 4";
            // 
            // labelDate7
            // 
            this.labelDate7.AutoSize = true;
            this.labelDate7.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate7.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate7.Location = new System.Drawing.Point(28, 510);
            this.labelDate7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate7.Name = "labelDate7";
            this.labelDate7.Size = new System.Drawing.Size(85, 45);
            this.labelDate7.TabIndex = 11;
            this.labelDate7.Text = "Day 7";
            // 
            // labelDate6
            // 
            this.labelDate6.AutoSize = true;
            this.labelDate6.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate6.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate6.Location = new System.Drawing.Point(28, 466);
            this.labelDate6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate6.Name = "labelDate6";
            this.labelDate6.Size = new System.Drawing.Size(85, 45);
            this.labelDate6.TabIndex = 10;
            this.labelDate6.Text = "Day 6";
            // 
            // labelDate5
            // 
            this.labelDate5.AutoSize = true;
            this.labelDate5.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate5.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelDate5.Location = new System.Drawing.Point(28, 424);
            this.labelDate5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate5.Name = "labelDate5";
            this.labelDate5.Size = new System.Drawing.Size(86, 45);
            this.labelDate5.TabIndex = 9;
            this.labelDate5.Text = "Day 5";
            // 
            // labelCurrency1_7
            // 
            this.labelCurrency1_7.AutoSize = true;
            this.labelCurrency1_7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_7.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_7.Location = new System.Drawing.Point(228, 512);
            this.labelCurrency1_7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_7.Name = "labelCurrency1_7";
            this.labelCurrency1_7.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_7.TabIndex = 18;
            this.labelCurrency1_7.Text = "_________________";
            // 
            // labelCurrency1_6
            // 
            this.labelCurrency1_6.AutoSize = true;
            this.labelCurrency1_6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_6.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_6.Location = new System.Drawing.Point(228, 469);
            this.labelCurrency1_6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_6.Name = "labelCurrency1_6";
            this.labelCurrency1_6.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_6.TabIndex = 17;
            this.labelCurrency1_6.Text = "_________________";
            // 
            // labelCurrency1_5
            // 
            this.labelCurrency1_5.AutoSize = true;
            this.labelCurrency1_5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_5.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_5.Location = new System.Drawing.Point(228, 426);
            this.labelCurrency1_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_5.Name = "labelCurrency1_5";
            this.labelCurrency1_5.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_5.TabIndex = 16;
            this.labelCurrency1_5.Text = "_________________";
            // 
            // labelCurrency1_4
            // 
            this.labelCurrency1_4.AutoSize = true;
            this.labelCurrency1_4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_4.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_4.Location = new System.Drawing.Point(228, 384);
            this.labelCurrency1_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_4.Name = "labelCurrency1_4";
            this.labelCurrency1_4.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_4.TabIndex = 15;
            this.labelCurrency1_4.Text = "_________________";
            // 
            // labelCurrency1_3
            // 
            this.labelCurrency1_3.AutoSize = true;
            this.labelCurrency1_3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_3.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_3.Location = new System.Drawing.Point(228, 341);
            this.labelCurrency1_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_3.Name = "labelCurrency1_3";
            this.labelCurrency1_3.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_3.TabIndex = 14;
            this.labelCurrency1_3.Text = "_________________";
            // 
            // labelCurrency1_2
            // 
            this.labelCurrency1_2.AutoSize = true;
            this.labelCurrency1_2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_2.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_2.Location = new System.Drawing.Point(228, 291);
            this.labelCurrency1_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_2.Name = "labelCurrency1_2";
            this.labelCurrency1_2.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_2.TabIndex = 13;
            this.labelCurrency1_2.Text = "_________________";
            // 
            // labelCurrency1_1
            // 
            this.labelCurrency1_1.AutoSize = true;
            this.labelCurrency1_1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1_1.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency1_1.Location = new System.Drawing.Point(228, 244);
            this.labelCurrency1_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1_1.Name = "labelCurrency1_1";
            this.labelCurrency1_1.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency1_1.TabIndex = 12;
            this.labelCurrency1_1.Text = "_________________";
            // 
            // labelCurrency2_7
            // 
            this.labelCurrency2_7.AutoSize = true;
            this.labelCurrency2_7.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_7.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_7.Location = new System.Drawing.Point(458, 512);
            this.labelCurrency2_7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_7.Name = "labelCurrency2_7";
            this.labelCurrency2_7.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_7.TabIndex = 25;
            this.labelCurrency2_7.Text = "_________________";
            // 
            // labelCurrency2_6
            // 
            this.labelCurrency2_6.AutoSize = true;
            this.labelCurrency2_6.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_6.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_6.Location = new System.Drawing.Point(458, 469);
            this.labelCurrency2_6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_6.Name = "labelCurrency2_6";
            this.labelCurrency2_6.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_6.TabIndex = 24;
            this.labelCurrency2_6.Text = "_________________";
            // 
            // labelCurrency2_5
            // 
            this.labelCurrency2_5.AutoSize = true;
            this.labelCurrency2_5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_5.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_5.Location = new System.Drawing.Point(458, 426);
            this.labelCurrency2_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_5.Name = "labelCurrency2_5";
            this.labelCurrency2_5.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_5.TabIndex = 23;
            this.labelCurrency2_5.Text = "_________________";
            // 
            // labelCurrency2_4
            // 
            this.labelCurrency2_4.AutoSize = true;
            this.labelCurrency2_4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_4.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_4.Location = new System.Drawing.Point(458, 384);
            this.labelCurrency2_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_4.Name = "labelCurrency2_4";
            this.labelCurrency2_4.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_4.TabIndex = 22;
            this.labelCurrency2_4.Text = "_________________";
            // 
            // labelCurrency2_3
            // 
            this.labelCurrency2_3.AutoSize = true;
            this.labelCurrency2_3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_3.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_3.Location = new System.Drawing.Point(458, 341);
            this.labelCurrency2_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_3.Name = "labelCurrency2_3";
            this.labelCurrency2_3.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_3.TabIndex = 21;
            this.labelCurrency2_3.Text = "_________________";
            // 
            // labelCurrency2_2
            // 
            this.labelCurrency2_2.AutoSize = true;
            this.labelCurrency2_2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_2.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_2.Location = new System.Drawing.Point(458, 294);
            this.labelCurrency2_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_2.Name = "labelCurrency2_2";
            this.labelCurrency2_2.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_2.TabIndex = 20;
            this.labelCurrency2_2.Text = "_________________";
            // 
            // labelCurrency2_1
            // 
            this.labelCurrency2_1.AutoSize = true;
            this.labelCurrency2_1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2_1.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCurrency2_1.Location = new System.Drawing.Point(458, 246);
            this.labelCurrency2_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2_1.Name = "labelCurrency2_1";
            this.labelCurrency2_1.Size = new System.Drawing.Size(205, 41);
            this.labelCurrency2_1.TabIndex = 19;
            this.labelCurrency2_1.Text = "_________________";
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaximum.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelMaximum.Location = new System.Drawing.Point(130, 666);
            this.labelMaximum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(139, 45);
            this.labelMaximum.TabIndex = 26;
            this.labelMaximum.Text = "Maximum";
            // 
            // labelMinimum
            // 
            this.labelMinimum.AutoSize = true;
            this.labelMinimum.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinimum.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelMinimum.Location = new System.Drawing.Point(299, 666);
            this.labelMinimum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimum.Name = "labelMinimum";
            this.labelMinimum.Size = new System.Drawing.Size(131, 45);
            this.labelMinimum.TabIndex = 27;
            this.labelMinimum.Text = "Minimum";
            // 
            // labelCurrency1
            // 
            this.labelCurrency1.AutoSize = true;
            this.labelCurrency1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency1.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelCurrency1.Location = new System.Drawing.Point(2, 709);
            this.labelCurrency1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency1.Name = "labelCurrency1";
            this.labelCurrency1.Size = new System.Drawing.Size(147, 45);
            this.labelCurrency1.TabIndex = 28;
            this.labelCurrency1.Text = "Currency 1";
            // 
            // labelCurrency2
            // 
            this.labelCurrency2.AutoSize = true;
            this.labelCurrency2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency2.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelCurrency2.Location = new System.Drawing.Point(2, 778);
            this.labelCurrency2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency2.Name = "labelCurrency2";
            this.labelCurrency2.Size = new System.Drawing.Size(152, 45);
            this.labelCurrency2.TabIndex = 29;
            this.labelCurrency2.Text = "Currency 2";
            // 
            // labelMaxCur1
            // 
            this.labelMaxCur1.AutoSize = true;
            this.labelMaxCur1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxCur1.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMaxCur1.Location = new System.Drawing.Point(148, 711);
            this.labelMaxCur1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxCur1.Name = "labelMaxCur1";
            this.labelMaxCur1.Size = new System.Drawing.Size(128, 41);
            this.labelMaxCur1.TabIndex = 30;
            this.labelMaxCur1.Text = "__________";
            // 
            // labelMinCur1
            // 
            this.labelMinCur1.AutoSize = true;
            this.labelMinCur1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinCur1.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMinCur1.Location = new System.Drawing.Point(300, 711);
            this.labelMinCur1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinCur1.Name = "labelMinCur1";
            this.labelMinCur1.Size = new System.Drawing.Size(128, 41);
            this.labelMinCur1.TabIndex = 31;
            this.labelMinCur1.Text = "__________";
            // 
            // labelMaxCur2
            // 
            this.labelMaxCur2.AutoSize = true;
            this.labelMaxCur2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxCur2.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMaxCur2.Location = new System.Drawing.Point(148, 780);
            this.labelMaxCur2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxCur2.Name = "labelMaxCur2";
            this.labelMaxCur2.Size = new System.Drawing.Size(128, 41);
            this.labelMaxCur2.TabIndex = 32;
            this.labelMaxCur2.Text = "__________";
            // 
            // labelMinCur2
            // 
            this.labelMinCur2.AutoSize = true;
            this.labelMinCur2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinCur2.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMinCur2.Location = new System.Drawing.Point(300, 780);
            this.labelMinCur2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinCur2.Name = "labelMinCur2";
            this.labelMinCur2.Size = new System.Drawing.Size(128, 41);
            this.labelMinCur2.TabIndex = 33;
            this.labelMinCur2.Text = "__________";
            // 
            // Graph1
            // 
            this.Graph1.BackColor = System.Drawing.SystemColors.Control;
            this.Graph1.BorderlineColor = System.Drawing.SystemColors.Control;
            this.Graph1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.Graph1.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.Graph1.Legends.Add(legend3);
            this.Graph1.Location = new System.Drawing.Point(795, 110);
            this.Graph1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Graph1.Name = "Graph1";
            this.Graph1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BorderColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Graph1.Series.Add(series3);
            this.Graph1.Size = new System.Drawing.Size(586, 384);
            this.Graph1.TabIndex = 34;
            this.Graph1.Text = "chart1";
            // 
            // Graph2
            // 
            this.Graph2.BackColor = System.Drawing.SystemColors.Control;
            this.Graph2.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.Graph2.ChartAreas.Add(chartArea4);
            legend4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.Graph2.Legends.Add(legend4);
            this.Graph2.Location = new System.Drawing.Point(795, 501);
            this.Graph2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Graph2.Name = "Graph2";
            this.Graph2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.Graph2.Series.Add(series4);
            this.Graph2.Size = new System.Drawing.Size(586, 384);
            this.Graph2.TabIndex = 35;
            this.Graph2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(229, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "First currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(460, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = "Second currency";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1425, 892);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph2);
            this.Controls.Add(this.Graph1);
            this.Controls.Add(this.labelMinCur2);
            this.Controls.Add(this.labelMaxCur2);
            this.Controls.Add(this.labelMinCur1);
            this.Controls.Add(this.labelMaxCur1);
            this.Controls.Add(this.labelCurrency2);
            this.Controls.Add(this.labelCurrency1);
            this.Controls.Add(this.labelMinimum);
            this.Controls.Add(this.labelMaximum);
            this.Controls.Add(this.labelCurrency2_7);
            this.Controls.Add(this.labelCurrency2_6);
            this.Controls.Add(this.labelCurrency2_5);
            this.Controls.Add(this.labelCurrency2_4);
            this.Controls.Add(this.labelCurrency2_3);
            this.Controls.Add(this.labelCurrency2_2);
            this.Controls.Add(this.labelCurrency2_1);
            this.Controls.Add(this.labelCurrency1_7);
            this.Controls.Add(this.labelCurrency1_6);
            this.Controls.Add(this.labelCurrency1_5);
            this.Controls.Add(this.labelCurrency1_4);
            this.Controls.Add(this.labelCurrency1_3);
            this.Controls.Add(this.labelCurrency1_2);
            this.Controls.Add(this.labelCurrency1_1);
            this.Controls.Add(this.labelDate7);
            this.Controls.Add(this.labelDate6);
            this.Controls.Add(this.labelDate5);
            this.Controls.Add(this.labelDate4);
            this.Controls.Add(this.labelDate3);
            this.Controls.Add(this.labelDate2);
            this.Controls.Add(this.labelDate1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.comboBox_Second);
            this.Controls.Add(this.comboBox_First);
            this.Controls.Add(this.ExitButton);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency_Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.Graph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox comboBox_First;
        private System.Windows.Forms.ComboBox comboBox_Second;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.Label labelDate3;
        private System.Windows.Forms.Label labelDate4;
        private System.Windows.Forms.Label labelDate7;
        private System.Windows.Forms.Label labelDate6;
        private System.Windows.Forms.Label labelDate5;
        private System.Windows.Forms.Label labelCurrency1_7;
        private System.Windows.Forms.Label labelCurrency1_6;
        private System.Windows.Forms.Label labelCurrency1_5;
        private System.Windows.Forms.Label labelCurrency1_4;
        private System.Windows.Forms.Label labelCurrency1_3;
        private System.Windows.Forms.Label labelCurrency1_2;
        private System.Windows.Forms.Label labelCurrency1_1;
        private System.Windows.Forms.Label labelCurrency2_7;
        private System.Windows.Forms.Label labelCurrency2_6;
        private System.Windows.Forms.Label labelCurrency2_5;
        private System.Windows.Forms.Label labelCurrency2_4;
        private System.Windows.Forms.Label labelCurrency2_3;
        private System.Windows.Forms.Label labelCurrency2_2;
        private System.Windows.Forms.Label labelCurrency2_1;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.Label labelMinimum;
        private System.Windows.Forms.Label labelCurrency1;
        private System.Windows.Forms.Label labelCurrency2;
        private System.Windows.Forms.Label labelMaxCur1;
        private System.Windows.Forms.Label labelMinCur1;
        private System.Windows.Forms.Label labelMaxCur2;
        private System.Windows.Forms.Label labelMinCur2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

