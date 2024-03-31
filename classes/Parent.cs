using System;
using HW_4_1.interfaces;

namespace HW_4_1.classes
{
    abstract class Parent<T> : IParent<T>
    {
        const int default_d1_length = 7;
        protected int d1_length;

        public Parent(int d1_length)
        {
            this.d1_length = d1_length;
        }
        public Parent() : this(default_d1_length) { }

        public abstract void Add(T element);

        // public abstract void Remove(T element);


        public abstract int Length();
        public abstract int Length(Func<T, bool> condition);

        public abstract bool Check(T element);

        public abstract void Foreach(Action<T> action);

        public abstract T Find(Func<T, bool> condition);

        public abstract T[] FindAll(Func<T, bool> condition);
        public abstract T[] FindAll<TResult>();

        public abstract void Reverse();

        public abstract TResult[] Projection<TResult>(Func<T, TResult> project);
    }
}