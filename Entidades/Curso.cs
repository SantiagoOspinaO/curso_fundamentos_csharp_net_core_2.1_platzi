namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string uniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
        public TipoJornada jornada { get; set; }
        public List<Asignatura> asignaturas { get; set; }
        public List<Alumno> alumnos { get; set; }
    }
}

/*Dos maneras de borrar un curso en especifico
escuela.cursos.RemoveAll(delegate (Curso curso) { return curso.nombre == "301"; });
escuela.cursos.RemoveAll((curso) => curso.nombre == "501" && curso.jornada == TipoJornada.Mañana);*/