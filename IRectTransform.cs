using System.Numerics;

namespace Transforms
{
    public interface IRectTransform
    {
        float Height { get; }
        Vector2 Size { get; }
        ITransform Transform { get; }
        float Width { get; }
    }
}