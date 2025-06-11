namespace MathLibrary;

/// <summary>
/// يحتوي على دوال رياضية بسيطة
/// </summary>
public static class Calculator
{
    /// <summary>
    /// تحسب حاصل ضرب عددين صحيحين
    /// </summary>
    /// <param name="a">العدد الأول</param>
    /// <param name="b">العدد الثاني</param>
    /// <returns>ناتج الضرب</returns>
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// يقسم عددين صحيحين
    /// </summary>
    /// <param name="a">المقسوم</param>
    /// <param name="b">المقسوم عليه</param>
    /// <returns>ناتج القسمة</returns>
    public static int Divide(int a, int b)
    {
        return a / b;
    }

    /// <summary>
    /// يتحقق إذا كان الرقم زوجيًا
    /// </summary>
    /// <param name="a">العدد المطلوب فحصه</param>
    /// <returns>صحيح إذا كان العدد زوجيًا</returns>
    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
}
