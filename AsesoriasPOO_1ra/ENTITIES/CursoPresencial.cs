using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriasPOO_1ra.ENTITIES
{
    public class CursoPresencial : Curso
    {
        public string aula { get; set; }

        public CursoPresencial()
        {

        }
        public CursoPresencial(string aula)
        {
            this.aula = aula;
        }
        public override string iniciarCurso(string nombre)
        {
            return $"esta inicando ell curso{nombre}de manera online";
        }
    }
}
