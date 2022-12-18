def show_menu():
    print('Выберете команду: \n1 - показать всех сотрудников '
          '\n2 - добавить сотрудника \n3 - изменить данные сотрудника сотрудника '
          '\n4 - удалить сотрудника')
    try:
        select = int(input())
        if not select in [1, 2, 3, 4]:
            raise ValueError
        return select
    except Exception:
        print("Ошибка!!!")
        exit()


def show_emplyees(spisok):
    print('Список всех сотрудников:')
    for i, sotrudnik in enumerate(spisok):
        if i == 0:
            print(' ', *sotrudnik)
        else:
            print(i, *sotrudnik)


def add_employees():
    print("Введите Фамилию, Имя, Телефон и Должность через пробел:")
    data = input().split()
    return data


def change_employees():
    print("Выберете строку для перезаписи: ")
    change = int(input())
    print("Введите строку для записи: ")
    string = input().split()
    return change, string


def delete():
    print("Введите номер строки для удаления: ")
    number = int(input())
    return number
