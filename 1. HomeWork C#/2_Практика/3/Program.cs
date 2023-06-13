﻿/* 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
   2. По двум заданным числам проверять является ли одно квадратом другого
   3. Задать номер четверти, показать диапазоны для возможных координат
   4. Найти расстояние между точками в пространстве 2D/3D*/


Console.WriteLine("Введите номер четверти: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
 Console.WriteLine("Вы ввели не число, прошу введите корректную информацию согласно условиям");  
}

if (number == 1 ) Console.WriteLine("Диапазон координат точек Х > 0, Y > 0");
else if (number == 2 ) Console.WriteLine("Диапазон координат точек Х < 0, Y > 0");
else if (number == 3 ) Console.WriteLine("Диапазон координат точек Х < 0, Y < 0");
else if (number == 4 ) Console.WriteLine("Диапазон координат точек Х > 0, Y < 0");

else Console.WriteLine("Такой четверти не существует");