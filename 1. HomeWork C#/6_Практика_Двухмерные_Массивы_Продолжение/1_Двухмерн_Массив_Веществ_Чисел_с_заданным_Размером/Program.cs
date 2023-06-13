/*
1. Показать двумерный массив размером m×n заполненный вещественными числами
2. Задать двумерный массив следующим правилом: Aₘₙ = m+n 
3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
4. Написать программу, которая обменивает элементы первой строки и последней строки */

Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");
Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйста введите натуральное число");

double[,] MultyArray = new double[m, n];

double[,] InitArray = GenerateArray(MultyArray);
PrintArray(InitArray);

double[,] GenerateArray(double[,] array)
{
    Random random = new();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100)+ random.NextDouble();
        }
    }
    return array;
}

double[,] PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int u = 0; u < array.GetLength(0); u++)
    {
        Console.Write("[ ");
        for (int h = 0; h < array.GetLength(1); h++)
        {
            Console.Write($"{array[u, h]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}