namespace Ewancoder.Solid.Generic
{
    using System.Collections.Generic;

    public interface IParent<T>
    {
        ICollection<T> Children { get; }
    }
}