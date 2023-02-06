using System.Collections;

namespace FluentCalculator.Calculator
{
    internal class FluentCalculator
    {
        private readonly Queue _items;

        public FluentCalculator()
        {
            _items = new Queue();
        }

        #region Items

        public FluentCalculator One
        {
            get
            {
                _items.Enqueue(1f);
                return this;
            }
        }

        public FluentCalculator Two
        {
            get
            {
                _items.Enqueue(2f);
                return this;
            }
        }

        public FluentCalculator Three
        {
            get
            {
                _items.Enqueue(3f);
                return this;
            }
        }

        public FluentCalculator Four
        {
            get
            {
                _items.Enqueue(4f);
                return this;
            }
        }

        public FluentCalculator Five
        {
            get
            {
                _items.Enqueue(5f);
                return this;
            }
        }

        public FluentCalculator Six
        {
            get
            {
                _items.Enqueue(6f);
                return this;
            }
        }

        public FluentCalculator Seven
        {
            get
            {
                _items.Enqueue(7f);
                return this;
            }
        }

        public FluentCalculator Eight
        {
            get
            {
                _items.Enqueue(8f);
                return this;
            }
        }
        public FluentCalculator Nine
        {
            get
            {
                _items.Enqueue(9f);
                return this;
            }
        }

        public FluentCalculator Zero
        {
            get
            {
                _items.Enqueue(0f);
                return this;
            }
        }

        public FluentCalculator Ten
        {
            get
            {
                _items.Enqueue(10f);
                return this;
            }
        }

        public FluentCalculator Plus
        {
            get
            {
                _items.Enqueue(Operation.Plus);
                return this;
            }
        }

        public FluentCalculator Minus
        {
            get
            {
                _items.Enqueue(Operation.Minus);
                return this;
            }
        }

        public FluentCalculator Times
        {
            get
            {
                _items.Enqueue(Operation.Multiply);
                return this;
            }
        }

        public FluentCalculator DividedBy
        {
            get
            {
                _items.Enqueue(Operation.Divide);
                return this;
            }
        }

        #endregion

        public float Result()
        {
            var values = new Stack<float>();
            var operations = new Stack<Operation>();

            while (_items.Count > 0)
            {
                var item = _items.Dequeue();

                switch (item)
                {
                    case float value:
                        values.Push(value);
                        break;
                    case Operation op:
                        {
                            while (operations.Count > 0 && operations.Peek().Priority <= op.Priority)
                            {
                                var operation = operations.Pop();
                                var x = values.Pop();
                                var y = values.Pop();
                                values.Push(operation.Calculate(x, y));
                            }

                            operations.Push(op);
                            break;
                        }
                }
            }

            while (operations.Count > 0)
            {
                var operation = operations.Pop();
                var x = values.Pop();
                var y = values.Pop();
                values.Push(operation.Calculate(x, y));
            }

            _items.Clear();

            return values.Pop();
        }

        public static implicit operator float(FluentCalculator fluentCalculator)
        {
            return fluentCalculator.Result();
        }

        private readonly struct Operation
        {
            public Func<float, float, float> Calculate { get; private init; }
            public int Priority { get; private init; }

            public static Operation Plus { get; } = new Operation { Calculate = (x, y) => y + x, Priority = 2 };
            public static Operation Minus { get; } = new Operation { Calculate = (x, y) => y - x, Priority = 2 };
            public static Operation Multiply { get; } = new Operation { Calculate = (x, y) => y * x, Priority = 1 };
            public static Operation Divide { get; } = new Operation { Calculate = (x, y) => y / x, Priority = 1 };
        }

    }
}
