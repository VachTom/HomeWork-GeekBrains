/*
1. Задать массив из 8(n) элементов, заполненных нулями и единицами вывести их на экран
2. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
3. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
4. Найти сумму чисел одномерного массива стоящих на нечетной позиции
5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
6. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом  
*/



Console.Write("Введите размер массива: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed1) Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию согласно условиям");
/*
Console.WriteLine("Введите вещественным числом начало массива: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int min);
if (!IsParsed2) Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию согласно условиям");

Console.WriteLine("Введите конец массива: ");
bool IsParsed3 = int.TryParse(Console.ReadLine(), out int max);
if (!IsParsed3) Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию согласно условиям");

*/
double[] array = new double[n];
/*
double[] InitArray = GenerateArray(array);
PrintArray(InitArray);

double[] GenerateArray(double[] array)
{*/
    Random random = new();
    for (int i = 0; i < array.Length; i++)
    {
        //double mins = random.Next(min/10.0, max/10.0); 
        array[i] = random.Next(0, 100) + random.NextDouble();
        
        Console.WriteLine($"{array[i]} ");
    }/*
    return array;



void PrintArray(double[] array)
{
    for (double i = 0; i < array.Length; i++)
    {
    }


}

int [] FindMinMax()
{
    int max = 0;
    int min = 0;


}*/