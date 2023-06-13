/*
1. Показать натуральные числа от M до N, N и M заданы
2. Найти сумму элементов от M до N, N и M заданы
3. Найти сумму цифр числа
4. Написать программу вычисления функции Аккермана
5. Написать программу возведения числа А в целую стень B
6. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем */

int m = ReadInt("Введите число: ");
int SumNimber(int m)
{
    if (m == 0) return 0;
    return SumNimber(m / 10) + m % 10;

}
Console.WriteLine(SumNimber(m));

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write("Пожалуйста, введите целое число");
    return output;
}


