from Functional import create
from Interface import interface
path = "phone_book.txt"
create(path)
enter = 0
while enter != 5:
    enter = interface()
    if enter == 1:
        from Functional import add_cont
        stroka = str(input("Введите ФИО и номер телефона через пробел "))
        add_cont(path, stroka)
    elif enter == 2:
        from Functional import show_all
        print(show_all(path))
    elif enter == 3:
        from Functional import search
        stroka = str(input("Введите фамилию: "))
        search(path, stroka)
    elif enter == 4:
        from Functional import redaction
        stroka = str(input("Введите фамилию: "))
        redaction(path, stroka)

print("Спасибо за работу")