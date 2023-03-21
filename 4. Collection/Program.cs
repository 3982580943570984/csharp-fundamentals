
using Studying;
using System.Collections;

// Создание самостоятельно определенной обобщенной коллекции
CollectionType<Building> MyCollection = new()
{
    new Building(city: string.Empty,
                 street: string.Empty,
                 type: string.Empty,
                 constructionYear: 0,
                 number: 0,
                 width: 100,
                 length: 1,
                 height: 2),
    new Building(city: string.Empty,
                 street: string.Empty,
                 type: string.Empty,
                 constructionYear: 0,
                 number: 1,
                 width: 100,
                 length: 1,
                 height: 1),
    new Building(city: string.Empty,
                 street: string.Empty,
                 type: string.Empty,
                 constructionYear: 0,
                 number: 2,
                 width: 100,
                 length: 1,
                 height: 100)
};

// Сортировка коллекции относительно ключа
var orderedMyCollection = MyCollection.OrderBy(building => building.Volume);

// Итерирование по сортированной коллекции
foreach (Building building in orderedMyCollection)
    Console.WriteLine(building.ToString());

// Использование индексатора для обращения к объекту
Console.WriteLine(MyCollection[1].ToString());

// Запись строений в файл
StreamWriter BuildingWriter = new("MyCollection.txt");
foreach (var v in MyCollection)
    BuildingWriter.WriteLine(v?.ToString());
BuildingWriter.Close();


// LINQs
CollectionType<Building> MyCollection2 = new() {
    new Building(city: "Alice"),
    new Building(city: "Bob"),
    new Building(city: "Charlie"),
    new Building(city: "David"),
    new Building(city: "Eve")
};
MyCollection2[0].Volume = 10;
MyCollection2[2].Volume = 8;
MyCollection2[3].Volume = 9;

// 1
var LINQ1 = MyCollection2.Where(building => building.City.Length > 4)
                         .Select(building => building.City += "1")
                         .OrderBy(city => city.Length);
foreach (var str in LINQ1)
    Console.WriteLine(str);


// Создание нетипизированной коллекции ArrayList для хранения объектов
ArrayList MyStrings = new()
{
    "1",
    "2",
    "3",
    null
};

// Итерирование по коллекции используя цикл foreach
foreach (var v in MyStrings)
    Console.WriteLine(v?.ToString());
Console.WriteLine();

// Определение входимости строк в коллекцию
Console.WriteLine(MyStrings.Contains("1"));
Console.WriteLine(MyStrings.Contains("3"));
Console.WriteLine(MyStrings.Contains(null));

// Поиск строк определенной длины
uint n = 1;
Console.WriteLine(MyStrings.ToArray()
                           .Count(s => s?.ToString()?.Length == n ));

// Сортировка строк в возрастающем порядке
var orderedMyString = MyStrings.ToArray().Order();
foreach (var v in orderedMyString)
    Console.WriteLine(v?.ToString());
Console.WriteLine();

// Сортировка строк в убывающем порядке
var descendingOrderedMyString = MyStrings.ToArray().OrderDescending();
foreach (var v in descendingOrderedMyString)
    Console.WriteLine(v?.ToString());
Console.WriteLine();

// Запись строк в файл
StreamWriter StringWriter = new("MyStrings.txt");
foreach (var v in MyStrings)
    StringWriter.WriteLine(v?.ToString());
StringWriter.Close();