using System;
using System.Numerics;

namespace Transforms
{
    public class EventTransform : ITransform
    {
        private ITransform _impl;

        public Vector3 Forward
        {
            get => _impl.Forward;
            set
            {
                _impl.Forward = value;
                ForwardChanged?.Invoke(value);
            }
        }

        public event Action<Vector3> ForwardChanged;

        public Vector3 Position
        {
            get => _impl.Position;
            set
            {
                _impl.Position = value;
                PositionChanged?.Invoke(value);
            }
        }

        public Vector3 LocalScale
        {
            get => _impl.LocalScale;
            set => _impl.LocalScale = value;
        }

        public Vector3 Up => _impl.Up;

        public event Action<Vector3> PositionChanged;

        public ITransform Impl
        {
            set => _impl = value;
        }
    }
}