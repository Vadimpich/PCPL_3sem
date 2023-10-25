import unittest

from main import *


class TestSolutions(unittest.TestCase):
    def setUp(self):
        self.prods = [
            Producer(1, 'ВАГОНМАШ'),
            Producer(2, 'Завод Драйв'),
            Producer(3, 'Партариум'),
        ]
        self.parts = [
            Part(1, 'Крепление', 100, 1),
            Part(2, 'Гайка', 50, 2),
            Part(3, 'Мост', 300, 3),
            Part(7, 'Двутавр', 500, 1),
            Part(8, 'Сетка', 400, 2),
            Part(9, 'Колесо', 1000, 3),
        ]
        self.prod_parts = [
            ProdPart(1, 1),
            ProdPart(2, 2),
            ProdPart(3, 3),
            ProdPart(1, 7),
            ProdPart(2, 8),
            ProdPart(3, 9),
        ]
        self.test_word = 'Драйв'
        self.test_letter = 'К'

    def test_task1_solution(self):
        result = task1(
            self.test_word,
            one_to_many(self.prods, self.parts)
        )
        self.assertEqual(
            result,
            [('Завод Драйв', 'Гайка', 50), ('Завод Драйв', 'Сетка', 400)]
        )

    def test_task2_solution(self):
        result = task2(one_to_many(self.prods, self.parts))
        self.assertEqual(
            result,
            [('Завод Драйв', 225.0), ('ВАГОНМАШ', 300.0), ('Партариум', 650.0)]
        )

    def test_task3_solution(self):
        result = task3(
            self.test_letter,
            many_to_many(self.prods, self.parts, self.prod_parts)
        )
        self.assertEqual(
            result,
            [('Крепление', 'ВАГОНМАШ'), ('Колесо', 'Партариум')]
        )


if __name__ == '__main__':
    unittest.main()
