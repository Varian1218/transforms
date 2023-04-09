using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace Transforms
{
    public class UnityRectTransform : IRectTransform
    {
        private RectTransform _impl;

        public RectTransform Impl
        {
            set
            {
                _impl = value;
                Transform = new UnityTransform
                {
                    Impl = value
                };
            }
        }

        public float Height => _impl.rect.size.y;
        public Vector2 Size => UnityUtils.Convert(_impl.rect.size);
        public ITransform Transform { get; private set; }
        public float Width => _impl.rect.size.x;
    }
}