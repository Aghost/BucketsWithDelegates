using System;

namespace Buckets.Data
{
    public sealed class Bucket : Container
    {
        //private Bucket(int capacity, int content) : base(capacity, content) { }
        public Bucket(int capacity = 12, int content = 0) : base(capacity, content) {
            if (capacity < 10 || capacity > 12) {
                throw new ArgumentOutOfRangeException("capacity", $"bucket capacity exception. minimum: 10, maximum: 12");
            }

            if (content > capacity || content < 0) {
                throw new ArgumentOutOfRangeException("content", $"bucket content exception. minimum: 0, maximum: capacity");
            }
        }
    }
}
