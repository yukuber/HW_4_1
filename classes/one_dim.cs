using System;
using HW_4_1.interfaces;

namespace HW_4_1.classes;

public sealed class one_dim<T> : Parent<T>, Ione_dim<T>
{
    private T[] array;

    public one_dim(int len_one_dim)
    {
        array = new T[len_one_dim];
        Create();
    }

    protected override void Create()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next();
        }
    }

    public override void Print()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}
