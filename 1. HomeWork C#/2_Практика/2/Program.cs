/* 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
   2. По двум заданным числам проверять является ли одно квадратом другого
   3. Задать номер четверти, показать диапазоны для возможных координат
   4. Найти расстояние между точками в пространстве 2D/3D*/


Console.WriteLine("Введите первое число");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int first);
if (!isParsed1)    Console.WriteLine("Вы ввели не число, прошу введите корректную информацию согласно условиям");

Console.WriteLine("Введите второе число");
bool isParsed2 = int.TryParse(Console.ReadLine(), out int second);
if (!isParsed2)    Console.WriteLine("Вы ввели не число, прошу введите корректную информацию согласно условиям");


int result1 = first * first;
int result2 = second * second;

if (result1  == second)    Console.WriteLine($"Число {second} является квадратом числа {first}");
else if (result2 == first) Console.WriteLine($"Число {first} является квадратом числа {second}");
else
{
    Console.WriteLine("Никакие из данных чисел не являются квадратом другого");
}