namespace Studying;

internal class HouseCollectionChangedEventArgs
{
    public HouseCollectionChangedEventType EventType { get; }
    public House House { get; }

    public HouseCollectionChangedEventArgs(HouseCollectionChangedEventType eventType, House house)
    {
        EventType = eventType;
        House = house;
    }
}
