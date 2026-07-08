# 🧮 مشروع حساب العمر الدقيق | Age Calculator Form

مشروع احترافي مبني باستخدام لغة **#C** وواجهات **Windows Forms**، يقوم بحساب عمر المستخدم بدقة متناهية بالسنوات، الشهور، والأيام، بالإضافة إلى تقديم تفاصيل متقدمة وشاملة عن الوقت الذي عاشه المستخدم وكذا موعد عيد ميلاده القادم مع معالجة ذكية للسنوات الكبيسة.

---

## 📸 واجهة البرنامج (UI Preview)

![Age Calculator UI](image_399b9c.png)

---

## 🚀 المميزات الرئيسية (Core Features)

* **حساب العمر الدقيق برمجياً:** حساب الفروق الزمنية بالسنوات والشهور والأيام بناءً على التقويم الفعلي الدقيق (وليس مجرد تقسيم رياضي تقريبي).
* **إحصائيات الوقت المستغرق (Time Lived):** حساب إجمالي الوقت الذي عشته بالدقائق، الساعات، الأيام، الأسابيع، والشهور.
* **تفاصيل إضافية (More Details):**
  * معرفة اليوم الذي ولددت فيه (مثل: Sunday, Monday... إلخ).
  * عد تنازلي دقيق بالأيام للأيام المتبقية على عيد ميلادك القادم.
* **نظام تحققات صارم (Strict Validation):** حماية البرنامج من المدخلات الخاطئة أو التواريخ الوهمية أو التواريخ المستقبلية.
* **تنظيف ذكي وعود تكراري (Recursive Clear):** تفريغ جميع خانات النصوص بضغطة زر واحدة دون الحاجة لتسمية كل أداة على حدة.

---

## 🏗️ التصميم البرمجي وهندسة الكود (Architecture Design)

تم بناء الكود بالاعتماد على تقسيم الوظائف (Separation of Concerns) لضمان سهولة القراءة والتطوير:
frmAgeCalculator (Form1)
│
├── 🛠️ Validations (التحققات)
│   ├── IsBirthDateEmpty() ──> التأكد من عدم ترك الحقول فارغة
│   ├── IsValidDate() ──> فحص صحة التاريخ وصيغته (d/M/yyyy)
│   └── IsValidBirthDate_limte() ──> منع تواريخ المستقبل أو ما قبل 1900
│
├── 🧠 Core Logic (العمليات الحسابية)
│   ├── Calculate_Age() ──> حساب السن بالسنوات والشهور والأيام (مع الاستلاف)
│   ├── Calculate_TimeLived() ──> حساب الإجمالي بالأسابيع، الأيام، الساعات، والثواني
│   └── Calculate_MoreDetals() ──> حساب يوم الميلاد وعيد الميلاد القادم (معالجة كبيسة)
│
└── 🖥️ UI Management (إدارة الواجهة)
├── Print_Calculate_Age() / Print_Calculate_MoreDetals() ──> عرض النتائج
└── ClearAllTextBoxes() ──> تنظيف الأدوات بشكل ذكي وتكراري (Recursive)
## 🛠️ تفاصيل تقنية متميزة في الكود الخاص بك

### 1. نظام التحقق الصارم باستخدام `DateTime.TryParseExact`
على عكس استخدام دالة `TryParse` العادية التي قد تتأثر بإعدادات لغة ثقافة جهاز العميل (Regional Settings)، يعتمد هذا المشروع على صيغة صارمة ومحددة وهي `"d/M/yyyy"` عبر الثقافة المحايدة `CultureInfo.InvariantCulture` لضمان استقرار العمل على أي جهاز:

```csharp
private bool IsValidDate()
{
    Full_Date = masday.Text + "/" + masMonth.Text + "/" + masYear.Text;
    DateTime validation_dateTime;
    return DateTime.TryParseExact(Full_Date, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out validation_dateTime);
}

2. منطق الحساب البشري الفعلي وحالات الاستلاف (Borrowing Logic)
يتميز الكود بحساب العمر تماماً كما يحسبه البشر؛ حيث يقوم بطرح الأيام والشهور والسنوات بشكل مباشر، وإذا كانت النتيجة سالبة (مثلاً يوم اليوم أقل من يوم الميلاد)، يقوم باستلاف عدد الأيام الفعلي للشهر السابق بدقة عبر DateTime.DaysInMonth:

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

3. المعالجة الذكية ليوم 29 فبراير (Leap Year Handling)
يتعامل البرنامج بذكاء شديد مع الأشخاص المولودين في يوم كبيس (29 فبراير). عند حساب عيد الميلاد القادم في سنة عادية (غير كبيرة)، يقوم الكود تلقائياً بتحويل اليوم إلى 28 فبراير لتفادي انهيار البرنامج (Crash) أو حدوث استثناء برمجى:


if (month == 2 && day == 29 && !DateTime.IsLeapYear(NextBirthDay.Year))
{
    NextBirthDay = new DateTime(NextBirthDay.Year, 2, 28);
}

4. استخدام التابع التكراري الذكي للتنظيف (Recursive Controls Clear)
بدلاً من كتابة سطر كود لكل تكست بوكس لمسح محتواه (والذي يعتبر أسلوباً غير مرن عند إضافة أدوات جديدة)، تم بناء ميثود تكرارية (Recursive Function) تمر على الواجهة وحاوياتها بالكامل وتمسح أي حقل نصي تلقائياً:
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
            ClearAllTextBoxes(control); // استدعاء ذاتي لتنظيف الحاويات الداخلية
        }
    }
}
💻 التقنيات المستخدمة (Tools & Tech Stack)
اللغة: #C (C-Sharp)

إطار العمل: .NET Framework

نوع التطبيق: Windows Forms App (Desktop)

بيئة التطوير: Visual Studio

🌟 الخلاصة
هذا الكود يمثل نموذجاً ممتازاً لتطبيق يراعي دقة البيانات المنطقية، ويحمي التطبيق من الانهيار باستخدام تحققات صارمة، مع الاستفادة من مفاهيم متقدمة مثل الـ Recursion للتحكم في عناصر الواجهة بسلاسة ورشاقة.
