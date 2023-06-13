/*
1. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
3. В прямоугольной матрице найти строку с наименьшей суммой элементов.*/

Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста, введите натуральное число");
Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйстa, введите натуральное число");

int[,] MultyArray = new int[m, n];

int[,] InitArray = GenerateArray(MultyArray);
PrintArray(InitArray);

int[,] ResiltArray = ColumnsMean(InitArray);


int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) { array[i, j] = random.Next(1, 10); }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++) { Console.Write($"{array[i, j]} "); }
        Console.Write("]");
        Console.WriteLine();
    }
    Console.WriteLine();
    
}

int[,] ColumnsMean(int[,] array)
{
    int countRow = 0;
    double sumRow = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[j, i];
            countRow++;
        }
        sumRow/=countRow;
        Console.WriteLine($"Среднее {i+1} столбца = {Math.Round(sumRow, 2)}");
        sumRow = 0;
        countRow = 0;
    }
    return array;
}

