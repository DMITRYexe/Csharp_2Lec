//12. Тренировка синтаксиса языка C#
Console.WriteLine("Привет! Данная программа создана для тренировки синтаксиса C#.");
Console.WriteLine("Я даже не знаю, что в ней будет:)");
void DigitsForArray(int [] digits) // процедура присваивания массиву радномных чисел
{
  int length = digits.Length;
  int index =0;
  while (index<length)
  {
    digits[index] = new Random().Next(1,10);
    index++;
  }
}
void PrintArray (int[] dig) // процедура вывода чисел из массива
{
  int count = dig.Length;
  int position = 0;
  while (position < count)
  {
    Console.Write($" {dig[position]}");
    position++;
  }
}
int[] array1 = new int[11]; // способ создания массива, где 11 - указание размера массива (кол-во элементов)

DigitsForArray(array1);
PrintArray(array1);