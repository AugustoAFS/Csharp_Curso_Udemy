namespace POO_Curso_Csharp_Udemy
{
    public class Carro
    {
        private string? Marca;
        private string? Modelo;
        private string? Cor;

        public string? GetMarca()
        {
            return this.Marca;
        }

        public string? GetModelo()
        {
            return this.Modelo;
        }

        public string? GetCor()
        {
            return this.Cor;
        }

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public void SetCor(string cor)
        {
            this.Cor = cor;
        }
    }
}
