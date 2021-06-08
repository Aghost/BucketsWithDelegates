using System;

namespace Buckets.Data
{
    public sealed class RainBarrel : Container
    {
        public RainBarrel(int capacity = 100, int content = 0) : base(capacity, content) {
            Capacity = capacity switch {
                int n when (n < 80) => 80,
                int n when (n > 100) => 120,
                _ => 100
            };

            if (content > Capacity || content < 0) {
                throw new ArgumentOutOfRangeException("content", $"rainbarrel content exception. minimun 0, maximum capacity");
            }

            Content = content;
        }
    }
}
