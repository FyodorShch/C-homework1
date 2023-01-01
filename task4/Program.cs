/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0)
{
    for (int i = 1; i <= N-2; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i}, ");
        }
    }
    Console.Write($" {N}");
}
else 
{
    for(int j=1;j<=N-2;j++)
    {
        if(j%2==0)
        {
            Console.Write($"{j}, ");
        }
    }
    Console.Write($"{N-1}");
}