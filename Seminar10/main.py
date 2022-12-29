from token1 import *
import logging
import emoji
from random import randint

from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove
from telegram.ext import Updater, CommandHandler, ConversationHandler, MessageHandler, Filters

reply_keyboard = [['/play', '/settings', '/easy'],
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
        f"Привет, {name}!{emoji.emojize(':waving_hand:')} Давай поиграем? Чтобы узнать правила игры нажми rules {emoji.emojize(':slightly_smiling_face:')}",
        reply_markup=markup
    )


def close_keyboard(update, context):
    update.message.reply_text(
        f"Ok, Bye! {emoji.emojize(':waving_hand:')}",
        reply_markup=ReplyKeyboardRemove()
    )


def rules(update, context):
    update.message.reply_text(
        "В начале игры нужно определить количество конфет на кону и количество конфет, "
        "которое можно взять за один раз ")


def settings(update, context):
    update.message.reply_text("Введите количество конфет на кону и максимально возможное количество на ход")
    return 1


def set_settings(update, context):
    global candies
    global step
    candies, step = map(int, update.message.text.split())
    update.message.reply_text(f"Правила установлены, начинаем! {emoji.emojize(':thumbs_up:')}")
    return 1


def play(update, context):
    update.message.reply_text(f"На кону {candies} конфет.{emoji.emojize(':candy:')} "
                              f"Ваш ход. Какое количество конфет вы берете?"
                              f"(Максимальное = {step} )", reply_markup=ReplyKeyboardRemove())
    return 1


def play_step(update, context):
    global candies
    candiy = int(update.message.text)
    candies -= candiy
    if candies <= step:
        update.message.reply_text(f"Игра окончена, я забираю оставшиеся конфеты, я победил! {emoji.emojize(':partying_face:')}", reply_markup=markup)
        return ConversationHandler.END
    else:
        update.message.reply_text(f"На кону {candies} конфет, я беру {candies % (step + 1)} {emoji.emojize(':candy:')}")
        candies -= candies % (step + 1)
        if candies <= step:
            update.message.reply_text(f"Поздравляю, ты победил! {emoji.emojize(':clapping_hands:')}", reply_markup=markup)
            return ConversationHandler.END


def easy(update, context):
    update.message.reply_text(f"Вы выбрали простой режим {emoji.emojize(':OK_hand:')} "
                              f"На кону {candies} конфет.{emoji.emojize(':candy:')} "
                              f"Ваш ход. Какое количество конфет вы берете?"
                              f"(Максимальное = {step} )", reply_markup=ReplyKeyboardRemove())
    return 1


def easy_step(update, context):
    global candies
    candy = int(update.message.text)
    candies -= candy
    if candies <= step:
        update.message.reply_text(f"Игра окончена, я забираю оставшиеся конфеты, я победил! {emoji.emojize(':partying_face:')}", reply_markup=markup)
        return ConversationHandler.END
    else:
        random = randint(0, step)
        update.message.reply_text(f"На кону {candies} конфет, я беру {random} {emoji.emojize(':candy:')}")
        candies -= random
        if candies <= step:
            update.message.reply_text(f"Поздравляю, ты победил! {emoji.emojize(':clapping_hands:')}", reply_markup=markup)
            return ConversationHandler.END


def stop(update, context):
    update.message.reply_text(f"Всего доброго! {emoji.emojize(':waving_hand:')}")
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

    easy_hundler = ConversationHandler(
        entry_points=[CommandHandler('easy', easy)],
        states={
            1: [MessageHandler(Filters.text & ~Filters.command, easy_step)]
        },
        fallbacks=[CommandHandler('stop', stop)]
    )

    dp.add_handler(CommandHandler("start", start))
    dp.add_handler(CommandHandler("rules", rules))
    dp.add_handler(settings_hundler)
    dp.add_handler(play_hundler)
    dp.add_handler(easy_hundler)

    dp.add_handler(CommandHandler("close", close_keyboard))

    updater.start_polling()
    updater.idle()


if __name__ == '__main__':
    main()
