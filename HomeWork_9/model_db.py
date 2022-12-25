import sqlite3


def connect():
    global conn, cursor
    conn = sqlite3.connect('people.db')
    cursor = conn.cursor()


def disconect():
    conn.commit()
    conn.close()


def all(update, context):
    cursor.execute("select * from people")
    results = cursor.fetchall()
    update.message.reply_text(''.join([str(element) for element in results]))


def find(update, context):
    try:
        name = update.message.text
        cursor.execute(f"select * from people where surname like '%{name}%'")
        results = cursor.fetchall()
        for i in results:
            if name not in i:
                update.message.reply_text("Контакт найден")
            else:
                update.message.reply_text(''.join([str(element) for element in results]))
    except Exception as exp:
        if name != name.title():
            update.message.reply_text('Введите фамилию с заглавной буквы!')


def add(update, context):
    flag = 0
    surname, name, phone, description = update.message.text.split()
    cursor.execute("select * from people")
    results = cursor.fetchall()
    for i in results:
        if int(phone) in i:
            update.message.reply_text("Такой номер уже есть")
            flag = 1
            break
        if flag != 1:
            cursor.execute(
                f"insert * into people (surname, name, phone, description)"
                f"values ('{surname}', '{name}', {phone}, '{description}')"
            )
        update.message.reply_text('Контакт добавлен')


def update(update, context):
    surname, phone = update.message.text.split()
    cursor.execute(f"update people set phone={phone} where surname = '{surname}'")
    update.message.reply_text('Изменения внесены')


def delete(update, context):
    try:
        cursor.execute(
            f"delete from phone where id = {id}")
        conn.commit()
        return "Контакт был удалён"
    except:
        return "Контакт не найден"




