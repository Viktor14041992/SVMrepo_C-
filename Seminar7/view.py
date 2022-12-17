def greeting():
    print('Hello! Выьъберете действие 1 - калькулятор, 2 - конвертер')
    select = int(input())
    return select

def get_math_example():
    primer = input("Введите выражение ")
    return primer

def view_result(result):
    print("Рузультат = ", result)

def get_mass():
    mass = input("Введите массу в кг ")
    return mass