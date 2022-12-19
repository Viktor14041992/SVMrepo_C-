import view
import model
import logging

logging.basicConfig(level=logging.INFO)



def main():
    sp = model.import_data()
    view.show_spisok(sp)
    sp = model.export_data()
    view.export_spisok(sp)