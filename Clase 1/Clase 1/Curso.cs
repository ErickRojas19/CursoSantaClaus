using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1
{
    
    class Curso
    {
        private string nombre;
        private string horario;
        private float costo;
        private string profesor;

        public Curso()

        {
        }
        public Curso(string nom, string hor, float cos, string pro)
        {
            this.nombre = nom;
            this.horario = hor;
            this.costo = cos;
            this.profesor = pro;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
        public string getHorario()
        {
            return horario;
        }
        public void setHorario(string nuevoHorario)
        {
            this.horario = nuevoHorario;
        }
        public float getCosto()
        {
            return costo;
        }
        public void setCosto(float nuevoCosto)
        {
            this.costo = nuevoCosto;
        }
        /*public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2:C2}\t",
            nombre, horario, costo);
        }
        */
        public override string ToString()
        {
            return string.Format("{0,-20} {1,30} {2:C2}",
            getNombre(), getHorario(), getCosto());

        }
        public void CapturarDatosPorConsola()
        {
            Console.WriteLine("\nIntroduzca los datos del nuevo curso");
            Console.WriteLine("nombre: "); setNombre(Console.ReadLine());
            Console.WriteLine("horario: "); setHorario(Console.ReadLine());
            Console.WriteLine("valor: "); setCosto(Convert.ToSingle(Console.ReadLine()));
        }

        
    }
}
