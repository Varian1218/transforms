using System.Numerics;

namespace Transforms
{
    public static class TransformUtility
    {
        public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta)
        {
            return UnityUtils.Convert(UnityEngine.Vector3.RotateTowards(
                UnityUtils.Convert(current),
                UnityUtils.Convert(target),
                maxRadiansDelta,
                0f
            ));
        }
    }
}