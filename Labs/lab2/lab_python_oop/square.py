from lab_python_oop.rectangle import Rectangle


class Square(Rectangle):
    figure_type = "Квадрат"

    def __init__(self, side_length, color):
        super().__init__(side_length, side_length, color)

    def __repr__(self):
        return "{}, {} цвет, со стороной {}. Площадь: {}".format(
            self.figure_type,
            self.color,
            self.width,
            self.calculate_area()
        )
