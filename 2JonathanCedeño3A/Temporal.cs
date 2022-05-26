using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2JonathanCedeño3A
{
     public class Temporal : Empleado
    {
        private string FechaEntrada, Fechasalida;
        private int sueldo;
        public Temporal(string apellidos, string nombres, string edad, string departamento, string fechaEntrada, string fechasalida, int sueldo) : base(apellidos, nombres, edad, departamento)
        {
            FechaEntrada = fechaEntrada;
            Fechasalida = fechasalida;
            this.sueldo = sueldo;
        }
        public void imprimirFechas()
        {
            Console.WriteLine("Sueldo mensual: " + sueldo);
            Console.WriteLine("Fecha de ingreso a la empresa: " + FechaEntrada );
            Console.WriteLine("Fecha de salida de la empresa: " + Fechasalida);
        }
        
    }
}
