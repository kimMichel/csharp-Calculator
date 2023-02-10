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

            ShowMenu();

            MathOperations action = GetCalcAction();
            MathOperation(firstNumber: firstNumber, secondNumber: secondNumber, action: action);

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

        static void ShowMenu()
        {
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("Qual operação deseja realizar?");
        }

        static MathOperations GetCalcAction()
        {
            var option = Console.ReadLine();
            switch (Convert.ToInt32(option))
            {
                case 1: return MathOperations.Adicao;
                case 2: return MathOperations.Subtracao;
                case 3: return MathOperations.Multiplicação;
                case 4: return MathOperations.Divisão;
                default: return MathOperations.Error;
            }
        }

        static void MathOperation(double firstNumber, double secondNumber, MathOperations action)
        {
            switch (action)
            {
                case MathOperations.Adicao:
                    {
                        Console.Clear();
                        var result = firstNumber + secondNumber;
                        Console.WriteLine($"O resultado  da operação é: {result}");
                        break;
                    }
                case MathOperations.Subtracao:
                    {
                        Console.Clear();
                        var result = firstNumber - secondNumber;
                        Console.WriteLine($"O resultado  da operação é: {result}");
                        break;
                    }
                case MathOperations.Multiplicação:
                    {
                        Console.Clear();
                        var result = firstNumber * secondNumber;
                        Console.WriteLine($"O resultado  da operação é: {result}");
                        break;
                    }
                case MathOperations.Divisão:
                    {
                        Console.Clear();
                        var result = firstNumber / secondNumber;
                        Console.WriteLine($"O resultado  da operação é: {result}");
                        break;
                    }
                default: Console.WriteLine("Não consegui identificar a ação que você deseja realizar."); break;
            }
        }
    }

    enum MathOperations
    {
        Adicao = 1,
        Subtracao = 2,
        Multiplicação = 3,
        Divisão = 4,
        Error = 5
    }
}
