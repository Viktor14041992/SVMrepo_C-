# 3.	Задайте последовательность чисел. Напишите программу,
# которая выведет список неповторяющихся элементов исходной последовательности.
# [1, 2, 2, 3, 4]  -> [1, 3, 4]

sp = [1, 2, 2, 3, 4]
new_sp = []
for i in sp:
    if sp.count(i) == 1:
        new_sp.append(i)

print("список неповторяющихся элементов: ", new_sp)
