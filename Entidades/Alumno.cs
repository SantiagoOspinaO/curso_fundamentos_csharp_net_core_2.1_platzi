namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string uniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
        public List<Asignatura> asignaturas { get; set; }
        public List<Evaluacion> evaluaciones { get; set; }
    }
}