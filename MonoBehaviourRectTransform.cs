using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace Transforms
{
    public class MonoBehaviourRectTransform : MonoBehaviour, IRectTransform
    {
        private IRectTransform _impl;

        private IRectTransform Impl => _impl ??= new UnityRectTransform
        {
            Impl = GetComponent<RectTransform>()
        };

        public float Height => Impl.Height;

        public ITransform Parent
        {
            set => Impl.Parent = value;
        }

        public Vector2 Size
        {
            get => Impl.Size;
            set => Impl.Size = value;
        }

        public ITransform Transform => Impl.Transform;

        public float Width => Impl.Width;
    }
}