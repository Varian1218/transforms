using System.Numerics;

namespace Transforms
{
    public interface ITransform
    {
        Vector3 Forward { get; set; }
        Vector3 Position { get; set; }
        Vector3 LocalScale { get; set; }
        Vector3 Up { get; }
        void AddChild(ITransform child);
        void AddChild(ITransform child, bool worldPositionStays);
        void Destroy();
        T GetComponent<T>();
    }
}