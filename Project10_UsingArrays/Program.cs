// 9. Нахождение максимального числа из 9 с использованием функций и массивов.
Console.WriteLine("Привет! Эта программа ищет максимальное число из 9.");
Console.WriteLine("Числа вводятся внутри кода. Программа использует функции и массивы.");
int[] array = { 1, 12, 32, 43, 54, 65, 76, 87, 98 }; // вместо нескольких переменных int задали 1 массив

array[0] = 100; // так можно менять числа массива

int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

int answ = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8])); // строки можно переносить. Логическое замыкание происходит только после ";"

Console.WriteLine(answ);
