# 4.	Задана натуральная степень k. Сформировать случайным образом список коэффициентов
# (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
# Пример:
# o	k=2 => 2x² + 4x + 5 = 0 или x² + 5 = 0 или 10*x² = 0


from random import randint

k = int(input("Введите значение степени, k = "))
sp_k = []
x = None
formula = ' '
for i in range(0, k + 1):
    sp_k.append(int(randint(1, 100)))
print("список коэффициентов: ", sp_k)


for i in range(0, k):
            if sp_k[i] != 0:                            #i != len(sp_k) - 1 and sp_k[i] != 0 and i != len(sp_k) - 2:
                formula += f'{sp_k[i]}x^{len(sp_k) - i - 1}'
                if sp_k[i + 1] != 0:
                    formula += ' + '
formula += f'{sp_k[-1]} = 0'
print("Многочлен: ", formula)

with open('Task_4.txt', 'w') as data:
    data.write(formula)