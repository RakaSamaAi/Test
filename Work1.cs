using System;
class Work1 {
    public static void Run() {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivisible = (number % 7 == 0) && (number % 23 == 0);

        Console.WriteLine($"Число {number} {(isDivisible ? "кратно" : "не кратно")} одновременно 7 и 23.");
    }
}
