#Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

# Пример:
#
# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

n = int(input("Введите число: "))
a = n
sp = []
f1 = 0
f2 = 1
sp.append(f1)
sp.append(f2)
while n > 1:
    f1, f2 = f2, f1 + f2
    sp.append(f2)
    n -= 1
print("Ряд Фибоначчи > 0: ", sp)
print()

f1 = 0
f2 = 1
sp.insert(0, f2)
for i in range(0, a-1):
    f1, f2 = f2, f1 - f2
    sp.insert(0, f2)
    i += 1
print("Итоговый список чисел Фибоначчи: ", sp)
