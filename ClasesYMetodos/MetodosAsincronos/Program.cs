using System;
using System.Threading.Tasks;

namespace MetodosAsincronos
{
    public class Program
    {
        static Task Main(string[] args) => EjecutarDemoraAsync();        
        static async Task EjecutarDemoraAsync()
        {
            DateTime inicio = DateTime.Now;
            /*Task<int> demora = Demora();
            Console.WriteLine("Ejecucion tarea async.. {0} ", (DateTime.Now - inicio));

            Task<int> demora2 = Demora2();
            Console.WriteLine("Ejecucion tarea async 2.. {0}", (DateTime.Now - inicio));

            int resultado = await demora;
            Console.WriteLine("Respuesta tarea async.. {0} Tiempo: {1}", resultado, (DateTime.Now - inicio));
            int resultado2 = await demora2;
            Console.WriteLine("Respuesta tarea async 2.. {0} Tiempo: {1} ", resultado2, (DateTime.Now - inicio));*/
            int demora = await Demora();
            Console.WriteLine("Ejecucion tarea async.. {0} ", (DateTime.Now - inicio));

            int demora2 = await Demora2();
            Console.WriteLine("Ejecucion tarea async 2.. {0}", (DateTime.Now - inicio));            
        }

        public static async Task<int> Demora()
        {
            Console.WriteLine("Inicia metodo");
            await Task.Delay(4000);
            Console.WriteLine("fin delay");
            return 5;
        }

        public static async Task<int> Demora2()
        {
            Console.WriteLine("Inicia metodo2");
            await Task.Delay(7000);
            Console.WriteLine("fin delay 2");
            return 15;
        }

    }
}
