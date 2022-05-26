
using System;

namespace _2JonathanCedeño3A 
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           Empleados por horas");
            PorHora porHora = new PorHora("Cordoba", "Alexander","26","TI",5,47);
            porHora.imprimirDatos();
            porHora.imprimirSueldo();
            porHora.calcularSueldo();
            Console.WriteLine(" ");
            Console.WriteLine("           Empleados Fijos");
            Console.WriteLine(" ");
            Fijo fijo = new Fijo("Ceballos","Maria","32","Secretaria",400,2010);
            fijo.imprimirDatos();
            fijo.imprimirAño();
            fijo.calcularSueldo();
            Console.WriteLine(" ");
            Console.WriteLine("           Empleados temporales");
            Console.WriteLine(" ");
            Temporal temporal = new Temporal("Garcia", "Carlos", "40", "Asesori Legal", "22/05/2012", "25/08/2012", 200);
            temporal.imprimirDatos();
            temporal.imprimirFechas();
        }
    }
}
