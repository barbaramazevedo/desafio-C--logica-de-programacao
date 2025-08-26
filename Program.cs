namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de segundos para converter ao formato HH:MM:SS:");
            int segundos = int.Parse(Console.ReadLine());

            if (segundos < 0)
            {
                Console.WriteLine("Por favor, insira um número inteiro não negativo.");
                return;
            }
            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segs = segundos % 60;
            Console.WriteLine($"{horas:D2}:{minutos:D2}:{segs:D2}");
            
        }
    }
}