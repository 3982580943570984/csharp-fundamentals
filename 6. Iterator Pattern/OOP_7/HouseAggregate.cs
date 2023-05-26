namespace Studying;

public class HouseAggregate : IAggregate<House>
{
    private List<House> _houses = new();

    public HouseAggregate() { }
    public HouseAggregate(List<House> houses) => _houses = houses;

    public IIterator<House> CreateIterator() => new HouseIterator(this);
    public void Clear() => _houses.Clear();
    public void AddHouse(House house) => _houses.Add(house);
    public void RemoveHouse(House house) => _houses.Remove(house);
    public House? GetHouse(int index)
    {
        if (index < 0 || index >= _houses.Count)
            return null;
        return _houses[index];
    }
    public House? this[int index]
    {
        get
        {
            if (index < 0 || index >= _houses.Count)
                return null;
            return _houses[index];
        }
        set
        {
            if (index < 0 || index >= _houses.Count)
                throw new IndexOutOfRangeException();
            _houses[index] = value;
        }
    }

    public int GetCount() => _houses.Count;
}
