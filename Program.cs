namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "barbara", "renata", "paula", "julia", "amanda", "larissa", "sofia" };

            Console.WriteLine("Digite um nome para verificar no sistema:");
            string nomeRecebido = Console.ReadLine();

            bool nomeEncontrado = false;
            foreach (string nome in nomes)
            {
                if (nome.Equals(nomeRecebido, StringComparison.OrdinalIgnoreCase))
                {
                    nomeEncontrado = true;
                    break;
                }
            }
            if (nomeEncontrado)
            {
                Console.WriteLine($"O nome {nomeRecebido} foi encontrado no sistema.");
            }
            else
            {
                Console.WriteLine($"O nome {nomeRecebido} não foi encontrado no sistema.");
            }            
        }
    }
}