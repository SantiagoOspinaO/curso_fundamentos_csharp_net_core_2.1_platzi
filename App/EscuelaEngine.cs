using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine() { }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi", "Cra 9 Calle 72", 2012, "Freddy Vega", TipoEscuela.Primaria, "Colombia", "Medellín");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarCursos()
        {
            Escuela.cursos = new List<Curso>(){
                new Curso { nombre = "101", jornada = TipoJornada.Mañana },
                new Curso { nombre = "201", jornada = TipoJornada.Mañana },
                new Curso { nombre = "301", jornada = TipoJornada.Mañana },
                new Curso { nombre = "401", jornada = TipoJornada.Tarde },
                new Curso { nombre = "501", jornada = TipoJornada.Tarde }
            };

            foreach (var curso in Escuela.cursos)
            {
                var random = new Random().Next(5, 20);
                curso.alumnos = GenerarAlumnosAlAzar(random);
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura { nombre = "Matemáticas" },
                    new Asignatura { nombre = "Educación Fisica" },
                    new Asignatura { nombre = "Castellano" },
                    new Asignatura { nombre = "Ciencias Naturales" },
                };
                curso.asignaturas = listaAsignaturas;
            }
        }

        /*private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.cursos)
            {
                foreach (var asignatura in curso.asignaturas)
                {
                    foreach (var alumno in curso.alumnos)
                    {
                        var random = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var evaluacion = new Evaluacion
                            {
                                asignatura = asignatura,
                                nombre = $"{asignatura.nombre} evaluacion# {i + 1}",
                                nota = (float)(5 * random.NextDouble()),
                                alumno = alumno
                            };

                            alumno.evaluaciones.Add(evaluacion);
                        }
                    }
                }
            }
        }*/

        private void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.cursos)
            {
                foreach (var alumno in curso.alumnos)
                {
                    var listaEvaluaciones = new List<Evaluacion>();
                    var random = new Random(System.Environment.TickCount);

                    foreach (var asignatura in curso.asignaturas)
                    {
                        listaEvaluaciones.Add(
                            new Evaluacion
                            {
                                nombre = $"Evaluacion {asignatura}",
                                alumno = alumno,
                                asignatura = asignatura,
                                nota = (float)(5 * random.NextDouble())
                            }
                        );
                    }
                    alumno.evaluaciones = listaEvaluaciones;
                }
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipe", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((alumno) => alumno.uniqueId).Take(cantidad).ToList();
        }
    }
}