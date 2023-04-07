using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace Transforms
{
    public class UnityTransform : ITransform
    {
        private Transform _impl;

        public Vector3 Forward
        {
            get => UnityUtils.Convert(_impl.forward);
            set => _impl.forward = UnityUtils.Convert(value);
        }

        public Vector3 LocalScale
        {
            get => UnityUtils.Convert(_impl.localScale);
            set => _impl.localScale = UnityUtils.Convert(value);
        }

        public Vector3 Up => UnityUtils.Convert(_impl.up);

        public Transform Impl
        {
            set => _impl = value;
        }

        public Vector3 Position
        {
            get => UnityUtils.Convert(_impl.position);
            set => _impl.position = UnityUtils.Convert(value);
        }
    }
}