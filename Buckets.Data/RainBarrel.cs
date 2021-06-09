using System;

namespace Buckets.Data
{
    public static class RainBarrelSizes {
        public const int Small = 80;
        public const int Medium = 100;
        public const int Large = 120;
    }

    public sealed class RainBarrel : Container
    {
        public RainBarrel(int capacity = RainBarrelSizes.Medium, int content = 0) : base(capacity, content) {
            if (content > capacity || content < 0) {
                throw new ArgumentOutOfRangeException("content", $"rainbarrel content exception. minimun 0, maximum capacity");
            }
            
        }
    }
}
