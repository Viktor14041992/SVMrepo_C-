#Реализуйте алгоритм перемешивания списка(shuffle использовать нельзя, другие методы из библиотеки random - можно).

from random import randint

sp = [1, 2, 3, 4, 5, 6, 7, 8]
print(sp)

for i in range(0, len(sp)*2):
    diff = int(randint(1, len(sp)-1))
    sp[0],sp[diff] = sp[diff],sp[0]

print(sp)
print(diff)

