"""  Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества. 
Затем пользователь вводит сами элементы множеств.
"""

import random
n = int(input("Введите кол-во элементов первой группы: "))
m = int(input("Введите кол-во элементов второй группы: "))

set_a = set()
set_b = set()

for i in range(0, n):
    temp_a = int(random.randint(1, 15))
    set_a.add(temp_a)
    
for i in range(0, m):
    temp_b = int(random.randint(1, 15))
    set_b.add(temp_b)
   
print()
print(f"Первая группа: {set_a}")
print(f"Вторая группа: {set_b}")

print()
result = list(set_a.intersection(set_b))
print(f"Результат: {result}")



