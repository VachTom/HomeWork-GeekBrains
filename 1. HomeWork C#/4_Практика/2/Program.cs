/*
1. Задать массив из 8(n) элементов, заполненных нулями и единицами вывести их на экран
    2. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
3. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
4. Найти сумму чисел одномерного массива стоящих на нечетной позиции
5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
6. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом   */


Console.Write("Введите размер массива: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if (!isParsed) Console.WriteLine("Вы ввели не число, прошу введите корректную информацию согласно условиям");
int[] array = new int[n];

int FullArr(int[] s) //Создание массива , рандомный элемент
{
    Random radnm = new Random();
    for (int i = 0; i < n; i++)
    {
        int d = radnm.Next(100, 999);
        array[i] = d;
    }
    return -1;
}
Console.WriteLine();

void PrintArray(int[] ars)
{
    for (int i = 0; i < array.Length; i++) { }
    string mes = string.Join(", ", array);
    Console.WriteLine($"[{mes}]");
}

int statistic(int[] yk)
{
    int ch = 0;
    int noch = 0;
    for (int i = 0; i < yk.Length; i++)
    {
        if (yk[i] % 2 == 0) ch++;
        else noch++;
    }
    Console.WriteLine($"Кол-во четных чисел: {ch}");
    Console.WriteLine($"Кол-во Нечетных чисел: {noch}");
return -1;
}

/*
int statistic(int[] yk)
{
    Console.Write($"Индексы ЧЕТНЫХ чисел массива: ");

    for (int i = 0; i < yk.Length; i++)
    {
        if (yk[i] % 2 == 0) Console.Write($"{i} ");
    }
    Console.WriteLine();

    Console.Write($"Индексы НЕЧЕТНЫХ чисел массива: ");

    for (int i = 0; i < yk.Length; i++)
    {
        if (yk[i] % 2 == 1) Console.Write($"{i} ");
    }
    Console.WriteLine();

    return n;
}*/




int o = FullArr(array);
Console.WriteLine(o);
PrintArray(array);
Console.WriteLine();

int p = statistic(array);
Console.WriteLine(p);
