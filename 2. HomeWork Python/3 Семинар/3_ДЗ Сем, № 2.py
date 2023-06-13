""" 
Задача 18: Требуется найти в массиве A[N] самый близкий по величине элемент к заданному числу X.
Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
Ввод: 5
Ввод: 1 2 6 4 9
Ввод: 8
-> 9 """

import random
n = int(input("Введите кол-во элементов в массиве: ")) + 1
arr = []

for i in range(1, n):
    temp = int(random.randint(0, 50))
    arr.append(temp)

# help(random)
arr.sort()
print(arr)


countNumber = int(input(
    "Введите число по которому будет обрабатываться запрос: "))

m = abs(countNumber - arr[0]) # модуль числа нужен для того чтобы не было отрицательных чисел
count = arr[0]

for i in range(1, len(arr)):
    if m > abs(arr[i] - countNumber):
        m = abs(arr[i] - countNumber)
        count = arr[i]
print(count)
