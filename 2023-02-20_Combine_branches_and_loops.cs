﻿

int sum = 0;

for (int i = 1; i < 21; i++)
{
    if (i % 3 == 0)
    {
        sum += i;
    }
}

System.Console.WriteLine($"Sum is {sum}");