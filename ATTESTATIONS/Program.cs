using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1. Вывести все натуральные числа в промежутке от N до 1");
        Console.WriteLine("2. Найти сумму натуральных чисел в промежутке от M до N");
        Console.WriteLine("3. Вычислить функцию Аккермана для m и n");
        Console.Write("Введите номер задачи (1, 2 или 3): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Введите значение N: ");
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine("Натуральные числа от N до 1:");
                PrintNaturalNumbers(N);
                break;

            case 2:
                Console.Write("Введите значение M: ");
                int M = int.Parse(Console.ReadLine());

                Console.Write("Введите значение N: ");
                int N2 = int.Parse(Console.ReadLine());

                int sum = SumNaturalNumbers(M, N2);
                Console.WriteLine($"Сумма натуральных чисел от {M} до {N2}: {sum}");
                break;

            case 3:
                Console.Write("Введите значение m: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Введите значение n: ");
                int n = int.Parse(Console.ReadLine());

                int result = AckermannFunction(m, n);
                Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");
                break;

            default:
                Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1, 2 или 3.");
                break;
        }
    }

    static void PrintNaturalNumbers(int num)
    {
        if (num <= 0)
            return;

        Console.Write($"{num} ");
        PrintNaturalNumbers(num - 1);
    }

    static int SumNaturalNumbers(int start, int end)
    {
        if (start > end)
            return 0;

        return start + SumNaturalNumbers(start + 1, end);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;

        if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);

        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
