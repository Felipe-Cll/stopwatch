using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo, o que você deseja fazer?");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1 - Cronômetro");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Counter(); break;
                case 0: Exit(); break;
                default: Invalid(); break;
            }
        }

        static void Counter()
        {
            Console.Clear();
            Console.WriteLine("Quanto tempo deseja contar? ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("S - Segundo");
            Console.WriteLine("M - Minuto");
            Console.WriteLine("");
            Console.WriteLine("Exemplo: 60s ou 60m");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite: ");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);

            Start(time);
        }

        static void Start(int time) 
        {
            int currentTime = 0;

            while(currentTime != time) 
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado.");
            Thread.Sleep(1000);
        }

        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar nosso aplicativo, volte sempre!");
            System.Environment.Exit(0);
        }

        static void Invalid()
        {
            Console.WriteLine("Opção inválida!");
            int delay = 1000;
            Thread.Sleep(delay);
            Menu();
        }
    }
}
