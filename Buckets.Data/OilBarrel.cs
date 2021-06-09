using System;

namespace Buckets.Data
{
    public sealed class OilBarrel : Container
    {
        public OilBarrel(int content = 0, int capacity = 159) : base(capacity, content) {
            if (capacity != 159) {
                throw new ArgumentOutOfRangeException("capacity", $"oilbarrel capacity exception. has to be: 159");
            }
            if (content > Capacity || content < 0) {
                throw new ArgumentOutOfRangeException("content", $"oilbarrel content exception. minimum: 0, maximum: 159");
            }

            Content = content;
        }
    }
}
