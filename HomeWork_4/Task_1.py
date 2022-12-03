# 1.	Вычислить число c заданной точностью d
# Пример:
# при $d = 0.001, π = 3.141.$ $10^{-1} ≤ d ≤10^{-10}$

import math
print(math.pi)
n = math.pi
d = input("Введите точность, d = ")
count = -1
for digit in d:
    if digit.isdigit():
        count += 1
print(count)
print(round((n), count))