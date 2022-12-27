import telegram
from token1 import *
import emoji
import logging

from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove
from telegram.ext import Updater, CommandHandler, ConversationHandler, MessageHandler, Filters

reply_keyboard = [['/address', '/settings'],
                  ['/rules', '/close']]
candies = 50
step = 15

markup = ReplyKeyboardMarkup(reply_keyboard, one_time_keyboard=False)

logging.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=logging.DEBUG
)

logger = logging.getLogger(__name__)

TOKEN = token1


def start(update, context):
    name = f"{update.message.from_user.first_name} {update.message.from_user.last_name}"
    update.message.reply_text(
        f"Привет, {name}!" + emoji.emojize('Python is :waving hand:'),
        f"Я хочу сыграть с тобой в игру! Чтобы узнать правила нажми rules" + emoji.emojize('Python is :slightly_smiling_face:'),
        reply_markup=markup
    )


def close_keyboard(update, context):
    update.message.reply_text(
        "Ok",
        reply_markup=ReplyKeyboardRemove()
    )


def rules(update, context):
    update.message.reply_text(
        "В начале игры нужно определить кол-во конфет на кону\n и количество конфет, которое можно взять за один раз")


def settings(update, context):
    update.message.reply_text("Введите количество конфет на кону и максимально возможное количество конфет на один ход")
    return 1


def set_settings(update, context):
    global candies
    global step
    candies, step = map(int, update.message.text.split())
    update.message.reply_text("Правила установлены, начинаем")
    return ConversationHandler.END


def play(update, context):
    update.message.reply_text(f"Осталось {candies} конфет." + emoji.emojize('Python is :candy:'),
                              f"Ваш ход. Какое количество конфет Вы берёте?"
                              f"(Максимальное = {step})", reply_markup=ReplyKeyboardRemove())
    return 1


def play_step(update, context):
    global candies
    candy = int(update.message.text)
    candies -= candy
    if candies <= step:
        update.message.reply_text("Игра окончена, я забираю оставшиеся конфеты, я победил!" + emoji.emojize('Python is :partying_face:'), reply_markup=markup)
        return ConversationHandler.END
    else:
        update.message.reply_text(f"На кону {candies}, я беру {candies % (step + 1)} конфет" + emoji.emojize('Python is :candy:'))
        candies -= candies % (step + 1)
        if candies <= step:
            update.message.reply_text("Поздравляю, ты победил!" + emoji.emojize('Python is :clapping_hands:'), reply_markup=markup)
            return ConversationHandler.END


def stop(update, context):
    update.message.reply_text("Всего доброго!" + emoji.emojize('Python is :waving hand:'))
    return ConversationHandler.END


def main():
    updater = Updater(TOKEN)
    dp = updater.dispatcher
    settings_hundler = ConversationHandler(
        entry_points=[CommandHandler('settings', settings)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, set_settings)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )

    play_hundler = ConversationHandler(
        entry_points=[CommandHandler('play', play)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, play_step)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )

    dp.add_handler(CommandHandler("start", start))
    dp.add_handler(CommandHandler("rules", rules))
    dp.add_handler(settings_hundler)
    dp.add_handler(play_hundler)

    dp.add_handler(CommandHandler("close", close_keyboard))

    updater.start_polling()
    updater.idle()


if __name__ == '__main__':
    main()
