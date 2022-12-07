# Список продуктов.
# лук 1 головка
# картофели штук 6
# картошку почистить
# лук порезать кольцами
# зажарить всё
#
# Программа убирает 'лук'



n = 5
sp = []
for i in range(1,6):
    sp.append(input())
print(sp)

sp = list(filter(lambda x: 'лук' not in x,sp))
sp.sort(key = lambda x: len(x))

print()
print(*sp, sep=',')

#print(','.join(sp))
