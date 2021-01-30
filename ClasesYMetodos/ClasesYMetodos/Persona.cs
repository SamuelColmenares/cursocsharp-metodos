using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesYMetodos
{
    public partial class Persona
    {
        private int _edad;
        private string _nombre;
        private string _apellido;
        private readonly string nickname;

        public int Edad
        {
            get
            {

                return _edad / 7;
            }

            set
            {
                _edad = value * 7;
            }
        }

        public static int Estatica { get; set; }

        public int Telefono { get; set; } = 7777777; //aautopropiedad

        public Persona()
        {

            Console.WriteLine("Se construye la clase edad: {0}  Telefono{1}", Edad, Telefono);
        }

        public Persona(string nombre)
        {
            _nombre = nombre;
        }
        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        public Persona(string nombre, string apellido, string nickname)
        {
            _nombre = nombre;
            _apellido = apellido;
            this.nickname = nickname;
        }

        public string NombreCompleto()
        {
            return $"El nombre completo es: {_nombre} {_apellido}";
        }

        public void Imprimir()
        {
            Console.WriteLine("Metodo imprimir edad: {0}", Edad + Estatica);
        }

        public static int General()
        {
            return Estatica;
        }


    }
}
