"""
Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.

Ввод: 17
Вывод: 1 2 4 8 16 
"""


n = int(input("Введите натуральное число: "))

i = 1
while (2 ** i) < n:
    result = 2 ** i
    i += 1
    print(result)
