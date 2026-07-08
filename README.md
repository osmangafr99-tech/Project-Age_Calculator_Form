## 🚀 Project Overview

> Enter your birthday — get your age in years, months, and days, plus total time lived in every unit, the day of the week you were born on, and how many days until your next birthday.

---

<img width="600" height="450" alt="image" src="image_399b9c.png" />

---

## 🚀 Project Overview

Fourth project in the WinForms self-practice series.

Same four controls. Different problem.

This one takes a date and turns it into a full picture of how long you have been alive.

Three inputs: Day, Month, Year.

One button.

Results across four sections: your exact age, total time lived, day of birth, and next birthday countdown.

---

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

The input date travels through three clean independent checkpoints, enforcing a strict `"d/M/yyyy"` format rather than relying on global system locale settings:

```csharp
// Layer 1 — Is anything left blank?
if (IsBirthDateEmpty()) → "من فضلك أدخل تاريخ الميلاد كاملاً."

// Layer 2 — Does the layout form a logically existing calendar date?
if (!IsValidDate()) → "التاريخ المدخل غير صحيح تأكد من الأيام والشهور"

// Layer 3 — Is it in the future or realistic (>= 1900)?
if (!IsValidBirthDate_limte()) → "لا يمكن أن يكون تاريخ الميلاد في المستقبل! او اقل سنة 1900"


Dynamic Human-Like Borrowing Logic
When computing exact remaining days and months, simple mathematical division fails due to variance in calendar month lengths. The codebase solves this by adapting a realistic human borrowing approach using DateTime.DaysInMonth:
