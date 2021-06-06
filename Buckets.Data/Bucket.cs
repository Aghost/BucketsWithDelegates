using System;

namespace Buckets.Data
{
    public sealed class Bucket : Container
    {
        //private Bucket(int capacity, int content) : base(capacity, content) { }
        public Bucket(int capacity = 12, int content = 0) : base(capacity, content) {
            if (capacity < 10 || capacity > 12) {
                throw new ArgumentOutOfRangeException("max", $"bucket minimum: 10, maximum: 12\n");
            }
        }
    }
}
