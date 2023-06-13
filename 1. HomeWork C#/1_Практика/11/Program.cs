
/*  Домашнее задание 1 практика
1. По двум заданным числам проверять является ли первое квадратом второго
2. По заданному номеру дня недели вывести его название
3. Найти максимальное из трех чисел
4. Выяснить является ли число чётным
5. Показать четные числа от 1 до N

6. Показать последнюю цифру трёхзначного числа
7. Показать вторую цифру трёхзначного числа
8. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
9. Удалить вторую цифру трёхзначного числа
10. Выяснить, кратно ли число заданному, если нет, вывести остаток.
11. Найти третью цифру числа или сообщить, что её нет */


                                                // 11. Найти третью цифру числа или сообщить, что её нет */

//                                                      ПЕРВЫЙ СПОСОБ
                                            Console.WriteLine("Введите число: ");
/*string number = Console.ReadLine();
Zadacha13(number);
void Zadacha13(string currentNumber)
{
        try
        {            Console.Write(currentNumber[2]); }
        catch
        {            Console.WriteLine("Третьей цифры/СИМВОЛА нет");}
        finally
        {
            Console.WriteLine();
            Console.WriteLine();
        }
}
*/
/*
//                                                       ВТОРОЙ СПОСОБ
int number2 = Convert.ToInt32(Console.ReadLine()); 
Zadacha13Alternativ(number2);
void Zadacha13Alternativ(int alteNumber)
{
   if      (alteNumber < 100)  Console.WriteLine("Третьей цифры нет.");

   else if (alteNumber < 1000)             Console.WriteLine(alteNumber % 10);
   else if (alteNumber < 10000)            Console.WriteLine(alteNumber % 100          / 10);
   else if (alteNumber < 100000)           Console.WriteLine(alteNumber % 1000         / 100);
   else if (alteNumber < 1000000)          Console.WriteLine(alteNumber % 10000        / 1000);
   else if (alteNumber < 10000000)         Console.WriteLine(alteNumber % 100000       / 10000);
   else if (alteNumber < 100000000)        Console.WriteLine(alteNumber % 1000000      / 100000);
   else if (alteNumber < 1000000000)       Console.WriteLine(alteNumber % 10000000     / 1000000);

   else if (alteNumber > 1000000000)      Console.WriteLine("Много лимонов");
}*/


// Уважаемый преподаватель,  я понимаю что данное решение не эффективное. Тк очень много кода. 
// Подскажите пожалуйста, как решить данную задачу с использованием цикла. Не могу установить закономерность((




Console.Write("Введите число А:");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int A);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");

while(A >=1000)
{
    A=A/10;
}
Console.WriteLine($"Третья цифра числа {A} равняется {A%10}");