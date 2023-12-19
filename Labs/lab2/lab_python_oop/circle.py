import math

from lab_python_oop.color import Color
from lab_python_oop.geometric_figure import GeometricFigure


class Circle(GeometricFigure, Color):
    figure_type = "Круг"

    def __init__(self, radius, color):
        GeometricFigure.__init__(self)
        Color.__init__(self, color)
        self.radius = radius

    def calculate_area(self):
        return math.pi * self.radius ** 2

    def __repr__(self):
        return "{}, {} цвет, радиусом {}. Площадь: {}".format(
            self.figure_type,
            self.color,
            self.radius,
            self.calculate_area()
        )
