//Задание 1.Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое (целое) число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе (целое) число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (number1 > number2) 
{
max = number1;
min = number2;
}
else 
{
max = number2;
min = number1;
}
Console.Write($"Максимальное число = {max}, а минимальное = {min}");