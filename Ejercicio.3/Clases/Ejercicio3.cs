using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._3.Clases
{

    namespace EjerciciosPOO
    {
        class Notificacion
        {
            public virtual void Enviar()
            {
                Console.WriteLine("Enviando notificación...");
            }
        }

        class NotificacionEmail : Notificacion
        {
            public override void Enviar()
            {
                Console.WriteLine("Enviando correo electrónico...");
            }
        }

        class NotificacionSMS : Notificacion
        {
            public override void Enviar()
            {
                Console.WriteLine("Enviando SMS...");
            }
        }

        class NotificacionPush : Notificacion
        {
            public override void Enviar()
            {
                Console.WriteLine("Enviando notificación push...");
            }
        }

        class ComandoVoz
        {
            public virtual void Ejecutar()
            {
                Console.WriteLine("Ejecutando comando...");
            }
        }

        class EncenderLuces : ComandoVoz
        {
            public override void Ejecutar()
            {
                Console.WriteLine("Luces encendidas.");
            }
        }

        class ReproducirMusica : ComandoVoz
        {
            public override void Ejecutar()
            {
                Console.WriteLine("Reproduciendo música.");
            }
        }

        class MostrarClima : ComandoVoz
        {
            public override void Ejecutar()
            {
                Console.WriteLine("Mostrando el clima actual.");
            }
        }

        class Pago
        {
            public virtual void ProcesarPago()
            {
                Console.WriteLine("Procesando pago...");
            }
        }

        class PagoConTarjeta : Pago
        {
            public override void ProcesarPago()
            {
                Console.WriteLine("Procesando pago con tarjeta...");
            }
        }

        class PagoConEfectivo : Pago
        {
            public override void ProcesarPago()
            {
                Console.WriteLine("Recibiendo efectivo...");
            }
        }

        class PagoConTransferencia : Pago
        {
            public override void ProcesarPago()
            {
                Console.WriteLine("Iniciando transferencia bancaria...");
            }
        }
    }