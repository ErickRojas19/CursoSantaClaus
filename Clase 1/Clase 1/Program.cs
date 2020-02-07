using System;

namespace Clase_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al instituto Santa Claus: ");
            Console.WriteLine("\nCatalogo de cursos navideños: ");

            Curso monos1 = new Curso();
            monos1.nombre = "Moños navideños nivel basico";
            monos1.horario = "Lunes y miercoles de 8 a 10 A.M";
            monos1.costo = 75000F;
            monos1.profesor = "Pepito Julieto";
            Console.WriteLine("\n{0}\n{1} Costo: {2:C2}\n{3}", monos1.nombre, monos1.horario, monos1.costo,monos1.profesor);

            Curso monos2 = new Curso();
            monos2.nombre = "Moños curso avanzado";
            monos2.horario = "Jueves y viernes de 2 a 4 P.M";
            monos2.costo = 120000F;
            monos2.profesor = "Julio pepito";
            Console.WriteLine("\n{0}\n{1} Costo: {2:C2}\n{3}", monos2.nombre, monos2.horario, monos2.costo, monos2.profesor);

            Curso monos3 = new Curso("Farolitos","De Sabado y Lunes de 1 a 4 P.M",200000F,"Pepito Peréz");
            Console.WriteLine("\n{0}\n{1} Costo: {2:C2}\n{3}", monos3.nombre, monos3.horario, monos3.costo, monos3.profesor);

            Console.ReadKey();
        }
        
        
    }
}
