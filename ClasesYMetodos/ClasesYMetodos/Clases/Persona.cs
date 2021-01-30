using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesYMetodos
{
    public partial class Persona
    {
        public string Profesion { get; set; } = "Ninguna";

        public string NombreProfesion()
        {
            return $"Mi profesion es: {Profesion}";
        }
    }
}
