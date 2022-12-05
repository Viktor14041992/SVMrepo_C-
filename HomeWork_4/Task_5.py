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
e = '^'

for i in range(0, len(sp1) - 2):

    if sp1[i] == str(e):
        continue

    if sp1[i].isdigit() and sp1[i + 1].isdigit() and sp1[i + 2].isdigit():
        new_sp1.append(sp1[i] + sp1[i + 1] + sp1[i + 2])
        continue
    if sp1[i].isdigit() and sp1[i + 1].isdigit():
        new_sp1.append(sp1[i] + sp1[i + 1])
        continue
    if sp1[i].isdigit():
        new_sp1.append(sp1[i])

    i += 1
print()
print(new_sp1)

