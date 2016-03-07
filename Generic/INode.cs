namespace Ewancoder.Solid.Generic
{
    public interface INode<TParent, TChild> : IChild<TParent>, IParent<TChild> { }

    public interface INode<T> : IChild<T>, IParent<T> { }
}