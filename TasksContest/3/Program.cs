using System;
using System.Linq;
using System.Drawing; 

class Program {
    static void DrawQuadrilateral(Point point1, Point point2, Point point3, Point point4) { // Рисуем четырехугольник по точкам
        return point1.X == point2.X &&  point1.Y == point4.Y && point2.Y == point3.Y && point3.X == point4.X;
    }
    static void Main(string[] args) {
        var n = Convert.ToInt32(Console.ReadlLIne());
        var points = new Point[n];
        for (int i=0; i<n; i++) { // заполняет массив значениями и перебирает элементы
            var Line = Console.ReadLine().Split(); // содержит координаты точек в ввиде строк 
            points[i] = new Point(int.Parse(Line[0]), int.Parse(Line[1])); // points[0] первая точка массива и
        }
    }
}