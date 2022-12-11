# 3.	Создайте программу для игры в "Крестики-нолики".

sp = [['-', '-', '-'], ['-', '-', '-'], ['-', '-', '-']]
string_number = None
column_number = None


print(*sp, sep='\n')

from random import randint

def start_game():
    print(f"ИГРА НАЧАЛАСЬ:")
    who_is_first()

def who_is_first():
    random_number = randint(1, 2)
    if random_number == 1:
        player1_turning()
    else:
        player2_turning()

def player1_turning():
    global string_number
    global column_number
    global sp
    print("Ваш ход, крестики!")
    string_number = int(input('Введите номер строки'))
    column_number = int(input('Введите номер столбца'))
    if 0 >= string_number >= 2 and 0 >= column_number >= 2 and sp[string_number][column_number] != '-':
        while 0 >= string_number >= 2 and 0 >= column_number >= 2 and sp[string_number][column_number] != '-':
            print('Выберете координату')
            string_number = int(input('Введите номер строки'))
            column_number = int(input('Введите номер столбца'))

    sp[string_number][column_number] = 'X'
    print(*sp, sep='\n')

    if (sp[0][0] == sp[0][1] == sp[0][2] != '-' or sp[0][0] == sp[1][0] == sp[2][0] != '-' or sp[0][0] == sp[1][1] == sp[2][2] != '-' or sp[1][1] == sp[0][1] == sp[2][1] != '-' or sp[1][1] == sp[1][0] == sp[1][2] != '-' or sp[2][0] == sp[1][1] == sp[0][2] != '-' or sp[2][2] == sp[1][2] == sp[0][2] != '-' or sp[2][2] == sp[2][1] == sp[2][0] != '-'):
        print(" выиграли!")
    else:
        player2_turning()

def player2_turning():
    global string_number
    global column_number
    global sp
    print("Ваш ход, нолики!")
    string_number = int(input('Введите номер строки'))
    column_number = int(input('Введите номер столбца'))
    if 0 >= string_number >= 2 and 0 >= column_number >= 2 and sp[string_number][column_number] != '-':
        while 0 >= string_number >= 2 and 0 >= column_number >= 2 and sp[string_number][column_number] != '-':
            print('Выберете координату')
            string_number = int(input('Введите номер строки'))
            column_number = int(input('Введите номер столбца'))

    sp[string_number][column_number] = '0'
    print(*sp, sep='\n')

    if (sp[0][0] == sp[0][1] == sp[0][2] != '-' or sp[0][0] == sp[1][0] == sp[2][0] != '-' or sp[0][0] == sp[1][1] ==
            sp[2][2] != '-' or sp[1][1] == sp[0][1] == sp[2][1] != '-' or sp[1][1] == sp[1][0] == sp[1][2] != '-' or
            sp[2][0] == sp[1][1] == sp[0][2] != '-' or sp[2][2] == sp[1][2] == sp[0][2] != '-' or sp[2][2] == sp[2][
                1] == sp[2][0] != '-'):
        print("Нолики выиграли!")
    else:
        player1_turning()

start_game()