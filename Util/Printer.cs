namespace CoreEscuela.Entidades.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            Console.WriteLine("".PadLeft(tam, '-'));
        }

        public static void EscribirTitulo(string titulo)
        {
            Console.WriteLine($"******************** {titulo} ********************");
        }

        public static void Beep(int hz = 1000,int tiempo = 2000, int cant = 1)
        {
            while (cant-- > 0)
            {
               Console.Beep(hz, tiempo); 
            }
        }
    }
}