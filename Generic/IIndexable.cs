namespace Ewancoder.Solid.Generic
{
    public interface IIndexable<T, in TKey>
    {
        T this[TKey index] { get; set; }
    }

    public interface IIndexable<T> : IIndexable<T, int> { }
}