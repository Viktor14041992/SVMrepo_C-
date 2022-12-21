import view
import model
import logging

logging.basicConfig(level=logging.INFO)

# logging.basicConfig(filename='log.txt',
#                     filemode='a',
#                     format='%(asctime)s,%(msecs)d %(name)s %(levelname)s %(message)s',
#                     datefmt='%H:%M:%S',
#                     level=logging.DEBUG,
#                     encoding="UTF-8")


def main():
    select = view.show_menu()
    if select == 1:
        logging.info("Выбран 1")
        sotr = model.get_list()
        view.show_emplyees(sotr)
    elif select == 2:
        logging.info("Выбран 2")
        data = view.add_employees()
        model.add_emloyees_to_list(data)
    elif select == 3:
        logging.info("Выбран 3")
        change, string = view.change_employees()
        model.update_employees(change, string)
    elif select == 4:
        logging.info("Выбран 4")
        number = view.delete()
        model.delete(number)
#продолжение--------------------------------------------------
    elif select == 5:
        logging.info("Выбран экспорт в txt")
        model.export_txt()
        logging.info("Список сотрудников экспортирован в txt")
    elif select == 6:
        logging.info("Выбран импорт из txt")
        model.import_txt()
        logging.info("Список сотрудников из txt импортирован")
    elif select == 7:
         logging.info("Выбран импорт из csv")
         model.import_csv()
         logging.info("Список сотрудников из csv импортирован")
    elif select == 8:
         logging.info("Выбран импорт из csv")
         model.export_csv()
         logging.info("Список сотрудников экспортирован в csv")
    else:
        logging.info("Выбрано некорректное число")
        print("Ошибка!!!")
        logging.info("Действия успешно выполнены!")

