def show_spisok(spisok):
    print('Список:')
    sp2 = []
    for i, man in enumerate(spisok, 1):
        print(i, *man)
        sp2.append(man)
    print(sp2)

    with open('file.txt', 'w') as data:
        data.write(sp2)
