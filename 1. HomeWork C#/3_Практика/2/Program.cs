/*
1. Найти кубы чисел от 1 до N
2. Подсчитать сумму цифр в числе
3. Написать программу вычисления произведения чисел от 1 до N
4. Показать кубы чисел, заканчивающихся на четную цифру*/

Console.Write("Введите число: ");
bool IsParsed = int.TryParse(Console.ReadLine(), out int x);
if (!IsParsed) Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию");

int sum = 0;
for (int i = 3; i >= 0; i--)
{
    sum += x / (int)Math.Pow(10, i);//4,61
    x=x%(int)Math.Pow(10,i);
}
Console.WriteLine(sum);
