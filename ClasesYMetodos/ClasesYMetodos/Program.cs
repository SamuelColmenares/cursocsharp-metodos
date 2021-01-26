using System;

namespace ClasesYMetodos
{
    class Program : Carro
    {
        delegate double Suma(float numA, float numB1); //<float, float, double>

        

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
            Console.WriteLine("- ============================ ");
            // Delegados.....
            //Suma add = delegate (float numA, float numB) { return numA + numB; };
            Suma add = (float numA, float numB) => numA + numB;

            Func<int, int, double> Resta = (int a, int b) => b - a;

            double res = add(11.11f, 4.12f);
            Console.WriteLine("- {0} ", res);

            Action<string,int,bool> operacion = carro.Operacion;
            Func<int, int, double> Suma = (int valA, int valB) =>
            {
                Console.WriteLine("valr a: {0}", valA);
                if (valA >= 144)
                {
                    return valA;
                }
                else
                {
                    return 0;
                }
            };

            Suma(0, 1);



        }

        public void Calcular (Action<int> action, int valA, bool a)
        {
            if (a)
            {
                action(valA);
            }
        }

        public void Operacion(string dato, int dato2, bool val)
        {
            Console.WriteLine(" dato - {0} - {1} - {2}", dato, dato2, val);
        }

        public double ImplSuma(float valA, float valorB)//<float, float, double>
        {
            
            return valA + valorB;
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
