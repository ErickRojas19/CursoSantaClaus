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
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2:C2}\t{3}\t",
            nombre, horario, costo, profesor);
        }
    }
}
