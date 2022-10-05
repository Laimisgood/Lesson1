// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int div = value % 2;

if (div == 0)
{
    System.Console.WriteLine($"Число {value} является четным числом");
}
else
{
    System.Console.WriteLine($"Число {value} не является четным числом");
}