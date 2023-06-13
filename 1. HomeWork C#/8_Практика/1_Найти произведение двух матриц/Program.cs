/*
1. Найти произведение двух матриц
2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника */


int RowsA = ReadInt("Введите размер строки 1 матрицы: ");
int ColumnA = ReadInt("Введите размер столбца 1 матрицы: ");

int RowsB = ReadInt("Введите размер строки 2 матрицы: ");
int ColumnB = ReadInt("Введите размер столбца 2 матрицы: ");

int[,] A = new int[RowsA, ColumnA];
int[,] B = new int[RowsB, ColumnB];

int[,] InitArr1 = GeneratArr(A);
PrintArr(InitArr1);
int[,] InitArr2 = GeneratArr(B);
PrintArr(InitArr2);
int[,] ResultArr = Multi(InitArr1, InitArr2);
PrintArr(ResultArr);

int[,] GeneratArr(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 5);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    Console.WriteLine();
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
    if (!IsParsed) Console.Write("Пожалуйста, введите целое число");
    return output;
}

int[,] Multi(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                r[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return r;
}

