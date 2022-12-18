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
