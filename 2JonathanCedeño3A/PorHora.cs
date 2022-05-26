using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2JonathanCedeño3A
{
    public class PorHora : Empleado
    {
        private int sueldo, Horas;
        public PorHora(string apellidos, string nombres, string edad, string departamento, int sueldo, int Horas) : base(apellidos, nombres, edad, departamento)
        {
            this.sueldo = sueldo;
            this.Horas = Horas;
        }
        public void imprimirSueldo()
        {
            Console.WriteLine("Valor por hora trabajada: " + sueldo);
            Console.WriteLine("Cantidad de horas trabajadas: " + Horas);
        }
        public void calcularSueldo()
        {
            int total = sueldo * Horas;
            Console.WriteLine("Sueldo a cobrar: " + total);
        }
    }
}
