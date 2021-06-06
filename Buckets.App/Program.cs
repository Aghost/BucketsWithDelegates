using System;
using Buckets.Data;

namespace Buckets.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeAmountDelegate cad;
            OverflowingDelegate ofd;
            ReachedCapacityDelegate rcd;

            cad = DelegatedMethods.ChangeAmount;
            ofd = DelegatedMethods.Overflowing;
            rcd = DelegatedMethods.ReachedCapacity;

            /*
            Bucket bucket = new Bucket(12, 10);
            bucket.Info();

            bucket.changeAmount = cad;
            bucket.overflowing = ofd;
            bucket.reachedCapacity = rcd;
            bucket.Content += 1;
            bucket.Content += 1;
            bucket.Content += 1;

            bucket.Info();
            */
            RainBarrel rainBarrel = new RainBarrel(99);
            rainBarrel.Info();

            rainBarrel.changeAmount = cad;
            rainBarrel.overflowing = ofd;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;

            rainBarrel.Info();

            OilBarrel oilBarrel = new OilBarrel(100);
            oilBarrel.Info();

            oilBarrel.changeAmount = cad;
            oilBarrel.overflowing = ofd;
            oilBarrel.reachedCapacity = rcd;
            oilBarrel.Content += 66;
            oilBarrel.Content += 66;
            oilBarrel.Content += 66;
            oilBarrel.Content += 66;

            oilBarrel.Info();
        }
    }
}
