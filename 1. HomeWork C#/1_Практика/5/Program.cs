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


                                                    //5. Показать четные числа от 1 до N
Console.WriteLine("Введите целое число:");

bool isParsed = int.TryParse(Console.ReadLine(), out int numbx); // проверка на то что пользователь ввел не число
if (!isParsed)
{
    Console.WriteLine("Вы ввели не целое число. Пожалуйста, введите корректную информацию согласно условию выше");
    return;
}
for (int i = 1; i <= numbx; i++)
{
    Console.Write(i + " ");    
}

