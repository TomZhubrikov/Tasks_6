// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

bool F = true;
int n, count = 0;
while (F)
{
    Console.Write("('666' for exit) Enter a number -> ");
    n = int.Parse(Console.ReadLine());
    if (n == 666) F = false;
    else if (n > 0) count++;
}
Console.WriteLine($"Entered {count} numbers > 0!");
