using UnityEngine;
using SystemVector3 = System.Numerics.Vector3;
using UnityVector3 = UnityEngine.Vector3;

namespace Transforms
{
    public class UnityTransform : ITransform
    {
        private Transform _impl;

        public SystemVector3 Forward
        {
            set => _impl.forward = Convert(value);
        }

        public SystemVector3 Position
        {
            get => Convert(_impl.position);
            set => _impl.position = Convert(value);
        }

        public SystemVector3 Up => Convert(_impl.up);

        public Transform Impl
        {
            set => _impl = value;
        }

        private static SystemVector3 Convert(UnityVector3 value)
        {
            return new SystemVector3(value.x, value.y, value.z);
        }

        private static UnityVector3 Convert(SystemVector3 value)
        {
            return new UnityVector3(value.X, value.Y, value.Z);
        }
    }
}