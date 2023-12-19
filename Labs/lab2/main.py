from lab_python_oop.circle import Circle
from lab_python_oop.rectangle import Rectangle
from lab_python_oop.square import Square


def main():
    width_height = 5
    radius_side_length = 5

    rectangle = Rectangle(width_height, width_height, "синий")
    circle = Circle(radius_side_length, "зеленый")
    square = Square(radius_side_length, "красный")

    print(rectangle)
    print(circle)
    print(square)


if __name__ == "__main__":
    main()
