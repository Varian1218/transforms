using System.Numerics;

namespace Transforms
{
    public interface ITransform
    {
        Vector3 Forward { set; }
        Vector3 Position { get; set; }
    }
}