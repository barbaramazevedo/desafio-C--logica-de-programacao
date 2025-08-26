namespace Desafio1
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

            Console.WriteLine($"Valor da soma dos dois valores: {soma}");
            Console.WriteLine($"Valor da sutração dos dois valores: {subtracao}");
            Console.WriteLine($"Valor da multiplicação dos dois valores: {multiplicacao}");

            if (valueTwo == 0)
            {
                Console.WriteLine("Não é possível realizar a divisão por zero.");
            }
            else
            {
                decimal divisao = valueOne / valueTwo;
                Console.WriteLine($"Valor da divisão dos dois valores: {divisao}");
            }

        }
    }
}
