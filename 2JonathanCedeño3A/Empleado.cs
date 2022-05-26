using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2JonathanCedeño3A
{
    public class Empleado
    {
        private string apellidos, nombres, edad, departamento;
        public Empleado(string apellidos, string nombres, string edad, string departamento)
        {
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.edad = edad;
            this.departamento = departamento;
        }
        public void imprimirDatos()
        {
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Departamento: " + departamento);
            
        }
    }
}
