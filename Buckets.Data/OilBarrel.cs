using System;

namespace Buckets.Data
{
    public sealed class OilBarrel : Container
    {
        public OilBarrel(int content = 0, int capacity = 159) : base(capacity, content) {
            Capacity = 159;
            if (content > Capacity || content < 0) {
                throw new ArgumentOutOfRangeException("content", $"oilbarrel content exception. minimum: 0, maximum: 159");
            }

            Content = content;
        }
    }
}
