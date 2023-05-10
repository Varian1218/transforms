// using UnityEngine;
// using Vector3 = System.Numerics.Vector3;
//
// namespace Transforms
// {
//     public class MonoBehaviourTransform : MonoBehaviour, ITransform
//     {
//         public Vector3 Forward
//         {
//             get => UnityUtils.Convert(transform.forward);
//             set => transform.forward = UnityUtils.Convert(value);
//         }
//
//         public Vector3 Position
//         {
//             get => UnityUtils.Convert(transform.position);
//             set => transform.position = UnityUtils.Convert(value);
//         }
//
//         public Vector3 LocalScale
//         {
//             get => UnityUtils.Convert(transform.localScale);
//             set => transform.localScale = UnityUtils.Convert(value);
//         }
//
//         public Vector3 Up
//         {
//             get => UnityUtils.Convert(transform.up);
//         }
//
//         public void AddChild(IComponentGetHandler child)
//         {
//             child.GetComponent<Transform>().SetParent(transform);
//         }
//
//         public void AddChild(IComponentGetHandler child, bool worldPositionStays)
//         {
//             child.GetComponent<Transform>().SetParent(transform, worldPositionStays);
//         }
//
//         public void Destroy()
//         {
//             Destroy(gameObject);
//         }
//     }
// }