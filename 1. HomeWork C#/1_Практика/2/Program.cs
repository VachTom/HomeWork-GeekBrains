﻿/*  Домашнее задание 1 практика
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

                                                        // 2.По заданному номеру дня недели вывести его название


Console.WriteLine("Введите число от 1 до 7:");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); // проверка на то что пользователь ввел не число
if (!isParsed)
{
    Console.WriteLine("Вы ввели не число. Пожалуйста, введите корректную информацию");
    return;
}
if (number > 0 & number < 8)
{
    if (number == 1) Console.WriteLine("Понедельник");
    if (number == 2) Console.WriteLine("Вторник");
    if (number == 3) Console.WriteLine("Среда");
    if (number == 4) Console.WriteLine("Четверг");
    if (number == 5) Console.WriteLine("Пятница");
    if (number == 6) Console.WriteLine("Суббота");
    if (number == 7) Console.WriteLine("Воскресенье");
}   
else
{
    Console.WriteLine("Данное число не равно дню недели. Пожалуйста, введите корректную информацию");
}
