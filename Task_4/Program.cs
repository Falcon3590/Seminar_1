﻿Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.Write ("{0}, ", i);
        Console.Write ("чётные числа");