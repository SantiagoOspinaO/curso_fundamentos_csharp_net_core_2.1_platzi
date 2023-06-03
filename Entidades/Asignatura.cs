namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string uniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
        public Evaluacion evaluacion { get; set; }
    }
}