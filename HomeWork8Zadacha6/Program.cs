using System;

namespace HomeWork8Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("строка:\t");
            int n = Num();
            Console.Write("колонна:\t");
            int m = Num();
            DoubMas mas = new DoubMas(n, m);
            mas.FilMas();
            Console.WriteLine("не сортированный масив");
            mas.ShowMas();
            Console.WriteLine("сортированный массив");
            mas.SortMas();
            mas.ShowMas();
            Console.WriteLine($"общее количество элементов {mas.IsElement}");
            Console.WriteLine("умноженный на скаляр");
            mas.skalyar = 3;
            mas.ShowMas();

        }
        static int Num()
        {
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
                    return a;
                else
                    Console.Write("введите коректные данные:");
            }
        }

    }
}
