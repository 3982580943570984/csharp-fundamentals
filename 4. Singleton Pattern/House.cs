public class House
{
    public string Street { get; set; }
    public int Number { get; set; }
    public int YearBuilt { get; set; }
    public int NumberOfApartments { get; set; }

    private static House instance;

    private House()
    {
        // Здесь можно добавить логику инициализации объекта
    }

    public static House GetInstance()
    {
        if (instance == null)
        {
            instance = new House();
        }
        return instance;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Street: {Street}, Number: {Number}, Year Built: {YearBuilt}, Number of Apartments: {NumberOfApartments}");
    }
}
