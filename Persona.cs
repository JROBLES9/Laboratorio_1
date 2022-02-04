using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    internal class Persona
    {
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            TimeSpan diferencia = hoy - FechaNacimiento;
            int edad = diferencia.Days / 365;
            return edad;
        }

        public void normalizarNombre()
        {
            //Nombre
            Nombre = Nombre.Trim();


            //Apellido
        }
    }
}
