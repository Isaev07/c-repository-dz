/* Задача 2

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

*/

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
System.Console.WriteLine("Большее число: " + a + ", меньшее число: " + b);
else System.Console.WriteLine($"Большее число: {a}, меньшее число: {b}");


