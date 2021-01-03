using System;
using MyClasses.Shared;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Start();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}