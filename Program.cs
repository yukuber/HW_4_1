using System;
using HW_4_1.classes;

namespace HW_4_1;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину массива. Введите 0 для дефолтного значения длины");
            int n = int.Parse(Console.ReadLine());

            One_dim<int> custom_array = (n == 0) ? new() : new(n);

            Console.WriteLine("Введите количество элементов");
            int current_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значения элементов (по одному элементу в строку)");
            for (int i = 0; i < current_length; i++)
            {
                custom_array.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Печать через Foreach");
            custom_array.Foreach((x) => Console.WriteLine(x));

            Console.WriteLine("Первый четный элемент");
            Console.WriteLine(custom_array.Find(t => t % 2 == 0));

            Console.WriteLine("Вывод элементов больших 10");
            custom_array.Print(custom_array.FindAll(t => t > 10));

            Console.WriteLine("Вывод элементов типа double");
            custom_array.Print(custom_array.FindAll<double>());

            Console.WriteLine("Введите значение для проверки на наличие в массиве");
            Console.WriteLine(custom_array.Check(int.Parse(Console.ReadLine())));

            // Console.WriteLine("Введите значение элемента для удаления");
            // custom_array.Remove(int.Parse(Console.ReadLine()));
            // custom_array.Print();
        }
    }