using CSharpBoosts;

namespace Transforms.Objects
{
    public struct TransformObjectData
    {
        public string Hash;
        public HashValue<int>[] Ints;
        public HashValue<string>[] Strings;
        public TransformData Transform;
    }
}