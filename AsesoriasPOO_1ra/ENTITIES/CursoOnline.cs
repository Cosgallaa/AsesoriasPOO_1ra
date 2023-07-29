using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriasPOO_1ra.ENTITIES
{
    public class CursoOnline : Curso
    {
        public string plataforma { get; set; }
        public string URL { get; set; }

        public override string iniciarCurso(string nombre)
        {
            return $"esta iniciando el curso{nombre}de manera presencial";
        }


    }
}
