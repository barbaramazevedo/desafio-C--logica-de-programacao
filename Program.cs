namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, -7, 10, 3, 8, 2, -1, 4, -9, 6 };

            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
            }
            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");
            Console.WriteLine($"Quantidade de números positivos: {positivos}");
            Console.WriteLine($"Quantidade de números negativos: {negativos}");
        }
    }
}