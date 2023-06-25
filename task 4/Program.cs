// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a,b;
b= 1;
Console.WriteLine("Введите число");
a= int.Parse(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до {a}:");
a++;
while (a>b)
{
if (b%2==0){
    Console.WriteLine(b);
};
b++;
}
