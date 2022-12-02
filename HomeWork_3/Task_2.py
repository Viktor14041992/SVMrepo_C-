#Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# Пример:
#
# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

list = [2, 3, 4, 5, 6]
prod = None
new_list = []
for i in range(len(list) // 2):
    prod = list[i] * list[-i - 1]
    new_list.append(prod)
if len(list) % 2 == 1:
    prod = list[len(list) // 2] ** 2
    new_list.append(prod)
print(new_list)

