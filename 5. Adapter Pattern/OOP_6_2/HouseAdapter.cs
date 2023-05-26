using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Xml.Serialization;

namespace Studying;

public class HouseAdapter : IAdapter
{
    private House _house;

    public HouseAdapter() => _house = new();
    public HouseAdapter(House house) =>
        // Если house имеет значение null, то генерируется исключение типа ArgumentNullException с указанием имени аргумента "house".
        _house = house ?? throw new ArgumentNullException(nameof(house));

    public string GetJSON()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        return JsonSerializer.Serialize(_house, options);
    }

    public string GetXML()
    {
        XmlSerializer serializer = new(typeof(House));
        using StringWriter writer = new();
        serializer.Serialize(writer, _house);
        return writer.ToString();
    }
    public string GetYAML() => _house.SerializeToYAML();
    public string GetCSV() => _house.SerializeToCSV();

    public House GetHouse() => _house;
    public void SetHouse(House house) => _house = house;
}
