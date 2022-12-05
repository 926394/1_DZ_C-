// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int num0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int num2 = int.Parse(Console.ReadLine()!);

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
if (max > num2) 
{
    max = max;   
}
else
{
    max = num2;
}
if (min > num2) 
{
    
    min = num2; 
}
Console.WriteLine("Ответ,большее число: " + max); 
Console.WriteLine("Ответ, меньшее число: " + min);
