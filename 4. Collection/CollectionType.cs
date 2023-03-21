using System.Collections;

namespace Studying
{
    public class CollectionType<T> : ICollection<T> where T : IComparable
    {
        private readonly List<T> items = new();

        public CollectionType() { }

        public CollectionType(List<T> items) => this.items = items;

        public int Count => items.Count;

        public bool IsReadOnly => false;

        public void Add(T item) => items.Add(item);

        public void Clear() => items.Clear();

        public bool Contains(T item) => items.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        public bool Remove(T item) => items.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public T this[int index] {
            get { 
                if (index >= 0 && index < Count)
                    return items[index];
                else
                    throw new ArgumentOutOfRangeException(nameof(index));
            }
            set
            {
                if (index >= 0 && index < Count)
                    items[index] = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(index));
            }
        }
    }
}
