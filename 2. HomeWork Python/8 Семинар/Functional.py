"""# 55.  Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt.
   # Фамилия, имя, отчество, номер телефона - данные, которые должны находиться в файле.

# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в текстовом файле
# 3. Поиск по фамилии

# 1 - Интерфейс
# 2 - работа с файлом
# 3 - алгоритм

# 1 - добавление контакта
# 2 - вывод всех
# 3 - поиск по фамилии
# 4 - Редактирование 
# 5 - Удаление
# 6 - выход """
# Создание файла если не нашел, открытие файла если нашел в системе
def create(path):
    try:
        file = open(path, 'r')
    except IOError:
        print('Создан новый справочник -> phone_book.txt ')
        file = open(path, 'w') 
    finally:
        file.close()

# 1 - добавление контакта
def add_cont(file_name, stroka): 
    data = open(file_name, 'a')
    data.write(stroka + "\n") # Добавляет список в 
    data.close 

# 2 - вывод всех
def show_all(file_name):
    data = open(file_name, "r")
    count = 0
    for line in data:
        count+=1
        print(f"{count}. {line[:-1]}")
    data.close()

# 3 - поиск по фамилии
def search(file_name, stroka):
    a = 0
    data = open(file_name, "r+")
    for line in data:
        if stroka in line:
            print(f"\nРезультат: {line}")
            a = 123
            break
    if a != 123:
        print(f"\nРезультат: Такого человека нет\n")
    data.close()
    return line

# 4 - Редактирование 
def redaction(file_name, stroka):
    b = search(file_name, stroka)
    data = open(file_name, "r+")

    # found = list(b.split(",")[0].split("\n"))
    founds = b.replace(stroka, str(input("Редактируйте: ")))
    data.write(founds)
    data.close()
