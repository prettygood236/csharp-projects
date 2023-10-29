using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            
            int roll1 = dice.Next(1,7);
            int roll2 = dice.Next(1,7);
            int roll3 = dice.Next(1,7);
            int bonus = 0;
            int total = 0;

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                bonus += 6;
            }
            else if ((roll1 == roll2) || (roll3 == roll2) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                bonus += 2;
            }

            total = roll1 + roll2 + roll3 + bonus;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} + {bonus} = {total}");
            if (total >= 15)
            {
                Console.WriteLine("You got it");
            }
            else
            {
                Console.WriteLine("You are a loser H A H A");
            }
        }
    }
}
