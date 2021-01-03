using System;
using static System.Console;

namespace MyClasses.Shared
{
    public class Game
    {
        private int You {get; set;}
        private int Computer {get; set;}
        private bool Loop {get; set;}
        private string[] Options = new string[4];
        Random RndBetween = new Random();

        public Game() {
            this.Loop = true;
            this.Options[0] = "empate!";
            this.Options[1] = "pedra";
            this.Options[2] = "papel";
            this.Options[3] = "tesoura";
        }

        public void Start() {

            string[] results = new string[3];

            results[0] = this.Options[0];
            results[1] = "perdeu!";
            results[2] = "ganhou!";
            int youPoints = 0;
            int computerPoints = 0;
            int nonePoints = 0;

            while (this.Loop) {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                WriteLine("Escolha uma das opções: [1] -> Pedra, [2] -> Papel, [3] -> Tesoura.");
                this.Computer = this.RndBetween.Next(1,3);

                try
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    this.You = int.Parse(ReadLine());

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    WriteLine($"Você: {this.Options[this.You]}, Computador: {this.Options[this.Computer]}");

                    int result = this.YouChoice(this.Options[this.You], this.Options[this.Computer]);

                    if (results[result] == "ganhou!")
                    {

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        youPoints++;
                    }else if (results[result] == "perdeu!")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        computerPoints++;
                    } else
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        nonePoints++;
                    }

                    WriteLine(results[result]);

                    WriteLine();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    
                    WriteLine("Deseja Continuar: [n] para cancelar, [*] qualquer tecla para continuar:");
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    string end = ReadLine();
                    WriteLine();

                    if (end.ToLower() == "n") {

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        this.Loop = false;
                        WriteLine("Seus pontos: " + youPoints);
                        WriteLine("Computador pontos: " + computerPoints);
                        WriteLine("Empates: " + nonePoints);
                    }
                }
                catch (System.Exception error)
                {
                    
                    WriteLine(error.Message);
                    WriteLine();
                }

            }

        }

        private int YouChoice(string you, string computer) {
            
            // pedra < papel

            // papel < tesoura

            // tesoura < pedra

            switch (you)
            {
                case "pedra":
                    switch (computer)
                    {
                        case "papel":
                        return 1;

                        case "tesoura":
                        return 2;
            
                        default:
                        break;
                    }
                break;

                case "papel":
                    switch (computer)
                    {
                        case "pedra":
                        return 2;

                        case "tesoura":
                        return 1;
            
                        default:
                        break;
                    }
                break;

                case "tesoura":
                    switch (computer)
                    {
                        case "pedra":
                        return 1;

                        case "papel":
                        return 2;
            
                        default:
                        break;
                    }
                break;

                default:
                break;
            }

            return 0;

        }
        
    }
}
