namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite a hora inicial do jogo:");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write($"Digite a hora final do jogo:");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine($"O jogo durou {duracao} hora(s)");
        }
    }
}
