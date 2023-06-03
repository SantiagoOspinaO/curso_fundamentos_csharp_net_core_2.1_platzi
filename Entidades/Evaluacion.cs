namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public string uniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
        public float nota { get; set; }
        public Asignatura asignatura { get; set; }
        public Alumno alumno { get; set; }

        public override string ToString()
        {
            return $"{nota}, {alumno.nombre}, {asignatura.nombre}";
        }
    }
}