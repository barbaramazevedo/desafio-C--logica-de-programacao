namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números de 0 a 25 (com incremento de 1):");
            for (int i = 0; i <= 25; i++)
            {
                if (i < 25)
                    Console.Write(i + ", ");
                else
                    Console.Write(i);
            }

            Console.WriteLine("\nNúmeros de 0 a 200 (com incremento de 10):");
            for (var i = 10; i <= 200; i += 10)
            {
                 if (i < 200)
                    Console.Write(i + ", ");
                else
                    Console.Write(i);
            }
        }
    }
}