// 9. Нахождение максимального числа из 9 с использованием функций и массивов.
Console.WriteLine("Привет! Эта программа ищет максимальное число из 9.");
Console.WriteLine("Числа вводятся внутри кода. Программа использует функции и массивы.");
int[] array = {1,12,32,43,54,65,76,87,98}; // вместо нескольких переменных int задали 1 массив

int Max(int arg1, int arg2, int arg3) // Создаем новую функцию (она же подпрограмма) для нахождения max из 3
{ // создаем тело функции
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result; // возвращаем в качестве ответа переменную "result".
}

int answ = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine(answ);
