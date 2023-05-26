namespace Studying;

public interface IIterator<T>
{
    T First();
    T Next();
    T GetCurrent();
    bool HasNext();
    void MoveToPosition(int position);
}
