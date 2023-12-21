using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class task1
//  Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
{
    static public void Main(string[] args)
    {
        Console.Write("Введите число m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());
        int x = 0;
        if (m > n)
        {
            x = m;
            m = n;
            n = x;
        }
        Console.WriteLine(ShowDigitsBetween(n, m));
    }

    static public string ShowDigitsBetween(int n, int m)
    {

        if (n == m)
            return $" {n}";
        return ShowDigitsBetween((n - 1), m) + $" {n}";
    }
}