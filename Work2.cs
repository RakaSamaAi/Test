using System;
class Work2 {
    public static void Run() {
        Console.Write("Введите координату X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        int quadrant = GetQuadrant(x, y);

        Console.WriteLine($"Точка находится в {quadrant}-й координатной четверти.");
    }

    static int GetQuadrant(double x, double y) {
        if (x > 0 && y > 0) {
            return 1;
        } else if (x < 0 && y > 0) {
            return 2;
        } else if (x < 0 && y < 0) {
            return 3;
        } else if (x > 0 && y < 0) {
            return 4;
        } else {
            
            return 0;
        }
    }
}
