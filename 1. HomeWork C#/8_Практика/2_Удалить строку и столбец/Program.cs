/*
1. Найти произведение двух матриц
2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника */
Console.Clear();

int m = ReadInt("Введите размер строки матрицы: ");
int n = ReadInt("Введите размер столбца матрицы: ");

int[,] nums = new int[m, n];
int[,] InitArray = GeneratArr(nums);
PrintArr(InitArray);

Random rnd = new Random();
int row = rnd.Next(nums.GetLength(0));
int col = rnd.Next(nums.GetLength(1));
Console.WriteLine("Удаляется {0}-я строка и {1}-й столбец", row + 1, col + 1);

int[,] result = DeleteCross(nums, row, col);
PrintArr(result);

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write("Пожалуйста, введите целое число");
    return output;
}
int[,] GeneratArr(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10, 99);
        }
    }
    return array;
}
void PrintArr(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(i + 1 + " ");
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int[,] DeleteCross(int[,] array, int row, int col)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        int a = i >= row ? i + 1 : i;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int b = j >= col ? j + 1 : j;
            result[i, j] = array[a, b];
        }
    }
    return result;
}

int[,] FindMinElements(int[,] array)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = temp;
            if (array[i, j] < array[i + 1, j])
            {
                min = array[i, j];
            }
        }
    }
    return array;
}
