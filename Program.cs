namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite o primeiro valor:");
            int valueOne = int.Parse(Console.ReadLine());
            Console.Write($"Digite o segundo valor:");
            int valueTwo = int.Parse(Console.ReadLine());
            Console.Write($"Digite o terceiro valor:");
            int valueThree = int.Parse(Console.ReadLine());

            Console.Write($"Valores digitados: {valueOne}, {valueTwo}, {valueThree}");

            int temp = valueTwo;
            valueTwo = valueThree;
            valueThree = valueOne;
            valueOne = temp;

            Console.Write($"\nValores após a troca: {valueOne}, {valueTwo}, {valueThree}");
        }
    }
}
