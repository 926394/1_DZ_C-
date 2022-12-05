// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int num0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num1 = int.Parse(Console.ReadLine()!);
int max = 0;
int min = 0;
if (num0 > num1)
{
    max = num0; 
    min = num1;   
}
else
{
    max = num1;
    min = num0;    
}
Console.WriteLine("Ответ,большее число: " + max);
Console.WriteLine("Ответ, меньшее число: " + min);
