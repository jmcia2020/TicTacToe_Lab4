﻿using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void StartGame()
        {
            // TODO: Setup your game.
            // Create a new method that creates your players and instantiates the game class.
            // Call that method in your Main method.
            // You are requesting a Winner to be returned,
            // Determine who the winner is output the celebratory message to the correct player.
            // If it's a draw, tell them that there is no winner. 

            Console.WriteLine("Player 1:");
            Player p1 = new Player();
            p1.Name = Console.ReadLine();
            p1.Marker = "X";

            Console.WriteLine("Player 2:");
            Player p2 = new Player();
            p2.Name = Console.ReadLine();
            p2.Marker = "O";

            Console.WriteLine($"Greetings {p1.Name} and {p2.Name}. " +
                $"Would you like to play a game?");

            Game game = new Game(p1, p2);
            Player winner = game.Play();

            if (winner is null)
            {
                Console.WriteLine($"It's a tie!");
                //Console.WriteLine($"Would you like to play again?");
                //Console.WriteLine($"Choose Y or N:");
                //Console.ReadLine(); //if y, StartGame() else close app
            }
            else
            {
                Console.WriteLine($"{winner.Name} won the game! " +
                    $"Isn't this better than global thermonuclear warfare?");
                //Console.WriteLine($"Would you like to play again?");
                //Console.WriteLine($"Choose Y or N:");
                //Console.ReadLine(); //if y, StartGame() else close app
            }
        }
    }
}
