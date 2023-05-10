// using UnityEngine;
// using Vector3 = System.Numerics.Vector3;
//
// namespace Transforms
// {
//     [CreateAssetMenu(fileName = "Transform", menuName = "Transforms/Transform")]
//     public class ScriptableObjectTransform : ScriptableObject, ITransform
//     {
//         private ITransform _impl;
//
//         public ITransform Impl
//         {
//             set => _impl = value;
//         }
//
//         public Vector3 Forward
//         {
//             get => _impl.Forward;
//             set => _impl.Forward = value;
//         }
//
//         public Vector3 Position
//         {
//             get => _impl.Position;
//             set => _impl.Position = value;
//         }
//
//         public Vector3 LocalScale
//         {
//             get => _impl.LocalScale;
//             set => _impl.LocalScale = value;
//         }
//
//         public Vector3 Up => _impl.Up;
//
//         public void AddChild(IComponentGetHandler child)
//         {
//             _impl.AddChild(child);
//         }
//
//         public void AddChild(IComponentGetHandler child, bool worldPositionStays)
//         {
//             _impl.AddChild(child, worldPositionStays);
//         }
//
//         public void Destroy()
//         {
//             _impl.Destroy();
//         }
//
//         public T GetComponent<T>()
//         {
//             return _impl.GetComponent<T>();
//         }
//     }
// }