// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a,b,c,max;

Console.WriteLine("Введите первое число");
a= int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
b= int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
c= int.Parse(Console.ReadLine());
max= a;
if (b > max) max=b;
if (c > max) max=c;

Console.WriteLine($"max = {max}");

