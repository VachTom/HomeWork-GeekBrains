""" Задача 26:  Посчитать факториал (произведение 1 до N) 
и треугольное число (сумма чисел от 1 до N) для числа N ЧЕРЕЗ РЕКУРСИЮ и без циклов
 """

def Factorial(n):
    if n == 1: return 1
    return n * Factorial(n-1)
print(Factorial(int(input("Введите Факториал числа: "))))


def Triangle_Number(n):
    if n == 1: return 1
    return n + Triangle_Number(n-1)
print(Triangle_Number(int(input("Введите Триугольное число: "))))