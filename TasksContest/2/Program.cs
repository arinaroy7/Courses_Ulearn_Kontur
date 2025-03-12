// Условие тоже, решение на 10 баллов. Устраняем вложенные циклы
// Есть последовательность чисел и надо найти максимальную разность, для этого возьмем максимум и миниму
// Разность между ними будет максимальна 

using System;
using System.Linq;
class Program {
    static void Main(string[] args) {

        var n = Convert.ToInt32(Console.ReadLine());

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var indexMini = 0;
        var indexMaxi = 0;

        for (int i = 0; i < n; i++) { // использую цикл, чтобы перебрать все элементы массива
            if (numbers[i] < numbers[indexMini]) {
                indexMini = i;
            }
            if (numbers[i] >= numbers[indexMaxi]) {
                indexMaxi = i;
            }
             
        }
        Console.WriteLine((indexMaxi + 1) + " " + (indexMini+1));    
    }
}
