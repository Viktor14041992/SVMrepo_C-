# 4.	Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.
#
# Пример:
# Введите текст для кодировки: WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWBWWWWWWWWWWWWWW
# Текст после кодировки: 12W1B12W3B24W1B14W
# Текст после дешифровки: WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWBWWWWWWWWWWWWWW
# Входные и выходные данные хранятся в отдельных текстовых файлах.




def shifr():
    path = 'task_4_DeShifr.txt'
    data = open(path, 'r')
    count = 1
    sp2 = []

    sp = data.readline()
    print(sp)
    for i in range(1, len(sp)):
        if sp[i] == sp[i-1]:
            count += 1
        else:
            sp2.append(str(count) + sp[i-1])
            count = 1
    sp2.append(str(count) + sp[-1])
    print(sp2)
    with open('task_4_Shifr.txt', 'w') as data:
        data.write(''.join(sp2))

def deshifr():
    global count_list
    path = 'task_4_Shifr.txt'
    data = open(path, 'r')
    sp2 = data.readline()
    print()
    print(sp2)
    sp = []
    digit = ''
    for i in range(0, len(sp2)):
        if sp2[i].isdigit():
            digit += sp2[i]
        else:
            sp += sp2[i] * int(digit)
            digit = ''
    print()
    print(''.join(sp))
    with open('task_4_DeShifr.txt', 'w') as data:
        data.write(''.join(sp))
shifr()
deshifr()