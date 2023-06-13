""" 
Задача 24: В фермерском хозяйстве в Карелии выращивают чернику. Она растёт на круглой грядке, причём кусты высажены только по окружности. 
Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растёт N кустов.
Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод — на i-ом кусте выросло ai ягод.
В этом фермерском хозяйстве внедрена система автоматического сбора черники. 
Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.
Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль,
находясь перед некоторым кустом заданной во входном файле грядки. 
    4 - 1 2 3 4 
    Результат: 9 """

import random

n = int(input("Введите кол-во элементов: "))
arr = list()
arrIndex = list()

for i in range(n):
    arrIndex.append(i+1)
print(f"Индекс {arrIndex}")

for k in range(n):
    temp = random.randint(0, n)
    arr.append(temp)
print(f"Массив {arr}")

arrCount = list()
max = 0
for j in range(n - 1):
    temp = arr[j] + arr[j + 1] + arr[j - 1]
    if max < temp:
        max = temp
        tempIndex = j
    # arrCount.append(arr[j] + arr[j + 1] + arr[j - 1])
    # print(f"{j + 1} Итерация = {arrCount}")

print()
print(f"{tempIndex+1} Итерация, Максимальное значение: {max}")
