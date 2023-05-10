using System.Numerics;
using Cameras;

namespace Transforms.Cameras
{
    public class CameraTransform : ITransform
    {
        public ICamera Camera { get; set; }
        public ITransform Impl { get; set; }

        public T GetComponent<T>()
        {
            return Impl.GetComponent<T>();
        }

        public TransformData Data
        {
            get => Impl.Data;
            set => Impl.Data = value;
        }

        public Vector3 Forward
        {
            get => Impl.Forward;
            set => Impl.Forward = value;
        }

        public Vector3 Position
        {
            get => Impl.Position;
            set => Impl.Position = Camera.WorldToScreenPoint(value);
        }

        public Vector3 LocalScale
        {
            get => Impl.LocalScale;
            set => Impl.LocalScale = value;
        }

        public Vector3 Up => Impl.Up;

        public void AddChild(IComponentGetHandler child)
        {
            Impl.AddChild(child);
        }

        public void AddChild(IComponentGetHandler child, bool worldPositionStays)
        {
            Impl.AddChild(child, worldPositionStays);
        }

        public void Destroy()
        {
            Impl.Destroy();
        }
    }
}