/*
1. Показать натуральные числа от M до N, N и M заданы
2. Найти сумму элементов от M до N, N и M заданы
3. Найти сумму цифр числа
4. Написать программу вычисления функции Аккермана
5. Написать программу возведения числа А в целую стень B
6. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем */



int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");

double result = Math.Pow(a, b);
Console.WriteLine($"Число {a} в {b} степени = {result}");


int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write("Пожалуйста, введите целое число");
    return output;
}
