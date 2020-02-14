using System;
using System.Collections.Generic;

namespace Clase_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al instituto Santa Claus: ");
            Console.WriteLine("\nCatalogo de cursos navideños: ");

            Curso monos1 = new Curso();
            /*nombre = "Moños navideños nivel basico";
            monos1.horario = "Lunes y miercoles de 8 a 10 A.M";
            monos1.costo = 75000F;
            monos1.profesor = "Pepito Julieto";
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}\n{3}\n", monos1.nombre, monos1.horario, monos1.costo,monos1.profesor);

            Curso monos2 = new Curso();
            monos2.nombre = "Moños curso avanzado";
            monos2.horario = "Jueves y viernes de 2 a 4 P.M";
            monos2.costo = 120000F;
            monos2.profesor = "Julio pepito";
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}\n{3}", monos2.nombre, monos2.horario, monos2.costo, monos2.profesor);

            Curso monos3 = new Curso("Farolitos","De Sabado y Lunes de 1 a 4 P.M",200000F,"Pepito Peréz");
            //Console.WriteLine("\n{0}\n{1} Costo: {2:C2}\n{3}", monos3.nombre, monos3.horario, monos3.costo, monos3.profesor);
            //WriteLine(monos1);
            //WriteLine(monos2);
            //nsole.WriteLine(monos3);
            
            Console.WriteLine("\nIntroduzca los datos del nuevo curso");
            Console.WriteLine("nombre: "); SetNombre(Console.ReadLine());
            Console.WriteLine("horario: "); SetHorario(Console.ReadLine());
            Console.WriteLine("valor: "); setCosto(Convert.ToSingle(Console.ReadLine());
            Console.ReadKey();
            */
            Curso cocina1 = new Curso();
            cocina1.CapturarDatosPorConsola();

            Curso cocina2 = new Curso();
            cocina2.CapturarDatosPorConsola();

            Curso cocina3 = new Curso();
            cocina3.CapturarDatosPorConsola();

            Curso cocina4 = new Curso();
            cocina4.CapturarDatosPorConsola();

            /*Curso[] VectorCursos = new Curso[4];
            VectorCursos[0] = cocina1;
            VectorCursos[1] = cocina2;
            VectorCursos[2] = cocina3;
            VectorCursos[3] = cocina4;

            Console.WriteLine("\nCatalogo de cursos de cocina navideños, usando vectores");
            Console.WriteLine("=======================================================");
            for (int i = 0; i < VectorCursos.Length; i++)
            {
                Console.WriteLine(VectorCursos[i]);
            }*/

            List<Curso> ListaCursos = new List<Curso>();
            ListaCursos.Add(cocina1);
            ListaCursos.Add(cocina2);
            ListaCursos.Add(cocina3);
            ListaCursos.Add(cocina4);

            Console.WriteLine("\nCatalogo de cursos de cocina navideños, usando listas");
            Console.WriteLine("=======================================================");
            foreach (Curso esteCurso in ListaCursos)
            {
                Console.WriteLine(esteCurso);
            }

        } 
    }
}

