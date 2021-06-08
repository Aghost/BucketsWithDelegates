using System;
using Buckets.Data;
using static System.Console;

namespace Buckets.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeAmountDelegate cad;
            OverflowingDelegate ofd;
            OverflowActionDelegate ofa;
            ReachedCapacityDelegate rcd;

            cad = DelegatedMethods.ChangeAmount;
            ofd = DelegatedMethods.Overflowing;
            ofa = DelegatedMethods.OverflowAction;
            rcd = DelegatedMethods.ReachedCapacity;

            Bucket bucket = new Bucket(12, 10);
            bucket.Info();

            bucket.changeAmount = cad;
            bucket.overflowing = ofd;
            bucket.overflowAction = ofa;
            bucket.reachedCapacity = rcd;
            bucket.Content += 1;
            bucket.Content += 1;
            bucket.Content += 1;

            bucket.Info();
            RainBarrel rainBarrel = new RainBarrel(99);
            rainBarrel.Info();

            rainBarrel.changeAmount = cad;
            rainBarrel.overflowing = ofd;
            rainBarrel.reachedCapacity = rcd;
            rainBarrel.overflowAction = ofa;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            rainBarrel.Content += 20;
            WriteLine("---");
            rainBarrel.Fill(10);
            rainBarrel.Empty(1000);
            rainBarrel.Fill(11);
            rainBarrel.Info();
            WriteLine("---");
            
            rainBarrel.Fill(11, bucket);
            rainBarrel.Info();
            WriteLine("---");

            OilBarrel oilBarrel = new OilBarrel(100);
            oilBarrel.Info();

            oilBarrel.changeAmount = cad;
            oilBarrel.overflowing = ofd;
            oilBarrel.reachedCapacity = rcd;
            oilBarrel.Content += 25;
            oilBarrel.Content += 25;
            oilBarrel.Content += 25;
            oilBarrel.Content += 25;

            oilBarrel.Info();
        }
    }
}
