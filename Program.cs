namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para efetuar o saque:");
            int valor = int.Parse(Console.ReadLine());

            var resultado = Sacar(valor);

            Console.WriteLine("\nCédulas entregues:");
            foreach (var item in resultado)
            {
                Console.WriteLine($"{item.Value} cédula(s) de R$ {item.Key}");
            }



            static Dictionary<int, int> Sacar(int valor)
            {
                int[] cedulas = { 200, 100, 50, 20, 10, 5, 2 };
                Dictionary<int, int> relacaoCedulas = new Dictionary<int, int>();

                int restante = valor;

                foreach (int nota in cedulas)
                {
                    if (restante >= nota)
                    {
                        int quantidade = restante / nota;
                        relacaoCedulas[nota] = quantidade;
                        restante %= nota;
                    }
                }

                if (restante != 0)
                {
                    Console.WriteLine("Não é possível sacar o valor exato com as cédulas disponíveis. Valor restante: R$ " + restante);
                }
                return relacaoCedulas;
            }
        }
    }
}