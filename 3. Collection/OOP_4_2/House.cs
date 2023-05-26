namespace Studying;

public sealed class House : IComparable<House>
{
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public ushort Number { get; set; } = 0;
    public ushort YearBuilt { get; set; } = 0;
    public ushort NumberOfFloors { get; set; } = 0;
    public ushort NumberOfApartments { get; set; } = 0;

    public House() => NumberOfFloors = 1;
    public House(ushort numberOfFloors) => NumberOfFloors = numberOfFloors;
    public House(ushort numberOfFloors, ushort numberOfApartments) : this(numberOfFloors) => NumberOfApartments = numberOfApartments;
    public House(string city, string street, string type, ushort number, ushort yearBuilt, ushort numberOfFloors, ushort numberOfApartments) : this(numberOfFloors, numberOfApartments)
    {
        // Если city имеет значение null, то генерируется исключение типа ArgumentNullException с указанием имени аргумента "city".
        City = city ?? throw new ArgumentNullException(nameof(city));
        // Если street имеет значение null, то генерируется исключение типа ArgumentNullException с указанием имени аргумента "street".
        Street = street ?? throw new ArgumentNullException(nameof(street));
        // Если type имеет значение null, то генерируется исключение типа ArgumentNullException с указанием имени аргумента "type".
        Type = type ?? throw new ArgumentNullException(nameof(type));
        Number = number;
        YearBuilt = yearBuilt;
    }

    public string GetYearBuiltInHex() => YearBuilt.ToString("X");
    public override string ToString() =>
        $"Город: {City}, Улица: {Street}, Тип: {Type}, Номер: {Number}, Год постройки: {YearBuilt}, Кол-во квартир: {NumberOfApartments}, Кол-во этажей: {NumberOfFloors}";

    public int CompareTo(House? other)
    {
        if (other == null) return 1;

        return NumberOfApartments.CompareTo(other.NumberOfApartments);
    }
}