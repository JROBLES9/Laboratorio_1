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
            String result;
            //Elimina espacios
            Nombre = Nombre.Trim();
            Apellido = Apellido.Trim();


            //Elimina simbolos q no sean letras
            result = Nombre;
            for(int i = 0; i < Nombre.Length; i++)
            {
                if (!char.IsLetter(Nombre[i]) & !char.IsWhiteSpace(Nombre[i]))
                   result = Nombre.Remove(i,1);
            }
            Nombre = result;
           
            result = Apellido;
            for (int i = 0; i < Apellido.Length; i++)
            {
                if (!char.IsLetter(Apellido[i]) & !char.IsWhiteSpace(Apellido[i]))
                    result = Apellido.Remove(i, 1);
            }
            Apellido = result;

            Nombre = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Nombre);
            Apellido = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Apellido);
        }
    }
}
