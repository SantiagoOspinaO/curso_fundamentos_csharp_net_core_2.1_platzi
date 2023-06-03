namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string uniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int añoFundacion { get; set; }
        public string ceo { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public TipoEscuela TipoEscuela { get; set; }
        public List<Curso> cursos { get; set; }


        public Escuela(string nombre, int añoFundacion) => (this.nombre, this.añoFundacion) = (nombre, añoFundacion);

        public Escuela(string nombre, string direccion, int añoFundacion, string ceo, TipoEscuela TipoEscuela, string pais="", string ciudad="")
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.añoFundacion = añoFundacion;
            this.ceo = ceo;
            this.TipoEscuela = TipoEscuela;
            this.pais = pais;
            this.ciudad = ciudad;
        }


        public void timbrar()
        {
            Console.Beep(2000, 2000);
        }

        public override string ToString()
        {
            return $"nombre: {nombre}\ndireccion: {direccion}\nañoFundacion: {añoFundacion}\nceo: {ceo}\ntipo: {TipoEscuela}\npais: {pais}\nciudad: {ciudad}";
        } 
    }
}