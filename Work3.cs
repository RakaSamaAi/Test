using System;

class Work3 {
    public static void Run() {
        Console.Write("Введите целое число из отрезка [10, 99]: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99) {
            int largestDigit = GetLargestDigit(number);

            Console.WriteLine($"Наибольшая цифра в числе {number}: {largestDigit}");
        } else {
            Console.WriteLine("Введенное число не соответствует условиям.");
        }
    }

    static int GetLargestDigit(int number) {
        int tensDigit = number / 10;
        int unitsDigit = number % 10;

        return Math.Max(tensDigit, unitsDigit);
    }
}