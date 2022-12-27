import logging

from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove
from telegram.ext import Updater, CommandHandler

reply_keyboard = [['/address', '/phone'],
                  ['/site', '/work_time'],
                  ['/picture', '/close']]

markup = ReplyKeyboardMarkup(reply_keyboard, one_time_keyboard=False)

logging.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=logging.DEBUG
)

logger = logging.getLogger(__name__)

TOKEN = ''


def start(update, context):
    update.message.reply_text(
        "РЇ Р±РѕС‚-СЃРїСЂР°РІРѕС‡РЅРёРє. РљР°РєР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ РІР°Рј РЅСѓР¶РЅР°?",
        reply_markup=markup
    )

def close_keyboard(update, context):
    update.message.reply_text(
        "Ok",
        reply_markup=ReplyKeyboardRemove()
    )

def help(update, context):
    update.message.reply_text(
        "РЇ Р±РѕС‚ СЃРїСЂР°РІРѕС‡РЅРёРє.")


def address(update, context):
    update.message.reply_text(
        "РђРґСЂРµСЃ: 125167, Рі. РњРѕСЃРєРІР°, Р›РµРЅРёРЅРіСЂР°РґСЃРєРёР№ РїСЂРѕСЃРїРµРєС‚, Рґ.39, СЃС‚СЂ.79 СЌС‚Р°Р¶ 23, РїРѕРјРµС‰РµРЅРёРµ XXXIV")


def phone(update, context):
    update.message.reply_text("РўРµР»РµС„РѕРЅ: 8 (800) 555-15-40")


def picture(update, context):
    context.bot.send_photo(update.effective_chat.id, photo=open('gb.png', 'rb'))


def site(update, context):
    update.message.reply_text(
        "РЎР°Р№С‚: https://gb.ru")


def work_time(update, context):
    update.message.reply_text(
        "Р’СЂРµРјСЏ СЂР°Р±РѕС‚С‹: РєСЂСѓРіР»РѕСЃСѓС‚РѕС‡РЅРѕ.")


def main():
    updater = Updater(TOKEN)
    dp = updater.dispatcher
    dp.add_handler(CommandHandler("address", address))
    dp.add_handler(CommandHandler("phone", phone))
    dp.add_handler(CommandHandler("site", site))
    dp.add_handler(CommandHandler("work_time", work_time))
    dp.add_handler(CommandHandler("help", help))
    dp.add_handler(CommandHandler("start", start))
    dp.add_handler(CommandHandler("close", close_keyboard))
    dp.add_handler(CommandHandler("picture", picture))

    updater.start_polling()
    updater.idle()


if __name__ == '__main__':
    main()