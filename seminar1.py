# Задача1: Напишите прормму, которая принимает на ввод два числа и проверяет,
# является ли одно число квадратом другого.

number1 = int(input('Введите первое число'))
number2 = int(input('Введите второе число'))

print(number1, number2)

if number1 == number2 ** 2:
    print(number1, 'является квадратом', number2)
elif number2 == number1 ** 2:
    print(number2, 'является квадратом', number1)
else:
    print('нет значений являющихся квадратом другого')



