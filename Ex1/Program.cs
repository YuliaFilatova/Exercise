﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
Console.WriteLine($"Число {number1} больше чем {number2}");
Console.WriteLine($"Число {number2} меньше чем {number2}");
}
else if(number1 < number2)
{
Console.WriteLine($"Число {number2} больше чем {number1}");
Console.WriteLine($"Число {number1} меньше чем {number2}");
}
