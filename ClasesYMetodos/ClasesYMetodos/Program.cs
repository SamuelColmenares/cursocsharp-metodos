using System;

namespace ClasesYMetodos
{
    class Program : Carro
    {
        static void Main(string[] args)
        {
            Program carro = new Program();
            carro.Arrancar();
            carro.AdicionarGasolina(5);
            int manejar = carro.Manejar(5, 10);
            var aa = 2;
            Console.WriteLine("Valor {1} de funcioni manejar {0}", manejar, aa);
            double velocidadMax = carro.ObtenerMaxVelocidad();
            Console.WriteLine("Mi velocidad max es {0} ", velocidadMax);
            string distancia = carro.Distancia(10, 30, "Millas.");
            int dist2 = carro.Distancia(5, 20);
            Console.WriteLine("- {0} - {1}", distancia, dist2);
        }

        public override double ObtenerMaxVelocidad()
        {
            return 201.4;
        }

        public string Distancia(int inicio, int fin, string medida = "Km")
        {
            return $"Mi distancia fue: {fin - inicio} {medida}";
        }

        public int Distancia(int inicio, int fin)
        {
            return fin - inicio;
        }

    }


}
