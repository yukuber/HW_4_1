using System;
using HW_4_1.classes;
namespace HW_4_1;
class Program
{
    static void Main()
    {
        one_dim<int> array = [];
        Console.WriteLine('Введите длину массивов');
        int len_one_dim = int.Parse(Console.ReadLine());

        for (int i = 0; i < len_one_dim; i++)
        {
            //array.Add(Random.Shared.Next(0, 100));
            array.Add(i);
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        array.AddRange(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
