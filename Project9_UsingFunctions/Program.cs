// 8. Нахождение максимального числа из 9 с использованием функций.
Console.WriteLine("Привет! Эта программа ищет максимальное число из 9.");
Console.WriteLine("Числа вводятся внутри кода. Программа использует функции.");
int a1 = 1;
int a2 = 12;
int a3 = 32;
int a4 = 43;
int a5 = 54;
int a6 = 65;
int a7 = 76;
int a8 = 87;
int a9 = 98;
int Max(int arg1, int arg2, int arg3) // Создаем новую функцию (она же подпрограмма) для нахождения max из 3
{ // создаем тело функции
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result; // возвращаем в качестве ответа переменную "result".
}
int max1 = Max(a1, a2, a3); // применяем функцию для чисел из кода
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int answ = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine(answ);

