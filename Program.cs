namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite o valor fixo do salário do(a) corretor(a):");
            decimal salarioFixo = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Digite o valor total de vendas do(a) corretor(a):");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Digite o percentual da comissão acordado:");
            decimal comissao = Convert.ToDecimal(Console.ReadLine());
            decimal valorComissao = (totalVendas * comissao) / 100;
            decimal salarioFinal = salarioFixo + valorComissao;
            Console.WriteLine($"Valor total a receber: {salarioFinal}");
        }
    }
}
