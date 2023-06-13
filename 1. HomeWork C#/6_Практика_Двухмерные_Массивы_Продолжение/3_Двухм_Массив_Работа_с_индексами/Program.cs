/*
1. Показать двумерный массив размером m×n заполненный вещественными числами
2. Задать двумерный массив следующим правилом: Aₘₙ = m+n // каждый элемент массива = сумме его индексов
3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
4. Написать программу, которая обменивает элементы первой строки и последней строки */

Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");
Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйста введите натуральное число");

int[,] MultyArray = new int[m, n];

int[,] InitArray = GenerateArray(MultyArray);
PrintArray(InitArray);

int[,] ResArray = ResultArray(MultyArray);
PrintArray(ResArray);


int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int o = 0; o < array.GetLength(0); o++)
    {
        Console.Write("[ ");
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[o, k]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] ResultArray(int[,] array)
{
    for (int p = 0; p < array.GetLength(0); p++)
    {
        if (p % 2 == 0)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                if (l % 2 == 0)
                {
                    array[p, l] = array[p, l] * array[p, l];
                }
            }
        }
    }
    return array;
}
