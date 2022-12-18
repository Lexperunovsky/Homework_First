Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine() ?? "");
int max;
if (number1 > number2) 
{
max = number1;
}
else if(number2 > number3)
{
max = number2;
}
else if(number3 > number1)
{
max = number3;
}
else if (number1 > number3)
{
    max = number1;
}
else 
{
max = number2;
}


Console.Write($"Максимальным из трех введенных чисел будет {max}");