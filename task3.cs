//Задайте произвольный массив.
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
public class task3
{
    static public void Main(string[] arg)
    {
        Console.Write("Введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Random rand = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)

            array[i] = rand.Next(0, 100);

        System.Console.WriteLine("Обычный массив: ");
        foreach (int item in array)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine("\n" + "Перевернутый массив");
        PrintReverseArray(array);
    }
    static public void PrintReverseArray(int[] array, int index = 0)
    {
        if (index != array.Length)
        {
            PrintReverseArray(array, index + 1);
            Console.Write($"{array[index]} ");
        }
    }
}
