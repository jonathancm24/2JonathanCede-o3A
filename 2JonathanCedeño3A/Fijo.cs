using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2JonathanCedeño3A
{
    public class Fijo : Empleado
    {
        private int Año, sueldo;
        public Fijo(string apellidos, string nombres, string edad, string departamento,int sueldo, int Año) : base(apellidos, nombres, edad, departamento)
        {
            this.Año = Año;
            this.sueldo = sueldo;
        }
        public void imprimirAño()
        {
            Console.WriteLine("Sueldo base: " + sueldo);
            Console.WriteLine("Año de ingreso a la empresa: " + Año);
            
        }
        public void calcularSueldo()
        {
            int Total = sueldo + (60 * (2022-Año));
            Console.WriteLine("Sueldo total a cobrar: " + Total);
        }
    }
}
