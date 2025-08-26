namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para verificar a tabuada:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{numero} x {i} = {numero * i}\n");
            }
        }
    }
}