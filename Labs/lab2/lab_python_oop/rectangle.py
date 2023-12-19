from lab_python_oop.color import Color
from lab_python_oop.geometric_figure import GeometricFigure


class Rectangle(GeometricFigure, Color):
    figure_type = "Прямоугольник"

    def __init__(self, width, height, color):
        GeometricFigure.__init__(self)
        Color.__init__(self, color)
        self.width = width
        self.height = height

    def calculate_area(self):
        return self.width * self.height

    def __repr__(self):
        return "{}, {} цвет, шириной {} и высотой {}. Площадь: {}".format(
            self.figure_type,
            self.color,
            self.width,
            self.height,
            self.calculate_area()
        )
