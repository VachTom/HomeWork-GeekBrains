/*
1. Найти кубы чисел от 1 до N
2. Подсчитать сумму цифр в числе
3. Написать программу вычисления произведения чисел от 1 до N
4. Показать кубы чисел, заканчивающихся на четную цифру*/

Console.Write("Введите число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if (!isParsed)
{
    Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию");
}
Console.WriteLine();

int[] array = new int[n];
int s = 1;
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    s *= array[i];
}

Console.WriteLine($"Произведение чисел от 1 до {n} = {s}");