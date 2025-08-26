﻿namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite o primeiro valor:");
            decimal valueOne = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Digite o segundo valor:");
            decimal valueTwo = Convert.ToDecimal(Console.ReadLine());

            while (valueOne == valueTwo)
            {
                Console.Write("Os valores são iguais, digite um valor diferente para o segundo valor: ");
                valueTwo = Convert.ToDecimal(Console.ReadLine());
            }

            decimal soma = valueOne + valueTwo;
            decimal subtracao = valueOne - valueTwo;
            decimal multiplicacao = valueOne * valueTwo;



            

            Console.WriteLine($"Digite o tipo de operação que deseja realizar: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão");
            int operacao = Convert.ToInt32(Console.ReadLine());
            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"Valor da soma dos dois valores: {soma}");
                    break;
                case 2:
                    Console.WriteLine($"Valor da subtração dos dois valores: {subtracao}");
                    break;
                case 3:
                    Console.WriteLine($"Valor da multiplicação dos dois valores: {multiplicacao}");
                    break;
                case 4:
                    if (valueTwo == 0)
                    {
                        Console.WriteLine("Não é possível realizar a divisão por zero.");
                    }
                    else
                    {
                        decimal divisao = valueOne / valueTwo;
                        Console.WriteLine($"Valor da divisão dos dois valores: {divisao}");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
        }
    }
}