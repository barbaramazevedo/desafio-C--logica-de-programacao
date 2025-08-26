namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite um valor:");
            decimal variavel = Convert.ToDecimal(Console.ReadLine());

            if (variavel > 0)
            {
                Console.WriteLine($"O valor {variavel} é positivo.");
            }
            else if (variavel < 0)
            {
                Console.WriteLine($"O valor {variavel} é negativo.");
            }
            else
            {
                Console.WriteLine($"O valor é zero.");
            }
        }
    }
}
