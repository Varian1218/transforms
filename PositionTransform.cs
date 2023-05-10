// using System.Numerics;
//
// namespace Transforms
// {
//     public class PositionTransform : ITransform
//     {
//         public ITransform Impl { get; set; }
//         public IPositionTransform Position { get; set; }
//
//         public T GetComponent<T>()
//         {
//             return Impl.GetComponent<T>();
//         }
//
//         Vector3 IPositionTransform.Position
//         {
//             get => Impl.Position;
//             set
//             {
//                 Impl.Position = value;
//                 Position.Position = value;
//             }
//         }
//
//         public Vector3 Forward
//         {
//             get => Impl.Forward;
//             set => Impl.Forward = value;
//         }
//
//         public Vector3 LocalScale
//         {
//             get => Impl.LocalScale;
//             set => Impl.LocalScale = value;
//         }
//
//         public Vector3 Up => Impl.Up;
//
//         public void AddChild(IComponentGetHandler child)
//         {
//             Impl.AddChild(child);
//         }
//
//         public void AddChild(IComponentGetHandler child, bool worldPositionStays)
//         {
//             Impl.AddChild(child, worldPositionStays);
//         }
//
//         public void Destroy()
//         {
//             Impl.Destroy();
//         }
//     }
// }