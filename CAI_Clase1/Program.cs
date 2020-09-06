using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancio una persona en una variable de tipo persona
            Persona p1 = new Persona();

            //setteo los atributos mediante su propiedad (encapsulamiento)
            p1.Nombre = "Jose";
            p1.Edad = 30;

            Console.WriteLine(p1.Nombre);
            Console.WriteLine(p1.Edad.ToString()); //get

            //ejecuto un metodo de este objeto
            p1.SumarEdad(5);

            Console.WriteLine(p1.Edad.ToString());

            //instancio otro objeto de tipo persona en la variable p2 de tipo Persona
            Persona p2 = new Persona("Juan", 33);
            Console.WriteLine(p2.Nombre);
            Console.WriteLine(p2.Edad.ToString());
            //declaro una variable de tipo persona pero no tiene instancia p3 es null
            Persona p3;
        }
    }
}
