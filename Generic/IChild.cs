namespace Ewancoder.Solid.Generic
{
    public interface IChild<out T>
    {
        T Parent { get; }
    }
}