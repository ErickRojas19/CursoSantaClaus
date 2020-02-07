using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1
{
    
    class Curso
    {
        public string nombre;
        public string horario;
        public float costo;
        public string profesor;

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

    }
}
