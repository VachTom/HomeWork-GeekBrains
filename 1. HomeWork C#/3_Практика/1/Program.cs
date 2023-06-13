/*
1. Найти кубы чисел от 1 до N
2. Подсчитать сумму цифр в числе
3. Написать программу вычисления произведения чисел от 1 до N
4. Показать кубы чисел, заканчивающихся на четную цифру*/


Console.Write("Введите число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию");
}

int[] array = new int[number];
int table(int[] number)
{
    int n = 1;
    for (int i = 1; i <= array.Length; i++)
    {
        n = i*i*i;
        Console.WriteLine($"{i} в кубе = {n}");
    }
    Console.WriteLine();
    return -1; // Конечная позиция до которой доходит цикл
}

int k = table(array);
Console.WriteLine(k);
