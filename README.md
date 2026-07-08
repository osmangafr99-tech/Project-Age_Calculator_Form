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

## 🏗️ Architecture Design & Code Structure

The source code is structured following the **Separation of Concerns (SoC)** principle to ensure readability and maintainability:
