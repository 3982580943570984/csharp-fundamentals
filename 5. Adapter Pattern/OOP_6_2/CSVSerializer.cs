using System.Reflection;
using System.Text;

namespace Studying;

public static class CSVSerializer
{
    // Метод расширения - статический метод, который позволяет добавлять новые методы
    // в существующие классы без изменения кода исходного класса
    public static string SerializeToCSV<T>(this T obj)
    {
        StringBuilder sb = new();

        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (PropertyInfo property in properties)
        {
            sb.Append(property.GetValue(obj)?.ToString() ?? "");
            sb.Append(',');
        }

        // Удаляем последний символ строки
        sb.Remove(sb.Length - 1, 1);
        // Добавляем символ перевода строки
        sb.AppendLine();

        return sb.ToString();
    }

    // Метод расширения - статический метод, который позволяет добавлять новые методы
    // в существующие классы без изменения кода исходного класса
    public static string SerializeToCSV<T>(this List<T> list)
    {
        StringBuilder sb = new();
        foreach (T obj in list)
            sb.Append(obj.SerializeToCSV());
        return sb.ToString();
    }
}