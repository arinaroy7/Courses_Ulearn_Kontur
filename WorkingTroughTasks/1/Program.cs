// Тренировочная задача (моя)

using System;
using System.Linq;

class Program {
    static void Main(string[] args) {

        var n = Convert.ToInt32(Console.ReadLine());
        var t = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var temperatureMin = 0; // первый элемент массива
        var temperatureMax = 0;

        for (int i=0; i < n; i++) {
            if (t[i] < t[temperatureMin]) {
                temperatureMin = i;
            }
            if (t[i] >= t[temperatureMax]) {
                temperatureMax = i;
            }
        }
        Console.WriteLine(temperatureMin + " " + temperatureMax);
    }
}