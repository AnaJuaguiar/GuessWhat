using System;

namespace GuessWhat
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int guess = 0;

            while (true)
            {
                GetAppInfo();

                GetUserInfo();

               Random random = new Random();

                int correctNumber = random.Next(1, 10);

                Console.WriteLine("Iremos jogar um jogo de adivinhação...");
                Console.WriteLine("Seu objetivo é escolher um número. Se o número escolhido por você for igual ao número pensado por mim, você ganha. ");
                Console.Write("Agora é a hora de adivinhar. Escolha um número entre 0 e 10: ");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("Errado! Você não digitou um número ");
                        Console.WriteLine("Por favor, digite um número válido entre 0 e 10: ");

                        Console.ResetColor();

                        continue;
                    }
                   
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("Errado! Tente novamente. Digite um número entre 0 e 10 ");
                   
                        guess = Int32.Parse(input);

                        Console.ResetColor();

                    }
                }

                CorrectNumber();

                Console.WriteLine("Jogar Novamente? [S ou N] ");

                string answer;
                answer = Console.ReadLine().ToUpper();

                if (answer == "S")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }
            }
            
         }

        static void GetAppInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Guess What?!");
            Console.WriteLine("Desenvolvido By: Ana Júlia");
            Console.WriteLine("Versão 1.0.0");

            Console.ResetColor();
        }

        static void GetUserInfo()
        {
            Console.Write("Qual o seu nome?  ");
            string name = Console.ReadLine();

            Console.WriteLine($"Olá {name}, vamos jogar um jogo... ");
        }

       

        static void CorrectNumber()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Você adivinhou o número correto e venceu o jogo! Parabéns");

            Console.ResetColor();
        }

    }
}
