namespace POO_Carro_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro myCar = new Carro();

            Console.WriteLine("Digite a marca do carro:");
            myCar.Marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro:");
            myCar.Modelo = Console.ReadLine();

            Console.WriteLine("Digite a cor do carro:");
            myCar.Cor = Console.ReadLine();

            Console.WriteLine("Dados do carro:");
            Console.WriteLine($"Marca: {myCar.Marca}");
            Console.WriteLine($"Modelo: {myCar.Modelo}");
            Console.WriteLine($"Cor: {myCar.Cor}");
        }
    }
}
