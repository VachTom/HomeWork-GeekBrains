/*
1. Задать массив из 8(n) элементов, заполненных нулями и единицами вывести их на экран
2. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
3. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
4. Найти сумму чисел одномерного массива стоящих на нечетной позиции
5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
6. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом   */

int[] InitArray = GeneratArray(1, 10, 10);
PrintArray(InitArray);
int[] Result = FindElements(InitArray);



int[] GeneratArray(int min, int max, int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { }
    string print = string.Join(", ", array);
    Console.WriteLine($"[{print}]");
}

int[] FindElements(int[] array)
{
    int number = 0;
    int j = array.Length - 1;
    for (int i = 0; i < array.Length/2; i++)
    {
        int product = array[i] * array[j];
        j--;
        number++;

        Console.WriteLine($"{number} Произведние пар чисел равна {product}");
    }
    return array;
}