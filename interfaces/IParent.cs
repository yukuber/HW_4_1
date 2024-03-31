using System;

namespace HW_4_1.interfaces;

    interface IParent<T>
    {
        void Add(T element);

        // void Remove(T element);

        int Length();
        int Length(Func<T, bool> func);

        bool Check(T element);

        T Find(Func<T, bool> func);

        T[] FindAll(Func<T, bool> func);
        T[] FindAll<TResult>();
    }
