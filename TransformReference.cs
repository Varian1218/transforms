using System;
using UnityEngine;
using Object = UnityEngine.Object;
using Vector3 = System.Numerics.Vector3;

namespace Transforms
{
    [Serializable]
    public class TransformReference : ITransform
    {
        [SerializeField] private Transform impl;

        public Vector3 Forward
        {
            get => UnityUtils.Convert(impl.forward);
            set => impl.forward = UnityUtils.Convert(value);
        }

        public Vector3 Position
        {
            get => UnityUtils.Convert(impl.position);
            set => impl.position = UnityUtils.Convert(value);
        }

        public Vector3 LocalScale
        {
            get => UnityUtils.Convert(impl.localScale);
            set => impl.localScale = UnityUtils.Convert(value);
        }

        public Vector3 Up => UnityUtils.Convert(impl.up);

        public void AddChild(ITransform child)
        {
            child.GetComponent<Transform>().SetParent(impl);
        }

        public void AddChild(ITransform child, bool worldPositionStays)
        {
            child.GetComponent<Transform>().SetParent(impl);
        }

        public void Destroy()
        {
            Object.Destroy(impl.gameObject);
        }

        public T GetComponent<T>()
        {
            return impl.GetComponent<T>();
        }
    }
}