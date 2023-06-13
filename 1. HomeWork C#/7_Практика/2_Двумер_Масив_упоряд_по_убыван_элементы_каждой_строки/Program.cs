/*
1. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
3. В прямоугольной матрице найти строку с наименьшей суммой элементов.*/

Console.Clear();
int m = ReadInt("Введите значение строки: ");
int n = ReadInt("Введите значение столбца: ");
int range = ReadInt("Введите диапазон чисел от 1 до ");

int[,] array = new int[m, n];
GeneratArray(array);
PrintArray(array);
int[,] ResultArray = SortArr(array);
PrintArray(ResultArray);

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
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write(" Пожалуйста, введите натуральное число");
    return output;
}

int[,] SortArr(int[,] array)
{
    for (int o = 0; o < array.GetLength(0); o++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                int sortRow = array[o, j];
                if (array[o, j + 1] > sortRow)
                {
                    int temp = array[o, j];
                    array[o, j] = array[o, j + 1];
                    array[o, j + 1] = temp;
                }
            }
        }
    }
    return array;
}