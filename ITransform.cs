using System.Numerics;

namespace Transforms
{
    public interface ITransform : IComponentGetHandler, IPositionTransform
    {
        Vector3 Forward { get; set; }
        Vector3 LocalScale { get; set; }
        Vector3 Up { get; }
        void AddChild(IComponentGetHandler child);
        void AddChild(IComponentGetHandler child, bool worldPositionStays);
        void Destroy();
    }
}