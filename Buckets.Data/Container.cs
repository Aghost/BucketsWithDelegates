using System;
using static Buckets.Data.DelegatedMethods;
using static System.Console;

namespace Buckets.Data
{
    public delegate int ChangeAmountDelegate(Container sender, int x);
    public delegate bool OverflowingDelegate(Container sender, int x);
    public delegate bool ReachedCapacityDelegate(Container sender, int x);

    public abstract class Container
    {
        private int _Capacity;
        private int _Content;

        public int Capacity {
            get => this._Capacity;
            set => this._Capacity = value;
        }

        public int Content {
            get => this._Content;
            set {
                this.reachedCapacity?.Invoke(this, value); // if (this.reachedCapacity != null) { this.reachedCapacity.Invoke(this, value); }

                if (this.overflowing != null) {
                    if (this.overflowing.Invoke(this, value))
                        return;
                }

                this._Content = (this.changeAmount != null) ? this.changeAmount.Invoke(this, value) : value;
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
        public ReachedCapacityDelegate reachedCapacity;

        // public Fill(int amount) { self._Content += amount }
        // public Fill(int amount, Container container) { self._Content += amount } ?
        // public Empty() { Content = 0 }

        public void Info(string mssg = "Container") {
            WriteLine($"{mssg} {Capacity}:{Content}");
        }
    }
}
