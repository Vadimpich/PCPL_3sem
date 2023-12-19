import json

from lab_python_fp.cm_timer import cm_timer_1
from lab_python_fp.print_result import print_result

path = 'data_light.json'

with open(path, encoding='UTF-8') as f:
    data = json.load(f)


@print_result
def f1(arg):
    return sorted(list(set(str(job).lower() for job in arg)),
                  key=lambda x: x.lower())


@print_result
def f2(arg):
    return list(filter(lambda x: str(x).startswith('программист'), arg))


@print_result
def f3(arg):
    return list(map(lambda x: str(x) + ', с опытом Python', arg))


@print_result
def f4(arg):
    salaries = [100000 + i for i in range(len(arg))]
    return list(
        map(lambda x, y: f'{str(x)}, зарплата {y} руб.', arg, salaries))


if __name__ == '__main__':
    with cm_timer_1():
        f4(f3(f2(f1(data))))
