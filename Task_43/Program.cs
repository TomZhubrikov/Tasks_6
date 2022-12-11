// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Hi! This is a program that will find the intersection point of two straight lines given by tasks y = k1 * x + b1, y = k2 * x + b2;");
Console.Write("Enter value k1 -> ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Enter value b1 -> ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Enter value k2 -> ");
float k2 = float.Parse(Console.ReadLine());
Console.Write("Enter value b2 -> ");
float b2 = float.Parse(Console.ReadLine());

// x0 and y0 - intersection point coordinates.
float x0 = (b2 - b1) / (k1 - k2);
float y0 = k2 * x0 + b2;
Console.WriteLine($"({x0}; {y0})");
