using System;
using static System.Console;

namespace Buckets.Data
{
    public static class DelegatedMethods
    {
        public static int ChangeAmount(Container container, int amount) {
            WriteLine($"Changing Amount. {container.Content} -> {amount}");

            return amount;
        }

        public static bool Overflowing(Container container, int amount) {
            if (amount > container.Capacity || amount < 0){
                WriteLine($"Overflowing! -> amount({amount}) > Capacity({container.Capacity})");
                return true;
            }

            return false;
        }

        public static int OverflowAction(Container container, int amount) { // fill until full, discard rest
            WriteLine($"\t{container.Capacity} OverflowAction test");

            if (amount >= container.Capacity)
                amount = container.Capacity;
            else if (amount <= 0) 
                amount = 0;

            // Cancel? fill other?
            return amount;
        }

        public static bool ReachedCapacity(Container container, int amount) {
            if (amount == container.Capacity){
                WriteLine($"Reached Capacity. -> amount({amount}) == Capacity({container.Capacity})");
                return true;
            }

            return false;
        }
    }
}
