// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    System.Console.Write($"Число {a} большее, а число {b} меньшее");
}
else {
    System.Console.Write($"Число {b} большее, а число {a} меньшее");
}