// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
using System;
public class task2
{
    static public void Main(string[] args)
    {
        Console.Write("Введите число m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(akkerman(n, m));
    }

    static public int akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return akkerman(m - 1, 1);
        else return akkerman(m - 1, akkerman(m, n - 1));
    }
}
