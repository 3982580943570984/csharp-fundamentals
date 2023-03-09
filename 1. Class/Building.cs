namespace Studying
{
    internal class Building
    {
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public ushort ConstructionYear { get; set; }
        public uint Number { get; set; }
        public uint Width { get; set; }
        public uint Length { get; set; }
        public uint Height { get; set; }
        public double Volume { get; set; }

        public Building() { }

        public Building(string city) => City = city;

        public Building(string city, string street) : this(city) => Street = street;

        public Building(string city,
                        string street,
                        string type,
                        ushort constructionYear,
                        uint number,
                        uint width,
                        uint length,
                        uint height) : this(city, street)
        {
            Type = type;
            ConstructionYear = constructionYear;
            Number = number;
            Width = width;
            Length = length;
            Height = height;
            Volume = Convert.ToDouble(width * length * height);
        }

        public string YearToHex() => string.Format("0x{0:X}", ConstructionYear);

        public override bool Equals(object? obj) => base.Equals(obj);

        public override int GetHashCode() => base.GetHashCode();

        public override string? ToString() => $"Город: {City}, Улица: {Street}, Тип: {Type}, Год постройки: {ConstructionYear}, Номер здания: {Number}, Ширина: {Width}, Длина: {Length}, Высота: {Height}, Объем: {Volume}";
    }
}
