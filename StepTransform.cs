using System.Numerics;
using Times;

namespace Transforms
{
    public class StepTransform : ITransform
    {
        private ITransform _impl;
        private float _rotateSpeed;

        public ITransform Impl
        {
            set => _impl = value;
        }

        public Vector3 Forward { get; set; }

        public Vector3 Position
        {
            get => _impl.Position;
            set => _impl.Position = value;
        }

        public float RotateSpeed
        {
            set => _rotateSpeed = value;
        }

        public Vector3 Up => _impl.Up;

        public void Step(ShortTimeSpan dt)
        {
            var forwardDelta = Forward - _impl.Forward;
            if (forwardDelta.LengthSquared() > 0)
            {
                _impl.Forward = TransformUtility.RotateTowards(_impl.Forward, Forward, _rotateSpeed * dt);
            }
        }
    }
}