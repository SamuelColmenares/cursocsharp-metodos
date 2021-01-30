using System;
namespace ClasesYMetodos
{
    class Program : Carro
    {
        delegate double Suma(float numA, float numB1); //<float, float, double>



        static void Main(string[] args)
        {
            /*Program carro = new Program();
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

            Action<string, int, bool> operacion = carro.Operacion;
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

            Func<int,int> funcion = (5) =>{
                return 5 + 2;
            }

            carro.Calcular((int val) => val + 2, 3, true);

            //------------------------------------ clases
            Persona persona = new Persona();
            persona.Edad = 15;
            Persona.Estatica = 10;

            Persona persona2 = new Persona();
            persona2.Imprimir();

            Console.WriteLine($"Valor {Persona.General()} --");

            Console.WriteLine($"Valor al cuadrado: {persona.Edad.ElevarAlCuadrado()} --");

            int variable = 4;
            Console.WriteLine($"Var al cuadrado: {variable.ElevarAlCuadrado()} --");
            persona.Imprimir();*/

            Persona persona3 = new Persona();
            Persona persona4 = new Persona("Samuel");
            Persona persona5 = new Persona("Samuel","Colmenares");

            Console.WriteLine($"Per3: {persona3.NombreCompleto()}");
            Console.WriteLine($"Per4: {persona4.NombreCompleto()}");
            Console.WriteLine($"Per5: {persona5.NombreCompleto()}");

            Console.WriteLine($"Per3: {persona3.NombreProfesion()}");
            persona4.Profesion = "Estudiante";
            Console.WriteLine($"Per4: {persona4.NombreProfesion()}");






        }

        public void Calcular(Func<int, int> action, int valA, bool a)
        {
            if (a)
            {
                int res = action(valA) + valA;
                Console.WriteLine(" Resultado suma : {0}", res);
            }
            else
            {
                Console.WriteLine(" No ingreso al if");
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
