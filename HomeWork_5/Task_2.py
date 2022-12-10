# 2.	Создайте программу для игры с конфетами человек против человека.
# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая
# ход друг после друга. Первый ход определяется жеребьёвкой.
# За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у
# своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте как наделить бота "интеллектом"




# Игра против бота:

from random import randint

total_candys = int(input('ведите кол-во конфет в игре: '))
taken_candys = 0
player_candys = 0
player2_candys = 0
bot_candys = 0

def start_game():
    print(f"ИГРА НАЧАЛАСЬ:\nВ игре {total_candys} конфет. За один ход можно забрать не более чем 28 конфет. Все конфеты оппонента достаются сделавшему последний ход.")
    who_is_first()

def who_is_first():
    random_number = randint(1,2)
    if random_number == 1:
        player_turning()
    else:
        # bot_turning()
        player2_turning()

def player_turning():
    global total_candys
    global taken_candys
    global player_candys
    print(f"Ваш ход. Сейчас на столе {total_candys} конфет")
    taken_candys = int(input('Сколько кофет Вы хотите взять?'))
    while taken_candys > 28 or total_candys < 0 or taken_candys > total_candys:
        taken_candys = int(input('Слишком много, попробуйте снова'))
    total_candys -= taken_candys
    player_candys += taken_candys

    if total_candys > 0:
        # bot_turning()
        player2_turning()
    else:
        print("Вы выиграли!")

def player2_turning():
    global total_candys
    global taken_candys
    global player2_candys
    print(f"Ваш ход. Сейчас на столе {total_candys} конфет")
    taken_candys = int(input('Сколько кофет Вы хотите взять?'))
    while taken_candys > 28 or total_candys < 0 or taken_candys > total_candys:
        taken_candys = int(input('Слишком много, попробуйте снова'))
    total_candys -= taken_candys
    player2_candys += taken_candys

    if total_candys > 0:
        player_turning()
    else:
        print("Вы выиграли!")


# def bot_turning():
#     global total_candys
#     global taken_candys
#     global bot_candys
#     if total_candys % 29 != 0:   # выигрышная стратегия
#         taken_candys = total_candys % 29
#     else:
#         randint(1, 28)
#     total_candys -= taken_candys
#     bot_candys += taken_candys
#     print(f"Бот взял {taken_candys} конфет. На столе осталось {total_candys}")
#
#     if total_candys > 0:
#         player_turning()
#     else:
#         print("Бот выиграл!")

start_game()