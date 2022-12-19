def show_spisok(spisok):
    print('Список:')
    for i, man in enumerate(spisok, 1):
        print(i, *man)


def export_spisok(spisok):
    print('Список:')
    for i, man in enumerate(spisok, 1):
        print(str(*man).split(','))


    with open('file.txt', 'w', encoding='utf8') as data:
        data.write(str(spisok))