using System;
using System.Linq;
class Program {
    static void Main(string[] args) {

        var n = Convert.ToInt32(Console.ReadLine());

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var index1 = 0;
        var index2 = 0;
        var max = int.MinValue;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i == j) continue; // пропускаем
                
                var dif = numbers[i] - numbers[j];
                if (dif > max) {
                    max = dif; // если текущая разность больше, чем макс, то все обновляем
                    index1 = i;
                    index2 = j;
                }
                else if (dif == max && i - j > index1 - index2) {
                        index1 = i;
                        index2 = j;
                }
            }
        }
        Console.WriteLine((index1 + 1) + " " + (index2+1));    
    }
}