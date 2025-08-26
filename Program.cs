namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.Write($"Digite o primeiro valor:");
            numeros.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Digite o segundo valor:");
            numeros.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Digite o tercero valor:");
            numeros.Add(Convert.ToInt32(Console.ReadLine()));

            Console.Write($"Valores em ordem crescente:");
            Console.WriteLine(string.Join(", ", numeros.OrderBy(n => n)));
        }
    }
}