#Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между
# максимальным и минимальным значением дробной части элементов.

# Пример:
#
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19

list = [1.1, 1.2, 3.1, 5, 10.01]
new_list = []
dr = 0
for i in range(len(list)):
    if type(list[i]) == float:
        dr = round((list[i] - int(list[i])), 2)
        new_list.append(dr)
print(new_list)
print("Максимальное значение дробной части: ", max(new_list))
print("Минимальное значение дробной части: ", min(new_list))
print()
print("Hазница между максимальным и минимальным значением дробной части элементов: ", max(new_list) - min(new_list))
