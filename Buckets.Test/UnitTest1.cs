using System;
using Buckets.Data;
using Xunit;

namespace Buckets.Test
{
    public partial class BucketsTest
    {
        [Fact]
        public void BucketTest() {
            // Arrange
            Bucket[] buckets = new Bucket[] {
                new Bucket(10, 0),
                new Bucket(),
                new Bucket(10),
                new Bucket(10, 5)
            };

            // Act
            int[] actual = new int[] {
                buckets[0].Capacity, buckets[0].Content,
                buckets[1].Capacity, buckets[1].Content,
                buckets[2].Capacity, buckets[2].Content,
                buckets[3].Capacity, buckets[3].Content
            };
            int[] expected = new int[] {
                10,     0,
                12,     0,
                10,     0,
                10,     5
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OilBarrelTest() {
            ChangeAmountDelegate cad;
            OverflowingDelegate ofd;
            OverflowActionDelegate ofa;
            ReachedCapacityDelegate rcd;

            cad = DelegatedMethods.ChangeAmount;
            ofd = DelegatedMethods.Overflowing;
            ofa = DelegatedMethods.OverflowAction;
            rcd = DelegatedMethods.ReachedCapacity;

            // Arrange
            OilBarrel[] oilBarrel = new OilBarrel[] {
                new OilBarrel(),
            };

            // Act
            int[] actual = new int[] {
                oilBarrel[0].Capacity, oilBarrel[0].Content
            };
            int[] expected = new int[] { 159, 0};

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RainBarrelTest() {
            ChangeAmountDelegate cad;
            OverflowingDelegate ofd;
            OverflowActionDelegate ofa;
            ReachedCapacityDelegate rcd;

            cad = DelegatedMethods.ChangeAmount;
            ofd = DelegatedMethods.Overflowing;
            ofa = DelegatedMethods.OverflowAction;
            rcd = DelegatedMethods.ReachedCapacity;

            // Arrange
            RainBarrel[] rainBarrel = new RainBarrel[] {
                new RainBarrel(),
                new RainBarrel(RainBarrelSizes.Small),
                new RainBarrel(RainBarrelSizes.Medium, 79),
                new RainBarrel(RainBarrelSizes.Large, 119),
            };

            // Act
            int[] actual = new int[] {
                rainBarrel[0].Capacity, rainBarrel[0].Content,
                rainBarrel[1].Capacity, rainBarrel[1].Content,
                rainBarrel[2].Capacity, rainBarrel[2].Content,
                rainBarrel[3].Capacity, rainBarrel[3].Content
            };
            int[] expected = new int[] {
                100,    0,
                80,     0,
                100,     79,
                120,    119
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BucketDelegateTest() {
            // Arrange
            ChangeAmountDelegate cad;
            OverflowingDelegate ofd;
            OverflowActionDelegate ofa;
            ReachedCapacityDelegate rcd;

            cad = DelegatedMethods.ChangeAmount;
            ofd = DelegatedMethods.Overflowing;
            ofa = DelegatedMethods.OverflowAction;
            rcd = DelegatedMethods.ReachedCapacity;

            Bucket bucket = new Bucket();

            bucket.changeAmount = cad;
            bucket.overflowing = ofd;
            bucket.overflowAction = ofa;
            bucket.reachedCapacity = rcd;

            bucket.Fill(-10);

            // Act
            int[] actual = new int[] { bucket.Capacity, bucket.Content };
            int[] expected = new int[] { 12, 0 };

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
