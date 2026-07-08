namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.masYear = new System.Windows.Forms.MaskedTextBox();
            this.masMonth = new System.Windows.Forms.MaskedTextBox();
            this.masday = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labYear = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.labDay = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxTotal_age = new System.Windows.Forms.TextBox();
            this.tbx_Year = new System.Windows.Forms.TextBox();
            this.tbx_Month = new System.Windows.Forms.TextBox();
            this.tbx_day = new System.Windows.Forms.TextBox();
            this.labYear2 = new System.Windows.Forms.Label();
            this.labMonth2 = new System.Windows.Forms.Label();
            this.labDay2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbx_Total_Seconds = new System.Windows.Forms.TextBox();
            this.tbx_Total_Minutes = new System.Windows.Forms.TextBox();
            this.tbx_Total_Hours = new System.Windows.Forms.TextBox();
            this.labTotal_Seconds = new System.Windows.Forms.Label();
            this.labTotal_Minutes = new System.Windows.Forms.Label();
            this.labTotal_Hours = new System.Windows.Forms.Label();
            this.tbx_Total_Days = new System.Windows.Forms.TextBox();
            this.tbx_Total_weeks = new System.Windows.Forms.TextBox();
            this.tbx_Total_Months = new System.Windows.Forms.TextBox();
            this.labTotal_Days = new System.Windows.Forms.Label();
            this.labTotal_Weeks = new System.Windows.Forms.Label();
            this.labTotal_Months = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labBorn_On = new System.Windows.Forms.Label();
            this.labNext_Birth_Day = new System.Windows.Forms.Label();
            this.tbx_Next_Birth_Day = new System.Windows.Forms.TextBox();
            this.tbx_Born_on = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Calculator Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1218, 225);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 219);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.masYear);
            this.panel2.Controls.Add(this.masMonth);
            this.panel2.Controls.Add(this.masday);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labYear);
            this.panel2.Controls.Add(this.labMonth);
            this.panel2.Controls.Add(this.labDay);
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 184);
            this.panel2.TabIndex = 2;
            // 
            // masYear
            // 
            this.masYear.Location = new System.Drawing.Point(826, 73);
            this.masYear.Mask = "0000";
            this.masYear.Name = "masYear";
            this.masYear.Size = new System.Drawing.Size(349, 20);
            this.masYear.TabIndex = 11;
            this.masYear.ValidatingType = typeof(int);
            // 
            // masMonth
            // 
            this.masMonth.Location = new System.Drawing.Point(435, 73);
            this.masMonth.Mask = "09";
            this.masMonth.Name = "masMonth";
            this.masMonth.Size = new System.Drawing.Size(349, 20);
            this.masMonth.TabIndex = 10;
            this.masMonth.ValidatingType = typeof(int);
            // 
            // masday
            // 
            this.masday.Location = new System.Drawing.Point(39, 73);
            this.masday.Mask = "09";
            this.masday.Name = "masday";
            this.masday.Size = new System.Drawing.Size(299, 20);
            this.masday.TabIndex = 9;
            this.masday.ValidatingType = typeof(int);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(691, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(419, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(80, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate My Age";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYear.ForeColor = System.Drawing.Color.Black;
            this.labYear.Location = new System.Drawing.Point(1019, 22);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(58, 25);
            this.labYear.TabIndex = 2;
            this.labYear.Text = "Year";
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonth.ForeColor = System.Drawing.Color.Black;
            this.labMonth.Location = new System.Drawing.Point(550, 22);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(72, 25);
            this.labMonth.TabIndex = 1;
            this.labMonth.Text = "Month";
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDay.ForeColor = System.Drawing.Color.Black;
            this.labDay.Location = new System.Drawing.Point(111, 22);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(50, 25);
            this.labDay.TabIndex = 0;
            this.labDay.Text = "Day";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 326);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1217, 225);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 219);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.tbxTotal_age);
            this.panel4.Controls.Add(this.tbx_Year);
            this.panel4.Controls.Add(this.tbx_Month);
            this.panel4.Controls.Add(this.tbx_day);
            this.panel4.Controls.Add(this.labYear2);
            this.panel4.Controls.Add(this.labMonth2);
            this.panel4.Controls.Add(this.labDay2);
            this.panel4.Location = new System.Drawing.Point(-1, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1215, 187);
            this.panel4.TabIndex = 2;
            // 
            // tbxTotal_age
            // 
            this.tbxTotal_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal_age.Location = new System.Drawing.Point(25, 17);
            this.tbxTotal_age.Multiline = true;
            this.tbxTotal_age.Name = "tbxTotal_age";
            this.tbxTotal_age.ReadOnly = true;
            this.tbxTotal_age.Size = new System.Drawing.Size(1150, 40);
            this.tbxTotal_age.TabIndex = 6;
            this.tbxTotal_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Year
            // 
            this.tbx_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Year.Location = new System.Drawing.Point(856, 118);
            this.tbx_Year.Multiline = true;
            this.tbx_Year.Name = "tbx_Year";
            this.tbx_Year.ReadOnly = true;
            this.tbx_Year.Size = new System.Drawing.Size(342, 30);
            this.tbx_Year.TabIndex = 5;
            // 
            // tbx_Month
            // 
            this.tbx_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Month.Location = new System.Drawing.Point(408, 118);
            this.tbx_Month.Multiline = true;
            this.tbx_Month.Name = "tbx_Month";
            this.tbx_Month.ReadOnly = true;
            this.tbx_Month.Size = new System.Drawing.Size(391, 30);
            this.tbx_Month.TabIndex = 4;
            // 
            // tbx_day
            // 
            this.tbx_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_day.Location = new System.Drawing.Point(7, 118);
            this.tbx_day.Multiline = true;
            this.tbx_day.Name = "tbx_day";
            this.tbx_day.ReadOnly = true;
            this.tbx_day.Size = new System.Drawing.Size(331, 30);
            this.tbx_day.TabIndex = 3;
            // 
            // labYear2
            // 
            this.labYear2.AutoSize = true;
            this.labYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYear2.ForeColor = System.Drawing.Color.Black;
            this.labYear2.Location = new System.Drawing.Point(999, 90);
            this.labYear2.Name = "labYear2";
            this.labYear2.Size = new System.Drawing.Size(58, 25);
            this.labYear2.TabIndex = 2;
            this.labYear2.Text = "Year";
            // 
            // labMonth2
            // 
            this.labMonth2.AutoSize = true;
            this.labMonth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonth2.ForeColor = System.Drawing.Color.Black;
            this.labMonth2.Location = new System.Drawing.Point(550, 90);
            this.labMonth2.Name = "labMonth2";
            this.labMonth2.Size = new System.Drawing.Size(72, 25);
            this.labMonth2.TabIndex = 1;
            this.labMonth2.Text = "Month";
            // 
            // labDay2
            // 
            this.labDay2.AutoSize = true;
            this.labDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDay2.ForeColor = System.Drawing.Color.Black;
            this.labDay2.Location = new System.Drawing.Point(119, 90);
            this.labDay2.Name = "labDay2";
            this.labDay2.Size = new System.Drawing.Size(50, 25);
            this.labDay2.TabIndex = 0;
            this.labDay2.Text = "Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Your Age Is";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 549);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(708, 234);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label13);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(702, 228);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.tbx_Total_Seconds);
            this.panel6.Controls.Add(this.tbx_Total_Minutes);
            this.panel6.Controls.Add(this.tbx_Total_Hours);
            this.panel6.Controls.Add(this.labTotal_Seconds);
            this.panel6.Controls.Add(this.labTotal_Minutes);
            this.panel6.Controls.Add(this.labTotal_Hours);
            this.panel6.Controls.Add(this.tbx_Total_Days);
            this.panel6.Controls.Add(this.tbx_Total_weeks);
            this.panel6.Controls.Add(this.tbx_Total_Months);
            this.panel6.Controls.Add(this.labTotal_Days);
            this.panel6.Controls.Add(this.labTotal_Weeks);
            this.panel6.Controls.Add(this.labTotal_Months);
            this.panel6.Location = new System.Drawing.Point(-1, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(710, 193);
            this.panel6.TabIndex = 2;
            // 
            // tbx_Total_Seconds
            // 
            this.tbx_Total_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total_Seconds.Location = new System.Drawing.Point(448, 132);
            this.tbx_Total_Seconds.Multiline = true;
            this.tbx_Total_Seconds.Name = "tbx_Total_Seconds";
            this.tbx_Total_Seconds.ReadOnly = true;
            this.tbx_Total_Seconds.Size = new System.Drawing.Size(254, 30);
            this.tbx_Total_Seconds.TabIndex = 11;
            // 
            // tbx_Total_Minutes
            // 
            this.tbx_Total_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total_Minutes.Location = new System.Drawing.Point(220, 132);
            this.tbx_Total_Minutes.Multiline = true;
            this.tbx_Total_Minutes.Name = "tbx_Total_Minutes";
            this.tbx_Total_Minutes.ReadOnly = true;
            this.tbx_Total_Minutes.Size = new System.Drawing.Size(220, 30);
            this.tbx_Total_Minutes.TabIndex = 10;
            // 
            // tbx_Total_Hours
            // 
            this.tbx_Total_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total_Hours.Location = new System.Drawing.Point(4, 132);
            this.tbx_Total_Hours.Multiline = true;
            this.tbx_Total_Hours.Name = "tbx_Total_Hours";
            this.tbx_Total_Hours.ReadOnly = true;
            this.tbx_Total_Hours.Size = new System.Drawing.Size(210, 30);
            this.tbx_Total_Hours.TabIndex = 9;
            // 
            // labTotal_Seconds
            // 
            this.labTotal_Seconds.AutoSize = true;
            this.labTotal_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal_Seconds.ForeColor = System.Drawing.Color.Black;
            this.labTotal_Seconds.Location = new System.Drawing.Point(451, 104);
            this.labTotal_Seconds.Name = "labTotal_Seconds";
            this.labTotal_Seconds.Size = new System.Drawing.Size(156, 25);
            this.labTotal_Seconds.TabIndex = 8;
            this.labTotal_Seconds.Text = "Total  Seconds";
            // 
            // labTotal_Minutes
            // 
            this.labTotal_Minutes.AutoSize = true;
            this.labTotal_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal_Minutes.ForeColor = System.Drawing.Color.Black;
            this.labTotal_Minutes.Location = new System.Drawing.Point(220, 104);
            this.labTotal_Minutes.Name = "labTotal_Minutes";
            this.labTotal_Minutes.Size = new System.Drawing.Size(148, 25);
            this.labTotal_Minutes.TabIndex = 7;
            this.labTotal_Minutes.Text = "Total  Minutes";
            // 
            // labTotal_Hours
            // 
            this.labTotal_Hours.AutoSize = true;
            this.labTotal_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal_Hours.ForeColor = System.Drawing.Color.Black;
            this.labTotal_Hours.Location = new System.Drawing.Point(1, 104);
            this.labTotal_Hours.Name = "labTotal_Hours";
            this.labTotal_Hours.Size = new System.Drawing.Size(123, 25);
            this.labTotal_Hours.TabIndex = 6;
            this.labTotal_Hours.Text = "Total Hours";
            // 
            // tbx_Total_Days
            // 
            this.tbx_Total_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total_Days.Location = new System.Drawing.Point(456, 51);
            this.tbx_Total_Days.Multiline = true;
            this.tbx_Total_Days.Name = "tbx_Total_Days";
            this.tbx_Total_Days.ReadOnly = true;
            this.tbx_Total_Days.Size = new System.Drawing.Size(244, 30);
            this.tbx_Total_Days.TabIndex = 5;
            // 
            // tbx_Total_weeks
            // 
            this.tbx_Total_weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total_weeks.Location = new System.Drawing.Point(223, 51);
            this.tbx_Total_weeks.Multiline = true;
            this.tbx_Total_weeks.Name = "tbx_Total_weeks";
            this.tbx_Total_weeks.ReadOnly = true;
            this.tbx_Total_weeks.Size = new System.Drawing.Size(227, 30);
            this.tbx_Total_weeks.TabIndex = 4;
            // 
            // tbx_Total_Months
            // 
            this.tbx_Total_Months.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total_Months.Location = new System.Drawing.Point(4, 51);
            this.tbx_Total_Months.Multiline = true;
            this.tbx_Total_Months.Name = "tbx_Total_Months";
            this.tbx_Total_Months.ReadOnly = true;
            this.tbx_Total_Months.Size = new System.Drawing.Size(213, 30);
            this.tbx_Total_Months.TabIndex = 3;
            // 
            // labTotal_Days
            // 
            this.labTotal_Days.AutoSize = true;
            this.labTotal_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal_Days.ForeColor = System.Drawing.Color.Black;
            this.labTotal_Days.Location = new System.Drawing.Point(451, 23);
            this.labTotal_Days.Name = "labTotal_Days";
            this.labTotal_Days.Size = new System.Drawing.Size(121, 25);
            this.labTotal_Days.TabIndex = 2;
            this.labTotal_Days.Text = "Total  Days";
            // 
            // labTotal_Weeks
            // 
            this.labTotal_Weeks.AutoSize = true;
            this.labTotal_Weeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal_Weeks.ForeColor = System.Drawing.Color.Black;
            this.labTotal_Weeks.Location = new System.Drawing.Point(230, 23);
            this.labTotal_Weeks.Name = "labTotal_Weeks";
            this.labTotal_Weeks.Size = new System.Drawing.Size(138, 25);
            this.labTotal_Weeks.TabIndex = 1;
            this.labTotal_Weeks.Text = "Total  Weeks";
            // 
            // labTotal_Months
            // 
            this.labTotal_Months.AutoSize = true;
            this.labTotal_Months.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal_Months.ForeColor = System.Drawing.Color.Black;
            this.labTotal_Months.Location = new System.Drawing.Point(6, 23);
            this.labTotal_Months.Name = "labTotal_Months";
            this.labTotal_Months.Size = new System.Drawing.Size(137, 25);
            this.labTotal_Months.TabIndex = 0;
            this.labTotal_Months.Text = "Total Months";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Time Lived";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(722, 549);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(502, 235);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label23);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(496, 228);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.labBorn_On);
            this.panel8.Controls.Add(this.labNext_Birth_Day);
            this.panel8.Controls.Add(this.tbx_Next_Birth_Day);
            this.panel8.Controls.Add(this.tbx_Born_on);
            this.panel8.Location = new System.Drawing.Point(-1, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(499, 197);
            this.panel8.TabIndex = 2;
            // 
            // labBorn_On
            // 
            this.labBorn_On.AutoSize = true;
            this.labBorn_On.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBorn_On.ForeColor = System.Drawing.Color.Black;
            this.labBorn_On.Location = new System.Drawing.Point(16, 23);
            this.labBorn_On.Name = "labBorn_On";
            this.labBorn_On.Size = new System.Drawing.Size(91, 25);
            this.labBorn_On.TabIndex = 10;
            this.labBorn_On.Text = "Born On";
            // 
            // labNext_Birth_Day
            // 
            this.labNext_Birth_Day.AutoSize = true;
            this.labNext_Birth_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNext_Birth_Day.ForeColor = System.Drawing.Color.Black;
            this.labNext_Birth_Day.Location = new System.Drawing.Point(4, 119);
            this.labNext_Birth_Day.Name = "labNext_Birth_Day";
            this.labNext_Birth_Day.Size = new System.Drawing.Size(150, 25);
            this.labNext_Birth_Day.TabIndex = 9;
            this.labNext_Birth_Day.Text = "Next Birth Day";
            // 
            // tbx_Next_Birth_Day
            // 
            this.tbx_Next_Birth_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Next_Birth_Day.Location = new System.Drawing.Point(160, 114);
            this.tbx_Next_Birth_Day.Multiline = true;
            this.tbx_Next_Birth_Day.Name = "tbx_Next_Birth_Day";
            this.tbx_Next_Birth_Day.ReadOnly = true;
            this.tbx_Next_Birth_Day.Size = new System.Drawing.Size(310, 30);
            this.tbx_Next_Birth_Day.TabIndex = 7;
            // 
            // tbx_Born_on
            // 
            this.tbx_Born_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Born_on.Location = new System.Drawing.Point(124, 18);
            this.tbx_Born_on.Multiline = true;
            this.tbx_Born_on.Name = "tbx_Born_on";
            this.tbx_Born_on.ReadOnly = true;
            this.tbx_Born_on.Size = new System.Drawing.Size(312, 30);
            this.tbx_Born_on.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(3, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 25);
            this.label23.TabIndex = 1;
            this.label23.Text = "More Detals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1242, 803);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxTotal_age;
        private System.Windows.Forms.TextBox tbx_Year;
        private System.Windows.Forms.TextBox tbx_Month;
        private System.Windows.Forms.TextBox tbx_day;
        private System.Windows.Forms.Label labYear2;
        private System.Windows.Forms.Label labMonth2;
        private System.Windows.Forms.Label labDay2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbx_Total_Days;
        private System.Windows.Forms.TextBox tbx_Total_weeks;
        private System.Windows.Forms.TextBox tbx_Total_Months;
        private System.Windows.Forms.Label labTotal_Days;
        private System.Windows.Forms.Label labTotal_Weeks;
        private System.Windows.Forms.Label labTotal_Months;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_Total_Seconds;
        private System.Windows.Forms.TextBox tbx_Total_Minutes;
        private System.Windows.Forms.TextBox tbx_Total_Hours;
        private System.Windows.Forms.Label labTotal_Seconds;
        private System.Windows.Forms.Label labTotal_Minutes;
        private System.Windows.Forms.Label labTotal_Hours;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labBorn_On;
        private System.Windows.Forms.Label labNext_Birth_Day;
        private System.Windows.Forms.TextBox tbx_Next_Birth_Day;
        private System.Windows.Forms.TextBox tbx_Born_on;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox masday;
        private System.Windows.Forms.MaskedTextBox masMonth;
        private System.Windows.Forms.MaskedTextBox masYear;
    }
}

