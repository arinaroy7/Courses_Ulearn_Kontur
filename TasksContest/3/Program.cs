using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

// по 2 точкам вычисляется площадь 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static bool IsExistPoint(Dictionary<long, List<long>> dict, long x, long y)
        {
            if (!dict.ContainsKey(x))
            {
                return false;
            }
            return dict[x].Contains(y);
        }

        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine()); // Считываем количество точек
            var points = new Point[n]; // Создаём массив точек
            var dict = new Dictionary<long, List<long>>(); // Словарь для хранения координат

            for (long i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(); // Считываем строку, разбиваем её на массив строк
                long x = long.Parse(line[0]); // Парсим первую координату x
                long y = long.Parse(line[1]); // Парсим вторую координату y
                points[i] = new Point((int)x, (int)y); // Записываем точку в массив

                if (dict.ContainsKey(x)) // Если уже есть точки с координатой x
                {
                    dict[x].Add(y); // Добавляем y в список значений
                }
                else
                {
                    dict.Add(x, new List<long> { y }); // Создаём новую запись x -> {y}
                }
            }

            long maxS = 0; // Переменная для хранения максимальной площади
            for (long i1 = 0; i1 < n; i1++) // Перебираем первую точку (верхний левый угол)
            {
                for (long i3 = 0; i3 < n; i3++) // Перебираем диагональную точку (нижний правый угол)
                {
                    long point2X = points[i1].X; // x второй точки (верхний правый угол)
                    long point2Y = points[i3].Y; // y второй точки
                    long point4X = points[i3].X; // x четвёртой точки (нижний левый угол)
                    long point4Y = points[i1].Y; // y четвёртой точки

                    long s = Math.Abs(points[i1].X - points[i3].X) * Math.Abs(points[i1].Y - points[i3].Y);

                    if (s > maxS && IsExistPoint(dict, point2X, point2Y) && IsExistPoint(dict, point4X, point4Y))
                    {
                        maxS = s; // Обновляем максимальную площадь, если нашёлся прямоугольник
                    }
                }
            }
            Console.WriteLine(maxS); // Выводим найденную максимальную площадь
        }
    }
}