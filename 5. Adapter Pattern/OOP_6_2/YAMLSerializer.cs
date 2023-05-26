using System.Reflection;
using System.Text;
using System.Linq;

namespace Studying;

public static class YAMLSerializer
{
    // Метод расширения - статический метод, который позволяет добавлять новые методы
    // в существующие классы без изменения кода исходного класса
    public static string SerializeToYAML<T>(this T obj)
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        List<string> lines = new();
        lines.AddRange(from PropertyInfo property in properties
                       select $"{property.Name}: {property.GetValue(obj)?.ToString() ?? "null"}");
        return string.Join(Environment.NewLine, lines);
    }

    // Метод расширения - статический метод, который позволяет добавлять новые методы
    // в существующие классы без изменения кода исходного класса
    public static string SerializeToYAML<T>(this List<T> list)
    {
        StringBuilder sb = new();
        foreach (T obj in list)
            sb.Append(obj.SerializeToYAML());
        return sb.ToString();
    }
}