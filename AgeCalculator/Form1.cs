using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DateTime my_age; string Full_Date = ""; DateTime NextBirthDay;
        int year; byte month, day; int year_result, Month_result, day_result; DateTime currentDatetime = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsBirthDateEmpty()
        {
            return (string.IsNullOrWhiteSpace(masday.Text) || string.IsNullOrWhiteSpace(masMonth.Text)|| string.IsNullOrWhiteSpace(masYear.Text));
        }
        private void WrongMessageBox1()
        {
            MessageBox.Show("من فضلك أدخل تاريخ الميلاد كاملاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void WrongMessageBox2()
        {
            MessageBox.Show("التاريخ المدخل غير صحيح تأكد من الأيام والشهور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void WrongMessageBox3()
        {
            MessageBox.Show("لا يمكن أن يكون تاريخ الميلاد في المستقبل! او اقل سنة 1900", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool IsValidDate()
        {
            Full_Date = masday.Text + "/" + masMonth.Text + "/" + masYear.Text; DateTime validation_dateTime;
            return DateTime.TryParseExact(Full_Date, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out validation_dateTime);

        }
        private bool IsValidBirthDate_limte()
        {
            year = Convert.ToInt32(masYear.Text); month = Convert.ToByte(masMonth.Text); day = Convert.ToByte(masday.Text);
            my_age = new DateTime(year, month, day);
            currentDatetime = DateTime.Now;
            return (my_age < DateTime.Now && my_age.Year >= 1900);
        }
        private bool validation_date()
        {
            if (IsBirthDateEmpty())
            {
                WrongMessageBox1();
                return false;
            }
           
            if (!IsValidDate())
            {
                WrongMessageBox2();
                return false;
            }
          
            if (!IsValidBirthDate_limte())
            {
                WrongMessageBox3();
                return false;
            }
            return true;
        }
        private void Calculate_Age()
        {
            currentDatetime = DateTime.Now;
            year_result = currentDatetime.Year - my_age.Year;
            Month_result = currentDatetime.Month - my_age.Month;
            day_result = currentDatetime.Day - my_age.Day;
            if (day_result < 0)
            {
                Month_result--;
                day_result  += DateTime.DaysInMonth(currentDatetime.Year, currentDatetime.AddMonths(-1).Month);
            }
            if (Month_result < 0)
            {
                year_result--;
                Month_result += 12;
            }
            Print_Calculate_Age();
        }
        private void Print_Calculate_Age()
        {
            tbx_Year.Text = year_result.ToString(); tbx_Month.Text = Month_result.ToString(); tbx_day.Text = day_result.ToString();
            tbxTotal_age.Text = "You are " + tbx_Year.Text + " Years " + tbx_Month.Text + " Months " + tbx_day.Text + " Days Old. ";
        }
        private void ClearAllTextBoxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is System.Windows.Forms.TextBox txt)
                {
                    txt.Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            masday.Focus();
        }
        private void Calculate_TimeLived()
        {
            currentDatetime = DateTime.Now;
            TimeSpan result = currentDatetime.Subtract(my_age);
            tbx_Total_Days.Text = Convert.ToString(Convert.ToUInt32(result.TotalDays));
            tbx_Total_Hours.Text = Convert.ToString(Convert.ToUInt32(result.TotalHours));
            tbx_Total_Minutes.Text = Convert.ToString(Convert.ToUInt32(result.TotalMinutes));
            tbx_Total_Seconds.Text = Convert.ToString(Convert.ToUInt32(result.TotalSeconds));
            int total_month = year_result * 12 + Month_result;
            tbx_Total_Months.Text = total_month.ToString();
            int Total_Weaks = Convert.ToInt32(result.TotalDays) / 7;
            tbx_Total_weeks.Text = Total_Weaks.ToString();
        }
        private void Calculate_MoreDetals()
        {
            tbx_Born_on.Text= my_age.DayOfWeek.ToString();
            ////////////////////////////////////////
            currentDatetime = DateTime.Now;
             NextBirthDay = new DateTime(currentDatetime.Year , month,day);

            if (NextBirthDay < currentDatetime)
            {
                NextBirthDay = NextBirthDay.AddYears(1);
            }
            if (month == 2 && day == 29 && !DateTime.IsLeapYear(NextBirthDay.Year))
            {
                NextBirthDay = new DateTime(NextBirthDay.Year, 2, 28);
            }
            Print_Calculate_MoreDetals();
        }
        private void Print_Calculate_MoreDetals()
        {
            TimeSpan diff = NextBirthDay - currentDatetime.Date;
            tbx_Next_Birth_Day.Text = diff.Days.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(validation_date())
            {
                Calculate_Age();
                Calculate_TimeLived();
                Calculate_MoreDetals();
            }
        }
    }
}