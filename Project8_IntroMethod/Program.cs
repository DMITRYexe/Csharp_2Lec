// 8. Нахождение максимального числа из 9 без подпрограмм
Console.WriteLine("Привет! Эта программа ищет максимальное число из 9.");
Console.WriteLine("Числа вводятся внутри кода. Программа работает без подпрограмм (стихийный подход)");
int a1 = 1;
int a2 = 12;
int a3 = 32;
int a4 = 43;
int a5 = 54;
int a6 = 65;
int a7 = 76;
int a8 = 87;
int a9 = 98;

int max = a1;
if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (a4 > max) max = a4;
if (a5 > max) max = a5;
if (a6 > max) max = a6;
if (a7 > max) max = a7;
if (a8 > max) max = a8;
if (a9 > max) max = a9;

Console.WriteLine(max);