using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._2.Clases
{
    class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
    }

    class Gerente : Empleado
    {
        public void TomarDecision()
        {
            System.Console.WriteLine(Nombre + " ha tomado una decisión.");
        }
    }

    class Desarrollador : Empleado
    {
        public void Programar()
        {
            System.Console.WriteLine(Nombre + " está programando.");
        }
    }

    class Vehiculo
    {
        public void Avanzar()
        {
            System.Console.WriteLine("El vehículo avanza.");
        }
    }

    class Auto : Vehiculo
    {
        public void EncenderRadio()
        {
            System.Console.WriteLine("La radio está encendida.");
        }
    }

    class Motocicleta : Vehiculo
    {
        public void HacerCaballito()
        {
            System.Console.WriteLine("La motocicleta hace un caballito.");
        }
    }

    class Cuenta
    {
        public double Saldo { get; set; }

        public void Depositar(double monto)
        {
            Saldo += monto;
            System.Console.WriteLine("Depósito realizado: Q" + monto);
        }
    }

    class CuentaAhorro : Cuenta
    {
        public void CalcularIntereses()
        {
            double interes = Saldo * 0.05;
            System.Console.WriteLine("Interés generado: Q" + interes);
        }
    }

    class CuentaCorriente : Cuenta
    {
        public void CalcularIntereses()
        {
            double interes = Saldo * 0.01;
            System.Console.WriteLine("Interés generado: Q" + interes);
        }
    }
}