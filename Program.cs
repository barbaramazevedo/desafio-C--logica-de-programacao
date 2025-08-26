namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, -7, 10, 3, 8, 2, -1, 4, -9, 6 };
            Console.Write("Dado o array de números: ");
            foreach (int num in numeros)
            {
                if(num == numeros.Last())
                    Console.Write(num);
                else
                    Console.Write(num + ", ");
            }
            Console.WriteLine("\n#######################################");
            Console.WriteLine("\nSelecione uma opção a sua escolha (1 a 6):");
            Console.WriteLine("1 - Adicionar um novo número no final do array");
            Console.WriteLine("2 - Remover um número do array baseado em posição");
            Console.WriteLine("3 - Remover um número do array baseado no seu valor");
            Console.WriteLine("4 - Ordenar os números em ordem crescente");
            Console.WriteLine("5 - Ordenar os números em ordem decrescente");
            Console.WriteLine("6 - Somar os valores do array");
            int operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"Digite o valor a ser adicionado:");
                    int valorAdicionar = Convert.ToInt32(Console.ReadLine());
                    Array.Resize(ref numeros, numeros.Length + 1);
                    numeros[numeros.Length - 1] = valorAdicionar;
                    Console.WriteLine("Array atualizado:");
                    foreach (int num in numeros)
                    {
                        if(num == numeros.Last())
                            Console.Write(num);
                        else
                            Console.Write(num + ", ");
                    }
                    break;
                case 2:
                    Console.WriteLine($"Digite a posição do número a ser removido (0 a {numeros.Length - 1}):");
                    int posicaoRemover = Convert.ToInt32(Console.ReadLine());
                    if (posicaoRemover >= 0 && posicaoRemover < numeros.Length)
                    {
                        for (int i = posicaoRemover; i < numeros.Length - 1; i++)
                        {
                            numeros[i] = numeros[i + 1];
                        }
                        Array.Resize(ref numeros, numeros.Length - 1);
                        Console.WriteLine("Array atualizado:");
                        foreach (int num in numeros)
                        {
                            if(num == numeros.Last())
                                Console.Write(num);
                            else
                                Console.Write(num + ", ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Digite o valor a ser removido:");
                    int valorParaRemover = Convert.ToInt32(Console.ReadLine());

                    numeros = numeros.Where(n => n != valorParaRemover).ToArray();

                    Console.WriteLine($"Array após remover {valorParaRemover}:");
                    foreach (int num in numeros)
                        {
                            if(num == numeros.Last())
                                Console.Write(num);
                            else
                                Console.Write(num + ", ");
                        }
                    break;
                case 4:
                    Console.WriteLine($"Você escolheu a opção ordenar por ordem crescente:");
                    Array.Sort(numeros);
                    foreach (int num in numeros)
                    {
                        if(num == numeros.Last())
                            Console.Write(num);
                        else
                            Console.Write(num + ", ");
                    }
                    break;
                case 5:
                    Console.WriteLine($"Você escolheu a opção ordenar por ordem decrescente:");
                    Array.Sort(numeros);
                    Array.Reverse(numeros);
                    foreach (int num in numeros)
                    {
                        if(num == numeros.Last())
                            Console.Write(num);
                        else
                            Console.Write(num + ", ");
                    }
                    break;
                case 6:
                    Console.WriteLine($"Você escolheu a opção somar todos valores:");
                    int soma = 0;

                    foreach (int num in numeros)
                    {
                        soma += num;
                    }
                    Console.WriteLine($"A soma dos valores do array é: {soma}");
                    break;    
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }    
        }
    }
}