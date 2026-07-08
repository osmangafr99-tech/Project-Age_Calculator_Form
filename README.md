
## 🚀 Project Overview

> Enter your birthday — get your age in years, months, and days, plus total time lived in every unit, the day of the week you were born on, and how many days until your next birthday.

---

## 🚀 Project Overview

Fourth project in the WinForms self-practice series.

Same four controls. Different problem.

This one takes a date and turns it into a full picture of how long you have been alive.

Three inputs: Day, Month, Year.

One button.

Results across four sections: your exact age, total time lived, day of birth, and next birthday countdown.

---

## 🏗️ Architecture Design

```text
button1_Click
 └── validation_date()
      ├── IsBirthDateEmpty()      ──> WrongMessageBox1()
      ├── IsValidDate()           ──> WrongMessageBox2()
      └── IsValidBirthDate_limte() ──> WrongMessageBox3()
           └── (valid) ──> Calculate_Age()
                            ├── Print_Calculate_Age()
                            ├── Calculate_TimeLived()
                            └── Calculate_MoreDetals()
                                 └── Print_Calculate_MoreDetals()

button2_Click (Clear Button)
 ├── ClearAllTextBoxes(this)
 └── masday.Focus()
```

---

## ⚙️ Core Functionalities

| Section | Output |
|---|---|
| **Your Age Is** | Years · Months · Days + full summary sentence |
| **Time Lived** | Total Months · Weeks · Days · Hours · Minutes · Seconds |
| **More Details** | Day of week born · Days until next birthday |

---

## 🧠 Design Decisions Worth Noting

### Three-Layer Strict Validation via `DateTime.TryParseExact`

The input date travels through three clean independent checkpoints, enforcing a strict "d/M/yyyy" format rather than relying on global system locale settings:

```csharp
// Layer 1 — Is anything left blank?
if (IsBirthDateEmpty()) → "من فضلك أدخل تاريخ الميلاد كاملاً."

// Layer 2 — Does the layout form a logically existing calendar date?
if (!IsValidDate()) → "التاريخ المدخل غير صحيح تأكد من الأيام والشهور"

// Layer 3 — Is it in the future or realistic (>= 1900)?
if (!IsValidBirthDate_limte()) → "لا يمكن أن يكون تاريخ الميلاد في المستقبل! او اقل سنة 1900"
```

---

### Dynamic Human-Like Borrowing Logic

When computing exact remaining days and months, simple mathematical division fails due to variance in calendar month lengths. The codebase solves this by adapting a realistic human borrowing approach using `DateTime.DaysInMonth`:

```csharp
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
```

---

### Dynamic 29th of February Handling (Leap Years)

To protect the software against sudden crashes when calculating the next birthday milestone for individuals born on a Leap Year (February 29th), the runtime dynamically shifts the target layout to February 28th during standard calendar years:

```csharp
if (month == 2 && day == 29 && !DateTime.IsLeapYear(NextBirthDay.Year))
{
    NextBirthDay = new DateTime(NextBirthDay.Year, 2, 28);
}
```

---

### Smart Recursive UI Control Clearing

Instead of hardcoding individual manual tracking statements for clearing every single output textbox on the window, this architecture leverages an elegant recursive loop traversing deep into nested layouts:

```csharp
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
```

---

## 🛠️ Tech Stack

| | |
|---|---|
| **Language** | C# |
| **Framework** | .NET Framework |
| **UI** | Windows Forms (WinForms) |
| **IDE** | Visual Studio |
| **Type** | Desktop Application |
| **Controls Used** | Form, Label, TextBox, Button |

---

## 📦 Practice Project Series

| Project | Controls Practiced | Application |
|---|---|---|
| **Project 25 — Tax Calculator** | Form, Label, TextBox, Button | Tax computation + session history |
| **Project 26 — Text Encryption** | Form, Label, TextBox, Button | Caesar Cipher encrypt/decrypt |
| **Project 27 — Password Generator** | Form, Label, TextBox, Button | GUID + Key + Password generator |
| **Project 28 — Age Calculator** *(you are here)* | Form, Label, TextBox, Button | Full age breakdown with time lived |
| More projects | Next control groups | 🔄 |

---

## 🏁 Course & Milestone Context

- ✅ Course 14 — C# Level 1 (Stage Two, in progress)
- ✅ Fourth project in the WinForms self-practice series
- ✅ Part of the **Programming Advices Roadmap** — Stage Two

---

## 🙏 Gratitude

Thank you to:

**[Programming Advices Platform](https://programmingadvices.com)**

**[Dr. Mohammed Abu-Hadhoud](https://programmingadvices.com)**

---

