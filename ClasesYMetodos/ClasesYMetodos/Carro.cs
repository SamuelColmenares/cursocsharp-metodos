using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesYMetodos
{
    abstract class Carro
    {
        public void Arrancar()
        {
            Console.WriteLine("Arranca carro.");
        }

        protected void AdicionarGasolina(int galones)
        {
            Console.WriteLine("llene {0} galones de gasolina del carro.", galones);
        }

        public virtual int Manejar(int km, int velocidad)
        {
            return 1;
        }

        public abstract double ObtenerMaxVelocidad();
    }
}
