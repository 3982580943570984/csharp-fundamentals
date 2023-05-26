using System.ComponentModel;

namespace Studying
{
    public sealed class House
    {
        [DisplayName("Город")]
        public string City { get; set; } = string.Empty;
        [DisplayName("Улица")]
        public string Street { get; set; } = string.Empty;
        [DisplayName("Тип")]
        public string Type { get; set; } = string.Empty;
        [DisplayName("Номер")]
        public ushort Number { get; set; } = 0;
        [DisplayName("Год постройки")]
        public ushort YearBuilt { get; set; } = 0;
        [DisplayName("Количество этажей")]
        public ushort NumberOfFloors { get; set; } = 0;
        [DisplayName("Количество квартир")]
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
        public override string ToString() => $"House: {City}, {Street}, {Type}, {Number}, {YearBuilt}, {NumberOfApartments}, {NumberOfFloors}";
    }
}