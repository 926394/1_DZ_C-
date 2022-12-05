// Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Console.Write("Введите число N: ");
//  int N = int.Parse(Console.ReadLine()!);


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 0;
int n = i;

while (i < N + 1) 
    {
    i = i + 1; 
    }

while (n < i) 
    {
    Console.WriteLine(n);
    n = n + 2; 
    }

