using System;

namespace Buckets.Data
{
    public sealed class OilBarrel : Container
    {
        public OilBarrel(int content = 0, int capacity = 159) : base(capacity, content) {
            Capacity = 159;
            Content = content;
        }
    }
}
