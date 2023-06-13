/*
1. Показать натуральные числа от M до N, N и M заданы
2. Найти сумму элементов от M до N, N и M заданы
3. Найти сумму цифр числа
4. Написать программу вычисления функции Аккермана
5. Написать программу возведения числа А в целую стень B
6. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем */

Console.Clear();
int m = ReadInt("Введите целое число М: ");
int n = ReadInt("Введите целое число N: ");
int range = ReadInt("Введите длину массива: ");

int[] array = new int[range];
int[] InitArray = GeneratArr(array);
PrintArr(InitArray);

int[] GeneratArr(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(m, n);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            Console.Write("");// Вместо 0
        }
        else Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write("Пожалуйста, введите целое число");
    return output;
}
