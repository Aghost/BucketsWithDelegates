using System;
using static System.Console;

namespace Buckets.Data
{
    public static class DelegatedMethods
    {
        public static int ChangeAmount(Container container, int amount) {
            //WriteLine($"{container.Content} {container.Capacity} {amount}");
            Write("Change Amount Delegate: ");
            WriteLine($"Success! {container.Content} -> {amount}");

            return amount;
        }

        public static bool Overflowing(Container container, int amount) {
            if (amount > container.Capacity){
                WriteLine($"Overflowing! -> amount({amount}) > Capacity({container.Capacity})");
                return true;
            }

            return false;
        }

        public static bool ReachedCapacity(Container container, int amount) {
            if (amount == container.Capacity){
                WriteLine($"Reached Capacity! -> amount({amount}) == Capacity({container.Capacity})");
                return true;
            }

            return false;
        }
    }
}
