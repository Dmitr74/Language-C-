//Напишите программу, которая на вход принимает число и выдаёт его квадрат (умножает число само на себя).

Console.Write ("Введите число:");
int number =  Convert.ToInt32(Console.ReadLine());
int square = 0;
square = number * number;
Console.Write($"Квадрат числа {number} = {square}");
