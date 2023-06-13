/*
1. Найти произведение двух матриц
2. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника */


Console.Clear();
int x = ReadInt("Введите кол-во страниц: ");
int m = ReadInt("Введите кол-во строк: ");
int n = ReadInt("Введите кол-во столбцов: ");
int range = ReadInt("Введите диапазон чисел от 1 до ");

int[,,] array = new int[x, m, n];
GeneratArray(array);
PrintArray(array);
int[,,] GeneratArray(int[,,] array)
{
    Random random = new();
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                array[x, i, j] = random.Next(range);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    Console.WriteLine();
    for (int x = 0; x < array.GetLength(0); x++)
    {
        Console.WriteLine($"{x + 1} страница:");
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[x, i, j]} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) 
    {
        Console.Write(" Пожалуйста, введите натуральное число");
    }
    return output;
}