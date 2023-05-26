using System.Collections;

namespace Studying;

internal class CollectionType<T> : ICollection<T>, IComparable<CollectionType<T>> where T : IComparable<T>
{
    private readonly List<T> _list = new();

    public CollectionType() { }
    public CollectionType(IEnumerable<T> collection) => _list = new List<T>(collection);

    public int Count => _list.Count;
    public bool IsReadOnly => false;
    public void Add(T item) => _list.Add(item);
    public bool Remove(T item) => _list.Remove(item);
    public void Clear() => _list.Clear();
    public bool Contains(T item) => _list.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();
    public int CompareTo(CollectionType<T>? other)
    {
        if (other == null) return 1;
        if (Count != other.Count) return Count.CompareTo(other.Count);
        for (int i = 0; i < Count; i++)
        {
            int comparisonResult = this[i].CompareTo(other[i]);
            if (comparisonResult != 0) return comparisonResult;
        }
        return 0;
    }
    public T this[int index]
    {
        get => _list[index];
        set => _list[index] = value;
    }
}
