// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    System.Console.WriteLine($"Максимальное число из всех введенных: {a}");
}
if (b > a && b > c)
{
    System.Console.WriteLine($"Максимальное число из всех введенных: {b}");
}
if (c > a && c > b)
{
    System.Console.WriteLine($"Максимальное число из всех введенных: {c}");
}