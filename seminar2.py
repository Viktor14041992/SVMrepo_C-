#1.	Даны три целых числа.
#Определите, сколько среди них совпадающих. Программа должна вывести одно из чисел: 3 (если все совпадают),
#2 (если два совпадает) или 0 (если все числа различны).

#number1 = int(input('Введите первое число'))
#number2 = int(input('Введите второе число'))
#number3 = int(input('Введите третье число'))

#if number1 == number2 and number1 == number3:
#   print('3')
#elif number1 != number2 and number1 != number3 and number2 != number3:
#    print('0')
#else:
#    print('2')


#2.	Даны два целых числа A и В, A>B. Выведите все нечётные числа от A до B включительно,
# в порядке убывания. В этой задаче можно обойтись без инструкции if.

#print('Введите два целых числа, А и В, чтобы А > В')
#a = int(input('Введите число A'))
#b = int(input('Введите число B'))

#while a >= b:
#    a = a - (a - 1) % 2
#    print(a)
#    a -= 2
#---------------------------------------------
#( for i in range(a - (a-1) % 2, b-1, -2):   )
#print(i)



#3.	Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
#Пример:
#Для N = 5: 1, -3, 9, -27, 81

#N = int(input('Введите число'))
#for i in range(N):
#    print((-3) ** i, end=' ')


#4.	Напишите программу, которая проверяет пятизначное число на палиндром

#n = input('Введите пятизначное число')

#if n[0] == n[-1] and n[1] == n[-2]:
#    print('Число является палиндромом')
#else:
#    print('Число не является палиндромом')
#-------------------------------------------

#f = 1
#for i in range(len(n) // 2):
#    if n[i] != n[-i - 1]:
#        print('Число не является палиндромом')
#        f = 0
#        break

#if f == 1:
#    print('Число является палиндромом')

# еще есть вариант сравнения строк, разворачиваем строку с помощью переворота строки n2 = n1[::-1]

#n2 = n[::-1]
#if n2 == n:
#    print('Число является палиндромом')
#else:
#    print('Число не является палиндромом')




#5.	Удалить вторую цифру трёхзначного числа.

#a = int(input('Введите число'))
#print(a // 100, a % 10, sep='')

#----------------------------
#a = (input('Введите число'))
#print(a[0] + a[2])



#6.	Напишите программу, в которой пользователь будет задавать
# две строки, а программа - определять количество
# вхождений одной строки в другой.

# первый простой метод:
#n1 = 'vvjhlfdjvvkjg'
#n2 = 'vv'
#print(n1.count(n2))

# алгоритмичный метод

#i = 0
#count = 0
#while i < len(n1):
#    if n1[i:i + len(n2)] == n2:
#        count += 1
#        i += (len(n2)-1)
#    i += 1
#print(count)


#7.	По данному целому числу N распечатайте все квадраты
# натуральных чисел, не превосходящие N, в
# порядке возрастания.

#n = int(input('Введите число'))
#n2 = 0
#while n2 ** 2 < n:
#    print(n2 ** 2)
#    n2 += 1
#-----------------
#for i in range(1, n):
#    if i ** 2 < n:
#        print(i ** 2)
#    else:
#        break

#8.	Определите среднее значение всех элементов
# последовательности, завершающейся числом 0.

#print('Введите число')
#n = None
#sum = 0
#count = 0
#while n != 0:
#    n = int(input())
#    sum += n
#    count += 1
#count -= 1
#avr = sum / count
#print(round(avr, 3))

#----------------------------------

sp = []
n = None
while n != 0:
    n = int(input())
    sp.append(n)
print(round(sum(sp)/(len(sp)-1), 2))
