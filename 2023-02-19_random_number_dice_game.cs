﻿// See https://aka.ms/new-console-template for more information
// If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
// If all three dice you roll result in the same value, you get six bonus points for rolling triples.
// If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
// 

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} ");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled Tripples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}



if (total >= 16)
{
    Console.WriteLine("You won a new car!!!");
}
else if (total >= 10)
{
    Console.WriteLine("You won a new Laptop!!!");
}
else if (total == 7)
{
    Console.WriteLine("You won a trip");
}
else
{
    Console.WriteLine("You won a kitten");
}

Console.WriteLine(total);

