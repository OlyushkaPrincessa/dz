using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string[n];

        Console.WriteLine("Введите строки:");
        for (int i = 0; i < n; i++)
        {
            strings[i] = Console.ReadLine();
        }

        string[] result = new string[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (strings[i].Length <= 3)
            {
                result[count] = strings[i];
                count++;
            }
        }

        string[] finalResult = new string[count];

        for (int i = 0; i < count; i++)
        {
            finalResult[i] = result[i];
        }

        Console.WriteLine("Массив строк длиной меньше или равной 3 символам:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(finalResult[i]);
        }
    }
}