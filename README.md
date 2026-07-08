# 🧮 High-Precision Age Calculator | Windows Forms

A professional desktop application built using **C#** and **Windows Forms**. It calculates the user's exact age in years, months, and days with absolute precision. Additionally, it provides advanced statistics about the total time lived and a dynamic countdown to the next birthday, featuring smart leap year handling.

---

## 📸 UI Preview

![Age Calculator UI](image_399b9c.png)

---

## 🚀 Core Features

* **Human-Like Exact Age Calculation:** Computes precise differences between dates in Years, Months, and Days based on the actual calendar (not just a rough mathematical division).
* **Comprehensive "Time Lived" Statistics:** Automatically calculates your total lifespan broken down into Months, Weeks, Days, Hours, Minutes, and Seconds.
* **Advanced "More Details" Panel:** * Identifies the exact day of the week you were born on (e.g., Sunday, Monday, etc.).
  * Calculates an exact day-by-day countdown remaining until your next birthday.
* **Strict Input Validation:** Features robust protection against empty fields, invalid calendar dates, future dates, or years prior to 1900.
* **Smart UI Management (Recursive Clear):** Flushes all textboxes across different containers with a single click using a clean recursive approach.

---




------------

## 🛠️ Outstanding Technical Highlights

### 1. Robust Validation via `DateTime.TryParseExact`
Unlike standard `TryParse` which depends heavily on the client machine's local regional settings, this implementation forces a strict `"d/M/yyyy"` pattern combined with `CultureInfo.InvariantCulture`. This guarantees seamless execution across any global machine setup:

```csharp
private bool IsValidDate()
{
    Full_Date = masday.Text + "/" + masMonth.Text + "/" + masYear.Text;
    DateTime validation_dateTime;
    return DateTime.TryParseExact(Full_Date, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out validation_dateTime);
}

------------
2. Precise "Human-Like" Borrowing Logic
When subtracting dates, days or months can frequently result in negative numbers (e.g., if today's day number is lower than your birthday). The code mimics actual human logic by decrementing the higher unit and pulling the accurate total days of that specific preceding month dynamically using DateTime.DaysInMonth:

C#


if (day_result < 0)
{
    Month_result--;
    day_result += DateTime.DaysInMonth(currentDatetime.Year, currentDatetime.AddMonths(-1).Month);
}
if (Month_result < 0)
{
    year_result--;
    Month_result += 12;
}



