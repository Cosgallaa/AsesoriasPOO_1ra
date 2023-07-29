using AsesoriasPOO_1ra.ENTITIES;
using System;
using System.Collections.Generic;

namespace AsesoriasPOO_1ra
{
    public class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso("Curso test", "Ubicacion", "Horario");
             string nombrecurso = null;

            Profesor profesor = new Profesor();
            profesor.Nombre = "Moises";
            profesor.Apellido = "Torres";
            profesor.numEmpleado = "123";
            profesor.Especializaciones = "ING";
            //una estancia de padre a hijo
            CursoPresencial cursopresencial = new CursoPresencial();
            cursopresencial.Nombre = nombrecurso!= null ? nombrecurso :"curso de programacion";
            cursopresencial.Fecha = new DateTime(2023,07,15);
            cursopresencial.Horarios = "de 9am 1pm";
            cursopresencial.Ubicacion = "no aplica";
            cursopresencial.NumHoras = 50;
            cursopresencial.Profesor = profesor;

            Console.WriteLine("===============CURSO PRESENCIAL============================");
            Console.WriteLine("nombre del curso"+cursopresencial.Nombre);
            Console.WriteLine("fecha del curso"+cursopresencial.Fecha);
            Console.WriteLine("horarios del curso"+cursopresencial.Horarios);
            Console.WriteLine(" numeros de horas del curso"+cursopresencial.NumHoras);
            Console.WriteLine($"el profesor de curso: "+ cursopresencial.Nombre + "es"+ cursopresencial.Nombre);

            Console.WriteLine(cursopresencial.iniciarCurso(cursopresencial.Nombre));
            Console.WriteLine(cursopresencial.PasarLista());

            CursoOnline cursoonline = new CursoOnline();
            cursoonline.Nombre = "curso de programacion";
            cursoonline.Fecha = new DateTime(2023, 07, 15);
            cursoonline.Horarios = "de 9am 1pm";
            cursoonline.Ubicacion = "no plataforma virtual";
            cursoonline.plataforma = "virtual";
            cursoonline.URL = "https.pppppppppppp.com";
            cursoonline.NumHoras=20;
            Console.WriteLine("=============CURSO ONLINE==================");

            Console.WriteLine("===============CURSO PRESENCIAL============================");
            Console.WriteLine("nombre del curso" + cursoonline.Nombre);
            Console.WriteLine("fecha del curso" + cursoonline.Fecha);
            Console.WriteLine("horarios del curso" + cursoonline.Horarios);
            Console.WriteLine(" numeros de horas del curso" + cursoonline.NumHoras);
            Console.WriteLine(" plataforma del curso" + cursoonline.plataforma);
            Console.WriteLine("URL del cursos" + cursoonline.URL);

            List<string> alummnos = new List<string>();
            alummnos.Add("Moises");
            alummnos.Add(">carlos");
            alummnos.Add("ismael");

            Console.WriteLine(cursoonline.iniciarCurso(cursoonline.Nombre));

            Console.WriteLine(cursoonline.PasarLista(alummnos));


        }
    }
}
