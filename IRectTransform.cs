using System.Numerics;

namespace Transforms
{
    public interface IRectTransform
    {
        float Height { get; }
        ITransform Parent { set; }
        Vector2 Size { get; set; }
        ITransform Transform { get; }
        float Width { get; }
    }
}