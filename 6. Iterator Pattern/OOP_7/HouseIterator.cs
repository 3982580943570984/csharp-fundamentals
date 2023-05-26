namespace Studying;

public class HouseIterator : IIterator<House>
{
    private readonly HouseAggregate _houseAggregate;
    private int _position = -1;

    public HouseIterator(HouseAggregate houseAggregate) => _houseAggregate = houseAggregate;

    public House First()
    {
        _position = 0;
        return _houseAggregate[0];
    }
    public House Next()
    {
        _position++;
        return _houseAggregate[_position];
    }
    public House Prev()
    {
        _position--;
        if (_position < 0)
            _position = 0;
        return _houseAggregate[_position];
    }
    public bool HasCurrent() => _position >= 0;
    public House GetCurrent() => _houseAggregate[_position];
    public bool HasNext() => (_position < _houseAggregate.GetCount() - 1);
    public void MoveToPosition(int position)
    {
        if (position >= 0 && position < _houseAggregate.GetCount())
            _position = position;
        else
            throw new ArgumentOutOfRangeException(nameof(position));
    }
    public int GetPosiiton() => _position;
}
