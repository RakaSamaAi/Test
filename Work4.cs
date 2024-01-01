using System;
class Work4 {
    public static void Run() {
        Console.Write("Введите натуральное число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0) {
            Console.WriteLine($"Цифры числа {n} через запятую: {GetDigitsInReverseOrder(n)}");
        } else {
            Console.WriteLine("Введенное число не является натуральным.");
        }
    }

    static string GetDigitsInReverseOrder(int number) {
        string result = "";

        while (number > 0) {
            int digit = number % 10;
            result = digit + (result == "" ? "" : ",") + result;
            number /= 10;
        }

        return result;
    }
}
