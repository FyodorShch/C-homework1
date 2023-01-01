/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();

Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine($"max -> {a}");
}
if (b > a && b > c)
{
    Console.WriteLine($"max -> {b}");
}
if (c > a && c > b)
{
    Console.WriteLine($"max -> {c}");
}