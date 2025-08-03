using Ejercicio._3.Clases.EjerciciosPOO;

class Program
{
    static void Main()
    {
        Console.WriteLine(" NOTIFICACIONES ");
        List<Notificacion> notificaciones = new List<Notificacion>
        {
            new NotificacionEmail(),
            new NotificacionSMS(),
            new NotificacionPush()
        };

        foreach (var n in notificaciones)
        {
            n.Enviar();
        }

        Console.WriteLine("\n COMANDOS DE VOZ ");
        List<ComandoVoz> comandos = new List<ComandoVoz>
        {
            new EncenderLuces(),
            new ReproducirMusica(),
            new MostrarClima()
        };

        EjecutarComandos(comandos);

        Console.WriteLine("\n PAGOS ");
        List<Pago> pagos = new List<Pago>
        {
            new PagoConTarjeta(),
            new PagoConEfectivo(),
            new PagoConTransferencia()
        };

        foreach (var p in pagos)
        {
            p.ProcesarPago();
        }

        Console.WriteLine("\nFin del programa.");
    }

    static void EjecutarComandos(List<ComandoVoz> lista)
    {
        foreach (var c in lista)
        {
            c.Ejecutar();
        }
    }
}