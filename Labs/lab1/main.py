import math
import sys


def solve_quadratic_equation(a, b, c):
    discriminant = b ** 2 - 4 * a * c

    if discriminant > 0:
        x1 = (-b + math.sqrt(discriminant)) / (2 * a)
        x2 = (-b - math.sqrt(discriminant)) / (2 * a)
        return x1, x2
    elif discriminant == 0:
        x = -b / (2 * a)
        return x,
    else:
        return None


def get_coefficient_from_input(prompt):
    while True:
        try:
            value = float(input(prompt))
            return value
        except ValueError:
            print('Введите правильное число.')


def main():
    if len(sys.argv) == 4:
        try:
            a = float(sys.argv[1])
            b = float(sys.argv[2])
            c = float(sys.argv[3])
        except ValueError:
            print("Неверные коэффициенты.")
    else:
        a = get_coefficient_from_input("Введите коэффициент  A: ")
        b = get_coefficient_from_input("Введите коэффициент  B: ")
        c = get_coefficient_from_input("Введите коэффициент  C: ")

    roots = solve_quadratic_equation(a, b, c)

    if roots is not None:
        print("Корни:", roots)
    else:
        print("Корней нет.")


if __name__ == "__main__":
    main()
