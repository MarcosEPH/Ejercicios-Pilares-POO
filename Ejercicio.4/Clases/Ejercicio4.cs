using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._4.Clases
{
    abstract class ArchivoMultimedia
    {
        public abstract void Reproducir();
    }

    class Video : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo video...");
        }
    }

    class Cancion : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo canción...");
        }
    }

    class AudioLibro : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo audiolibro...");
        }
    }

    interface IValidador
    {
        bool EsValido(string dato);
    }

    class ValidadorEmail : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Contains("@") && dato.Contains(".");
        }
    }

    class ValidadorTelefono : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 8 && long.TryParse(dato, out _);
        }
    }

    class ValidadorDPI : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 13 && long.TryParse(dato, out _);
        }
    }

    abstract class DispositivoSalida
    {
        public abstract void MostrarMensaje(string mensaje);
    }

    class Pantalla : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

    class Proyector : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("Lanzando proyección: " + mensaje);
        }
    }

    class Impresora : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("Imprimiendo mensaje: " + mensaje);
        }
    }
}