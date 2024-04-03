using System;

namespace HW_4_1.classes
{
    sealed class One_dim<T> : Parent<T>
    {

        private int default_d1_length = 0;
        private T[] array;

        public One_dim(int d1_length) : base(d1_length)
        {
            array = new T[d1_length];
        }
        public One_dim() { }

        public override void Add(T element)
        {
            if (d1_length >= default_d1_length)
            {
                d1_length = d1_length * 2 + 1;
                Array.Resize(ref array, d1_length);
            }
            array[default_d1_length] = element;
            default_d1_length++;
        }

        // public override void Remove(T element)
        // {
        //     default_d1_length--;
        // }

        public override int Length(Func<T, bool> condition)
        {
            int ans = 0;
            for (int i = 0; i < d1_length; i++)
            {
                if (condition(array[i]))
                {
                    ans += 1;
                }
            }
            return ans;
        }
        public override int Length()
        {
            return default_d1_length;
        }

        public override bool Check(T element)
        {
            return FindIndex(element) != -1;
        }

        public override void Reverse()
        {
            T[] _d1 = new T[d1_length];

            for (int i = 0; i < d1_length; i++)
            {
                _d1[i] = array[d1_length - i - 1];
            }

            array = _d1;
        }

        public override void Foreach(Action<T> action)
        {
            for (int i = 0; i < d1_length; i++)
            {
                action(array[i]);
            }
        }


        public override T Find(Func<T, bool> condition)
        {
            return array[FindIndex(condition)];
        }

        public override T[] FindAll(Func<T, bool> condition)
        {
            T[] elements = new T[Length(condition)];
            int index = 0;

            for (int i = 0; i < d1_length; i++)
            {
                if (condition(array[i]))
                {
                    elements[index] = array[i];
                    index++;
                }
            }

            return elements;
        }

        public override T[] FindAll<TResult>()
        {
            T[] elements = new T[default_d1_length];
            int index = 0;

            for (int i = 0; i < d1_length; i++)
            {
                if (array[i] is TResult)
                {
                    elements[index] = array[i];
                    index++;
                }
            }

            Array.Resize(ref elements, index);
            return elements;
        }

        private int FindIndex(Func<T, bool> condition)
        {
            for (int i = 0; i < default_d1_length; i++)
            {
                if (condition(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        private int FindIndex(T element)
        {
            for (int i = 0; i < d1_length; i++)
            {
                if (element.Equals(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public override TResult[] Projection<TResult>(Func<T, TResult> project)
        {
            TResult[] _d1 = new TResult[default_d1_length];

            for (int i = 0; i < default_d1_length; i++)
            {
                _d1[i] = project(array[i]);
            }

            return _d1;
        }

        public void Print()
        {
            foreach (T element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
        public void Print(T[] _d1)
        {
            foreach (T element in _d1)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
