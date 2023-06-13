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

int[,] MultyArray = new int[m, n];

int[,] InitArray = GenerateArray(MultyArray);
PrintArray(InitArray);

int[,] ResArray = ResultArray(MultyArray);
PrintArray(ResArray);

int[,] GenerateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите элемент {i + 1} строки, {j + 1} столбца: ");
            array[i, j] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int r = 0; r < array.GetLength(0); r++)
    {
        Console.Write("[ ");
        for (int t = 0; t < array.GetLength(1); t++)
        {
            Console.Write($"{array[r, t]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] ResultArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.GetUpperBound(1) + 1;

    int temp = 0;

    for (int w = 0; w < columns; w++)
    {
        temp = array[0, w];

        array[0, w] = array[rows - 1, columns - w - 1];
        array[rows - 1, columns - w - 1] = temp;
    }
    return array;

}