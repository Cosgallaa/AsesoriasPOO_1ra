using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoriasPOO_1ra.ENTITIES
{
    public class Curso
    {

        public string Nombre {get; set;}
        public string Ubicacion {get; set;}
        public string Horarios {get; set;}
        public int? Participantes {get; set;}
        public DateTime Fecha {get; set;}
        public int NumHoras {get; set;}
        public int? participantes {get; set;}
        public Profesor Profesor { get; set;}


        //contructores
        #region
        public Curso(string nombre, string ubicacion, string horarios, DateTime fecha, int numhoras, int? participantes )
        {
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.Fecha = fecha;
            this.Horarios = horarios;
            this.NumHoras = numhoras;
            this.Participantes = participantes;
        }
        public Curso(string nombre, string ubicacion, string horarios)
        {
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.Horarios = horarios;

        }
        #endregion
        public Curso()
        {

        }
        
        //con el virtual se hace una sobre escritura
        public virtual string iniciarCurso(string nombre)
        {
            return $"se ha iniciado el nombre del curso{nombre}";
        }
        //SOBRECARGA
        public string iniciarCurso()
        {
            return "se paso lista";
        }
        public string PasarLista()
        {
            return "se paso lista a todos";
        }
        public string PasarLista(List<string> nombres)
        {
            int numPersonas = 0;

            if (nombres.Count >= 0)
            {
                numPersonas = nombres.Count; 
            }
            //if (nombres,Any)
            //{
            //    numPersonas = nombres.Count;
            //}
            return $"se paso listade {nombres.Count}personas";
        }



    }
}
