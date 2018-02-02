using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona();
            Persona Persona2 = new Persona();

            QueHacer queHacer1= new QueHacer("Lavar Platos", new DateTime(), "Lavar los platos en la cocina");
            QueHacer queHacer2 = new QueHacer("Barrer el segundo nivel", new DateTime(), "Barrer el piso de la casa");
            QueHacer queHacer3 = new QueHacer("Trapear el segundo nivel", new DateTime(), "Trapear el piso del segundo nivel de la casa");
            QueHacer queHacer4 = new QueHacer("Arreglar las habitaciones", new DateTime(), "Arreglar las habitaciones del primer y segundo nivel");
            QueHacer queHacer5 = new QueHacer("Lavar los baños", new DateTime(), "Lavar los baños de la casa");
            

            Persona1.AgregarQueHacer(queHacer1);
            Persona1.AgregarQueHacer(queHacer2);
            Persona1.AgregarQueHacer(queHacer3);

            Persona2.AgregarQueHacer(queHacer4);
            Persona2.AgregarQueHacer(queHacer5);
            

            Persona1.CompletarQueHacer();

            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();

            Console.WriteLine("Persona uno esta disponible? => " + Persona1.EstaDisponible());
            Console.WriteLine("Persona dos esta disponible? => " + Persona2.EstaDisponible());
            Console.ReadLine();
        }
    }
}
