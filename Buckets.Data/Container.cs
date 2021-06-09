using System;
using static Buckets.Data.DelegatedMethods;
using static System.Console;

namespace Buckets.Data
{
    public delegate int ChangeAmountDelegate(Container sender, int x);
    public delegate int OverflowingDelegate(Container sender, int x);
    public delegate int OverflowActionDelegate(Container sender, int x);
    public delegate bool ReachedCapacityDelegate(Container sender, int x);

    public abstract class Container
    {
        private int _Capacity;
        private int _Content;

        public int Capacity {
            get => _Capacity;
            //set => _Capacity = value;
        }

        public int Content {
            get => _Content;
            set {
                reachedCapacity?.Invoke(this, value);
                _Content = changeAmount?.Invoke(this, overflowing?.Invoke(this, value) ?? value) ?? _Content;
            }
        }

        // Constructor
        protected Container(int capacity, int content) {
            _Capacity = capacity;
            _Content = content;
        }

        // Delegates
        public ChangeAmountDelegate changeAmount;
        public OverflowingDelegate overflowing;
        public OverflowActionDelegate overflowAction;
        public ReachedCapacityDelegate reachedCapacity;

        public void Fill(int amount) {
            Fill(amount, this);
        }

        public void Fill(int amount, Container container) {
            container.Content = container.Content + amount;
        }

        public void Empty() {
            Content = 0;
        }

        public void Empty(int amount) {
            Content -= amount;
        }

        public void Info(string mssg = "Container") {
            WriteLine($"{mssg} {Capacity}:{Content}");
        }
    }
}
