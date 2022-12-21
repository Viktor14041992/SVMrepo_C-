import csv


def get_list():
    with open('file.csv', encoding="utf8") as csvfile:
        reader = csv.reader(csvfile, delimiter=';', )
        return list(reader)


def add_emloyees_to_list(employees):
    with open('file.csv', 'a', encoding="utf8", newline='') as csvfile:
        writer = csv.writer(csvfile, delimiter=';')
        writer.writerow(employees)


def update_employees(number, string):
    try:
        with open('file.csv', 'r', encoding="utf8", newline='') as csvfile:
            reader = csv.reader(csvfile, delimiter=';', )
            data = list(reader)
            print(f"дата {data}")
            data[number] = string
        with open('file.csv', 'w', encoding="utf8", newline='') as csvfile:
            writer = csv.writer(csvfile, delimiter=';', )
            for i in data:
                writer.writerow(i)
    except IndexError:
        print("Вы вышли за границу списка")
        exit()
    except Exception:
        print("Ошибка")
        exit()


def delete(number):
    with open('file.csv', 'r', encoding="utf8", newline='') as csvfile:
        reader = csv.reader(csvfile, delimiter=';', )
        data = list(reader)
        print(f"дата {data}")
        del data[number]
    with open('file.csv', 'w', encoding="utf8", newline='') as csvfile:
        writer = csv.writer(csvfile, delimiter=';', )
        for i in data:
            writer.writerow(i)


# продолжение------------------------------------------------------------

def export_txt():
    with open('file.csv', 'r', encoding="utf8", newline='') as csvfile:
        reader = csv.reader(csvfile, delimiter=';')
        list_employees = list(reader)
    with open('spisok1.txt', 'w', encoding="utf-8") as data:
        for i in list_employees:
            for j in i:
                data.write(j + '  ')
            data.write('\n')



def import_txt():
    with open('spisok1.txt', 'r', encoding='utf-8') as data:
        for row in data:
            print(row)


def import_csv():
    with open("file.csv", encoding='utf-8') as r_file:
        file_reader = csv.DictReader(r_file, delimiter=";")
        count = 0
        for row in file_reader:
            if count == 0:
                print(f'Информация по следующим столбцам:\n {", ".join(row)}')
            print(f' {row["Фамилия"]} {row["Имя"]}, {row["Телефон"]}, {row["Должность"]}')
            count += 1


def export_csv(file, new_file):
    file2 = input(f'{new_file}, введите имя файла')
    with open(file2, mode="w", encoding='utf-8') as w_file:
        file_writer = csv.DictReader(w_file, delimiter=";", lineterminator='\r')
        file_writer.writerow(['Фамилия', 'Имя', 'Телефон', 'Описание'])
        for row in file:
            file_writer.writerow(row)
        print(f'данные записаны в файл {new_file}')

