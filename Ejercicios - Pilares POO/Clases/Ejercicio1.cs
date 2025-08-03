using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios___Pilares_POO.Clases
{
    class Empleado
    {
        private string nombre;
        private double salario;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;
                }
            }
        }

        public double Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
            }
        }
    }

    class CuentaBancaria
    {
        private double saldo;
        private double limiteDiario;

        public CuentaBancaria(double saldoInicial, double limite)
        {
            saldo = saldoInicial;
            limiteDiario = limite;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo && cantidad <= limiteDiario)
            {
                saldo -= cantidad;
                System.Console.WriteLine("Retiro exitoso");
            }
            else
            {
                System.Console.WriteLine("No se puede retirar esa cantidad");
            }
        }

        public void MostrarSaldo()
        {
            System.Console.WriteLine("Saldo disponible: Q" + saldo);
        }
    }

    class Vehiculo
    {
        private bool encendido;

        public bool Encendido
        {
            get { return encendido; }
        }

        public void Encender()
        {
            encendido = true;
            System.Console.WriteLine("Vehículo encendido");
        }

        public void Apagar()
        {
            encendido = false;
            System.Console.WriteLine("Vehículo apagado");
        }
    }
}