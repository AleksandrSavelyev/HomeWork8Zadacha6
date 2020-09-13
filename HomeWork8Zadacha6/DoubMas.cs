using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8Zadacha6
{
    class DoubMas
    {
        int n = 0, m = 0;
        double[,] mas;
        public DoubMas(int n, int m)
        {
            mas = new double[n, m];
        }
        public void FilMas()
        {
            for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"введите элемент массива под индексом{i}/{j} :\t");
                    mas[i, j] = Num();
                }
            }
        }
        public void ShowMas()
        {
            for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void SortMas()
        {
            double temp = mas[0, 0];
            for (int x = 0; x < mas.GetLength(0); x++)
            {
                for (int y = 0; y < mas.GetLength(1); y++)
                {
                    for (int i = 0; i < mas.GetLength(0); i++)
                    {
                        for (int j = i + 1; j < mas.GetLength(1);j++)
                        {
                            if (mas[x, i] < mas[x, j])
                            {
                                temp = mas[x, j];
                                mas[x, j] = mas[x, i];
                                mas[x, i] = temp;

                            }
                        }
                    }
                }
            }
        }
        private int isElement;
        public int IsElement
        {
            get
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    isElement += 1;
                }
                return isElement;
            }
        }
        public double skalyar
        {
            set
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        mas[i, j] *= value;
                    }
                }
            }
        }

        static double Num()
        {
            for (; ; )
            {
                if (double.TryParse(Console.ReadLine(), out double a))
                    return a;
                else
                    Console.Write("введите коректные данные:\t");
            }

        }
    }
}
