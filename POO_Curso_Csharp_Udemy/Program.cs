namespace POO_Curso_Csharp_Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            Console.WriteLine("Informe a marca do carro:");
            carro1.SetMarca(Console.ReadLine());

            Console.WriteLine("Informe o modelo do carro:");
            carro1.SetModelo(Console.ReadLine());

            Console.WriteLine("Informe a cor do carro:");
            carro1.SetCor(Console.ReadLine());

            Console.WriteLine($"Marca: {carro1.GetMarca()}");
            Console.WriteLine($"Modelo: {carro1.GetModelo()}");
            Console.WriteLine($"Cor: {carro1.GetCor()}");
        }
    }
}
