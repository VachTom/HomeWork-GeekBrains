/*
1. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
3. В прямоугольной матрице найти строку с наименьшей суммой элементов.*/

Console.Clear();
int m = ReadInt("Введите значение строки: ");
int n = ReadInt("Введите значение столбца: ");
int range = ReadInt("Введите диапазон данных массива от 1 до ");

int[,] arrays = new int[m, n];
int[,] InitArray = GeneratArray(arrays);
PrintArray(InitArray);
int[,] ResultArray = SumArr(arrays);

int[,] GeneratArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(range);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("]");
    }
}

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write("Пожалуйста, введите натуральное число.");
    return output;
}

int[,] SumArr(int[,] array)
{
    Console.WriteLine();

    int sumMin = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (sum < sumMin)
            {
                sumMin = sum;
            }
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        
    }

    Console.WriteLine($"Сумма наименьшей строки = {sumMin}");
    return array;
}
