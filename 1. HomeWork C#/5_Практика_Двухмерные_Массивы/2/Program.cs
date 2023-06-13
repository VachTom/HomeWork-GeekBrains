/*
1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
2. Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

3. Написать программу копирования массива Clone() */

Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");

Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйста введите натуральное число");

Console.Write("Введите коэффициент масштабирования: ");
bool IsParsed3 = int.TryParse(Console.ReadLine(), out int k);
if (!IsParsed3) Console.WriteLine("Пожалуйста введите натуральное число");


int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int w = 0; w < array.GetLength(0); w++)
    {
        Console.Write("[ ");
        for (int q = 0; q < array.GetLength(1); q++)
        {
            Console.Write($"{array[w, q]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int[,] CoefArray(int[,] array)
{
    for (int c = 0; c < array.GetLength(0); c++)
    {
        for (int w = 0; w < array.GetLength(1); w++)
        {
            array[c, w] *= k;
        }
    }
    return array;
}



int[,] marray = new int[m, n];

int[,] InitArray = GenerateArray(marray);
PrintArray(InitArray);

int[,] arra = CoefArray(marray);
PrintArray(arra);
