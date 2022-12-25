import logging
import token1
import model_db
from telegram import Bot
from telegram.ext import Updater, CommandHandler, MessageHandler, ConversationHandler, filters

from telegram.ext import Updater, CommandHandler, ConversationHandler, MessageHandler, Filters

logging.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=logging.DEBUG
)

logger = logging.getLogger(__name__)

bot = Bot(token1)
updater = Updater(token1, use_context=True)
dispatcher = updater.dispatcher


def start(update, context):
    model_db.connect()
    update.message.reply_text(
        "Привет! Выберите команду:"
        "\n/all - Посмотреть весь список"
        "\n/find - Поиск по фамилии сотрудника"
        "\n/update - изменить тел. номер сотрудника по фамилии"
        "\n/delete - удалисть сотрудника по фамилии"
        "\n/stop - остановить бота")


def find(update, context):
    update.message.reply_text("Введите фамилию с заглавной буквы ")
    return 1


def add(update, context):
    update.message.reply_text("Введите Фамилию, Имя, телефон и должность через пробел ")
    return 1


def delete(update, context):
    update.message.reply_text("Введите Фамилию для удаления сотрудника из базы")
    return 1


def update(update, context):
    update.message.reply_text("Введите овые данные: Фамилию, Имя, телефон и должность через пробел")
    return 1


def stop(update, context):
    update.message.reply_text("Всего доброго!")
    model_db.disconect()
    return ConversationHandler.END


def main():
    updater = Updater(token1)
    dp = updater.dispatcher

    find_handler = ConversationHandler(
        entry_points=[CommandHandler('find', find)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, model_db.find_people)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )


    add_handler = ConversationHandler(
        entry_points=[CommandHandler('add', add)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, model_db.add_people)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )


    delete_handler = ConversationHandler(
        entry_points=[CommandHandler('delete', delete)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, model_db.delete_people)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )


    update_handler = ConversationHandler(
        entry_points=[CommandHandler('update', update)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, model_db.update_info)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )


    start_handler = CommandHandler('start', start)
    read_handler = CommandHandler('all', model_db.all)
    dp.add_handler(start_handler)
    dp.add_handler(read_handler)
    dp.add_handler(find_handler)
    dp.add_handler(add_handler)
    dp.add_handler(delete_handler)
    dp.add_handler(update_handler)
    updater.start_polling()
    updater.idle()


if __name__ == '__main__':
    main()




# pip install -r requirements.txt - для прочтения  Бот: t.me/gb_test1242022_bot.
