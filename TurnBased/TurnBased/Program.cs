using System;

namespace TurnBased
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                // Player turn
                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player HP - " + playerHp + " | Enemy HP - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");
                    Console.WriteLine("Enemy has " + enemyHp + " HP left!");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }
                
                // Enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player HP - " + playerHp + " | Enemy HP - " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                        Console.WriteLine("Player has " + playerHp + " HP left!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }

                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, you've won the game!");
            }
            else
            {
                Console.WriteLine("You lost the game!");
                Console.WriteLine("------------------");
                Console.WriteLine("GAME OVER");
            }
        }
    }
}