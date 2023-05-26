using System.Collections;

namespace Studying;

internal static class AppData
{
    public static readonly HouseCollection houses = new();
    public static readonly HouseCollectionListener housesListener = new();

    public static readonly Hashtable uniqueHousesHashtable = new();
    public static readonly List<House> uniqueHousesList = new();
    public static List<int> indexes = Enumerable.Range(0, 99999).ToList();

    public static readonly uint amountHouses = 100_000;
    public static readonly House[] arrayHouses = new House[amountHouses];
    public static readonly Hashtable hashtableHouses = new();
}
