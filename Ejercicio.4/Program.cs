using Ejercicio._4.Clases;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ARCHIVOS MULTIMEDIA ");
        List<ArchivoMultimedia> archivos = new List<ArchivoMultimedia>
        {
            new Video(),
            new Cancion(),
            new AudioLibro()
        };

        foreach (var a in archivos)
        {
            a.Reproducir();
        }

        Console.WriteLine("\n VALIDADORES ");
        List<IValidador> validadores = new List<IValidador>
        {
            new ValidadorEmail(),
            new ValidadorTelefono(),
            new ValidadorDPI()
        };

        string[] datos = { "juan@gmail.com", "12345678", "1234567890123", "correo@", "1234", "abc" };

        foreach (var dato in datos)
        {
            Console.WriteLine("\nDato: " + dato);
            Console.WriteLine("Email: " + validadores[0].EsValido(dato));
            Console.WriteLine("Teléfono: " + validadores[1].EsValido(dato));
            Console.WriteLine("DPI: " + validadores[2].EsValido(dato));
        }

        Console.WriteLine("\n DISPOSITIVOS DE SALIDA ");
        List<DispositivoSalida> dispositivos = new List<DispositivoSalida>
        {
            new Pantalla(),
            new Proyector(),
            new Impresora()
        };

        string mensaje = "Hola, esto es una prueba.";

        foreach (var d in dispositivos)
        {
            d.MostrarMensaje(mensaje);
        }

        Console.WriteLine("\nFin del programa.");
    }
}
