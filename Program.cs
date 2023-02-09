using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeBoard();

            double firstNumber = GetFirstNumber();
            double secondNumber = GetSecondNumber();

        }

        static void WelcomeBoard()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-----------Bem vindo-----------");
            Console.WriteLine("-------------------------------");
        }

        static double GetFirstNumber()
        {
            Console.WriteLine("Digite o primeiro valor a ser calculado:");
            var number = Console.ReadLine();
            return Convert.ToDouble(number);
        }

        static double GetSecondNumber()
        {
            Console.WriteLine("Digite o segundo valor a ser calculado:");
            var number = Console.ReadLine();
            return Convert.ToDouble(number);
        }
    }
}
