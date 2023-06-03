using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Entidades.Util;

internal class Program
{
    private static void Main(string[] args)
    {
        var engine = new EscuelaEngine();
        Printer.EscribirTitulo("B I E N V E N I D O S");
        engine.Inicializar();
        VerCursos(engine.Escuela);
    }


    static void VerCursos(Escuela escuela)
    {
        Printer.EscribirTitulo("C U R S O S");
        if (escuela?.cursos != null)
        {
            foreach (var curso in escuela.cursos)
            {
                Console.WriteLine($"nombre: {curso.nombre}, id: {curso.uniqueId}, jornada: {curso.jornada}");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    static void VerInfo(Escuela escuela)
    {

    }
}