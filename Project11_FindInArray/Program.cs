//11. Нахождение в массиве указанного числа.
Console.WriteLine("Привет! Данная программа ищет указаннок число в массиве и выводит его индекс");
int[] array1 = { 5, 65, 89, 1156, 9921, 59, -563, 55, -798, 9998 };

int n = array1.Length; // так можно считать информацию о длине массива

Console.WriteLine("Укажите, какое число ищем");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0; // счетчик индекса

while (index < n)
{
  if (array1[index] == find)
  {
    Console.WriteLine($"Индекс числа: {index}");
  }
  index++;
}