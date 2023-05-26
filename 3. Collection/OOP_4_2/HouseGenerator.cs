namespace Studying
{
    internal class HouseGenerator
    {
        private static readonly string[] cities = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казань", "Самара", "Омск", "Челябинск", "Ростов-на-Дону", "Уфа", "Волгоград", "Пермь", "Красноярск", "Воронеж", "Саратов", "Краснодар", "Тольятти", "Ижевск", "Барнаул", "Ульяновск", "Тюмень", "Иркутск", "Йошкар-Ола", "Ярославль" };
        private static readonly string[] streets = { "Ленина", "Кирова", "Гагарина", "Пушкина", "Советская", "Мира", "Профсоюзов", "Красная", "Садовая", "Набережная", "Школьная", "Строителей", "Береговая", "Юбилейная", "Парковая", "Центральная", "Зеленая", "Октябрьская", "Мичурина", "Молодежная", "Орджоникидзе", "Рабочая", "Горького", "Солнечная", "Новая" };
        private static readonly string[] buildingTypes = { "Многоквартирный жилой дом", "Частный жилой дом", "Административное здание", "Банк", "Магазин", "Кафе", "Ресторан", "Отель", "Гостиница", "Кинотеатр", "Театр", "Больница", "Школа", "Университет", "Спортзал", "Бассейн", "Сауна", "Парикмахерская", "Кабинет стоматолога", "Ателье" };
        public static House Generate()
        {
            Random random = new();

            string city = cities[random.Next(cities.Length)];
            string street = streets[random.Next(streets.Length)];
            string buildingType = buildingTypes[random.Next(buildingTypes.Length)];
            ushort number = (ushort)random.Next(1, 100);
            ushort yearBuilt = (ushort)random.Next(1900, 2023);
            ushort numberOfFloors = (ushort)random.Next(1, 10);
            ushort numberOfApartments = (ushort)random.Next(1, 100);

            return new House(city, street, buildingType, number, yearBuilt, numberOfFloors, numberOfApartments);
        }
    }
}
