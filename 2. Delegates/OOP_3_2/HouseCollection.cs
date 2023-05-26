using System.Collections;

namespace Studying;

internal class HouseCollection : IEnumerable
{
    public readonly Hashtable _houses = new();
    // delegate определяет сигнатуру метода
    public delegate void HouseCollectionChangedEventHandler(object sender, HouseCollectionChangedEventArgs e);
    // event является реализацией delegate
    public event HouseCollectionChangedEventHandler? HouseCollectionChanged;

    public void Add(House house)
    {
        if (_houses.Contains(house))
            throw new ArgumentException($"Дом с адресом {house.City}, {house.Street}, {house.Number} уже добавлен в коллекцию.");

        _houses.Add(house.GetHashCode(), house);

        OnHouseCollectionChanged(new HouseCollectionChangedEventArgs(HouseCollectionChangedEventType.Added, house));
    }
    public void Remove(House house)
    {
        if (_houses.Contains(house))
        {
            _houses.Remove(house.GetHashCode());

            OnHouseCollectionChanged(new HouseCollectionChangedEventArgs(HouseCollectionChangedEventType.Removed, house));
        }
    }
    private void OnHouseCollectionChanged(HouseCollectionChangedEventArgs e) => HouseCollectionChanged?.Invoke(this, e);

    public IEnumerator GetEnumerator() => _houses.GetEnumerator();
}
