import csv


def import_data():
    with open('file.csv', encoding="utf8") as csvfile:
        reader = csv.reader(csvfile, delimiter=' ', )
        return list(reader)


