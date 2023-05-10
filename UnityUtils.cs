using SystemQuaternion = System.Numerics.Quaternion;
using SystemVector2 = System.Numerics.Vector2;
using SystemVector3 = System.Numerics.Vector3;
using UnityQuaternion = UnityEngine.Quaternion;
using UnityVector2 = UnityEngine.Vector2;
using UnityVector3 = UnityEngine.Vector3;

namespace Transforms
{
    public static class UnityUtils
    {
        public static SystemVector2 Convert(UnityVector2 value)
        {
            return new SystemVector2(value.x, value.y);
        }
        
        public static UnityVector2 Convert(SystemVector2 value)
        {
            return new UnityVector2(value.X, value.Y);
        }
        
        public static SystemVector3 Convert(UnityVector3 value)
        {
            return new SystemVector3(value.x, value.y, value.z);
        }

        public static UnityVector3 Convert(SystemVector3 value)
        {
            return new UnityVector3(value.X, value.Y, value.Z);
        }

        public static UnityQuaternion Convert(SystemQuaternion value)
        {
            return new UnityQuaternion(value.X, value.Y, value.Z, value.W);
        }

        public static SystemQuaternion Convert(UnityQuaternion value)
        {
            return new SystemQuaternion(value.x, value.y, value.z, value.w);
        }
    }
}