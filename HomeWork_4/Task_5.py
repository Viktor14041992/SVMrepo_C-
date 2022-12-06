# 1.	Даны два файла, в каждом из которых находится запись многочлена.
# Задача - сформировать файл, содержащий сумму многочленов.

with open('Task_5.1.txt', 'r') as f:
    a = f.read()

with open('Task_5.2.txt', 'r') as f:
    b = f.read()

sp1 = a
sp2 = b
print(sp1)
print(sp2)
new_sp1 = []
new_sp2 = []

sp1 = sp1[:-3].split('x^')

for i in sp1:
    if '+' in i:
        i = i.split(' + ')
        new_sp1.append(int(i[1]))
        #print(new_sp1)
    else:
        new_sp1.append(int(i))
print()
print("Коэффициенты первого уравнения:", new_sp1)

sp2 = sp2[:-3].split('x^')

for i in sp2:
    if '+' in i:
        i = i.split(' + ')
        new_sp2.append(int(i[1]))
    else:
        new_sp2.append(int(i))
print()
print("Коэффициенты второго уравнения:", new_sp2)

summa = []
print()
summa = list(map(lambda x, y: x + y, new_sp1, new_sp2))
print('Сумма коэффициентов уравнения:', summa)

formula = ' '
for i in range(0, len(summa) - 1):
            if summa[i] != 0:                            #i != len(sp_k) - 1 and sp_k[i] != 0 and i != len(sp_k) - 2:
                formula += f'{summa[i]}x^{len(summa) - i - 1}'
                if summa[i + 1] != 0:
                    formula += ' + '
formula += f'{summa[-1]} = 0'
print("Многочлен: ", formula)

with open('Task_5_rezult.txt', 'w') as data:
    data.write(formula)
