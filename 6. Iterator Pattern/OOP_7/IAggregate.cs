namespace Studying;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
