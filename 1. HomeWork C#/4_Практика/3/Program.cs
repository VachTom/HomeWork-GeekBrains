/*
1. Задать массив из 8(n) элементов, заполненных нулями и единицами вывести их на экран
2. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
3. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
4. Найти сумму чисел одномерного массива стоящих на нечетной позиции
5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
    6. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом   */

int[] InitArray = Generate();
PrintArray(InitArray);
int[] result = FindElements(InitArray);


int[] Generate() // массив состоит из 123 элементов, отрезок [1, 999]. Ищем кол-во элементов из отрезка [10, 99]
{
    Random random = new Random();
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine();
}

int[] FindElements(int [] array)
{
    int find = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            find++;
        }
    }
    Console.WriteLine($"Найденное кол-во элементов из отрезка [10, 99] в массиве состовило {find}");
    return array;
}
